using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHoa.DTO
{
    public class Supplier
    {
        private int iD;
        private string name;
        private string address;
        private string phoneNumber;

        public Supplier(DataRow row)
        {
            this.ID = (int)row["MaNCC"];
            this.Name = (string)row["TenNCC"];
            this.Address = (string)row["diachi"];
            this.PhoneNumber = (string)row["sdt"];
        }
        public Supplier(int ID, string Ten, string Diachi, string sdt)
        {

            this.ID = ID;
            this.Name = Ten;
            this.Address = Diachi;
            this.PhoneNumber = sdt;
        }
        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

    }
}
