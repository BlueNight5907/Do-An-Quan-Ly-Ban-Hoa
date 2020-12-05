namespace QuanLyBanHoa.Forms
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iconbtnReturn = new FontAwesome.Sharp.IconButton();
            this.iconbtnAccept = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtOldPass
            // 
            this.txtOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.Location = new System.Drawing.Point(227, 33);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(354, 29);
            this.txtOldPass.TabIndex = 5;
            this.txtOldPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập mật  khẩu cũ";
            // 
            // txtNewpass
            // 
            this.txtNewpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewpass.Location = new System.Drawing.Point(227, 76);
            this.txtNewpass.Name = "txtNewpass";
            this.txtNewpass.Size = new System.Drawing.Size(354, 29);
            this.txtNewpass.TabIndex = 7;
            this.txtNewpass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập mật khẩu mới";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(227, 124);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(354, 29);
            this.txtConfirmPass.TabIndex = 9;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Xác nhận mật khẩu mới";
            // 
            // iconbtnReturn
            // 
            this.iconbtnReturn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconbtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconbtnReturn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnReturn.ForeColor = System.Drawing.Color.White;
            this.iconbtnReturn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnReturn.IconColor = System.Drawing.Color.Black;
            this.iconbtnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnReturn.IconSize = 48;
            this.iconbtnReturn.Location = new System.Drawing.Point(227, 182);
            this.iconbtnReturn.Name = "iconbtnReturn";
            this.iconbtnReturn.Rotation = 0D;
            this.iconbtnReturn.Size = new System.Drawing.Size(146, 38);
            this.iconbtnReturn.TabIndex = 10;
            this.iconbtnReturn.Text = "Quay lại";
            this.iconbtnReturn.UseVisualStyleBackColor = false;
            this.iconbtnReturn.Click += new System.EventHandler(this.iconbtnReturn_Click);
            // 
            // iconbtnAccept
            // 
            this.iconbtnAccept.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconbtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconbtnAccept.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnAccept.ForeColor = System.Drawing.Color.MistyRose;
            this.iconbtnAccept.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnAccept.IconColor = System.Drawing.Color.Black;
            this.iconbtnAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnAccept.IconSize = 48;
            this.iconbtnAccept.Location = new System.Drawing.Point(379, 182);
            this.iconbtnAccept.Name = "iconbtnAccept";
            this.iconbtnAccept.Rotation = 0D;
            this.iconbtnAccept.Size = new System.Drawing.Size(202, 38);
            this.iconbtnAccept.TabIndex = 11;
            this.iconbtnAccept.Text = "Đổi mật khẩu";
            this.iconbtnAccept.UseVisualStyleBackColor = false;
            this.iconbtnAccept.Click += new System.EventHandler(this.iconbtnAccept_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 232);
            this.Controls.Add(this.iconbtnAccept);
            this.Controls.Add(this.iconbtnReturn);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangePassword";
            this.Text = "Thay đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconbtnReturn;
        private FontAwesome.Sharp.IconButton iconbtnAccept;
    }
}