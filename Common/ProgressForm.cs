using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CHBK2014_N9.Common
{
  public  class ProgressForm: XtraForm
    {
        private ProgressBarControl progressBarControl1;

        private Container components = null;

        private LabelControl lblMessage;

        private LabelControl lblTitle;

        private bool _die = false;

        private bool _autoClose = false;

        private Form _form;

        public bool AutoClose
        {
            get
            {
                return this._autoClose;
            }
            set
            {
                this._autoClose = value;
            }
        }

        public ProgressForm(UserControl parent)
        {
            this.InitializeComponent();
        }

        public ProgressForm()
        {
            this.InitializeComponent();
        }

        public ProgressForm(Form parent)
        {
            this.InitializeComponent();
            this._form = parent;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.components != null)
                {
                    this.components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.progressBarControl1 = new ProgressBarControl();
            this.lblMessage = new LabelControl();
            this.lblTitle = new LabelControl();
            ((ISupportInitialize)this.progressBarControl1.Properties).BeginInit();
            base.SuspendLayout();
            this.progressBarControl1.Location = new Point(12, 16);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ExportMode = ExportMode.Value;
            this.progressBarControl1.Properties.ProgressViewStyle = ProgressViewStyle.Solid;
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new Size(338, 16);
            this.progressBarControl1.TabIndex = 0;
            this.lblMessage.AllowHtmlString = true;
            this.lblMessage.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblMessage.Appearance.ForeColor = Color.Black;
            this.lblMessage.Appearance.Options.UseFont = true;
            this.lblMessage.Appearance.Options.UseForeColor = true;
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.AutoSizeMode = LabelAutoSizeMode.None;
            this.lblMessage.Location = new Point(13, 2);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new Size(338, 15);
            this.lblMessage.TabIndex = 66;
            this.lblTitle.AllowHtmlString = true;
            this.lblTitle.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblTitle.Appearance.ForeColor = Color.Black;
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseForeColor = true;
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.AutoSizeMode = LabelAutoSizeMode.None;
            this.lblTitle.Location = new Point(14, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(337, 13);
            this.lblTitle.TabIndex = 65;
            this.AutoScaleBaseSize = new Size(5, 14);
            base.ClientSize = new Size(362, 48);
            base.ControlBox = false;
            base.Controls.Add(this.lblMessage);
            base.Controls.Add(this.lblTitle);
            base.Controls.Add(this.progressBarControl1);
            this.DoubleBuffered = true;
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ProgressForm";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            base.TopMost = true;
            ((ISupportInitialize)this.progressBarControl1.Properties).EndInit();
            base.ResumeLayout(false);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
        }

        public void SetProgressValue(string message)
        {
            this.SetProgressValue(this.progressBarControl1.Position, message);
        }

        public void SetProgressValue(int position)
        {
            this.SetProgressValue(position, this.lblTitle.Text);
        }

        public void SetProgressValue(int position, string message)
        {
            this.SetProgressValue(position, message, "Vui lòng đợi trong giây lát");
        }

        public void SetProgressValue(int position, string message, string caption)
        {
            if (!this._die)
            {
                if (!base.Visible)
                {
                    if (this._form == null)
                    {
                        base.Show();
                    }
                    else
                    {
                        base.Show(this._form);
                    }
                }
                this.lblMessage.Text = message;
                this.progressBarControl1.Position = position;
                this.lblTitle.Text = caption;
                base.Update();
                if (position >= 100 && this.AutoClose)
                {
                    base.Visible = false;
                }
            }
        }

    }
}
