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
    public partial class ThongTin : Form
    {
        public ThongTin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FKDV2P4;Initial Catalog=QL_CAFE;Integrated Security=True");
        private void frm_load()
        {
            string sql = @"select MaNV,TenNV,GioiTinh,SoDT,TaiKhoan,ChucVu, Img from NhanVien where TrangThai=N'online'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txt_ma.Text = dt.Rows[0]["MaNV"].ToString().Trim();
                txt_ten.Text = dt.Rows[0]["TenNV"].ToString().Trim();
                txt_gioitinh.Text = dt.Rows[0]["GioiTinh"].ToString().Trim();
                txt_sdt.Text = dt.Rows[0]["SoDT"].ToString().Trim();
                txt_tk.Text = dt.Rows[0]["TaiKhoan"].ToString().Trim();
                txt_chucvu.Text = dt.Rows[0]["ChucVu"].ToString().Trim();
                string ha = dt.Rows[0]["Img"].ToString().Trim();
                string duongDanHienTai = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                hanh.Image = Image.FromFile(duongDanHienTai + @"\Images\" + ha);
            }
        }
        private void ThongTin_Load(object sender, EventArgs e)
        {
            frm_load();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Master mt = new Master();
            mt.Show();
        }

    }
}
