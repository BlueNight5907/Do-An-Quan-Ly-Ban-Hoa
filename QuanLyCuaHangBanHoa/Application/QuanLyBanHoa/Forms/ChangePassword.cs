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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void iconbtnAccept_Click(object sender, EventArgs e)
        {
            
            if(txtOldPass.TextLength == 0 || txtConfirmPass.TextLength == 0 || txtNewpass.TextLength == 0)
            {
                MessageBox.Show("Vẫn còn thông tin bị bỏ sót");
            }
            else if(txtNewpass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp với nhau");
            }
            else if (txtNewpass.TextLength < 6)
            {
                MessageBox.Show("Mật khẩu quá ngắn");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn đổi mật khẩu?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (!AccountDAO.Instance.CheckAccount(AccountDAO.Instance.AccountInfor().UserName, txtOldPass.Text))
                    {
                        MessageBox.Show(AccountDAO.Instance.AccountInfor().UserName + "  " + AccountDAO.Instance.AccountInfor().PassWord+ "  " + txtOldPass.Text);
                        MessageBox.Show("Đổi mật khẩu thất bại");
                    }
                    else
                    {
                        int result = AccountDAO.Instance.ChangePassWord(AccountDAO.Instance.AccountInfor().UserName, txtConfirmPass.Text);
                        if(result > 0)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công");
                            this.Close();
                        }
                    }
                }
            }
            
        }

        private void iconbtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
