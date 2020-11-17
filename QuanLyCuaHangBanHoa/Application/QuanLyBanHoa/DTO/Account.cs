using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHoa.DTO
{
    public class Account
    {
        private string displayName;
        private string userName;
        private string passWord;
        private int iD;
        private string name;
        private string permission;
        public Account(DataRow row)
        {
            this.ID = (int)row["MaNV"];
            this.Name = (string)row["TenNV"];
            this.PassWord = (string)row["MatKhau"];
            this.DisplayName = (string)row["TenHienThi"];
            this.UserName = (string)row["TenDangNhap"];
            this.Permission = (string)row["permission"];
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
        public string DisplayName
        {
            get
            {
                return displayName;
            }

            set
            {
                displayName = value;
            }
        }
        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
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
        public string PassWord
        {
            get
            {
                return passWord;
            }

            set
            {
                passWord = value;
            }
        }
        public string Permission
        {
            get
            {
                return permission;
            }

            set
            {
                permission = value;
            }
        }
    }
}
