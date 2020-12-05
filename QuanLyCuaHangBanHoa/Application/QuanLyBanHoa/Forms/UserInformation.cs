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
    public partial class UserInformation : Form
    {
        public UserInformation()
        {
            InitializeComponent();
        }
        private Account account = AccountDAO.Instance.AccountInfor();
        private bool current_gender = true;
        private void UserInformation_Load(object sender, EventArgs e)
        {
            txtName.Text = account.Name;
            txtDisplayName.Text = account.DisplayName;
            txtCMND.Text = account.CMND;
            txtPhoneNumber.Text = account.SDT;
            txtPermission.Text = account.Permission;
            current_gender = account.Sex;
            if(account.Sex == true)
            {
                cbFemale.Checked=true;
            }
            else
            {
                cbMale.Checked = true;
            }
            txtAddress.Text = account.Address;
            txtUsername.Text = account.UserName;
            txtBirth.Text = account.BirthDay.ToShortDateString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbFemale_CheckedChanged(object sender, EventArgs e)
        {
            cbFemale.Checked = current_gender;
        }

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
            cbMale.Checked = !current_gender;
        }

        private void iconbtnChangePassword_Click(object sender, EventArgs e)
        {
            Form changepass = new ChangePassword();
            changepass.ShowDialog();
        }
    }
}
