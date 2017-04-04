using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_HS_GV.BLL;

namespace QL_HS_GV.GUI
{
    public partial class frmLogin : Form
    {
        BUS_tblUser user = new BUS_tblUser();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.ToString() == "" || txtPassword.Text.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin đăng nhập!");
            }
            else
            {
                if(user.CheckLogin(txtUsername.Text.ToString(), txtPassword.Text.ToString()) == 1)
                {
                    this.Visible = false;
                    frmMain main = new frmMain();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập sai");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ckcHienpw_CheckedChanged(object sender, EventArgs e)
        {
            if(ckcHienpw.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
