using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using WinDriverDemo.About;
using WinDriverDemo.Options;
using leomon;
using DevExpress.XtraTreeList.Nodes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;


namespace WinDriverDemo
{
    public enum ReceivedDataType
    {
        CharType,
        HexType
    };
    public enum SendDataType
    {
        CharType,
        HexType
    }
    public partial class MainFrm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private System.IO.Ports.SerialPort mySerialPort;
        private ReceivedDataType myReceivedDataType = ReceivedDataType.CharType;
        private SendDataType mySendDataType = SendDataType.CharType;
        private int totalReceivedBytes = 0;
        private int totalSendBytes = 0;
        private bool autoSend = false;
        private System.Drawing.Size _frmOriginSize;
        public delegate void UpdateAcceptTextBoxTextHandler(string text);
        public UpdateAcceptTextBoxTextHandler UpdateTextHandler;
        DevExpress.Utils.WaitDialogForm _waitForm;
        OptionsFrm _optionFrm;
        ShortCutFrm _shortCutFrm;
        public MainFrm()
        {
            _waitForm = new DevExpress.Utils.WaitDialogForm("Initialize components...(1/4)", "Waiting...");//,new Size(200,120)
            _waitForm.Show();
            InitializeComponent();
            UpdateTextHandler = new UpdateAcceptTextBoxTextHandler(UpdateText);
            this.btnRefresh.Enabled = false;
            this.btnOpenDevice.Enabled = false;
            btnStop.Enabled = false;
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.mySerialPort.ReadBufferSize = 2;
            sendSettingGroupBox.Enabled = false;
            this.barCheckCom.Checked = true;
            this.barCheckShort.Checked = true;
            this.barCheckSetting.Checked = true;

            //this.mySerialPort.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.mySerialPort_ErrorReceived);
            //this.mySerialPort.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.mySerialPort_PinChanged);
            this.mySerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.mySerialPort_DataReceived);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            _waitForm.SetCaption("Initialize skin...(2/4)");
            // System.Threading.Thread.Sleep(1000)
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinMenu, true);
            this.btnRefresh.Enabled = false;
            //this.LookAndFeel.SkinName = "Office 2007 Blue";
            //this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue";
            _waitForm.SetCaption("Checking available ports...(3/4)");
            _optionFrm = new OptionsFrm();
            _shortCutFrm = new ShortCutFrm();
            //检查可用端口
            CheckAvailablePorts();
            _waitForm.SetCaption("Loading configurations...(4/4)");
            //载入配置信息
            LoadConfig("串口助手配置.xml");           
            _waitForm.Close();
            _frmOriginSize = this.Size;
        }
        public DevExpress.XtraTreeList.TreeList GetShortCmdList()
        {
            return treeRegConfig;
        }

        #region 数据发送
        /// <summary>
        /// 开始向端口发送数据
        /// </summary>
        private void SendTextNow()
        {
            try
            {
                if (mySendDataType == SendDataType.CharType)
                {
                    SerialPortSendChar(this.dataSendEdit.Text.ToString());
                }
                else
                {
                    SerialPortSendHex(this.dataSendEdit.Text.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void SerialPortSendHex(String str)
        {
            uint length = (uint)str.Length;
            byte[] m_bData;
            UInt16[] m_wData;
            UInt32[] m_dwBytes;

            object[] m_obj ;
            
            try
            {
                switch (this._optionFrm.GetSendMode())
                {
                    case "单字节发送":
                        {
                            if (length % 2 != 0)
                            {
                                str = str.Insert((int)length / 2 * 2, "0");
                                length = (uint)str.Length;
                            }
                            m_bData = new byte[length / 2];
                            m_obj = new object[length / 2];
                            for (int i = 0, j = 0; i < length; j++)
                            {
                                while (str[i] == ' ') ++i;
                                m_bData[j] = Convert.ToByte(str.Substring(i, 2), 16);
                                i += 2;
                                totalSendBytes++;
                            }
                            m_obj[0] = m_bData;
                        }
                        break;
                    case "双字节发送":
                        {
                            while (length % 4 != 0)
                            {
                                str = str.Insert((int)length / 4 * 4, "0");
                                length = (uint)str.Length;
                            }
                            m_obj = new object[length / 2];
                            m_wData = new UInt16[length / 4];
                          //  m_bData = new byte[length / 2];
                            for (int i = 0, j = 0; i < length; j++)
                            {
                                while (str[i] == ' ') ++i;
                                m_wData[j] = Convert.ToUInt16(str.Substring(i, 4), 16);
                                i += 4;
                                totalSendBytes += 2;
                            }
                           // m_bData = System.BitConverter.GetBytes(m_wData[0]);
                            m_obj[0] = m_wData;
                            
                        }
                        break;
                    case "四字节发送":
                        while (length % 8 != 0)
                        {
                            str = str.Insert((int)length / 4 * 4, "0");
                            length = (uint)str.Length;
                        }
                        m_obj = new object[length / 2];
                            m_dwBytes = new UInt32[length / 8];
                        for (int i = 0, j = 0; i < length; j++)
                        {                   
                            while (str[i] == ' ') ++i;
                            m_dwBytes[j] = Convert.ToUInt32(str.Substring(i, 8), 16);
                            i += 8;
                            totalSendBytes += 4;
                        }
                        m_obj[0] = m_dwBytes;
                        break;
                    default:
                        {
                            if (length % 2 != 0)
                            {
                                str = str.Insert((int)length / 2 * 2, "0");
                                length = (uint)str.Length;
                            }
                            m_bData = new byte[length / 2];
                            m_obj = new object[length / 2];
                            for (int i = 0, j = 0; i < length; j++)
                            {
                                while (str[i] == ' ') ++i;
                                m_bData[j] = Convert.ToByte(str.Substring(i, 2), 16);
                                i += 2;
                                totalSendBytes++;
                            }
                            m_obj[0] = m_bData;
                        }
                        break;
                }
                m_bData = (byte[])m_obj[0];
                mySerialPort.Write(m_bData, 0, m_obj.Length);
                sendStatusLabel.Caption = "发送：" + totalSendBytes.ToString() + "字节";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void SerialPortSendChar(String str)
        {
            char[] ch = str.ToCharArray();
            foreach (var item in ch)
            {
                if (item <= 255)
                {
                    totalSendBytes += 1;
                }
                else
                {
                    totalSendBytes += 2;
                }
            }
            if (mySerialPort == null || mySerialPort.IsOpen == false)
            {
                MessageBox.Show("没有打开任何串口被开启，无法发送数据！", "发送数据", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mySerialPort.Write(ch, 0, ch.Length);
                    sendStatusLabel.Caption = "发送：" + totalSendBytes.ToString() + "字节";
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (this.dataSendEdit.TextLength != 0)
            {
                SendTextNow();
                if (!autoSend && this._optionFrm.GetAuotClearSend())
                {
                    this.dataSendEdit.Clear();
                }
                this.dataSendEdit.Enabled = true;
            }
        }
        #endregion
        #region 数据接收
        /// <summary>
        /// 每次从SerialPort接收数据时发生，由于运行在辅助线程
        /// 所以必须要通过委托来实现跨线程。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string text = string.Empty;
               
                int size = sp.BytesToRead;
                if (checkDisplayData.Checked)
                {
                    if (myReceivedDataType == ReceivedDataType.HexType)
                    {
                        StringBuilder sbText = new StringBuilder();
                        for (int i = 0; i < size; i++)
                        {
                            int tempByte = sp.ReadByte();
                         //   string tempStr = "0X";
                            StringBuilder tempStr = new StringBuilder();
                            if (tempByte <= 0X0F)
                            {
                                tempStr.Append("0X0");
                            }
                            else
                            {
                                tempStr.Append("0X");
                            }
                            //text +=
                            //    tempStr + Convert.ToString(tempByte, 16).ToUpper() + " ";
                            sbText.AppendFormat(String.Format("{0}{1} ", tempStr, Convert.ToString(tempByte, 16).ToUpper()));
                            text = sbText.ToString();
                        }
                    }
                    else
                    {
                        text = sp.ReadExisting();
                    }
                }
                else
                {
                    sp.ReadExisting();
                }
               
                totalReceivedBytes += size;
                this.Invoke(UpdateTextHandler, text);
                //Thread.Sleep(50);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void UpdateText(string text)
        {
            if (this._optionFrm.GetAuotClearRecv())
            {
                this.dataRecvEdit.Clear();
            }
            StringBuilder sb = new StringBuilder(this.dataRecvEdit.Text);
            sb.Append(text);
            this.dataRecvEdit.Text = sb.ToString();
            acceptStatusLabel.Caption = String.Format("接收：{0}字节", totalReceivedBytes);
            //isReading = true;
            //statusDisplayToolStripStatusLabel.Text = "正在接收.";
        }
        #endregion
        #region ComSearch
        private bool hasPorts = false;
        /// <summary>
        /// 获取可用的端口名，并添加到选择框中，同时设置相关
        /// 默认项。
        /// </summary>
        private void CheckAvailablePorts()
        {
            //portNameComboBox
            portNameComboBox.Properties.Items.Clear();
            string[] allAvailablePorts = SerialPort.GetPortNames();
            //判断是否有可用的端口
            if (allAvailablePorts.Length > 0)
            {
                hasPorts = true;
                //使能控件portNamesComboBox，openOrCloseButton
                this.btnRefresh.Enabled = true;
                portNameComboBox.Properties.Enabled = true;
                this.btnOpenDevice.Enabled = true;
                //依次添加可用的串口
                portNameComboBox.Properties.Items.AddRange(allAvailablePorts);
                //默认选中第一个项
                portNameComboBox.SelectedIndex = 0;
                //显示相应的状态信息
                //statusDisplayToolStripStatusLabel.Text = string.Format("  欢迎使用！自动查找到该计算机可用端口数：{0}，当前选中端口号{1}  :)",
                //    allAvailablePorts.Length, portNameComboBox.SelectedItem.ToString());
            }
            else
            {
                hasPorts = false;
                this.checkAutoSend.Enabled = false;
                this.btnSend.Enabled = false;
                this.btnStop.Enabled = false;
                this.btnCloseDevice.Enabled = false;

                //清空所有项
                portNameComboBox.Properties.Items.Clear();
                portNameComboBox.Properties.Enabled = false;
                // statusDisplayToolStripStatusLabel.Text = "  抱歉，未查找到当前计算机中可用端口。";
                //同时弹出警告对话框，提示是否进行再次检查？!
                ShowWarningMessageBox();
            }
        }

        /// <summary>
        /// 当没有检测到可用端口号时，弹出该对话框，
        /// 提示是否重新检测。
        /// </summary>
        private void ShowWarningMessageBox()
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("抱歉，没有检测到当前计算机中可用端口，请插入相关设备或者检查有关驱动是否安装？" +
            Environment.NewLine + "提示：您可以取消后单击“查找可用端口”按钮重新查找。",
                "自动查找计算机可用端口", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Retry)
            {
                //重新运行检测方法
                CheckAvailablePorts();
            }
        }
        #endregion
        #region Menu

        private void btnShortCmd_ItemClick(object sender, ItemClickEventArgs e)
        {
            _shortCutFrm.Show();
        }
        private void btnOpenDevice_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.dataRecvEdit.Clear();
            OpenSelectedPort();
            //更改配置信息
            SetSerialPortPropertiesBeforeSending();
        }
        private void btnCloseDevice_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseCurrentPort();
        }
        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {                    
                    Application.Exit();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }
        private void btnSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            _optionFrm.Show();
        }

        private void btnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            AboutFrm frm = new AboutFrm();
            frm.Show();
        }
        #endregion
        #region 打开关闭端口
        #region 获取配置信息
        private StopBits GetSelectedStopBits()
        {
            StopBits stopBits = StopBits.One;
            switch (stopBitsComboBox.SelectedItem.ToString())
            {
                case "1":
                    { stopBits = StopBits.One; }
                    break;
                case "2":
                    { stopBits = StopBits.Two; }
                    break;
                case "1.5":
                    { stopBits = StopBits.OnePointFive; }
                    break;
                default:
                    stopBits = StopBits.One;
                    break;
            }
            return stopBits;
        }

        private int GetSelectedDataBits()
        {
            int dataBits = 8;
            if (!(int.TryParse(dataBitsComboBox.SelectedItem.ToString(), out dataBits)))
            {
                MessageBox.Show("转换失败！");
            }
            return dataBits;
        }

        private Parity GetSelectedParity()
        {
            Parity parity = Parity.None;
            switch (parityComboBox.SelectedItem.ToString())
            {
                case "偶校验(Even)":
                    {
                        parity = Parity.Even;
                    }
                    break;
                case "奇校验(Odd)":
                    {
                        parity = Parity.Odd;
                    }
                    break;
                case "保留为0(Space)":
                    {
                        parity = Parity.Space;
                    }
                    break;
                case "保留为1(Mark)":
                    {
                        parity = Parity.Mark;
                    }
                    break;
                default:
                    {
                        parity = Parity.None;
                    }
                    break;
            }
            return parity;
        }

        private int GetSelectedBaudRate()
        {
            int baudRate = 0;
            if (!(int.TryParse(baudRateComboBox.SelectedItem.ToString(), out baudRate)))
            {
                baudRate = 9600;
            }
            return baudRate;

        }
        #endregion
        /// <summary>
        /// 在开始发送前设置串口信息。
        /// </summary>
        private void SetSerialPortPropertiesBeforeSending()
        {
            mySerialPort.Encoding = System.Text.Encoding.Default;
            //设置成为选中的波特率
            mySerialPort.BaudRate = GetSelectedBaudRate();
            //设置成为选中的奇偶校验位
            mySerialPort.Parity = GetSelectedParity();
            //设置成为选中的数据位
            mySerialPort.DataBits = GetSelectedDataBits();
            //设置成为选中的端口停止位
            try
            {
                mySerialPort.StopBits = GetSelectedStopBits();
            }
            catch (IOException ee)
            {
                MessageBox.Show(ee.Message + "已经将 停止位 设置为 默认一位 了！",
                    "提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySerialPort.StopBits = StopBits.One;
                stopBitsComboBox.SelectedIndex = 1;
            }
        }
        private void OpenSelectedPort()
        {
            try
            {
                //设置打开的端口号
                mySerialPort.PortName = portNameComboBox.SelectedItem.ToString();
                //打开选中串口
                mySerialPort.Open();
                //更新状态栏的显示
                stateIndicatorComponent1.StateIndex = 3;
                this.btnCloseDevice.Enabled = true;
                //打开串口成功后
                OpenSelectedPortSuccessfully();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.simpleButton1.Text == "打开端口")
            {
                this.dataRecvEdit.Clear();
                OpenSelectedPort();
                //更改配置信息
                SetSerialPortPropertiesBeforeSending();
            }
            else
            {
                CloseCurrentPort();
            }
        }
        private void OpenSelectedPortSuccessfully()
        {
            this.simpleButton1.Text = "关闭端口";
            baudRateComboBox.Enabled = false;
            dataBitsComboBox.Enabled = false;
            stopBitsComboBox.Enabled = false;
            parityComboBox.Enabled = false;
            portNameComboBox.Enabled = false;
            this.btnCloseDevice.Enabled = true;
            this.btnOpenDevice.Enabled = false;
            sendSettingGroupBox.Enabled = true;
            //acceptZoneSettingGroupBox.Enabled = true;
            //sendZoneSettingGroupBox.Enabled = true;
            //acceptRichTextBox.Enabled = true;
            //sendRichTextBox.Enabled = true;
        }

        private void CloseCurrentPort()
        {
            autoSend = false;
            this.checkAutoSend.Checked = false;
            //关闭选中串口
            mySerialPort.Close();
            //更换为关闭状态的图片
            stateIndicatorComponent1.StateIndex = 1;
            //更新状态栏的显示
            //statusDisplayToolStripStatusLabel.Text = string.Format("  关闭端口 {0}成功！",
            //    mySerialPort.PortName);
            //所有设置控件非使能态
            CloseSelectedPortSuccessfully();
        }

        private void CloseSelectedPortSuccessfully()
        {
            this.simpleButton1.Text = "打开端口";
            portNameComboBox.Enabled = true;
            this.btnOpenDevice.Enabled = true;
            this.btnCloseDevice.Enabled = false;
            // acceptZoneSettingGroupBox.Enabled = false;
            //sendZoneSettingGroupBox.Enabled = false;
            // acceptRichTextBox.Enabled = true;
            // sendRichTextBox.Enabled = true;
            baudRateComboBox.Enabled = true;
            dataBitsComboBox.Enabled = true;
            stopBitsComboBox.Enabled = true;
            parityComboBox.Enabled = true;
            sendSettingGroupBox.Enabled = false;
            totalReceivedBytes = 0;
            totalSendBytes = 0;
            // isReading = false;
            //acceptRichTextBox.Clear();
            //sendRichTextBox.Clear();
        }
        #endregion

        #region Tree
        private void treeRegConfig_MouseClick(object sender, MouseEventArgs e)
        {
            shortConfig config = this.treeRegConfig.FocusedNode.Tag as shortConfig;
            if (config != null)
            {
                this.dataSendEdit.Text = config.data;
            }

        }

        private void treeRegConfig_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            shortConfig config = this.treeRegConfig.FocusedNode.Tag as shortConfig;
            this.dataSendEdit.Text = config.data;
            if (this.dataSendEdit.TextLength != 0)
            {
                SendTextNow();
                this.dataSendEdit.Clear();
            }
        }
        #endregion
        #region RadioButton
        private void acceptCharRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.dataRecvEdit.Clear();
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    myReceivedDataType = ReceivedDataType.CharType;
                }
                else
                {
                    myReceivedDataType = ReceivedDataType.HexType;
                }
            }
        }

        private void sendCharRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    mySendDataType = SendDataType.CharType;
                }
                else
                {
                    mySendDataType = SendDataType.HexType;
                }
            }
        }

        private void sendHexRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (!rb.Checked)
                {
                    mySendDataType = SendDataType.CharType;
                }
                else
                {
                    mySendDataType = SendDataType.HexType;
                }
            }
        }

        private void sendFileRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (chooseFileRadioButton.Checked)
            {
                //禁用发送区输入
                this.dataSendEdit.Enabled = false;
                //弹出打开文件对话框
                ChooseFileToSend();                
            }
            else
            {
                this.dataSendEdit.Enabled = true;
            }
        }
        /// <summary>
        /// 打开选择文件对话框，选择要发送的文件。
        /// </summary>
        private void ChooseFileToSend()
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "txt文件|*.txt|其它文件|*.*";
            fd.FileName = "txt文件";
            fd.Title = "选择要发送的文件...";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                //TO DO.
                using (StreamReader sr = new StreamReader(fd.FileName, System.Text.Encoding.Default))
                {
                    dataSendEdit.Clear();
                    dataSendEdit.AppendText(sr.ReadToEnd());
                }
            }
            //if (inputCharRadioButton.Checked == false)
            //    inputCharRadioButton.Checked = true;
        }
        #endregion
        #region AutoSend
        private void autoSendTimer_Tick(object sender, EventArgs e)
        {
            if (autoSend)
            {
                try
                {
                    if (mySendDataType == SendDataType.CharType)
                    {
                        SerialPortSendChar(this.dataSendEdit.Text.ToString());
                    }
                    else
                    {
                        SerialPortSendHex(this.dataSendEdit.Text.ToString());
                    }
                }
                catch
                {
                    this.checkAutoSend.Checked = false;
                }
            }
        }

        private void checkAutoSend_CheckedChanged(object sender, EventArgs e)
        {
            if (this.dataSendEdit.TextLength == 0)
            {
                this.checkAutoSend.Checked = false;
                autoSend = false;
                MessageBox.Show("没有需要发送的内容");
            }
            else
            {
                if (checkAutoSend.Checked == true)
                {
                    autoSend = true;
                    this.btnSend.Enabled = false;
                    //btnSend.TextAlign = ContentAlignment.MiddleLeft;
                    btnSend.Text = "自动发送中.";
                    btnStop.Enabled = true;
                    btnSend.Enabled = false;
                    //SetSerialPortPropertiesBeforeSending();

                    autoSendTimer.Enabled = true;
                    sendPeriod.Enabled = false;
                    autoSendTimer.Interval = (int)sendPeriod.Value;
                    autoSendTimer.Start();
                    checkAutoSend.Enabled = false;
                }
                else
                {
                    autoSend = false;
                    btnSend.Text = "发送数据";
                    btnStop.Enabled = false;
                    btnSend.Enabled = true;
                    sendPeriod.Enabled = true; ;
                }
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (autoSend)
            {
                btnSend.Enabled = true;
                btnSend.Text = "发送数据";
                autoSend = false;

                btnStop.Enabled = false;
                checkAutoSend.Enabled = true;
                if (checkAutoSend.Checked)
                    checkAutoSend.Checked = false;
                autoSendTimer.Enabled = false;
                this.sendPeriod.Enabled = true;
                autoSendTimer.Stop();
            }
        }
        #endregion
        #region 悬停面板
        private void btnClearSend_Click(object sender, EventArgs e)
        {
            this.dataSendEdit.Clear();
        }

        private void btnClearRecv_Click(object sender, EventArgs e)
        {
            this.dataRecvEdit.Clear();
        }

        private void barCheckCom_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (barCheckCom.Checked)
            {
                this.dockPanelCom.Show();
            }
            else
            {
                this.dockPanelCom.Hide();
            }
        }

        private void barCheckShort_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (barCheckShort.Checked)
            {
                this.dockPanelShort.Show();
            }
            else
            {
                this.dockPanelShort.Hide();
            }
        }

        private void barCheckSetting_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (barCheckSetting.Checked)
            {
                this.dockPanelSetting.Show();
            }
            else
            {
                this.dockPanelSetting.Hide();
            }
        }

        private void dockPanelCom_ClosedPanel(object sender, DevExpress.XtraBars.Docking.DockPanelEventArgs e)
        {
            barCheckCom.Checked = false;
        }

        private void dockPanelSetting_ClosedPanel(object sender, DevExpress.XtraBars.Docking.DockPanelEventArgs e)
        {
            barCheckSetting.Checked = false;
        }

        private void dockPanelShort_ClosedPanel(object sender, DevExpress.XtraBars.Docking.DockPanelEventArgs e)
        {
            barCheckShort.Checked = false;
        }

        #endregion
        #region Resize

        private void xtraTabPage1_Resize(object sender, EventArgs e)
        {
            if (_frmOriginSize.Height != 0)
            {
                double ty = (double)this.Height / _frmOriginSize.Height;
                double tx = (double)this.Width / _frmOriginSize.Width;
                this.dataRecvEdit.Height = Convert.ToInt32(this.dataRecvEdit.Height * ty);                
                int y = dataRecvEdit.Location.Y + dataRecvEdit.Height+5;
                labelControl6.Location = new System.Drawing.Point(this.labelControl6.Location.X, y);
                this.dataSendEdit.Location = new System.Drawing.Point(this.dataSendEdit.Location.X, y+18);
                this.dataSendEdit.Height = Convert.ToInt32(this.xtraTabPage1.Height - this.gaugeControl1.Height - this.dataRecvEdit.Height - 60);
                //this.btnSend.Location = new System.Drawing.Point(Convert.ToInt32(btnSend.Location.X * tx), btnSend.Location.Y);
                //this.sendPeriod.Location = new System.Drawing.Point(Convert.ToInt32(sendPeriod.Location.X * tx), sendPeriod.Location.Y);
                //this.checkAutoSend.Location = new System.Drawing.Point(Convert.ToInt32(checkAutoSend.Location.X * tx), checkAutoSend.Location.Y);
                //this.btnStop.Location = new System.Drawing.Point(Convert.ToInt32(btnStop.Location.X * tx), btnStop.Location.Y);
                //labelControl7.Location = new System.Drawing.Point(sendPeriod.Location.X - 90, labelControl7.Location.Y);
            }
            _frmOriginSize = this.Size;
        }
        #endregion

        private void btnClearStatistic_ItemClick(object sender, ItemClickEventArgs e)
        {
            totalReceivedBytes = 0;
            totalSendBytes = 0;
            acceptStatusLabel.Caption = String.Format("接收：{0}字节", totalReceivedBytes);
            sendStatusLabel.Caption = "发送：" + totalSendBytes.ToString() + "字节";
        }




       
    }
}