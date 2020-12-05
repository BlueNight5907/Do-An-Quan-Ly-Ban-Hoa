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
using FontAwesome.Sharp;

namespace QuanLyBanHoa.Forms
{
    public partial class SellProduct : Form
    {
        public SellProduct()
        {
            InitializeComponent();
            LoadProductToFlowPanel(0, "All", "", 0, 0);
            iconbtnSell.Enabled = false;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Text = "Xóa";
            btn.Name = "btn";
            
            btn.UseColumnTextForButtonValue = true;
            int columnIndex = 5;
            if (dgvListProduct.Columns[""] == null)
            {
                dgvListProduct.Columns.Insert(columnIndex, btn);
                dgvListProduct.Columns[5].Width = 70;
            }
            LoadTypeProduct();
        }

        private void cbTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadProductToFlowPanel(int ID, string name, string type, int price1, int price2)
        {

            DataTable data = ProductDAO.Instance.ListProductWithIMG(ID, name, type, price1, price2);
            foreach (DataRow item in data.Rows)
            {
                Image img = null;
                int MaHH = (int)item["Mahh"];
                string TenHH = (string)item["Ten"];
                int GiaBan = (int)item["GiaBan"];
                if (item["IMG"] != System.DBNull.Value)
                    //MessageBox.Show("Ko co hinh");
                    img = ByteArrToImage((byte[])item["IMG"]);
                AddProductToFLowPanel(MaHH, TenHH, img, GiaBan);
            }

        }
        // Chuyển  dữ liệu Byte sang IMG

        private Image ByteArrToImage(byte[] imgArr)
        {
            MemoryStream m = new MemoryStream(imgArr);
            return Image.FromStream(m);
        }
        private void AddProductToFLowPanel(int ID, string name, Image img,int GiaBan)
        {

            Panel panel = new Panel();
            panel.Width = 150;
            panel.Height = 190;
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
            ProductWithIMG product = new ProductWithIMG(ID, name, img , GiaBan);
            //MessageBox.Show(product.ID.ToString());
            btn.Tag = product;
            btn.Click += btn_Click;
            btn.Leave += btn_Leave;
            //panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(btn);
            btn.Dock = DockStyle.Bottom;
            btn.Height = 140;
            Label lbPrice = new Label();
            lbPrice.Text = GiaBan.ToString()+"đ";
            lbPrice.Font = new Font(FontFamily.GenericSansSerif, 12);
            lbPrice.ForeColor = Color.White;
            panel.Controls.Add(lbPrice);
            lbPrice.Dock = DockStyle.Top;
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
            int price = (btn.Tag as ProductWithIMG).Price;
            txtName.Text = productName.ToString();
            txtID.Text = productID.ToString();
            txtPrice.Text = price.ToString();

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
            iconbtnAddProduct.Enabled = true;
        }

        private void txtBID_TextChanged(object sender, EventArgs e)
        {
            txtPrice.ForeColor = Color.Black;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtID.ForeColor = Color.Black;
        }

        private void iconbtnAddProduct_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "ID" && CheckCondition(txtPrice.Text) && CheckCondition(txtID.Text))
            {
                int ID = Int32.Parse(txtID.Text);
                string Name = txtName.Text;
                int Amount = (int)nudAmount.Value;
                int Price = Int32.Parse(txtPrice.Text);
                AddItemToListView(ID, Name, Amount, Price);
                Reset();
                iconbtnAddProduct.Enabled = false;
            }
        }
        private void Reset()
        {
            txtPrice.Text = "Đơn giá";
            txtPrice.ForeColor = Color.Gainsboro;
            txtName.Text = "Tên sản phẩm";
            txtName.ForeColor = Color.Gainsboro;
            nudAmount.Value = 1;

        }
        private int No = 0;
        private int TotalValue = 0;
        private int Pay = 0;
        List<SellItemInfor> ListSellItem = new List<SellItemInfor>();
        private void AddItemToListView(int ID, string Name, int Amount, int Price)
        {
            bool exist = false;
            int money = Amount * Price;
            foreach (SellItemInfor ItemInfor in ListSellItem)
            {
                int IDProduct = ItemInfor.ProductID;
                if(IDProduct == ID)
                {
                    ItemInfor.Amount = Amount + ItemInfor.Amount;
                    int Money = ItemInfor.Amount * Price;
                    ItemInfor.Money = Money;
                    exist = true;
                    break;

                }
            }
            if (!exist)
            {
                SellItemInfor Item = new SellItemInfor(ID, Name, Amount, Price, money);
                ListSellItem.Add(Item);
            }
            TotalValue = TotalValue + money;
            Pay = TotalValue - TotalValue * (int)nudDiscount.Value / 100;
            txtPay.Text = Pay.ToString();
            txtTotalMoney.Text = TotalValue.ToString();
            LoadListView();
        }
        private void LoadListView()
        {
            dgvListProduct.Rows.Clear();
            No = 0;
            foreach(SellItemInfor ItemInfor in ListSellItem)
            {
                No += 1;
                string Name = ItemInfor.Name;
                int Amount = ItemInfor.Amount;
                int money = ItemInfor.Money;
                int Price = ItemInfor.Price;
                dgvListProduct.Rows.Add(No, Name, Amount, Price, money);
                //dgvListProduct.Rows.Add(No, Name, Amount, money, Price, btn);
            }

        }

        private void dgvListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex== 5)
            {
                SellItemInfor item = ListSellItem[e.RowIndex];
                TotalValue = TotalValue - item.Money;
                Pay = TotalValue - TotalValue * (int)nudDiscount.Value / 100;
                txtPay.Text = Pay.ToString();
                txtTotalMoney.Text = TotalValue.ToString();
                ListSellItem.RemoveAt(e.RowIndex);
                LoadListView();
            }
        }
        private void ProceedPayment()
        {
            if (txtTotalMoney.Text != "0")
            {
                int StaffID = AccountDAO.Instance.AccountInfor().ID;
                int totalValue = TotalValue;
                int DiscountMoney = totalValue - Pay;
                string CustomerName = txtCustomerName.Text;
                string CustomerPhone = txtCustomerPhoneNumber.Text;
                int IDCustomer = BillDAO.Instance.AddCustomerInfor(CustomerName, CustomerPhone);
                int IDBill = BillDAO.Instance.AddBillInfor(IDCustomer, StaffID, totalValue, DiscountMoney,Pay);
                ProceedPayment_Detail(IDBill);
            }
        }
        private void ProceedPayment_Detail(int IDBill)
        {
            foreach(SellItemInfor item in ListSellItem)
            {
                int idProduct = item.ProductID;
                int amount = item.Amount;
                int money = item.Money;
                BillDAO.Instance.DetailBill(IDBill, idProduct, amount, money);
            }
        }


        private void iconbtnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if(ListSellItem.Count > 0){
                    ProceedPayment();
                    dgvListProduct.Rows.Clear();
                    Reset();
                    ListSellItem.Clear();
                    txtTotalMoney.Text = "0";
                    txtPay.Text = "0";
                    TotalValue = 0;
                    Pay = 0;
                    No = 0;
                    MessageBox.Show("Thanh toán thành công");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có một sản phẩm đã hết hàng");
            }
        }

        private void iconbtnReset_Click(object sender, EventArgs e)
        {
            flpListProduct.Controls.Clear();
            LoadProductToFlowPanel(0, "All", "", 0, 0);
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            if(txtCustomerName.TextLength == 0 || txtCustomerPhoneNumber.TextLength == 0)
            {
                iconbtnSell.Enabled = false;
            }
            else
            {
                iconbtnSell.Enabled = true;
            }
        }

        private void iconbtnFilter_Click(object sender, EventArgs e)
        {
            flpListProduct.Controls.Clear();
            FindProduct();
        }
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
        private void LoadTypeProduct()
        {
            cbTypeProduct.DataSource = null;
            listP = ProductDAO.Instance.LoadTypeProduct();
            foreach (TypeProduct item in listP)
            {
                cbTypeProduct.Items.Add(item.ProductType);
            }

        }
        List<TypeProduct> listP = new List<TypeProduct>();
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

        private void txtCustomerPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerName.TextLength == 0 || txtCustomerPhoneNumber.TextLength == 0)
            {
                iconbtnSell.Enabled = false;
            }
            else
            {
                iconbtnSell.Enabled = true;
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

        private void sub10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nudDiscount.Value += 5;
        }

        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            Pay = TotalValue - TotalValue * (int)nudDiscount.Value / 100;
            txtPay.Text = Pay.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (nudDiscount.Value - 10 > 0)
                nudDiscount.Value = nudDiscount.Value - 10;
            else
                nudDiscount.Value = 0;
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            txtPrice.Text = "";
        }

        private void tabHistory_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }
        DataTable data = new DataTable();
        private void LoadHistory()
        {
            DateTime time = dtbTime.Value;
            data = BillDAO.Instance.History(time);
            int n = data.Rows.Count;
            dataGridViewHistory.DataSource = data;
            int TotalValueMoney = 0;
            int TotalDiscountMoney = 0;
            int TotalPay = 0;
            for (int i = 1; i <= n; i++)
            {
                dataGridViewHistory.Rows[i - 1].Cells[0].Value = i.ToString();
                TotalValueMoney = TotalValueMoney + Int32.Parse(dataGridViewHistory.Rows[i - 1].Cells[5].Value.ToString());
                TotalDiscountMoney = TotalDiscountMoney + Int32.Parse(dataGridViewHistory.Rows[i - 1].Cells[6].Value.ToString());
                TotalPay = TotalPay + Int32.Parse(dataGridViewHistory.Rows[i - 1].Cells[7].Value.ToString());

            }
            lblMoney.Text = TotalValueMoney.ToString() + "đ";
            lblTotalDiscount.Text = TotalDiscountMoney.ToString() + "đ"; 
            lblTotalPay.Text = TotalPay.ToString() + "đ";
        }
        DataTable data_detail = new DataTable();
        private void Load_DetailHistory()
        {
            DateTime time = dtp_DetailHis.Value;
            data_detail = BillDAO.Instance.DetailHistory(time);
            int n = data_detail.Rows.Count;
            dataGridViewDetailHistory.DataSource = data_detail;
            int TotalValueMoney = 0;
            for (int i = 1; i <= n; i++)
            {
                dataGridViewDetailHistory.Rows[i - 1].Cells[0].Value = i.ToString();
                TotalValueMoney = TotalValueMoney + Int32.Parse(dataGridViewDetailHistory.Rows[i - 1].Cells[6].Value.ToString());

            }
            lblMoneyDetail.Text = TotalValueMoney.ToString() + "đ";
        }

        private void dtbTime_ValueChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void tcImportGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHistory();
            Load_DetailHistory();
        }

        private void dataGridViewHistory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 1; i <= data.Rows.Count; i++)
            {
                dataGridViewHistory.Rows[i - 1].Cells[0].Value = i.ToString();

            }
        }

        private void dataGridViewDetailHistory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 1; i <= data_detail.Rows.Count; i++)
            {
                dataGridViewDetailHistory.Rows[i - 1].Cells[0].Value = i.ToString();

            }
        }

        private void lblTotalDiscount_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPay_Click(object sender, EventArgs e)
        {

        }

        private void tabSellProduct_Click(object sender, EventArgs e)
        {

        }
        private void flpListProduct_Paint(object sender, EventArgs e)
        {

        }
    }
}
