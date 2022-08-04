using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class thucDon : Form
    {
        public thucDon()
        {
            InitializeComponent();
        }
        XuLy xl = new XuLy();
        DataTable dt = new DataTable();
        public int ma = 0, dem = 0;
        private void load()
        {
            dt.Clear();
            if (dem == 0)
            {
                cbo_nhom.Text = null;
            }
            dt = xl.TD_load(0);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma.Text = dataGridView1.CurrentRow.Cells["Matd"].Value.ToString();
            txt_ten.Text = dataGridView1.CurrentRow.Cells["Ten"].Value.ToString();
            txt_gia.Text = dataGridView1.CurrentRow.Cells["Gia"].Value.ToString();
            cbo_nhom.Text = dataGridView1.CurrentRow.Cells["Nhom"].Value.ToString();
            txt_maN.Text = dataGridView1.CurrentRow.Cells["MaN"].Value.ToString();
            txt_hinh.Text = dataGridView1.CurrentRow.Cells["Img"].Value.ToString();

            string ha = dataGridView1.CurrentRow.Cells["Img"].Value.ToString();
            if (ha != "")
            {
                string duongDanHienTai = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));// lấy đường dẫn vào project
                hanh.Image = Image.FromFile(duongDanHienTai + @"\Images\" + ha);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (txt_ma.Text != "" && txt_ten.Text != "" && txt_gia.Text != "" && txt_maN.Text != "")
            {
                dt = xl.TD_them(Convert.ToInt32(txt_ma.Text), txt_ten.Text, Convert.ToInt32(txt_gia.Text), Convert.ToInt32(txt_maN.Text), txt_hinh.Text);
                if (MessageBox.Show("yeah !! Đã thêm thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    load();
            }
            else
                MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            load();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_gia.Text))
            {
                dt.Clear();
                dt = xl.TD_sua(Convert.ToInt32(txt_ma.Text), txt_ten.Text, Convert.ToInt32(txt_gia.Text), Convert.ToInt32(txt_maN.Text), txt_hinh.Text);
                MessageBox.Show("yeah !! Sửa thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                load();
            }
            else
                MessageBox.Show("Sửa không thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa món này ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                dr = xl.TD_xoa(Convert.ToInt32(txt_ma.Text));
                load();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
            QuanLy ql = new QuanLy();
            ql.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;

                fileName = dlg.FileName;
                string somestring = fileName;
                string newstring = somestring.Substring(somestring.Length - 6, 6);
                txt_hinh.Text = newstring;
                
            }
        }
        SqlConnection _Connsql = new SqlConnection("Data Source=DESKTOP-FKDV2P4;Initial Catalog=QL_CAFE;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();

        private void btn_in_Click(object sender, EventArgs e)
        {
            string l = "InThucDon";
            SqlCommand lenh = new SqlCommand(l, _Connsql);
            lenh.CommandType = CommandType.StoredProcedure;
            lenh.Parameters.Clear();
            lenh.Parameters.AddWithValue("@nhom", cbo_nhom.Text);

            da.SelectCommand = lenh;
            DataTable data = new DataTable("BangDiemIn");
            da.Fill(data);

            CrptThucDon baocao = new CrptThucDon();
            baocao.SetDataSource(data);

            InBill f = new InBill();
            f.crystalReportViewer1.ReportSource = baocao;
            f.ShowDialog();
        }


        private void td_Load(object sender, EventArgs e)
        {
            load();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.cbo_nhom, "Tên Nhóm Món");
            ToolTip1.SetToolTip(this.txt_maN, "Mã Nhóm Món \n 1: Coffee \n 2:Trà sữa \n 3: Yogurt \n 4: Sữa Tươi \n 5: Trà trái cây \n 6: Đá Xay");
            ToolTip1.SetToolTip(this.btn_them, "Thêm Món Mới Vào Thực Đơn");
            ToolTip1.SetToolTip(this.btn_sua, "Sửa Món Trong Thực Đơn");
            ToolTip1.SetToolTip(this.btn_xoa, "Xóa Món Khỏi Thực Đơn");
            ToolTip1.SetToolTip(this.btn_thoat, "Thoát Khỏi Giao Diện Thanh Toán");
        }
    }
}
