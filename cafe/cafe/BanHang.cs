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
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }
        public static int mb = 0;
        public static int tt = 0;
        public int madv = 0, giadv = 0, dongia = 0;
        public string tendv = null;
        XuLy xl = new XuLy();
        DataTable dt = new DataTable();

        private void cb_nhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tong = 0;
            dt.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string t = dt.Rows[i]["DoUong"].ToString();
                string g = dt.Rows[i]["DonGia"].ToString();
                tong = tong + Convert.ToInt32(g);
                txt_tong.Text = tong.ToString();
            }
            dt = xl.BH_loadThucDon(cb_nhom.Text);
            dataGridView1.DataSource = dt;
        }

        private void btn_dat_Click(object sender, EventArgs e)
        {
            dongia = giadv * Convert.ToInt32(txt_sl.Text);
            if (string.IsNullOrEmpty(txt_tien.Text))
                txt_tien.Text = dongia.ToString();
            else
                txt_tien.Text += "+" + dongia.ToString();

            DataGridViewRow row = new DataGridViewRow();
            DataGridViewCell _cell;
            _cell = new DataGridViewTextBoxCell();
            _cell.Value = txt_sl.Text + " " + tendv;
            row.Cells.Add(_cell);

            _cell = new DataGridViewTextBoxCell();
            _cell.Value = dongia;
            row.Cells.Add(_cell);
            dataGridView2.Rows.Add(row);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            int tongtien = Convert.ToInt32(txt_tong.Text), d1 = 0;

            string chuoi1 = txt_tien.Text;
            string[] ketqua1 = chuoi1.Split('+');
            d1 = ketqua1.Length - 1;
            if (d1 != 0)
            {
                for (int i = 0; i <= d1; i++)
                {
                    tongtien += Convert.ToInt32(ketqua1[i]);
                }
                txt_tong.Text = tongtien.ToString();
            }
            else
            {
                tongtien += Convert.ToInt32(txt_tien.Text);
                txt_tong.Text = tongtien.ToString();
            }
            txt_tien.Text = "0";
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                string ten = dataGridView2.Rows[i].Cells["Tensp"].Value.ToString();
                int gia = Convert.ToInt32(dataGridView2.Rows[i].Cells["Giasp"].Value.ToString());
                dr = xl.Ban_them(mb, "Có Khách", ten, gia);
            }
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan tt = new ThanhToan();
            tt.ShowDialog();
            this.Hide();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanHang bh = new BanHang();
            bh.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_sl.Text = "1";
            tendv = dataGridView1.CurrentRow.Cells["Ten"].Value.ToString();
            giadv = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Gia"].Value);

            if (txt_tien.Text == "0")
                txt_tien.Clear();
        }

        private void frm_load()
        {
            int tong = 0;
            dt.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string t = dt.Rows[i]["DoUong"].ToString();
                string g = dt.Rows[i]["DonGia"].ToString();
                tong = tong + Convert.ToInt32(g);
                txt_tong.Text = tong.ToString();
            }
            cb_nhom.Text = "Tất Cả";
            dt = xl.BH_loadThucDon(cb_nhom.Text);
            dataGridView1.DataSource = dt;
        }
        private void ban_Load(object sender, EventArgs e)
        {
            frm_load();
        }
    }
}
