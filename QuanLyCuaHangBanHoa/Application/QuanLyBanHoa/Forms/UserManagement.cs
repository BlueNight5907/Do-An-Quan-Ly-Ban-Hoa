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
            int index = e.RowIndex;
            if (index < 0 || index >= dtgvEmployee.RowCount)
            {
                return;
            }
            DataGridViewRow row = dtgvEmployee.Rows[index];
            String manv = Convert.ToString(row.Cells[0].Value);
            String tennv = Convert.ToString(row.Cells[1].Value);
            String ngaysinh = Convert.ToString(row.Cells[2].Value).Trim();
            String gioitinh = "nu";
            if (Convert.ToString(row.Cells[3].Value).Equals("True"))
            {
                gioitinh = "nam";
            }
            String CMND = Convert.ToString(row.Cells[4].Value);
            String sdt = Convert.ToString(row.Cells[5].Value);
            String diachi = Convert.ToString(row.Cells[6].Value);
            String ngayvaolam = Convert.ToString(row.Cells[7].Value);
            String luong = Convert.ToString(row.Cells[8].Value);

            // update UI
            txtEmployeeID.Text = manv;
            txtEmployeeName.Text = tennv;
            txtEmployeeDOB.Text = ngaysinh;
            txtEmployeeGender.Text = gioitinh;
            txtEmployeeCMND.Text = CMND;
            txtEmployeePhone.Text = sdt;
            txtEmployeeAddress.Text = diachi;
            txtEmployeeD.Text = ngayvaolam;
            txtEmployeeSalary.Text = luong;
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = UserManagementDAO.Instance.GetAllUserInfor();
            dtgvEmployee.DataSource = dataTable;

            loadData();
        }

        private void loadData()
        {
            
        }
    }
}
