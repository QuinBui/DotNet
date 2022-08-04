using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe
{
    public class XuLy
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FKDV2P4;Initial Catalog=QL_CAFE;Integrated Security=True");
        DataTable dt = new DataTable();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tk"></param>
        /// <param name="mk"></param>
        /// <returns></returns>
        public DataTable KiemTraDangNhap(string tk, string mk)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("KiemTraDangNhap", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@taikhoan", tk);
            cm.Parameters.AddWithValue("@matkhau", mk);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable KiemTra(string tk, string mk,string gioOnl)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("KiemTra", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@taikhoan", tk);
            cm.Parameters.AddWithValue("@matkhau", mk);
            cm.Parameters.AddWithValue("@gioOnl", gioOnl);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable DangXuat(string gioOff)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("DangXuat", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@gioOff", gioOff);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable DoiMatKhau(string tk, string mkC,string mkM)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("DoiMatKhau", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@taikhoan", tk);
            cm.Parameters.AddWithValue("@matkhaucu", mkC);
            cm.Parameters.AddWithValue("@matkhaumoi", mkM);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maban"></param>
        /// <returns></returns>
        public SqlDataReader Ban_xemTrangThaiBan(int maban)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr;
            SqlCommand cm = new SqlCommand("Ban_xemTrangThaiBan", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@maban", maban);
            dr = cm.ExecuteReader();
            return dr;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maban"></param>
        /// <returns></returns>
        public DataTable Ban_ThanhToanTungBan(int maban)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("Ban_ThanhToanTungBan", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", maban);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maban"></param>
        /// <returns></returns>
        public SqlDataReader Ban_xoaBan(int maban)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr;
            SqlCommand cm = new SqlCommand("Ban_xoaBan", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@maban", maban);
            dr = cm.ExecuteReader();
            return dr;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngay"></param>
        /// <param name="thang"></param>
        /// <param name="tongtien"></param>
        /// <returns></returns>
        public SqlDataReader ThanhToan(int ngay, int thang,int nam, int tongtien)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr;
            SqlCommand cm = new SqlCommand("ThanhToan", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ngay", ngay);
            cm.Parameters.AddWithValue("@thang", thang);
            cm.Parameters.AddWithValue("@nam", nam);
            cm.Parameters.AddWithValue("@tongtien", tongtien);
            dr = cm.ExecuteReader();
            return dr;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nhom"></param>
        /// <returns></returns>
        public DataTable BH_loadThucDon(string nhom)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("BH_loadThucDon", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@nhom", nhom);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        public DataTable TD_load(int ma)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("TD_load", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", ma);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ma"></param>
        /// <param name="ten"></param>
        /// <param name="gia"></param>
        /// <param name="nhom"></param>
        /// <returns></returns>
        public DataTable TD_sua(int ma, string ten, int gia, int nhom,string img)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("TD_sua", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", ma);
            cm.Parameters.AddWithValue("@ten", ten);
            cm.Parameters.AddWithValue("@gia", gia);
            cm.Parameters.AddWithValue("@nhom", nhom);
            cm.Parameters.AddWithValue("@img", img);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        public SqlDataReader TD_xoa(int ma)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr;
            SqlCommand cm = new SqlCommand("TD_xoa", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", ma);
            dr = cm.ExecuteReader();
            return dr;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matd"></param>
        /// <param name="ten"></param>
        /// <param name="gia"></param>
        /// <param name="man"></param>
        /// <returns></returns>
        public DataTable TD_them(int matd, string ten, int gia, int man,string img)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("TD_them", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@matd", matd);
            cm.Parameters.AddWithValue("@ten", ten);
            cm.Parameters.AddWithValue("@gia", gia);
            cm.Parameters.AddWithValue("@man", man);
            cm.Parameters.AddWithValue("@img", img);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable NV_load()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("NV_load", con);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ten"></param>
        /// <param name="gioitinh"></param>
        /// <param name="sdt"></param>
        /// <param name="taikhoan"></param>
        /// <param name="matkhau"></param>
        /// <param name="chucvu"></param>
        /// <param name="maq"></param>
        /// <returns></returns>
        public DataTable NV_them(string ten, string gioitinh, string sdt, string taikhoan, string matkhau, string chucvu, int maq,string img)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("NV_them", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ten", ten);
            cm.Parameters.AddWithValue("@gioitinh", gioitinh);
            cm.Parameters.AddWithValue("@sodt", sdt);
            cm.Parameters.AddWithValue("@taikhoan", taikhoan);
            cm.Parameters.AddWithValue("@matkhau", matkhau);
            cm.Parameters.AddWithValue("@chucvu", chucvu);
            cm.Parameters.AddWithValue("@maq", maq);
            cm.Parameters.AddWithValue("@img", img);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ma"></param>
        /// <param name="ten"></param>
        /// <param name="gioitinh"></param>
        /// <param name="sdt"></param>
        /// <param name="taikhoan"></param>
        /// <param name="matkhau"></param>
        /// <param name="chucvu"></param>
        /// <param name="maq"></param>
        /// <returns></returns>
        public DataTable NV_sua(int ma, string ten, string gioitinh, string sdt, string taikhoan, string matkhau, string chucvu, int maq,string img)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("NV_sua", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", ma);
            cm.Parameters.AddWithValue("@ten", ten);
            cm.Parameters.AddWithValue("@gioitinh", gioitinh);
            cm.Parameters.AddWithValue("@sodt", sdt);
            cm.Parameters.AddWithValue("@taikhoan", taikhoan);
            cm.Parameters.AddWithValue("@matkhau", matkhau);
            cm.Parameters.AddWithValue("@chucvu", chucvu);
            cm.Parameters.AddWithValue("@maq", maq);
            cm.Parameters.AddWithValue("@img", img);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        public DataTable NV_xoa(int ma)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("NV_xoa", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", ma);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maban"></param>
        /// <param name="trangthai"></param>
        /// <param name="douong"></param>
        /// <param name="dongia"></param>
        /// <returns></returns>
        public SqlDataReader Ban_them(int maban, string trangthai, string douong, int dongia)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr;
            SqlCommand cm = new SqlCommand("Ban_them", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@maban", maban);
            cm.Parameters.AddWithValue("@trangthai", trangthai);
            cm.Parameters.AddWithValue("@douong", douong);
            cm.Parameters.AddWithValue("@dongia", dongia);
            dr = cm.ExecuteReader();
            return dr;
        }

        public DataTable ThongKe()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("ThongKe", con);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngaydau"></param>
        /// <param name="ngaycuoi"></param>
        /// <returns></returns>
        public DataTable ThongKeTheoNgay(int ngaydau, int ngaycuoi)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("ThongKeTheoNgay", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ngaydau", ngaydau);
            cm.Parameters.AddWithValue("@ngaycuoi", ngaycuoi);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        public SqlDataReader ThongKe_xoa(int ma)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlDataReader dr;
            SqlCommand cm = new SqlCommand("ThongKe_xoa", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", ma);
            dr = cm.ExecuteReader();
            return dr;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable NL_load()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("NL_load", con);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable NL_them(string ten, int gia, int soluong, string dvt, string ngaynhap)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("NL_them", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ten", ten);
            cm.Parameters.AddWithValue("@gia", gia);
            cm.Parameters.AddWithValue("@soluong", soluong);
            cm.Parameters.AddWithValue("@dvt", dvt);
            cm.Parameters.AddWithValue("@ngaynhap", ngaynhap);
            //cm.Parameters.AddWithValue("@ngayhet", ngayhet);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        public DataTable NL_sua(int ma, string ten, int gia, int soluong, string dvt, string ngaynhap, string ngayhet)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("NL_sua", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", ma);
            cm.Parameters.AddWithValue("@ten", ten);
            cm.Parameters.AddWithValue("@gia", gia);
            cm.Parameters.AddWithValue("@soluong", soluong);
            cm.Parameters.AddWithValue("@dvt", dvt);
            cm.Parameters.AddWithValue("@ngaynhap", ngaynhap);
            cm.Parameters.AddWithValue("@ngayhet", ngayhet);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        public DataTable NL_xoa(int ma)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cm = new SqlCommand("NL_xoa", con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@ma", ma);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
    }
}
