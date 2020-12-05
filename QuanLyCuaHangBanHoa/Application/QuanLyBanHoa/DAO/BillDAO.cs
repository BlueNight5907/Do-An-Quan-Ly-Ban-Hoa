using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHoa.DAO;
using QuanLyBanHoa.DTO;
namespace QuanLyBanHoa.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private BillDAO() { }
        public int AddCustomerInfor(string name, string phonenumber)
        {
            DataTable data = new DataTable();
            string query = "exec NhapKhachHang @a , @b ";
            data = DataProvider.Instance.ExecuteQuery(query, new object[] { name , phonenumber });
            int CustomerID = (int)data.Rows[0]["MaKH"];
            return CustomerID;
        }
        public int AddBillInfor(int customerID, int staffID, int totalMoney,int discountMoney, int pay )
        {
            DataTable data = new DataTable();
            string query = "exec NhapHoaDon @a , @b , @c , @d , @e";
            data = DataProvider.Instance.ExecuteQuery(query, new object[] { customerID, staffID, totalMoney, discountMoney, pay });
            int BillID = (int)data.Rows[0]["MaHD"];
            return BillID;
        }

        public void DetailBill(int BillID, int IDProduct, int Amount, int Money)
        {
            string query = "exec NhapHoaDon_ChiTiet @a , @b , @c , @d";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { BillID, IDProduct, Amount, Money });
        }

        public DataTable History(DateTime date)
        {
            DataTable data = new DataTable();
            string query = "select TenNV,TenKH,KhachHang.sdt,HoaDon.MaHD,TongTien,TienGiam,ThanhToan From HoaDon inner join KhachHang on KhachHang.MaKH = HoaDon.MaKH " +
                "inner join NhanVien on NhanVien.MaNV = HoaDon.MaNV where HoaDon.DateCheckIn = '" + date.ToString("MM/dd/yyyy") + "'";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable DetailHistory(DateTime date)
        {
            DataTable data = new DataTable();
            string query = "select Ten,TenNV,HoaDon.MaHD,HangHoa.GiaBan,SoLuong,ThanhTien From ChiTietHoaDon" +
                " inner join HoaDon on ChiTietHoaDOn.MaHD = HoaDon.MaHD inner join HangHoa on HangHoa.MaHH = ChiTietHoaDon.MaHH " +
                "inner join NhanVien on NhanVien.MaNV = HoaDon.MaNV where HoaDon.DateCheckIn ='" + date.ToString("MM/dd/yyyy") + "'";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
