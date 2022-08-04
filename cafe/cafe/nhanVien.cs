using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class nhanVien : Form
    {
        XuLy cl = new XuLy();
        DataTable dt = new DataTable();
        public nhanVien()
        {
            InitializeComponent();
        }
        private void frm_load()
        {
            dt.Clear();
            dt = cl.NV_load();
            dataGridView1.DataSource = dt;
        }
        private void nv_Load(object sender, EventArgs e)
        {
            frm_load();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.cb_q, "Chức Vụ Bạn Làm Trong Quán");
            ToolTip1.SetToolTip(this.bunifuImageButton1, "Mã Nhân Viên");
            ToolTip1.SetToolTip(this.bunifuImageButton2, "Mã Quyền Nhân Viên");
            ToolTip1.SetToolTip(this.bunifuImageButton3, "Tên Nhân Viên");
            ToolTip1.SetToolTip(this.btn_them, "Thêm Nhân Viên Mới");
            ToolTip1.SetToolTip(this.btn_sua, "Sửa Thông Tin Nhân Viên");
            ToolTip1.SetToolTip(this.btn_xoa, "Xóa Xóa Nhân Viên");
            ToolTip1.SetToolTip(this.btn_thoat, "Thoát Khỏi Giao Diện");
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (txt_ten.Text != "" && txt_sdt.Text != "" && txt_tk.Text != "" && txt_mk.Text != "" && cb_q.Text != "" && txt_maQ.Text != "" && txt_hinh.Text != "")
            {
                if (rd_nam.Checked == true)
                {
                    dt = cl.NV_them(txt_ten.Text, "Nam", txt_sdt.Text, txt_tk.Text, txt_mk.Text, cb_q.Text, Convert.ToInt32(txt_maQ.Text), txt_hinh.Text);
                    MessageBox.Show("yeah !! Bạn đã thêm nhân viên thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    frm_load();
                }

                else
                {
                    dt = cl.NV_them(txt_ten.Text, "Nữ", txt_sdt.Text, txt_tk.Text, txt_mk.Text, cb_q.Text, Convert.ToInt32(txt_maQ.Text), txt_hinh.Text);
                    MessageBox.Show("yeah !! Bạn đã thêm nhân viên thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    frm_load();
                }
            }
            else
            {
                MessageBox.Show("Thêm nhân viên không thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                frm_load();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (MessageBox.Show("Bạn chắc chắn muốn sửa thông tin nhân viên này ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (rd_nam.Checked == true)
                    dt = cl.NV_sua(Convert.ToInt32(txt_ma.Text), txt_ten.Text, "Nam", txt_sdt.Text, txt_tk.Text, txt_mk.Text, cb_q.Text, Convert.ToInt32(txt_maQ.Text), txt_hinh.Text);
                else
                    dt = cl.NV_sua(Convert.ToInt32(txt_ma.Text), txt_ten.Text, "Nữ", txt_sdt.Text, txt_tk.Text, txt_mk.Text, cb_q.Text, Convert.ToInt32(txt_maQ.Text), txt_hinh.Text);
            }
            frm_load();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                dt = cl.NV_xoa(Convert.ToInt32(txt_ma.Text));
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
            txt_ma.Text = dataGridView1.CurrentRow.Cells["Manv"].Value.ToString();
            txt_ten.Text = dataGridView1.CurrentRow.Cells["Tennv"].Value.ToString();
            txt_sdt.Text = dataGridView1.CurrentRow.Cells["Sodt"].Value.ToString();
            txt_mk.Text = dataGridView1.CurrentRow.Cells["Matkhau"].Value.ToString();
            txt_tk.Text = dataGridView1.CurrentRow.Cells["Taikhoan"].Value.ToString();
            cb_q.Text = dataGridView1.CurrentRow.Cells["ChucVu"].Value.ToString();
            txt_maQ.Text = dataGridView1.CurrentRow.Cells["MaQ"].Value.ToString();
            txt_hinh.Text= dataGridView1.CurrentRow.Cells["Img"].Value.ToString();
            string gt = dataGridView1.CurrentRow.Cells["Gioitinh"].Value.ToString();
            if (gt == "Nam")
                rd_nam.Checked = true;
            else rd_nu.Checked = true;

            string ha = dataGridView1.CurrentRow.Cells["Img"].Value.ToString();
            string duongDanHienTai = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));// lấy đường dẫn vào project
            if (ha != "") 
            {
                hanh.Image = Image.FromFile(duongDanHienTai + @"\Images\" + ha);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;

                fileName = dlg.FileName;
                string somestring = fileName;
                string newstring = somestring.Substring(somestring.Length - 7, 7);
                txt_hinh.Text = newstring;

            }
        }

    }
}
