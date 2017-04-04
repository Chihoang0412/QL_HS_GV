using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HS_GV.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnHocsinh_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmSinhVien sv = new frmSinhVien();
            sv.ShowDialog();
            this.Visible = true;
        }

        private void btnGiaovien_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmGiaoVien gv = new frmGiaoVien();
            gv.ShowDialog();
            this.Visible = true;
        }

        private void btnGiangDay_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmDangKyGiangDay giangDay = new frmDangKyGiangDay();
            giangDay.ShowDialog();
            this.Visible = true;
        }

        private void btnHuongdan_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmHuongDan huongDan = new frmHuongDan();
            huongDan.ShowDialog();
            this.Visible = true;
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmTaiKhoan tk = new frmTaiKhoan();
            tk.ShowDialog();
            this.Visible = true;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
