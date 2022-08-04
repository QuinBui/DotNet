using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        XuLy cl = new XuLy();
        DataTable dt = new DataTable();
        private void btn_DX_Click(object sender, EventArgs e)
        {
            string t = DateTime.Now.ToShortTimeString();
            dt = cl.DangXuat(t);
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }

        private void btn_TD_Click(object sender, EventArgs e)
        {
            thucDon nv = new thucDon();
            nv.Show();
            this.Hide();
        }

        private void btn_NV_Click(object sender, EventArgs e)
        {
            nhanVien nv = new nhanVien();
            nv.Show();
            this.Hide();
        }

        private void btn_DT_Click(object sender, EventArgs e)
        {
            doanhThu nv = new doanhThu();
            nv.Show();
            this.Hide();
        }

        private void btn_NL_Click(object sender, EventArgs e)
        {
            NguyenLieu nl = new NguyenLieu();
            nl.Show();
            this.Hide();
        }

        private void QuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát đúng hem ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                DangNhap dn = new DangNhap();
                dn.Show();
            }
        }
    }
}
