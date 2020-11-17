using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHoa.DAO;
using QuanLyBanHoa.DTO;
using System.IO;
namespace QuanLyBanHoa.Forms
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            LoadData();
            SetAddingMode();
            iconBtnClear.Enabled = false;
        }
        List<TypeProduct> listP = new List<TypeProduct>();
        List<Supplier> listS = new List<Supplier>();
        private void LoadData()
        {
            cbTypeProduct.DataSource = null;
            listP = ProductDAO.Instance.LoadTypeProduct();
            foreach(TypeProduct item in listP)
            {
                cbTypeProduct.Items.Add(item.ProductType);
            }
            cbTypeProduct.SelectedIndex = 0;
            listS = ProductDAO.Instance.LoadSupplier();
            foreach(Supplier item in listS)
            {
                cbSupplier.Items.Add(item.Name);
            }
            cbSupplier.SelectedIndex = 0;
            

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void iconBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtAmount.Text = "0";
            txtAmount.ForeColor = Color.DarkGray;
            txtBID.Text = "1000";
            txtBID.ForeColor = Color.DarkGray;
            txtPrice.Text = "1000";
            txtPrice.ForeColor = Color.DarkGray;
            txtName.Text = "";
            iconBtnClear.Enabled = false;
            picIMGProduct.Image = null;
            cbTypeProduct.SelectedIndex = 0;
            cbSupplier.SelectedIndex = 0;

        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            iconBtnClear.Enabled = true;
            SetAddingMode();
        }

        private void txtBID_TextChanged(object sender, EventArgs e)
        {
            SetAddingMode();
            iconBtnClear.Enabled = true;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            iconBtnClear.Enabled = true;
            SetAddingMode();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            iconBtnClear.Enabled = true;
            SetAddingMode();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void cbTypeProduct_TextChanged(object sender, EventArgs e)
        {
            iconBtnClear.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            iconBtnClear.Enabled = true;
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
        private void SetAddingMode()
        {
            if((txtAmount.TextLength == 0) || (txtBID.TextLength == 0) || (txtAmount.TextLength == 0)||(txtName.TextLength ==0)||(picIMGProduct.Image == null))
            {
                iconbtnAdd.Enabled = false;
            }
            else
            {
                iconbtnAdd.Enabled = true;
            }
        }
        private void SaveIMG(byte[] b)
        {
            string s = "exec CapNhatIMGHangHoa @id , @hinh";
            int data = DataProvider.Instance.ExecuteNonQuery(s, new object[] { 2, b });
        }
        private void iconbtnAdd_Click(object sender, EventArgs e)
        {
            if (CheckCondition(txtBID.Text) && CheckCondition(txtPrice.Text) && CheckCondition(txtAmount.Text) && (picIMGProduct.Image != null))
            {
                string name = txtName.Text;
                string typeID = null;
                int ID = 0;
                foreach (TypeProduct item in listP)
                {
                    if (String.Compare(item.ProductType, cbTypeProduct.SelectedItem.ToString(), false) == 0)
                    {
                        typeID = item.ID;
                    }
                }
                foreach (Supplier item in listS)
                {
                    if (String.Compare(item.Name, cbSupplier.SelectedItem.ToString(), false) == 0)
                    {
                        ID = item.ID;
                    }
                }
                int bid = Int32.Parse(txtBID.Text);
                int price = Int32.Parse(txtPrice.Text);
                int amount = Int32.Parse(txtAmount.Text);
                byte[] imgArr = ImageToByteArray(picIMGProduct.Image);
                //SaveIMG(imgArr);
                if (AddProductToDatabase(ID, name, typeID, bid, price, amount, imgArr))
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Thông tin bạn vừa nhập bị sai!!");
            }
            //byte[] imgArr = ImageToByteArray(picIMGProduct.Image);
            
            Clear();
        }
        private bool AddProductToDatabase(int ID, string name, string productTypeID, int bid, int price, int amount, byte[] imgArr)
        {
            return ProductDAO.Instance.AddProduct(ID,name,productTypeID,bid,price,amount,imgArr);
        }

        private void txtBID_Enter(object sender, EventArgs e)
        {
            if(txtBID.Text == "1000")
            {
                txtBID.Clear();
                txtBID.ForeColor = Color.MediumSeaGreen;
            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (txtPrice.Text == "1000")
            {
                txtPrice.Clear();
                txtPrice.ForeColor = Color.MediumSeaGreen;
            }
        }

        private void txtAmount_Enter(object sender, EventArgs e)
        {
            if (txtAmount.Text == "0")
            {
                txtAmount.Clear();
                txtAmount.ForeColor = Color.MediumSeaGreen;
            }
        }

        private void txtBID_Leave(object sender, EventArgs e)
        {
            if(txtBID.TextLength == 0)
            {
                txtBID.Text = "1000";
                txtBID.ForeColor = Color.DarkGray;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (txtPrice.TextLength == 0)
            {
                txtPrice.Text = "1000";
                txtPrice.ForeColor = Color.DarkGray;
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (txtAmount.TextLength == 0)
            {
                txtAmount.Text = "0";
                txtAmount.ForeColor = Color.DarkGray;
            }
        }

        private void picIMGProduct_Click(object sender, EventArgs e)
        {
            SetAddingMode();
        }
        string imageName = "";
        private byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void iconBtnChooseIMG_Click(object sender, EventArgs e)
        {
            
            try {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string imageLocation = dialog.FileName;
                    imageName = Path.GetFileName(imageLocation);
                    
                    //picIMGProduct.ImageLocation = imageLocation;
                    picIMGProduct.Image = new Bitmap(imageLocation);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Có lỗi xảy ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
