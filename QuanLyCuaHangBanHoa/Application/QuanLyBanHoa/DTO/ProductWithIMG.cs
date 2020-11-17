using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Data;

namespace QuanLyBanHoa.DTO
{
    public class ProductWithIMG
    {
        private int iD;
        private string name;
        private Image img = null;
        private Image ByteArrToImage(byte[] imgArr)
        {
            MemoryStream m = new MemoryStream(imgArr);
            return Image.FromStream(m);
        }
        public ProductWithIMG(DataRow row)
        {
            this.ID = (int)row["MaHH"];
            this.Name = (string)row["Ten"];
            if((row["IMG"])!= System.DBNull.Value)
            {
                this.img = ByteArrToImage((byte[])row["IMG"]);
            }
        }
        public ProductWithIMG(int ID, string Ten,Image img)
        {

            this.ID = ID;
            this.Name = Ten;
            this.IMG = img;
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
        public Image IMG
        {
            get
            {
                return img;
            }

            set
            {
                img = value;
            }
        }
    }
}
