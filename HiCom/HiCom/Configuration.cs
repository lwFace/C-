using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using leomon;

namespace WinDriverDemo
{
    public partial class MainFrm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //想一想，需要保存的内容有哪些呢？
        //1、串口的相关配置信息
        //2、文本框中的内容。
        //3、没了。。。^_^
        private void SaveConfig(string fileName)
        {
            Editor editor = new Editor();
            if (hasPorts)
            {           
                //保存选中的端口
                editor.PutInt32("selectedPort", this.portNameComboBox.SelectedIndex);
                //保存设置的波特率
                editor.PutInt32("baudRate", this.baudRateComboBox.SelectedIndex);
                //保存设置的校验方式
                editor.PutInt32("parity", this.parityComboBox.SelectedIndex);
                //保存设置的数据位
                editor.PutInt32("dataBits", this.dataBitsComboBox.SelectedIndex);
                //保存设置的停止位
                editor.PutInt32("stopBits", this.stopBitsComboBox.SelectedIndex);
                //保存自动发送数据时间间隔
                editor.PutInt32("intervalTime", (int)this.sendPeriod.Value);
                ////保存接收方式
                editor.PutBoolean("acceptChar", this.acceptCharRadioButton.Checked);
                editor.PutBoolean("acceptHex", this.acceptHexRadioButton.Checked);
                ////保存发送方式
                editor.PutBoolean("sendChar", this.sendCharRadioButton.Checked);
                editor.PutBoolean("sendHex", this.chooseFileRadioButton.Checked);
                ////保存标志变量，即是否在接收框中显示信息。
                //editor.PutBoolean("showInfo", showInfo);
                SharedPreferences sp = new SharedPreferences(fileName);
                //记得调用该方法将上述内容一次写入并保存。
                sp.Save(editor);
            }
            
        }
        private bool firstTime = true;
        /// <summary>
        /// 默认端口参数设置
        /// </summary>
        private void ResetToDefaultSettings()
        {
            //默认波特率
            this.baudRateComboBox.SelectedItem = "9600";
            //默认不校验
            this.parityComboBox.SelectedIndex = 0;
            //默认数据位设置为8位
            this.dataBitsComboBox.SelectedIndex = 0;
            //默认停止位设置为1位
            this.stopBitsComboBox.SelectedIndex = 0;
        }
        private void LoadConfig(string fileName)
        {
            SharedPreferences sp = new SharedPreferences(fileName);
            if (sp.ConfigFileExists)
            {
                //读取选中的端口
                if (hasPorts)
                {
                    portNameComboBox.SelectedIndex = sp.GetInt32("selectedPort", 0);
                }
                //读取设置的波特率
                baudRateComboBox.SelectedIndex = sp.GetInt32("baudRate", 0);
                //读取设置的校验方式
                this.parityComboBox.SelectedIndex = sp.GetInt32("parity", 0);
                //读取设置的数据位
                this.dataBitsComboBox.SelectedIndex = sp.GetInt32("dataBits", 0);
                //读取设置的停止位
                this.stopBitsComboBox.SelectedIndex = sp.GetInt32("stopBits", 0);
                //读取自动发送数据时间间隔
                this.sendPeriod.Value = (decimal)sp.GetInt32("intervalTime", 500);
                //读取接收方式
                acceptCharRadioButton.Checked = sp.GetBoolean("acceptChar", true);
                acceptHexRadioButton.Checked = sp.GetBoolean("acceptHex", false);
                ////读取发送方式
                sendCharRadioButton.Checked = sp.GetBoolean("sendChar", true);
                sendHexRadioButton.Checked = sp.GetBoolean("sendHex", true);
                //读取标志变量，即是否在接收框中显示信息。
                //  showInfo = sp.GetBoolean("showInfo", true);
                //if (showInfo)
                //{
                //    displayReadInfoButton.Text = "不显示接收缓冲区内容";
                //}
                //else
                //{
                //    displayReadInfoButton.Text = "显示接收缓冲区内容";
                //}

                // this.acceptRichTextBox.Clear();
                firstTime = false;
            }
            else
            {
                firstTime = true;
                //载入默认设置
                ResetToDefaultSettings();
            }
        }
    }
}
