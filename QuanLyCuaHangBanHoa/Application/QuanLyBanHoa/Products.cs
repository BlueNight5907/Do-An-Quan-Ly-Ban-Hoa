using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHoa.DAO;
using QuanLyBanHoa.Forms;
using System.IO;
//using QuanLyBanHoa.DTO;

namespace QuanLyBanHoa
{
    public partial class Products : Form
    {
        private MainScreen main = null;
        public Products(Form callingForm)
        {
            main = callingForm as MainScreen;
            InitializeComponent();
            LoadDataByResetButton();
            Color c = Color.FromArgb(0, 189, 69);
            ChangeColor(c);
            dataGridViewListProduct.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewListProduct.RowTemplate.Height = 50;

        }
        private void ChangeColor(Color color)
        {
            iconBtnSearch.IconColor = color;
            iconbtnReset.IconColor = color;
            iconbtnClear.IconColor = color;
            iconbtnAdd.IconColor = color;
            iconbtnUpdate.IconColor = color;
            iconbtnDelete.IconColor = color;
        }
        private Color color = Color.FromArgb(24, 155, 242);
        private void LoadData()
        {
            dataGridViewListProduct.DataSource = table;
            SetEditingMode(false);
        }
        private void LoadDataByResetButton()
        {
            table = ProductDAO.Instance.ListProduct();
            LoadData();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            
            //SetEditingMode(false);
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }
        DataTable table = new DataTable();
        private void iconBtnSearch_Click(object sender, EventArgs e)
        {
            if (CheckCondition(txtIDProduct.Text))
            {
                int ID = Int32.Parse(txtIDProduct.Text);
                idproduct = ID;
                name = txtNameProduct.Text;

            }
            else
            {
                idproduct = 0;
                name = txtNameProduct.Text;
            }
            FindProduct();
        }
        int idproduct = 0;
        string name = "";
        private void FindProduct()
        {
            DataTable data = ProductDAO.Instance.FindProduct(idproduct, name);
            table = data;
            LoadData();

        }
        private bool CheckCondition(string a)
        {
            int x = 0;

            if (Int32.TryParse(a, out x))
            {
                return true;
                // you know that the parsing attempt
                // was successful
            }
            return false;
        }
        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIDProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDProduct_Enter(object sender, EventArgs e)
        {
            if(txtIDProduct.Text == "Mã sản phẩm")
            {
                txtIDProduct.Clear();
                txtIDProduct.ForeColor = color;
            }
        }

        private void txtNameProduct_Enter(object sender, EventArgs e)
        {
            if (txtNameProduct.Text == "Tên sản phẩm")
            {
                txtNameProduct.Clear();
                txtNameProduct.ForeColor = color;
            }
        }

        private void txtIDProduct_Leave(object sender, EventArgs e)
        {
            if(txtIDProduct.TextLength == 0)
            {
                txtIDProduct.Text = "Mã sản phẩm";
                txtIDProduct.ForeColor = Color.LightGray;
                
            }
        }

        private void txtNameProduct_Leave(object sender, EventArgs e)
        {
            if (txtNameProduct.TextLength == 0)
            {
                txtNameProduct.Text = "Tên sản phẩm";
                txtNameProduct.ForeColor = Color.LightGray;
            }
        }

        private void txtNameProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconbtnClear_Click(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            txtIDType.Text = "";
            txtID.Text = "";
            txtAmount.Text = "";
            txtName.Text = "";
            txtTypeProductName.Text = "";
            txtPrice.Text = "";
            txtBid.Text = "";
            picture.Image = picture.InitialImage;
            LoadData();
            SetEditingMode(false);
        }
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblprice_Click(object sender, EventArgs e)
        {

        }
        private void SetEditingMode(bool enable)
        {
            if (!enable)
            {
                dataGridViewListProduct.ClearSelection();
            }
            iconbtnDelete.Enabled = enable;
            iconbtnUpdate.Enabled = enable;
            iconbtnReset.Enabled = enable;
        }
        private void dataGridViewListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridViewListProduct.RowCount)
            {
                return;
            }
            SetEditingMode(true);
            DataGridViewRow row = dataGridViewListProduct.Rows[index];
            String mahh = Convert.ToString(row.Cells[0].Value);
            String tenhh = Convert.ToString(row.Cells[1].Value);
            String maloai = Convert.ToString(row.Cells[2].Value).Trim();
            String tenloai = Convert.ToString(row.Cells[3].Value);
            String gianhap = Convert.ToString(row.Cells[4].Value);
            String giaban = Convert.ToString(row.Cells[5].Value);
            String soluong = Convert.ToString(row.Cells[6].Value);

            // update UI
            txtIDType.Text = maloai;
            txtID.Text = mahh;
            txtAmount.Text = soluong;
            txtName.Text = tenhh;
            txtTypeProductName.Text = tenloai;
            txtPrice.Text = giaban;
            txtBid.Text = gianhap;
            DataTable data = ProductDAO.Instance.LoadIMG(Int32.Parse(txtID.Text));
            Image img = null;
            
            foreach (DataRow item in data.Rows)
            {
                img = ByteArrToImage((byte[])item["IMG"]);
            }
            if(img != null)
            {
                picture.Image = img;
               
            }
            else
            {
                picture.Image = picture.ErrorImage;
            }

        }
        private Image ByteArrToImage(byte[] imgArr)
        {
            MemoryStream m = new MemoryStream(imgArr);
            return Image.FromStream(m);
        }
        private void labelmoney1_Click(object sender, EventArgs e)
        {

        }

        private void iconbtnDelete_Click(object sender, EventArgs e)
        {

            int ID = Int32.Parse(txtID.Text);
            bool result = ProductDAO.Instance.DeleteProduct(ID);
            if (result)
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                LoadData();
                Clear();
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại");
            }
            if ((idproduct == 0) && (name == ""))
            {
                LoadDataByResetButton();
            }
            else
            {
                FindProduct();
            }

        }

        private void iconbtnUpdate_Click(object sender, EventArgs e)
        {

            int ID = Int32.Parse(txtID.Text);
            int price = Int32.Parse(txtPrice.Text);
            int bid = Int32.Parse(txtBid.Text);
            byte[] imgArr = ImageToByteArray(picture.Image);
            bool result = ProductDAO.Instance.UpdateProduct(ID,txtName.Text,txtIDType.Text,price,bid,imgArr);
            
            if (result)
            {
                MessageBox.Show("Cập nhật sản phẩm thành công");
                LoadData();
                Clear();
            }
            else
            {
                MessageBox.Show("Cập nhật sản phẩm thất bại");
            }
            if ((idproduct == 0) && (name == ""))
            {
                LoadDataByResetButton();
            }
            else
            {
                FindProduct();
            }
        }

        private void iconbtnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void iconbtnClear_Click_1(object sender, EventArgs e)
        {
            txtIDProduct.Clear();
            txtNameProduct.Clear();
            txtIDProduct.Text = "Mã sản phẩm";
            txtIDProduct.ForeColor = Color.LightGray;
            txtNameProduct.Text = "Tên sản phẩm";
            txtNameProduct.ForeColor = Color.LightGray;
            idproduct = 0;
            name = "";
            LoadDataByResetButton();
            Clear();
        }

        private void dataGridViewListProduct_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dataGridViewListProduct_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in dataGridViewListProduct.Rows)
            {
                x.MinimumHeight = 50;
            }
        }
        
        private void iconbtnAdd_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show(); 
        }

        private void panelLeft_Paint_1(object sender, PaintEventArgs e)
        {

        }
        
        private byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string imageLocation = dialog.FileName;
                    //picIMGProduct.ImageLocation = imageLocation;
                    picture.Image = new Bitmap(imageLocation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewListProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
