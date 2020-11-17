using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHoa.Forms
{
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
            Loaddata();
        }

        private void Sell_Load(object sender, EventArgs e)

        {

        }
        private void Loaddata()
        {
            Panel panel = new Panel();
            
            panel.Width = 150;
            panel.Height = 170;
            panel.BackColor = Color.FromArgb(31, 30, 68);
            Button btn = new Button();
            btn.BackgroundImage = pictureBox.Image;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(5, 255, 251);
            btn.FlatAppearance.BorderSize = 2;
            
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(btn);
            btn.Dock = DockStyle.Bottom;
            btn.Height = 140;
            Label lb = new Label();
            lb.Text = "Hoa Lan Nhu Y";
            lb.Font = new Font(FontFamily.GenericSansSerif, 15);
            lb.ForeColor = Color.White;
            lb.Margin = new Padding(3,3,3,10);
            
            panel.Controls.Add(lb);
            lb.Dock = DockStyle.Top;
            panelMain.Controls.Add(panel);

        }
    }
}
