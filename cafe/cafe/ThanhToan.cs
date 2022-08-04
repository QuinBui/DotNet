using CrystalDecisions.CrystalReports.Engine;
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
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }
        public static string nv = null;
        public static int mb = 0;
        int dem = 0;
        XuLy cl = new XuLy();
        DataTable dt = new DataTable();
        private void frm_load()
        {
            double tongtien = 0, tien = 0;
            dt.Clear();
            dt = cl.Ban_ThanhToanTungBan(mb);
            dataGridView1.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tien += Convert.ToInt32(dataGridView1.Rows[i].Cells["DonGia"].Value.ToString());
            }
            tongtien = tien;
            lb_tien.Text = tongtien.ToString();
        }
        private void ThanhToan_Load(object sender, EventArgs e)
        {
            frm_load();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button1, "In ra Bill");
            ToolTip1.SetToolTip(this.btn_thanhToan, "Thanh Toán Tiền");
            ToolTip1.SetToolTip(this.btn_thoat, "Thoát Khỏi Giao Diện Thanh Toán");
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            dem = 1;
            SqlDataReader dr;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int year = DateTime.Now.Year;
            int tongtien = Convert.ToInt32(lb_tien.Text);
            dr = cl.ThanhToan(day, month,year, tongtien);
            string chuoi = null;
            int soluong = 0;
            string douong = null;
            int dongia = 0;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                soluong = Convert.ToInt32((dataGridView1.Rows[i].Cells["Ten"].Value.ToString()).Substring(0, 1));
                chuoi = dataGridView1.Rows[i].Cells["Ten"].Value.ToString();
                douong = chuoi.Substring(1, chuoi.Length - 1);
                dongia = Convert.ToInt32(dataGridView1.Rows[i].Cells["Dongia"].Value.ToString());
            }
            if (txt_khach.Text != "")
            {
                int t = Convert.ToInt32(txt_khach.Text) - tongtien;
                txt_thoi.Text = t.ToString();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (dem > 0)
            {
                if (MessageBox.Show("Thanh toán thành công", "Thông Báo", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlDataReader dr;
                    dr = cl.Ban_xoaBan(mb);
                    this.Close();
                }
            }
            this.Close();
        }
        SqlConnection _Connsql = new SqlConnection("Data Source=DESKTOP-FKDV2P4;Initial Catalog=QL_CAFE;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            double tongtien = 0, tien = 0;
            dt.Clear();
            dt = cl.Ban_ThanhToanTungBan(mb);
            dataGridView1.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tien += Convert.ToInt32(dataGridView1.Rows[i].Cells["DonGia"].Value.ToString());
            }
            tongtien = tien;

            _Connsql.Open();
            string l = "select DoUong,DonGia from PhieuDatBan"; 
            SqlCommand lenh = new SqlCommand(l, _Connsql);
            lenh.Parameters.Clear();
            da.SelectCommand = lenh;
            DataTable data = new DataTable("BangDiemIn");
            da.Fill(data);

            CrystalReport1 baocao = new CrystalReport1();
            baocao.SetDataSource(data);
            // Lấy tất cả các đối tượng thuộc   myReport
            ReportObjects rptObjects = baocao.ReportDefinition.ReportObjects;
            // Sàn lọc lấy đối tượng txtName từ rptObjects
            TextObject selectObj = (TextObject)rptObjects["Text4"];
            selectObj.Text = tongtien.ToString();

            InBill f = new InBill();
            f.crystalReportViewer1.ReportSource = baocao;
            f.ShowDialog();
        }
    }
}
