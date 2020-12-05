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

namespace QuanLyBanHoa.Forms
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            DataTable data = AccountDAO.Instance.LoadAllUser();
            dgvListAccount.DataSource = data;
        }
        private int IDstaff;
        private void dgvListAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dgvListAccount.RowCount)
            {
                return;
            }
            DataGridViewRow row = dgvListAccount.Rows[index];
            IDstaff = Convert.ToInt32(row.Cells[0].Value);
            String staffname = Convert.ToString(row.Cells[1].Value);
            String displayname = Convert.ToString(row.Cells[2].Value);
            String username = Convert.ToString(row.Cells[3].Value);
            String pass = Convert.ToString(row.Cells[4].Value);
            String role = Convert.ToString(row.Cells[5].Value);
            // update UI
            txtID.Text = IDstaff.ToString();
            txtStaffName.Text = staffname;
            txtUsername.Text = username;
            txtDisplayname.Text = displayname;
            txtPass.Text = pass;
            bool chose = false;
            foreach (String rol in cbbRole.Items)
            {
                if (rol.Trim() == role.Trim())
                {
                    
                    cbbRole.SelectedItem = rol;
                    chose = true;
                }
            }
            if (!chose)
            {
                cbbRole.SelectedItem = null;
            }
            if(displayname != "")
            {
                txtUsername.ReadOnly = true;
                txtUsername.BackColor = Color.FromArgb(3, 169, 252);
                txtUsername.ForeColor = Color.White;
            }
            else
            {
                txtUsername.ReadOnly = false;
                txtUsername.BackColor = Color.White;
                txtUsername.ForeColor = Color.Black;
            }
        }
        private bool CheckValid(){
            if (txtStaffName.TextLength == 0)
            {
                return false;
            }
            else if (txtUsername.TextLength < 6)
            {
                return false;
            }
            else if (txtPass.TextLength < 6)
            {
                return false;
            }
            else if (cbbRole.SelectedItem == null)
            {
                return false;
            }
            return true;
        }
        private void Clear()
        {
            txtDisplayname.Clear();
            txtPass.Clear();
            txtStaffName.Clear();
            txtUsername.Clear();
            txtID.Clear();
        }
        private void iconbtnDelete_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (AccountDAO.Instance.DeleteAccount(username) && username != AccountDAO.Instance.AccountInfor().UserName)
            {
                MessageBox.Show("Xóa tài khoản thành công");
                LoadData();
                Clear();
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (CheckValid() && txtUsername.Text.Trim() != AccountDAO.Instance.AccountInfor().UserName)
            {
                string displayname = txtDisplayname.Text;
                string username = txtUsername.Text.Trim();
                string pass = txtPass.Text.Trim();
                string role = cbbRole.SelectedItem.ToString();
                int id = IDstaff;
                if (AccountDAO.Instance.UpdateAccount(username, pass, role, displayname, id))
                {
                    MessageBox.Show("Cập nhật thành công");
                    Clear();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin");
            }
        }
    }
}
