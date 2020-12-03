using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QuanLyBanHoa.Forms;
using QuanLyBanHoa.DAO;
using QuanLyBanHoa.DTO;
namespace QuanLyBanHoa
{
    public partial class MainScreen : Form
    {
        private IconButton currentButton;
        private Panel leftBorderBtn;
        private Form currentChildForm = null;
        
        public MainScreen()
        {
            InitializeComponent();
            CustomizeDesing();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(8,iconbtnCustomers.Height);
            panelMenu.Controls.Add(leftBorderBtn);
            panelline.BackColor = hightlightColor;
            iconbtnUser.Text = AccountDAO.Instance.AccountInfor().DisplayName;
            //form
            //this.Text = String.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void openChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblHome.Text = childForm.Text;
        }
        //Structs
        private struct RGB
        {
            //green
            public static Color color1 = Color.FromArgb(66, 245, 117);
            //red
            public static Color color2 = Color.FromArgb(247, 22, 52);
            //pink
            public static Color color3 = Color.FromArgb(242, 0, 242);
            //lightblue
            public static Color color4 = Color.FromArgb(5, 255, 251);
            //yellow
            public static Color color5 = Color.FromArgb(238, 255, 5);
        }
        public Color hightlightColor = RGB.color1;
        private void activateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                disableButton();
                //Button
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.IconColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleRight;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleCenter;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Top icon
                iconbtnHome.IconChar = currentButton.IconChar;
                iconbtnHome.IconColor = color;
                lblHome.Text = currentButton.Text;
                lblHome.ForeColor = color;
                panelShadow.BackColor = color;
                panelline.BackColor = color;
            }
        }
        private void disableButton()
        {
            if(currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(31, 30, 68);
                currentButton.ForeColor = Color.White;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.White;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                //reset Top icon
                iconbtnHome.IconChar = IconChar.Home;
                iconbtnHome.IconColor = Color.HotPink;
                lblHome.Text = "Home";
                lblHome.ForeColor = Color.Fuchsia;
                panelShadow.BackColor = Color.FromArgb(31, 30, 68);
                panelline.BackColor = Color.Black;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnShowSelling_Click(object sender, EventArgs e)
        {

        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void iconbtnSelling_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            activateButton(sender, hightlightColor);
            openChildForm(new Sell());
            
        }

        private void iconbtnHome_Click(object sender, EventArgs e)
        {
        
     
        }

        private void iconbtnHome_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void iconbtnHome_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(26, 25, 62);
        }

        private void iconbtnProducts_Click(object sender, EventArgs e)
        {
            //activateButton(sender, hightlightColor);
            ChangeSubMenuButtonColor(sender, Color.DeepSkyBlue, panelline1);
            openChildForm(new Products(this));

        }
        private void CustomizeDesing()
        {
            panelsubmenuProduct.Visible = false;
            //............
        }
        private void HideSubMenu()
        {
            if(panelsubmenuProduct.Visible == true)
                panelsubmenuProduct.Visible = false;

        }
        private bool ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                disableSubMenuButton();
                HideSubMenu();
                subMenu.Visible = true;
                return true;
            }
            else
                subMenu.Visible = false;
            return false;

        }
        private void iconbtnCustomers_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            activateButton(sender, hightlightColor);
            openChildForm(new Customers());
            
        }

        private void iconbtnadmin_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            activateButton(sender, hightlightColor);
            openChildForm(new UserManagement());

            

        }

        private void iconbtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconbtnLogout_MouseHover(object sender, EventArgs e)
        {
            iconbtnLogout.ForeColor = hightlightColor;
            iconbtnLogout.IconColor = hightlightColor;
        }

        private void iconbtnLogout_MouseLeave(object sender, EventArgs e)
        {
            iconbtnLogout.ForeColor = Color.White;
            iconbtnLogout.IconColor = Color.White;
            
        }
        
        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void iconbtnSetting_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            activateButton(sender, hightlightColor);
            Setting setting = new Setting(this);
            openChildForm(setting);
            setting.passControl = new Setting.PassControl(changeColor);
        }
        public void changePanelColor(Color color)
        {
            panelline.BackColor = color;
            panelShadow.BackColor = color;
            iconbtnSetting.IconColor = color;
            iconbtnSetting.ForeColor = color;
            leftBorderBtn.BackColor = color;
            iconbtnHome.IconColor = color;
            lblHome.ForeColor = color;
        }
        private void changeColor(object sender)
        {
            hightlightColor = (Color)sender;
        }
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "sendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            disableButton();
            leftBorderBtn.Visible = false;
            currentChildForm.Close();
        }

        private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panelShadow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconbtnMenuProducts_Click(object sender, EventArgs e)
        {
            activateButton(sender, hightlightColor);
            bool show = ShowSubMenu(panelsubmenuProduct);
            if (!show)
            {
                if (currentChildForm != null)
                    currentChildForm.Close();
            }
      
            

            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ChangeSubMenuButtonColor(object senderBtn, Color color, Panel panel)
        {
            if (senderBtn != null)
            {
                disableSubMenuButton();
                //Button
                currentSubMenuButton = (IconButton)senderBtn;
                currentSubMenuButton.BackColor = Color.FromArgb(61, 78, 179);
                currentSubMenuButton.ForeColor = color;
                currentSubMenuButton.IconColor = color;
   
                //Top icon
                iconbtnHome.IconChar = currentSubMenuButton.IconChar;
                iconbtnHome.IconColor = color;
                lblHome.Text = currentSubMenuButton.Text;
                currentPanelline = panel;
                lblHome.ForeColor = hightlightColor;
                currentPanelline.BackColor = color;
            }
        }
        private IconButton currentSubMenuButton;
        private Panel currentPanelline;
        private void disableSubMenuButton()
        {
            if (currentSubMenuButton != null)
            {
                currentSubMenuButton.BackColor = Color.FromArgb(86, 100, 179);
                currentSubMenuButton.ForeColor = Color.White;
                currentSubMenuButton.IconColor = Color.White;
                currentPanelline.BackColor = Color.FromArgb(86, 100, 179);
                //reset Top icon
                
            }
        }

        private void iconbtnImportGoods_Click(object sender, EventArgs e)
        {
            ChangeSubMenuButtonColor(sender, Color.DeepSkyBlue, panelline2);
            openChildForm(new ImportGoods(this));
        }

        private void panelTitlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconbtnUser_MouseHover(object sender, EventArgs e)
        {
            iconbtnUser.ForeColor = hightlightColor;
            iconbtnUser.IconColor = hightlightColor;
        }

        private void iconbtnUser_MouseLeave(object sender, EventArgs e)
        {
            iconbtnUser.ForeColor = Color.White;
            iconbtnUser.IconColor = Color.White;
        }

        private void iconbtnUser_Click(object sender, EventArgs e)
        {
            iconbtnUser.ForeColor = hightlightColor;
            iconbtnUser.IconColor = hightlightColor;
            Form userIfor = new UserInformation();
            userIfor.ShowDialog();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
