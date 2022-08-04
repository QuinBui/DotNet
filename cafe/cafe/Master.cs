using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }
        XuLy cl = new XuLy();
        DataTable dt = new DataTable();
        public void loadTTDat(Button btn)
        {
            btn.BackgroundImage = global::cafe.Properties.Resources.db;
            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn.Location = new System.Drawing.Point(171, 331);
            btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btn.Size = new System.Drawing.Size(281, 136);
            btn.TabIndex = 2;
            btn.UseVisualStyleBackColor = true;
        }
        public void loadTTBT(Button btn)
        {
            btn.BackgroundImage = global::cafe.Properties.Resources._1;
            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn.Location = new System.Drawing.Point(171, 331);
            btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btn.Size = new System.Drawing.Size(281, 136);
            btn.TabIndex = 2;
            btn.UseVisualStyleBackColor = true;
        }
        private int LayTrangThaiBan(int mb)
        {
            SqlDataReader dr;
            dr = cl.Ban_xemTrangThaiBan(mb);
            while (dr.Read())
            {
                string tt = dr.GetString(0);
                if (tt == "Có Khách")
                {
                    return 1;
                }
            }
            return 0;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string t = DateTime.Now.ToShortTimeString();
            dt = cl.DangXuat(t);
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.Show();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn Xã bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                loadTTBT(this.bt_1);
            }

        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            BanHang db = new BanHang();
            BanHang.mb = 1;
            ThanhToan.mb = 1;
            BanHang.tt = LayTrangThaiBan(1);
            db.ShowDialog();
            loadTTDat(this.bt_1);
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            BanHang db = new BanHang();
            BanHang.mb = 2;
            ThanhToan.mb = 2;
            BanHang.tt = LayTrangThaiBan(2);
            db.ShowDialog();
            loadTTDat(this.bt_2);
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            BanHang db = new BanHang();
            BanHang.mb = 3;
            ThanhToan.mb = 3;
            BanHang.tt = LayTrangThaiBan(3);
            db.ShowDialog();
            loadTTDat(this.bt_3);
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            BanHang db = new BanHang();
            BanHang.mb = 4;
            ThanhToan.mb = 4;
            BanHang.tt = LayTrangThaiBan(4);
            db.ShowDialog();
            loadTTDat(this.bt_4);
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            BanHang db = new BanHang();
            BanHang.mb = 5;
            ThanhToan.mb = 5;
            BanHang.tt = LayTrangThaiBan(5);
            db.ShowDialog();
            loadTTDat(this.bt_5);
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            BanHang db = new BanHang();
            BanHang.mb = 6;
            ThanhToan.mb = 6;
            BanHang.tt = LayTrangThaiBan(6);
            db.ShowDialog();
            loadTTDat(this.bt_6);
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            BanHang db = new BanHang();
            BanHang.mb = 8;
            ThanhToan.mb = 8;
            BanHang.tt = LayTrangThaiBan(8);
            db.ShowDialog();
            loadTTDat(this.bt_8);
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            BanHang db = new BanHang();
            BanHang.mb = 7;
            ThanhToan.mb = 7;
            BanHang.tt = LayTrangThaiBan(7);
            db.ShowDialog();
            loadTTDat(this.bt_7);
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            BanHang db = new BanHang();
            BanHang.mb = 9;
            ThanhToan.mb = 9;
            BanHang.tt = LayTrangThaiBan(9);
            db.ShowDialog();
            loadTTDat(this.bt_9);
        }

        private void bt_10_Click(object sender, EventArgs e)
        {
            BanHang db = new BanHang();
            BanHang.mb = 10;
            ThanhToan.mb = 10;
            BanHang.tt = LayTrangThaiBan(10);
            db.ShowDialog();
            loadTTDat(this.bt_10);
        }

        private void bt_11_Click(object sender, EventArgs e)
        {
            BanHang db = new BanHang();
            BanHang.mb = 11;
            ThanhToan.mb = 11;
            BanHang.tt = LayTrangThaiBan(11);
            db.ShowDialog();
            loadTTDat(this.bt_11);
        }

        private void bt_12_Click(object sender, EventArgs e)
        {
            BanHang db = new BanHang();
            BanHang.mb = 12;
            ThanhToan.mb = 12;
            BanHang.tt = LayTrangThaiBan(12);
            db.ShowDialog();
            loadTTDat(this.bt_12);
        }

        private void lb_2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn Xã bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                loadTTBT(this.bt_2);
            }
        }

        private void lb_3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn Xã bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                loadTTBT(this.bt_3);
            }
        }

        private void lb_4_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn Xã bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                loadTTBT(this.bt_4);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn Xã bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                loadTTBT(this.bt_5);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn Xã bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                loadTTBT(this.bt_6);
            }
        }

        private void lb_7_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn Xã bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                loadTTBT(this.bt_7);
            }
        }

        private void lb_8_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn Xã bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                loadTTBT(this.bt_8);
            }
        }

        private void lb_9_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn Xã bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                loadTTBT(this.bt_9);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn Xã bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                loadTTBT(this.bt_10);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn Xã bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                loadTTBT(this.bt_11);
            }
        }

        private void lb_12_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn Xã bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                loadTTBT(this.bt_12);
            }
        }

        private void Master_Load(object sender, EventArgs e)
        {

        }

        private void btn_tt_Click(object sender, EventArgs e)
        {
            ThongTin dn = new ThongTin();
            this.Hide();
            dn.Show();
        }

        private void btn_repass_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            this.Hide();
            dmk.Show();
        }

        private void Master_FormClosing(object sender, FormClosingEventArgs e)
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
