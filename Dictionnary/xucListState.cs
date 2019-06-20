using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.ERP;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace CHBK2014_N9.Dictionnary
{
    public partial class xucListState : UserControl
    {
        private DataTable dt_State;

        private SelectionMode m_ListSelectionMode = SelectionMode.One;
        public xucListState()
        {
            InitializeComponent();
        }

        private void btSearch_EditValueChanged(object sender, EventArgs e)
        {
            this.Search(this.dt_State, this.btSearch.Text);
            if (this.btSearch.Text == "")
            {
                this.btSearch.EditValue = null;
            }
        }

        private string GetCode(ImageListBoxItem item)
        {
            string str;
            try
            {
                string str1 = item.Value.ToString();
                char[] chrArray = new char[] { '(', ')' };
                str = str1.Split(chrArray)[1];
            }
            catch
            {
                str = "";
            }
            return str;
        }

        private void imgListEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            this.imgListState.SelectionMode = SelectionMode.MultiSimple;
            if ((e.Modifiers != Keys.Control ? false : e.KeyCode == Keys.A))
            {
                this.imgListState.SelectAll();
            }
        }

        private void imgListState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.RaiseClickedEventHander(this.GetCode(this.imgListState.SelectedItem as ImageListBoxItem));
            }
            catch
            {
            }
            if (this.m_ListSelectionMode == SelectionMode.One)
            {
                if (Control.ModifierKeys == Keys.None)
                {
                    this.imgListState.SelectionMode = SelectionMode.One;
                }
                else
                {
                    this.imgListState.SelectionMode = SelectionMode.MultiSimple;
                }
            }
        }


        public void ListSelectionMode(SelectionMode mode)
        {
            SelectionMode selectionMode = mode;
            SelectionMode selectionMode1 = selectionMode;
            this.m_ListSelectionMode = selectionMode;
            this.imgListState.SelectionMode = selectionMode1;
        }

        public void LoadData()
        {
            this.dt_State = (new DIC_STATE()).GetList();
            this.imgListState.Items.Clear();
            foreach (DataRow row in this.dt_State.Rows)
            {
                ImageListBoxItem imageListBoxItem = new ImageListBoxItem()
                {
                    ImageIndex = 0,
                    Value = string.Concat("(", row["StateCode"].ToString(), ") - ", row["StateName"].ToString())
                };
                this.imgListState.Items.Add(imageListBoxItem);
            }
        }

        public void RaiseClickedEventHander(string Value)
        {
            if (this.Clicked != null)
            {
                this.Clicked(this, Value);
            }
        }

        public void Search(DataTable States, string Value)
        {
            this.imgListState.Items.Clear();
            foreach (DataRow row in States.Rows)
            {
                if ((row["StateCode"].ToString().ToLower().Contains(Value.ToLower()) ? true : row["StateName"].ToString().ToLower().Contains(Value.ToLower())))
                {
                    ImageListBoxItem imageListBoxItem = new ImageListBoxItem()
                    {
                        ImageIndex = 0,
                        Value = string.Concat("(", row["StateCode"].ToString(), ") - ", row["StateName"].ToString())
                    };
                    this.imgListState.Items.Add(imageListBoxItem);
                }
            }
        }

        public event xucListState.ClickedEventHander Clicked;

        public delegate void ClickedEventHander(object sender, string Value);

    }
}
