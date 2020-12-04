using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using QuanLyBanHoa.DAO;

namespace QuanLyBanHoa.Forms
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void dtgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = UserManagementDAO.Instance.GetAllUserInfor().Rows("MaNV");
            dtgvEmployee.DataSource = dataTable;
        }
    }
}
