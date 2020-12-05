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

namespace QuanLyBanHoa.Forms
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            Search(DateTime.Now.Month, DateTime.Now.Year);
            txtYear.Text = DateTime.Now.Year.ToString();
        }
        private void Search(int mont,int year)
        {
            DataTable data = CustomerDAO.Instance.GetTopCustomer(mont, year);
            dgvCustomer.DataSource = data;
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(!CheckCondition(txtMonth.Text))
            {
                MessageBox.Show("Thông tin không hợp lệ");
                return;
            }
            else if (!CheckCondition(txtYear.Text))
            {
                MessageBox.Show("Thông tin không hợp lệ");
                return;
            }
            else if( Convert.ToInt32(txtMonth.Text) < 1 && Convert.ToInt32(txtMonth.Text) > 12)
            {
                MessageBox.Show("Thông tin không hợp lệ");
                return;
            }
            else if (Convert.ToInt32(txtYear.Text) < 2000)
            {
                MessageBox.Show("Thông tin không hợp lệ");
                return;
            }
            else
            {
                Search(Convert.ToInt32(txtMonth.Text), Convert.ToInt32(txtYear.Text));
            }
        }
    }
}
