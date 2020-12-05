using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHoa.DAO
{
    public class ImportGoodDAO
    {
        private static ImportGoodDAO instance;
        public static ImportGoodDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImportGoodDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private ImportGoodDAO() { }
        public int Import(int ID, int supplier, int totalValue)
        {
            DataTable data = new DataTable();
            string query = "exec NhapHangVaoKho @id , @supplier , @totaValue";
            data = DataProvider.Instance.ExecuteQuery(query, new object[] { ID ,supplier,totalValue});
            int importID = (int)data.Rows[0]["MaNH"];
            return importID;
        }
        public void DetailImport(int ID, int IDProduct, int BID,int Amount, int Money)
        {
            string query = "exec NhapHangVaoKho_ChiTiet @a , @b , @c , @d , @e";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] {ID, IDProduct, BID, Amount, Money });  
        }
        public DataTable DetailHistory(DateTime date)
        {
            DataTable data = new DataTable();
            string query = "select Ten,TenNV,NhapHang.MaNH,ChiTietNhapHang.GiaNhap,SoLuong,ThanhTien,TongTien  From ChiTietNhapHang" +
                " inner join NhapHang on NhapHang.MaNH = ChiTietNhapHang.MaNH inner join HangHoa on HangHoa.MaHH = ChiTietNhapHang.MaHH " +
                "inner join NhanVien on NhanVien.MaNV = NhapHang.MaNV where NhapHang.DateCheckIn = '"+date.ToString("MM/dd/yyyy")+"'";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
