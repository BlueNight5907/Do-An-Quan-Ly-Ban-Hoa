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
        private DateTime birthday;
        private string cmnd;
        private string sdt;
        private string address;
        private DateTime datestartjob;
        private bool sex;
        public Account(DataRow row)
        {
            this.ID = (int)row["MaNV"];
            this.Name = (string)row["TenNV"];
            this.PassWord = (string)row["MatKhau"];
            this.DisplayName = (string)row["TenHienThi"];
            this.UserName = (string)row["TenDangNhap"];
            this.Permission = (string)row["permission"];
            this.BirthDay = (DateTime)row["NgaySinh"];
            this.CMND = (string)row["CMND"];
            this.SDT = (string)row["sdt"];
            this.Address=(string)row["diachi"];
            this.DateStartJob = (DateTime)row["NgayVaoLam"];
            this.Sex = (bool)row["GT"];
        }
        public bool Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }
        public DateTime DateStartJob
        {
            get
            {
                return datestartjob;
            }

            set
            {
                datestartjob = value;
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
        public string SDT
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }
        public string CMND
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }
        public DateTime BirthDay
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
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
