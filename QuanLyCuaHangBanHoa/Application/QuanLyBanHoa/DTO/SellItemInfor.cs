using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHoa.DTO
{
    public class SellItemInfor
    {
        private int iD;
        private int productID;
        private string name;
        private int price;
        private int amount;
        private int money;
        public SellItemInfor(int ProductID, string Name, int Amount, int Price, int Money)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Amount = Amount;
            this.Price = Price;
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
        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
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
