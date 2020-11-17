using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHoa.DTO
{
    public class ImportGoodsInfor
    {
        private int iD;
        private int productID;
        private string name;
        private int bid;
        private int amount;
        private int money;
        public ImportGoodsInfor(int ProductID, string Name,int Amount, int BID, int Money)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Amount = Amount;
            this.BID = BID;
            this.Money = Money;
        }
        public int ProductID
        {
            get
            {
                return productID;
            }

            set
            {
                productID = value;
            }
        }
        public int Money
        {
            get
            {
                return money;
            }

            set
            {
                money = value;
            }
        }
        public int Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
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
        public int BID
        {
            get
            {
                return bid;
            }

            set
            {
                bid = value;
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
    }
}
