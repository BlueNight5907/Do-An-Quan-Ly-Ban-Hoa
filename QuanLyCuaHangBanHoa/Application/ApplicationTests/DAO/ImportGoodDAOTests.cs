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
    public class ImportGoodDAOTests
    {
        [TestMethod()]
        public void ImportTest()
        {
            int ID = 6;
            int Supplier = 1;
            int Total = 4;

            int import = ImportGoodDAO.Instance.Import(ID, Supplier, Total);
            Assert.AreEqual(import, 6);
        }
    }
}