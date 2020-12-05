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
    public class StaffDAO
    {
        private static StaffDAO instance;
        public static StaffDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaffDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private StaffDAO() { }
        public DataTable LoadAllStaff()
        {
            string query = "select MaNV,TenNv,NgaySinh,GT,Cmnd,sdt,diachi,ngayvaolam,luong,chucvu from NhanVien where activated = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool AddStaff(string name, DateTime birthday, bool gender, string cmnd, string sdt, string address, DateTime daystart, int salary, string position)
        {
            string query = "insert into NhanVien values( @a , @b , @c , @d , @e , @f , @g , @h , @i , 1 )";
            int rowaffect = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, birthday, gender, cmnd, sdt, address, daystart, salary, position });
            if(rowaffect < 1)
            {
                return false;
            }
            return true;
        }

    }
}
