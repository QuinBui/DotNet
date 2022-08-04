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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        XuLy xl = new XuLy();
        DataTable dt = new DataTable();
        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (txt_mkMoi.Text == txt_remk.Text)
            {
                dt.Clear();
                dt = xl.DoiMatKhau(txt_tk.Text, txt_mkCu.Text, txt_mkMoi.Text);
                if (dt.Rows[0]["err"].ToString() == "0")
                {
                    MessageBox.Show("yeah !! Bạn đã đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    this.Close();
                    Master mt = new Master();
                    mt.Show();
                }
                else
                {
                    MessageBox.Show("Nhập sai tài khoản hoặc mật khẩu rùi :( ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Mật Khẩu Không Khớp!!", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                this.Hide();
                DoiMatKhau dmk = new DoiMatKhau();
                dmk.ShowDialog();
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Master mt = new Master();
            mt.Show();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.txt_tk, "Nhập tên tài khoản");
            ToolTip1.SetToolTip(this.txt_mkCu, "Nhập mật khẩu củ");
            ToolTip1.SetToolTip(this.txt_mkMoi, "Nhập mật khẩu mới");
            ToolTip1.SetToolTip(this.txt_remk, "Nhập lại mật khẩu mới");
        }

    }
}
