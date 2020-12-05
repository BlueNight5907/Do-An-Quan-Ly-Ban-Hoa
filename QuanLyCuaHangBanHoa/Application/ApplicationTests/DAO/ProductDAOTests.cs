using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyBanHoa.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHoa.DAO.Tests
{
    [TestClass()]
    public class ProductDAOTests
    {
        // Kiem tra xem san pham da duoc xoa chua, ID khong ton tai
        [TestMethod()]
        public void DeleteProductTest()
        {
            int ID = 15;
            bool delete = ProductDAO.Instance.DeleteProduct(ID);
            Assert.AreEqual(delete, false);
        }

        // Kiem tra xem san pham da duoc xoa chua, ID ton tai
        public void DeleteProductTest2()
        {
            int ID = 4;
            bool delete = ProductDAO.Instance.DeleteProduct(ID);
            Assert.AreEqual(delete, true);
        }

        // Kiem tra xem so luong san pham hien co, so luong dung
        [TestMethod()]
        public void CountListProduct()
        {
            int count = ProductDAO.Instance.CountListProduct();
            Assert.AreEqual(count, 5);
        }

        // Kiem tra xem so luong san pham hien co, so luong sai
        [TestMethod()]
        public void CountListProduct2()
        {
            int count = ProductDAO.Instance.CountListProduct();
            Assert.AreEqual(count, 6);
        }
    }
}