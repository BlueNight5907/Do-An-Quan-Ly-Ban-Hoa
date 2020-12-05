using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyBanHoa.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHoa.DAO;

namespace QuanLyBanHoa.DAO.Tests
{
    [TestClass()]
    public class AccountDAOTests
    {
        // Kiem tra tai khoan co ton tai, Tai khoan sai
        [TestMethod()]
        public void LoginTest()
        {
            String Username = "taikhoan";
            String Password = "matkhau";
            bool login = AccountDAO.Instance.Login(Username, Password);
            Assert.AreEqual(login, false);
        }

        // Kiem tra tai khoan co ton tai, Tai khoan dung
        [TestMethod()]
        public void LoginTest2()
        {
            String Username2 = "Username";
            String Password2 = "Password";
            bool login = AccountDAO.Instance.Login(Username2, Password2);
            Assert.AreEqual(login, true);
        }
    } 
}