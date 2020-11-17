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
    public partial class ImportGoods : Form
    {
        private MainScreen main = null;
        public ImportGoods(Form callingForm)
        {
            main = callingForm as MainScreen;
            InitializeComponent();
            ChangeIconColor(main.hightlightColor);
            LoadData();

        }
        private void ChangeIconColor(Color color)
        {
            iconbtnAddProduct.IconColor = color;
            iconbtnImport.IconColor = color;
            iconbtnFilter.IconColor = color;
            iconbtnReset.IconColor = color;
            iconbtnAddProduct.ForeColor = Color.FromArgb(39, 100, 242);
            iconbtnImport.ForeColor = Color.FromArgb(39, 100, 242);
            
        }
        List<TypeProduct> listP = new List<TypeProduct>();
        List<Supplier> listS = new List<Supplier>();
        List<(int, int)> ListPrice = new List<(int, int)>();
        private void FindProduct()
        {
            int idProduct;
            if (CheckCondition(txtProductID.Text))
            {
                idProduct = int.Parse(txtProductID.Text);
            }
            else
                idProduct = 0;
            string name = txtProductName.Text;
            string typeproductID = "";
            if (cbTypeProduct.SelectedItem != null)
            {
                var index = listP.FindIndex(x => x.ProductType == cbTypeProduct.SelectedItem.ToString());
                typeproductID = listP[index].ID;
            } 
            
            LoadProductToFlowPanel(idProduct, name, typeproductID, 0, 0);
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
        private void LoadData()
        {
            cbTypeProduct.DataSource = null;
            listP = ProductDAO.Instance.LoadTypeProduct();
            foreach (TypeProduct item in listP)
            {
                cbTypeProduct.Items.Add(item.ProductType);
            }
            
            listS = ProductDAO.Instance.LoadSupplier();
            foreach (Supplier item in listS)
            {
                cbSupplier.Items.Add(item.Name);
            }
            cbSupplier.SelectedIndex = 0;
            for (int i = 2; i < 1000; i++)
            {
                string Price = "Từ " + ChangeValue((i)) + " đến " + ChangeValue(2 * (i));
                if (i > 1000)
                    i = 1000;
                ListPrice.Add(((i-1) * 1000, 2 * (i) * 1000));
                cbPrice.Items.Add(Price);
                if (i<1000)
                    i = 2*i-1;
            }
            string price = "Trên 1 triệu";
            ListPrice.Add((1001000,1000000000));
            cbPrice.Items.Add(price);
            flpListProduct.AutoScroll = false;
            flpListProduct.HorizontalScroll.Enabled = false;
            flpListProduct.HorizontalScroll.Visible = false;
            flpListProduct.HorizontalScroll.Maximum = 0;
            flpListProduct.AutoScroll = true;
            iconbtnAddProduct.Enabled = false;

        }
        //Làm mới toàn bộ thông tin
        private void Reset()
        {
            txtBID.Text = "Giá nhập";
            txtBID.ForeColor = Color.Gainsboro;
            txtName.Text = "Tên sản phẩm";
            txtName.ForeColor = Color.Gainsboro;
            nudAmount.Value = 1;
            
        }
        private void Clear()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            cbTypeProduct.SelectedItem = null;
            cbPrice.SelectedItem = null;
            flpListProduct.Controls.Clear();
        }
        private string ChangeValue(int i)
        {
            if(i * 1000 > 1000000)
                return (i/1000)+" triệu";
            return i + "k";

        }
        // Chuyển  dữ liệu Byte sang IMG

        private Image ByteArrToImage(byte[] imgArr)
        {
            MemoryStream m = new MemoryStream(imgArr);
            return Image.FromStream(m);
        }

        private void tabHistory_Click(object sender, EventArgs e)
        {

        }

        private void flpListProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFilter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbPrice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flpListProduct_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void listViewProducts_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        
        private void txtBID_TextChanged(object sender, EventArgs e)
        {
            if (CheckCondition(txtBID.Text)&&(txtName.Text != "Tên sản phẩm"))
            {
                iconbtnAddProduct.Enabled = true;
            }
            else
            {
                iconbtnAddProduct.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nudAmount.Value = nudAmount.Value + 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nudAmount.Value - 10 > 0)
                nudAmount.Value = nudAmount.Value - 10;
            else
                nudAmount.Value = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nudAmount.Value = nudAmount.Value + 100;
        }

        private void btnS100_Click(object sender, EventArgs e)
        {
            if (nudAmount.Value - 100 > 0)
                nudAmount.Value = nudAmount.Value - 100;
            else
                nudAmount.Value = 1;
        }
        private int No = 0;
        int TotalValue = 0;
        List<ImportGoodsInfor> ListImportGood = new List<ImportGoodsInfor>();
        private void AddItemToListView(int ID, string Name,int Amount, int BID)
        {
            No = No + 1;
            ListViewItem lsvItem = new ListViewItem(No.ToString());
            lsvItem.SubItems.Add(Name.ToString());
            lsvItem.SubItems.Add(Amount.ToString());
            int money = Amount * BID;
            lsvItem.SubItems.Add(money.ToString());
            lsvItem.SubItems.Add(BID.ToString());
            listVProduct.Items.Add(lsvItem);
            TotalValue = TotalValue + money;
            ImportGoodsInfor ItemInfor = new ImportGoodsInfor(ID, Name, Amount, BID, money);
            ListImportGood.Add(ItemInfor);
            
            
            txtTotalMoney.Text = TotalValue.ToString();
        }
        private void iconbtnAddProduct_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(txtID.Text);
            string Name = txtName.Text;
            int Amount = (int)nudAmount.Value;
            int BID = Int32.Parse(txtBID.Text);
            AddItemToListView(ID, Name, Amount, BID);
            Reset();
            iconbtnAddProduct.Enabled = false;
        }

        private void cbTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Clear();
            LoadProductToFlowPanel(0,"All","",0,0);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            flpListProduct.Controls.Clear();
            FindProduct();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBID_Enter(object sender, EventArgs e)
        {
            if (txtBID.Text == "Giá nhập")
            {
                txtBID.Clear();
                txtBID.ForeColor = Color.Black;
            }
        }

        private void txtBID_Leave(object sender, EventArgs e)
        {
            if (txtBID.Text =="")
            {
                txtBID.Text ="Giá nhập";
                txtBID.ForeColor = Color.Gainsboro;
            }
        }

        private void nudAmount_Enter(object sender, EventArgs e)
        {

        }

        private void flpListProduct_Paint_2(object sender, PaintEventArgs e)
        {

        }
        private void LoadProductToFlowPanel(int ID, string name, string type,int price1, int price2)
        {

            DataTable data = ProductDAO.Instance.ListProductWithIMG(ID, name, type, price1,price2);
            Image img = null;
            foreach (DataRow item in data.Rows)
            {
                int MaHH = (int)item["Mahh"];
                string TenHH = (string)item["Ten"];
                if (item["IMG"] != System.DBNull.Value)
                    //MessageBox.Show("Ko co hinh");
                    img = ByteArrToImage((byte[])item["IMG"]);
                AddProductToFLowPanel(MaHH,TenHH,img);
            }
           
        }
        private void AddProductToFLowPanel(int ID, string name,Image img)
        {
            
            Panel panel = new Panel();
            panel.Width = 170;
            panel.Height = 200;
            panel.Margin = new Padding(6);
            panel.BackColor = Color.FromArgb(31, 30, 68);
            Button btn = new Button();
            if (img != null)
            {
                btn.BackgroundImage = img;

            }
            else
            {
                btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\HoaSen.jpg");
            }
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            ProductWithIMG product = new ProductWithIMG(ID, name, img);
            //MessageBox.Show(product.ID.ToString());
            btn.Tag = product;
            btn.Click += btn_Click;
            btn.Leave += btn_Leave;
            //panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(btn);
            btn.Dock = DockStyle.Bottom;
            btn.Height = 170;
            Label lb = new Label();
            lb.Text = name;
            lb.Font = new Font(FontFamily.GenericSansSerif, 12);
            lb.ForeColor = Color.White;

            panel.Controls.Add(lb);
            lb.Dock = DockStyle.Top;
            flpListProduct.Controls.Add(panel);
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            btn.FlatAppearance.BorderSize = 4;
            int productID = (btn.Tag as ProductWithIMG).ID;
            string productName = (btn.Tag as ProductWithIMG).Name;
            txtName.Text = productName.ToString();
            txtID.Text = productID.ToString();

        }
        void btn_Leave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            btn.FlatAppearance.BorderSize = 1;
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.ForeColor = Color.Black;
        }
        private void ImportGood()
        { 
            if(txtTotalMoney.Text != "0")
            {
                int ID = AccountDAO.Instance.AccountInfor().ID;
                int totalValue = Int32.Parse(txtTotalMoney.Text);
                var index = listS.FindIndex(x => x.Name == cbSupplier.SelectedItem.ToString());
                int IDSupplier = listS[index].ID;
                int importID = ImportGoodDAO.Instance.Import(ID, IDSupplier, totalValue);
                ImportGoodDetail(importID);
            }
        }
        private void ImportGoodDetail(int importID) {
            foreach(ImportGoodsInfor item in ListImportGood)
            {
                int ProductID = item.ProductID;
                int BID = item.BID;
                int Amount = item.Amount;
                int Money = item.Money;
                ImportGoodDAO.Instance.DetailImport(importID,ProductID,BID,Amount,Money);
            }
        }
        private void iconbtnImport_Click(object sender, EventArgs e)
        {
            ImportGood();
            cbSupplier.SelectedIndex = 0;
            ListImportGood.Clear();
            txtTotalMoney.Text = "0";
            No = 0;
            TotalValue = 0;
            listVProduct.Items.Clear();
        }

        private void listVProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtID.ForeColor = Color.Black;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listVProduct_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

       
        DataTable data = new DataTable();
        private void LoadHistory()
        {
            DateTime time = dtbTime.Value;
            data = ImportGoodDAO.Instance.DetailHistory(time);
            int n = data.Rows.Count;
            
            dataGridViewHistory.DataSource = data;
            int TotalValue = 0;
            for (int i = 1; i <= n; i++)
            {
                dataGridViewHistory.Rows[i - 1].Cells[0].Value = i.ToString();
                TotalValue =TotalValue + Int32.Parse(dataGridViewHistory.Rows[i - 1].Cells[6].Value.ToString());
                
            }
            lblMoney.Text = TotalValue.ToString() + "đ";
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void tcImportGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void dataGridViewHistory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 1; i <= data.Rows.Count; i++)
            {
                dataGridViewHistory.Rows[i - 1].Cells[0].Value = i.ToString();

            }
        }
    }
}
