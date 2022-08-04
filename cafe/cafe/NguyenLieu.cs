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
    public partial class NguyenLieu : Form
    {
        XuLy cl = new XuLy();
        DataTable dt = new DataTable();
        public NguyenLieu()
        {
            InitializeComponent();
        }
        private void frm_load()
        {
            dt.Clear();
            dt = cl.NL_load();
            dataGridView1.DataSource = dt;
        }
        private void nl_Load(object sender, EventArgs e)
        {
            frm_load();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btn_them, "Thêm Món Mới Vào Thực Đơn");
            ToolTip1.SetToolTip(this.btn_sua, "Sửa Món Trong Thực Đơn");
            ToolTip1.SetToolTip(this.btn_xoa, "Xóa Món Khỏi Thực Đơn");
            ToolTip1.SetToolTip(this.btn_thoat, "Thoát Khỏi Giao Diện Nguyên Liệu");
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (txt_ten.Text != "" && txt_sl.Text != "" && txt_gia.Text != "")
            {
                dt = cl.NL_them(txt_ten.Text, Convert.ToInt32(txt_gia.Text), Convert.ToInt32(txt_sl.Text), txt_dvt.Text, date_nhap.Text);
                MessageBox.Show("yeah !! Bạn đã thêm nguyên liệu thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                frm_load();
            }
            else
            {
                MessageBox.Show("Thêm nguyên liệu không thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                frm_load();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (MessageBox.Show("Bạn chắc chắn muốn sửa thông tin nhân viên này ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                dt = cl.NL_sua(Convert.ToInt32(txt_ma.Text), txt_ten.Text, Convert.ToInt32(txt_gia.Text), Convert.ToInt32(txt_sl.Text), txt_dvt.Text, date_nhap.Text, date_het.Text);
            }
            frm_load();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa nguyên liệu này", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                dt = cl.NL_xoa(Convert.ToInt32(txt_ma.Text));
            }
            frm_load();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
            QuanLy ql = new QuanLy();
            ql.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma.Text = dataGridView1.CurrentRow.Cells["Manl"].Value.ToString();
            txt_ten.Text = dataGridView1.CurrentRow.Cells["Ten"].Value.ToString();
            txt_sl.Text = dataGridView1.CurrentRow.Cells["SoLuong"].Value.ToString();
            txt_gia.Text = dataGridView1.CurrentRow.Cells["Gia"].Value.ToString();
            txt_dvt.Text = dataGridView1.CurrentRow.Cells["DVT"].Value.ToString();
            date_nhap.Text = dataGridView1.CurrentRow.Cells["NgayNhap"].Value.ToString();
            txt_ngayHet.Text = dataGridView1.CurrentRow.Cells["NgayHet"].Value.ToString();
        }

    }
}
