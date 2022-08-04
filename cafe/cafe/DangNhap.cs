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
    public partial class DangNhap : Form
    {
        XuLy xl = new XuLy();
        DataTable dt = new DataTable();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_tk.Text))
            {
                if (!string.IsNullOrEmpty(txt_mk.Text))
                {
                    dt.Clear();
                    string t = DateTime.Now.ToShortTimeString();
                    dt = xl.KiemTra(txt_tk.Text, txt_mk.Text,t);
                    dt = xl.KiemTraDangNhap(txt_tk.Text, txt_mk.Text);
                    if (dt.Rows[0]["err"].ToString() == "0")
                    {
                        //dt = xl.KiemTra(txt_tk.Text);
                        QuanLy ql = new QuanLy();
                        ql.Show();
                        this.Hide();
                    }
                    else if (dt.Rows[0]["err"].ToString() == "1")
                    {
                        Master ql = new Master();
                        ql.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản của bạn :((", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txt_tk.Clear();
                        txt_mk.Clear();
                        txt_tk.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu :(", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txt_mk.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tài khoản :(", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_tk.Focus();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dk_Click(object sender, EventArgs e)
        {
            dangKy dk = new dangKy();
            dk.Show();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                this.Close();
            }
        }
    }
}
