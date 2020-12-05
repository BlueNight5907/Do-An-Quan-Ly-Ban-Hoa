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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
            SetEditingMode(false);
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadListStaff();

        }
        private void LoadListStaff()
        {
            DataTable data = StaffDAO.Instance.LoadAllStaff();
            dgvListStaff.DataSource = data;
        }

        private void dgvListStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iconbtnAdd.Enabled = false;
            SetEditingMode(true);
            int index = e.RowIndex;
            if (index < 0 || index >= dgvListStaff.RowCount)
            {
                return;
            }
            DataGridViewRow row = dgvListStaff.Rows[index];
            String staffname = Convert.ToString(row.Cells[1].Value);
            DateTime birthday = Convert.ToDateTime(row.Cells[2].Value);
            bool gender = Convert.ToBoolean(row.Cells[3].Value);
            String cmnd = Convert.ToString(row.Cells[4].Value);
            String phonenumber = Convert.ToString(row.Cells[5].Value);
            String address = Convert.ToString(row.Cells[6].Value);
            DateTime daystart = Convert.ToDateTime(row.Cells[7].Value);
            int salary = Convert.ToInt32(row.Cells[8].Value);
            String position = Convert.ToString(row.Cells[9].Value);
            // update UI
            txtStaffName.Text = staffname;
            dtpBirth.Value = birthday;
            if(gender == true)
            {
                cbFemale.Checked = true;
            }
            else
            {
                cbMale.Checked = true;
            }
            txtCMND.Text = cmnd;
            txtPhoneNumber.Text = phonenumber;
            txtAddress.Text = address;
            dtpDateStart.Value = daystart;
            txtSalary.Text = salary.ToString() ;
            foreach(String pos in cbbPosition.Items)
            {
                if(pos == position)
                {
                    cbbPosition.SelectedItem = pos;
                }
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            LoadListStaff();
        }

        private void cbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if(cbFemale.Checked == true)
            {
                cbMale.Checked = false;
            }
        }
        private void SetEditingMode(bool enable)
        {
            if (!enable)
            {
                dgvListStaff.ClearSelection();
            }
            iconbtnDelete.Enabled = enable;
            iconbtnUpdate.Enabled = enable;
            iconbtnCreateAccount.Enabled = enable;
        }

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMale.Checked== true)
            {
                cbFemale.Checked = false;
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            iconbtnAdd.Enabled = true;
            SetEditingMode(false);
            txtAddress.Clear();
            txtCMND.Clear();
            txtSalary.Clear();
            txtPhoneNumber.Clear();
            txtStaffName.Clear();
            dtpBirth.Value = DateTime.Now;
            dtpDateStart.Value = DateTime.Now;
            cbbPosition.SelectedItem = null;
            cbFemale.Checked = false;
            cbMale.Checked = false;
        }
        private bool isNum(string a)
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
        private bool CheckValid()
        {
            if(txtAddress.TextLength == 0)
            {
                return false;
            }
            else if (txtStaffName.TextLength == 0)
            {
                return false;
            }
            else if (txtSalary.TextLength == 0)
            {
                return false;
            }
            else if (!isNum(txtSalary.Text))
            {
                return false;
            }
            else if (!isNum(txtPhoneNumber.Text))
            {
                return false;
            }
            else if (!isNum(txtCMND.Text))
            {
                return false;
            }
            else if (cbFemale.Checked == false && cbMale.Checked == false)
            {
                return false;
            }
            else if (cbbPosition.SelectedItem == null)
            {
                return false;
            }
            return true;
        }

        private void iconbtnAdd_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                string staffname = txtStaffName.Text;
                DateTime birthday = dtpBirth.Value;
                bool gender = cbFemale.Checked;
                string cmnd = txtCMND.Text;
                string sdt = txtPhoneNumber.Text;
                string address = txtAddress.Text;
                DateTime daystart = dtpDateStart.Value;
                int salary = Convert.ToInt32(txtSalary.Text);
                string positon = cbbPosition.SelectedItem.ToString();
                try
                {
                    if (StaffDAO.Instance.AddStaff(staffname, birthday, gender, cmnd, sdt, address, daystart, salary, positon))
                    {
                        MessageBox.Show("Thêm nhân viên thành công");
                        Clear();
                        LoadListStaff();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ hoặc thông tin không hợp lệ");
            }
        }
    }
}
