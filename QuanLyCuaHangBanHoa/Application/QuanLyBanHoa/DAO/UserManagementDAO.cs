using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHoa.DAO
{
    public class UserManagementDAO
    {
        private static UserManagementDAO instance;
        public static UserManagementDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserManagementDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private UserManagementDAO() { }
        
        //Lấy toàn bộ thông tin nhân viên
        public DataTable GetAllUserInfor()
        {
            DataTable data = new DataTable();
            string sql = "select * from NhanVien";
            data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }
    }
}
