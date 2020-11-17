using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHoa.DTO
{
    public class TypeProduct
    {
        private string iD;
        private string productType;
        public TypeProduct(DataRow row) {
            this.ID = (string)row["MaLoai"];
            this.ProductType = (string)row["TenLoai"];
        }
        public TypeProduct(string Maloai, string TenLoai)
        {
            this.ID = Maloai;
            this.ProductType = TenLoai;
        }
        public string ID
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
        public string ProductType
        {
            get
            {
                return productType;
            }

            set
            {
                productType = value;
            }
        }
    }
}
