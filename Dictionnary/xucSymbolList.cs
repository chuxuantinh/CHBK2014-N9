using DevExpress.Utils;
using DevExpress.XtraEditors;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.Dictionnary
{
    public partial class xucSymbolList : xucBase
    {

        private bool m_IsShowLateEarly = false;

        private bool m_IsShowShift = false;

        public xucSymbolList()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            xfmSymbol _xfmSymbol = new xfmSymbol();
            _xfmSymbol.Updated += new xfmSymbol.UpdatedEventHander((object s, DIC_SYMBOL o) => this.Init(this.m_IsShowLateEarly, this.m_IsShowShift));
            _xfmSymbol.Deleted += new DeletedEventHander((object s, RowClickEventArgs o) => this.Init(this.m_IsShowLateEarly, this.m_IsShowShift));
            _xfmSymbol.Added += new xfmSymbol.AddedEventHander((object s, DIC_SYMBOL o) => this.Init(this.m_IsShowLateEarly, this.m_IsShowShift));
            _xfmSymbol.ShowDialog();


        }

        public void Init(bool IsShowLateEarly, bool IsShowShift)
        {
            DIC_SYMBOL dICSYMBOL = new DIC_SYMBOL();
            this.flowLayoutPanel1.Controls.Clear();
            this.flowLayoutPanel2.Controls.Clear();
            foreach (DataRow row in dICSYMBOL.GetList().Rows)
            {
                if (bool.Parse(row["IsShow"].ToString()))
                {
                    string str = "";
                    if (!(row["SymbolCode"].ToString() == ""))
                    {
                        str = ((row["SymbolCode"].ToString() == "CS" || row["SymbolCode"].ToString() == "KCR" ? false : !(row["SymbolCode"].ToString() == "KCV")) ? row["SymbolCode"].ToString() : string.Concat("<color=red>", row["SymbolCode"].ToString(), "</color>"));
                    }
                    else
                    {
                        str = "(trống)";
                    }
                    xucSymbolItem _xucSymbolItem = new xucSymbolItem()
                    {
                        Height = 13,
                        SymbolCode = string.Concat(":  ", str),
                        SymbolName = row["SymbolName"].ToString()
                    };
                    this.flowLayoutPanel1.Controls.Add(_xucSymbolItem);
                }
            }
            bool isShowLateEarly = IsShowLateEarly;
            bool flag = isShowLateEarly;
            this.m_IsShowLateEarly = isShowLateEarly;
            if (flag)
            {
                xucSymbolItem _xucSymbolItem1 = new xucSymbolItem()
                {
                    Height = 13,
                    SymbolCode = ":  +(số phút)",
                    SymbolName = "Số phút đi trễ"
                };
                this.flowLayoutPanel1.Controls.Add(_xucSymbolItem1);
                xucSymbolItem _xucSymbolItem2 = new xucSymbolItem()
                {
                    Height = 13,
                    SymbolCode = ":  -(số phút)",
                    SymbolName = "Số phút về sớm"
                };
                this.flowLayoutPanel1.Controls.Add(_xucSymbolItem2);
                xucSymbolItem _xucSymbolItem3 = new xucSymbolItem()
                {
                    Height = 13,
                    SymbolCode = ": +(sp):-(sp)",
                    SymbolName = "Đi trễ, về sớm"
                };
                this.flowLayoutPanel1.Controls.Add(_xucSymbolItem3);
                xucSymbolItem _xucSymbolItem4 = new xucSymbolItem()
                {
                    Height = 13,
                    SymbolCode = ": <color=black>+;V +;P ...</color>",
                    SymbolName = "<color=black>Tách đôi ca</color>"
                };
                this.flowLayoutPanel1.Controls.Add(_xucSymbolItem4);
            }
            bool isShowShift = IsShowShift;
            flag = isShowShift;
            this.m_IsShowShift = isShowShift;
            if (!flag)
            {
                this.flowLayoutPanel2.Height = 0;
            }
            else
            {
                this.flowLayoutPanel2.Height = 17;
                DIC_SHIFT dICSHIFT = new DIC_SHIFT();
                LabelControl labelControl = new LabelControl()
                {
                    Text = "* Ký hiệu theo ca: "
                };
                this.flowLayoutPanel2.Controls.Add(labelControl);
                foreach (DataRow dataRow in dICSHIFT.GetList().Rows)
                {
                    xucSymbolItem _xucSymbolItem5 = new xucSymbolItem()
                    {
                        Height = 13,
                        Width = 184
                    };
                    _xucSymbolItem5.lbSymbolCode.Width = 46;
                    _xucSymbolItem5.SymbolCode = string.Concat(":  <color=blue>", dataRow["ShiftCode"].ToString(), "</color>");
                    string[] shortTimeString = new string[] { "<u>", dataRow["ShiftName"].ToString(), " <i>(", null, null, null, null };
                    DateTime dateTime = Convert.ToDateTime(dataRow["BeginTime"]);
                    shortTimeString[3] = dateTime.ToShortTimeString();
                    shortTimeString[4] = " - ";
                    dateTime = Convert.ToDateTime(dataRow["EndTime"]);
                    shortTimeString[5] = dateTime.ToShortTimeString();
                    shortTimeString[6] = ")</i></u>";
                    _xucSymbolItem5.SymbolName = string.Concat(shortTimeString);
                    SuperToolTip superToolTip = new SuperToolTip();
                    ToolTipItemCollection items = superToolTip.Items;
                    shortTimeString = new string[] { dataRow["ShiftName"].ToString(), " (", null, null, null, null, null };
                    dateTime = Convert.ToDateTime(dataRow["BeginTime"]);
                    shortTimeString[2] = dateTime.ToShortTimeString();
                    shortTimeString[3] = " - ";
                    dateTime = Convert.ToDateTime(dataRow["EndTime"]);
                    shortTimeString[4] = dateTime.ToShortTimeString();
                    shortTimeString[5] = "): ";
                    shortTimeString[6] = dataRow["ShiftCode"].ToString();
                    items.AddTitle(string.Concat(shortTimeString));
                    if (Convert.ToBoolean(dataRow["IsOvernight"].ToString()))
                    {
                        superToolTip.Items.Add("- Làm việc qua đêm");
                    }
                    if (!Convert.ToBoolean(dataRow["IsBreak"].ToString()))
                    {
                        superToolTip.Items.Add("- Không nghỉ giữa ca");
                    }
                    else
                    {
                        ToolTipItemCollection toolTipItemCollection = superToolTip.Items;
                        dateTime = Convert.ToDateTime(dataRow["BreakBeginTime"]);
                        string shortTimeString1 = dateTime.ToShortTimeString();
                        dateTime = Convert.ToDateTime(dataRow["BreakEndTime"]);
                        toolTipItemCollection.Add(string.Concat("- Nghỉ giữa ca từ ", shortTimeString1, " - ", dateTime.ToShortTimeString()));
                    }
                    _xucSymbolItem5.lbSymbolName.SuperTip = superToolTip;
                    this.flowLayoutPanel2.Controls.Add(_xucSymbolItem5);
                }
            }
            SimpleButton simpleButton = new SimpleButton()
            {
                Text = "Chỉnh Sửa Bảng Ký Hiệu Chấm Công",
                Width = 200
            };
            simpleButton.Click += new EventHandler(this.bt_Click);
            this.flowLayoutPanel1.Controls.Add(simpleButton);
        }

    }
}
