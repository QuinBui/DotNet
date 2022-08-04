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
    public partial class doanhThu : Form
    {
        public doanhThu()
        {
            InitializeComponent();
        }
        XuLy cl = new XuLy();
        DataTable dt = new DataTable();
        public static string nv = null;
        private void frm_load()
        {
            dt.Clear();
            dt = cl.ThongKe();
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
                int tien = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    tien += Convert.ToInt32(dataGridView1.Rows[i].Cells["Tongtien"].Value.ToString());
                }
                lb_thu.Text = String.Format("{0:0,0}", tien).ToString();
            }
        }
        private void dt_Load(object sender, EventArgs e)
        {
            frm_load();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btn_reset, "Reset lại dữ liệu");
            ToolTip1.SetToolTip(this.bunifuImageButton1, "Xóa tất cả dữ liệu thống kê");
            ToolTip1.SetToolTip(this.bunifuImageButton2, "Thoát Khỏi Giao Diện");
        }

        private void cb_tt_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dt = cl.ThongKeTheoNgay(Convert.ToInt32(cb_tn.Text), Convert.ToInt32(cb_tt.Text));
            if (dt.Rows.Count == 0)
            {
                lb_thongBao.Text = "Không có dữ liệu...";
                lb_thu.Text = "0";
            }
            else
            {
                lb_thongBao.Text = "";
                dataGridView1.DataSource = dt;
                int tien = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    tien += Convert.ToInt32(dataGridView1.Rows[i].Cells["Tongtien"].Value.ToString());
                }
                lb_thu.Text = String.Format("{0:0,0}", tien).ToString();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            frm_load();
            cb_tn.Text = "";
            cb_tt.Text = "";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            try
            {
                if (MessageBox.Show("Xóa hết dữ liệu thống kê" + Environment.NewLine + "Không thể khôi phục lại đâu nhé !",
                    "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    dr = cl.ThongKe_xoa(0);
                    frm_load();
                }
            }
            catch (Exception)
            {

            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
            QuanLy ql = new QuanLy();
            ql.Show();
        }
    }
}
