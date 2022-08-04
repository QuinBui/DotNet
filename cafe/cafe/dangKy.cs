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
    public partial class dangKy : Form
    {
        XuLy xl = new XuLy();
        DataTable dt = new DataTable();
        public dangKy()
        {
            InitializeComponent();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (txt_ten.Text != "" && txt_sdt.Text != "" && txt_tk.Text != "" && txt_mk.Text != "" && cb_q.Text != "" && txt_maQ.Text != "")
            {
                if (rd_nam.Checked == true)
                {
                    dt = xl.NV_them(txt_ten.Text, "Nam", txt_sdt.Text, txt_tk.Text, txt_mk.Text, cb_q.Text, Convert.ToInt32(txt_maQ.Text), "duck.png");
                    MessageBox.Show("yeah !! Bạn đã đăng ký thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    this.Close();
                    DangNhap dn = new DangNhap();
                    dn.Show();
                }

                else
                {
                    dt = xl.NV_them(txt_ten.Text, "Nữ", txt_sdt.Text, txt_tk.Text, txt_mk.Text, cb_q.Text, Convert.ToInt32(txt_maQ.Text), "duck.png");
                    MessageBox.Show("yeah !! Bạn đã đăng ký thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    this.Close();
                    DangNhap dn = new DangNhap();
                    dn.Show();
                }
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn muốn thoát phải không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            this.Close();
        }

        private void dangKy_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.bunifuImageButton2, "Quyền Nhân Viên : 2");
            ToolTip1.SetToolTip(this.cb_q, "Chức Vụ Bạn Làm Trong Quán");
            ToolTip1.SetToolTip(this.bt_luu, "Đăng Ký");
            ToolTip1.SetToolTip(this.bt_thoat, "Thoát Khỏi Giao Diện");
        }

        private void dangKy_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
