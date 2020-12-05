using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHoa.DAO;

namespace QuanLyBanHoa.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private CustomerDAO() { }
        public DataTable GetTopCustomer(int month, int year)
        {
            string query = "exec KhachHangTiemNang @a , @b";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {month,year});
            return data;
        }
    }
}
