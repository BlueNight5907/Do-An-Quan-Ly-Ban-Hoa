using QuanLyBanHoa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHoa.DAO
{
    public class ProductDAO
    {

        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProductDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private ProductDAO() { }
        public DataTable ListProduct()
        {
            DataTable data = new DataTable();
            string query = "exec DanhMucSanPham";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public int CountListProduct()
        {
            DataTable data = new DataTable();
            string query = "exec DanhMucSanPham";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count;
        }
        public bool DeleteProduct(int ID)
        {
            string query = "exec XoaSanPham @ID";
            int data = DataProvider.Instance.ExecuteNonQuery(query,new object[] { ID});
            return data>0;
        }
        public bool UpdateProduct(int ID,string name,string productTypeID, int price,int bid,byte[] imgArr)
        {
            string query = "exec CapNhatSanPham @ID , @name , @productTypeID , @price , @bid , @img";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[]{ ID,name,productTypeID,price,bid,imgArr});
            return data > 0;
        }
        public bool AddProduct(int ID, string name, string productTypeID, int bid, int price, int amount,byte[] imgArr )
        {
            string query = "exec ThemSanPham @mancc , @tenhh , @maloai , @bid , @price , @soluong , @img";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID, name, productTypeID, bid, price, amount, imgArr});
            return data > 0;
        }
        public DataTable FindProduct(int ID, string name)
        {
            DataTable data = new DataTable();
            string query = "exec TimSanPham @ID , @name";
            data = DataProvider.Instance.ExecuteQuery(query, new object[] { ID, name });
            return data;
        }
        public DataTable LoadIMG(int ID)
        {
            DataTable data = new DataTable();
            string query = "exec LoadIMG @ID";
            data = DataProvider.Instance.ExecuteQuery(query, new object[] {ID});
            return data;
        }
        public DataTable ListProductWithIMG(int ID = 0,string Name = "All",string Type = "Null", int price1 = 0, int price2 = 0)
        {
            DataTable data = new DataTable();
            string query = "exec DanhMucSanPhamKemAnh @ID , @Name , @Type , @price1 , @price2";
            data = DataProvider.Instance.ExecuteQuery(query, new object[] { ID, Name, Type, price1, price2 });
            return data;
        }
        public List<TypeProduct> LoadTypeProduct()
        {
            List<TypeProduct> ProducTypeList = new List<TypeProduct>();
            string query = "exec LoaiSanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TypeProduct Product = new TypeProduct(item);
                ProducTypeList.Add(Product);
            }
            return ProducTypeList;
        }
        public List<Supplier> LoadSupplier()
        {
            List<Supplier> SupplierList = new List<Supplier>();
            string query = "exec NhaCC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Supplier supplier = new Supplier(item);
                SupplierList.Add(supplier);
            }
            return SupplierList;
        }
    }
}
