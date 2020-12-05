﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHoa.DTO;

namespace QuanLyBanHoa.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null)
                    instance = new AccountDAO();
                  return instance; }
            private set { instance = value; }
        }
        private Account account;
        private AccountDAO() { }
        public bool Login(string username,string password)
        {
            string query = "exec CheckAccount @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] {username,password});
            if(result.Rows.Count > 0)
                account = new Account(result.Rows[0]);
            return result.Rows.Count > 0;
        }
        public Account AccountInfor()
        {
            return account;
        }
        public bool CheckAccount(string username, string password)
        {
            string query = "exec CheckAccount @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }
        public int ChangePassWord(string username, string password)
        {
            string query = "Update TaiKhoan set Matkhau = @password where TenDangNhap = @username";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { password,username });
            return result;
        }
    }
}
