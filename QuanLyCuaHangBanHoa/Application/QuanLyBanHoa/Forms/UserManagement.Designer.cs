namespace QuanLyBanHoa.Forms
{
    partial class UserManagement
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
            this.dtgvEmployee = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeDOB = new System.Windows.Forms.TextBox();
            this.txtEmployeeCMND = new System.Windows.Forms.TextBox();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CMND = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
            this.txtEmployeeD = new System.Windows.Forms.TextBox();
            this.txtEmployeeGender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvEmployee
            // 
            this.dtgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dtgvEmployee.Name = "dtgvEmployee";
            this.dtgvEmployee.ReadOnly = true;
            this.dtgvEmployee.RowHeadersWidth = 51;
            this.dtgvEmployee.RowTemplate.Height = 24;
            this.dtgvEmployee.Size = new System.Drawing.Size(1032, 782);
            this.dtgvEmployee.TabIndex = 0;
            this.dtgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEmployee_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1240, 407);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 35);
            this.button4.TabIndex = 44;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1351, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 35);
            this.button3.TabIndex = 43;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1115, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 41;
            this.button1.Text = "Thêm ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(1240, 49);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(219, 22);
            this.txtEmployeeName.TabIndex = 36;
            // 
            // txtEmployeeDOB
            // 
            this.txtEmployeeDOB.Location = new System.Drawing.Point(1240, 86);
            this.txtEmployeeDOB.Name = "txtEmployeeDOB";
            this.txtEmployeeDOB.Size = new System.Drawing.Size(219, 22);
            this.txtEmployeeDOB.TabIndex = 35;
            // 
            // txtEmployeeCMND
            // 
            this.txtEmployeeCMND.Location = new System.Drawing.Point(1240, 166);
            this.txtEmployeeCMND.Name = "txtEmployeeCMND";
            this.txtEmployeeCMND.Size = new System.Drawing.Size(219, 22);
            this.txtEmployeeCMND.TabIndex = 34;
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.Location = new System.Drawing.Point(1240, 204);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(219, 22);
            this.txtEmployeePhone.TabIndex = 33;
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Location = new System.Drawing.Point(1240, 242);
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(219, 22);
            this.txtEmployeeAddress.TabIndex = 32;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(1240, 12);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(219, 22);
            this.txtEmployeeID.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1068, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Địa chỉ";
            // 
            // CMND
            // 
            this.CMND.AutoSize = true;
            this.CMND.Location = new System.Drawing.Point(1068, 166);
            this.CMND.Name = "CMND";
            this.CMND.Size = new System.Drawing.Size(48, 17);
            this.CMND.TabIndex = 29;
            this.CMND.Text = "CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1068, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1068, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1068, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1068, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1068, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1068, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Ngày vào làm";
            // 
            // txtEmployeeSalary
            // 
            this.txtEmployeeSalary.Location = new System.Drawing.Point(1240, 324);
            this.txtEmployeeSalary.Name = "txtEmployeeSalary";
            this.txtEmployeeSalary.Size = new System.Drawing.Size(219, 22);
            this.txtEmployeeSalary.TabIndex = 39;
            // 
            // txtEmployeeD
            // 
            this.txtEmployeeD.Location = new System.Drawing.Point(1240, 286);
            this.txtEmployeeD.Name = "txtEmployeeD";
            this.txtEmployeeD.Size = new System.Drawing.Size(219, 22);
            this.txtEmployeeD.TabIndex = 40;
            // 
            // txtEmployeeGender
            // 
            this.txtEmployeeGender.Location = new System.Drawing.Point(1240, 127);
            this.txtEmployeeGender.Name = "txtEmployeeGender";
            this.txtEmployeeGender.Size = new System.Drawing.Size(219, 22);
            this.txtEmployeeGender.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1068, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Giới tính";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 821);
            this.ControlBox = false;
            this.Controls.Add(this.txtEmployeeGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEmployeeD);
            this.Controls.Add(this.txtEmployeeSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeDOB);
            this.Controls.Add(this.txtEmployeeCMND);
            this.Controls.Add(this.txtEmployeePhone);
            this.Controls.Add(this.txtEmployeeAddress);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CMND);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvEmployee;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeDOB;
        private System.Windows.Forms.TextBox txtEmployeeCMND;
        private System.Windows.Forms.TextBox txtEmployeePhone;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeSalary;
        private System.Windows.Forms.TextBox txtEmployeeD;
        private System.Windows.Forms.TextBox txtEmployeeGender;
        private System.Windows.Forms.Label label3;
    }
}