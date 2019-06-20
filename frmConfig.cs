using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CHBK2014_N9
{
    public partial class frmConfig :DevExpress.XtraEditors.XtraForm
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Class.RegistryWriter rg = new Class.RegistryWriter();
            try
            {

                rg.WriteKey("server", txtServer.Text);
                rg.WriteKey("database", txtDatabaseName.Text);
                string _user = Class.App.EncryptString(txtUser.Text, "UserID");
                string _pass = Class.App.EncryptString(txtPass.Text, "PasswordID");
                rg.WriteKey("user", _user);
                rg.WriteKey("pass", _pass);
                if (checkAutoUpdate.Checked)
                {
                    rg.WriteKey("autoupdate", "1");
                }
                else
                {
                    rg.WriteKey("autoupdate", "0");
                }

                MessageBox.Show("Lưu cấu hình thành công !");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lưu cấu hình thất bại !");
            }
            
        }
    }
}
