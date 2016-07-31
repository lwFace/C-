using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ESPHelper.DDSInc;
using com.hirain.avionics.dds.util;

namespace ESPHelper
{
    public partial class DDSStatusFrm : DevExpress.XtraEditors.XtraForm
    {
        List<DDSStatus> list = new List<DDSStatus>();
        public DDSStatusFrm()
        {
            InitializeComponent();
            this.gridControl1.DataSource = list;
            this.gridView1.Columns["SN"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridView1.Columns["SN"].DisplayFormat.FormatString = "{0}(0x{0:X})";
        }

        private void DDSStatusFrm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        void UpdateData()
        {
            this.gridView1.BeginUpdate();
            list.Clear();
            foreach (var item in ServerManager.Project.Projects)
            {
                string cardType = item.Projects[0].type;
                switch (cardType)
                {
                    case "422":
                        foreach (var l in AAMS_422.gridDataDictionary)
                        {
                            DDSStatus status = new DDSStatus(cardType);
                            status.sn = l.Key;
                            status.count = l.Value.Count;
                            list.Add(status);
                        }
                        break;
                    case "discrete":
                    case "analog":
                        foreach (var l in AAMS_Nobus.gridDataDictionary)
                        {
                            DDSStatus status = new DDSStatus(cardType);
                            status.sn = l.Key;
                            status.count = l.Value.Count;
                            list.Add(status);
                        }
                        break;
                    case "429":
                        foreach (var l in AAMS_429.gridDataDictionary)
                        {
                            DDSStatus status = new DDSStatus(cardType);
                            status.sn = l.Key;
                            status.count = l.Value.Count;
                            list.Add(status);
                        }
                        break;
                    default:
                        break;
                }


            }
            this.gridView1.EndUpdate();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0 || gridView1.FocusedRowHandle>=list.Count)
            {
                return;
            }
            uint sn = list[gridView1.FocusedRowHandle].sn;
            ChannelSNConvert.ChannelInfo chnInfo = ChannelSNConvert.SN2Channel((int)sn);
            this.snInfoText.Caption = string.Format("Type:{0} DevId:{1} CardSlot:{2} Channel:{3}", chnInfo.Type, chnInfo.DevId, chnInfo.CardId, chnInfo.ChannelId);
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateData();
        }
    }
    public class DDSStatus
    {
        public string type;
        public uint sn;
        public int count;
        public DDSStatus(string type)
        {
            this.type = type;
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public uint SN
        {
            get { return sn; }
            set { SN = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }
}