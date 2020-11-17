namespace QuanLyBanHoa.Forms
{
    partial class AddProduct
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
            this.picIMGProduct = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.lblTypeProduct = new System.Windows.Forms.Label();
            this.lblBID = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.iconBtnChooseIMG = new FontAwesome.Sharp.IconButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbTypeProduct = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconBtnClose = new FontAwesome.Sharp.IconButton();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.iconBtnClear = new FontAwesome.Sharp.IconButton();
            this.iconbtnAdd = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.picIMGProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // picIMGProduct
            // 
            this.picIMGProduct.BackColor = System.Drawing.Color.LightGray;
            this.picIMGProduct.Location = new System.Drawing.Point(93, 77);
            this.picIMGProduct.Name = "picIMGProduct";
            this.picIMGProduct.Size = new System.Drawing.Size(272, 192);
            this.picIMGProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIMGProduct.TabIndex = 0;
            this.picIMGProduct.TabStop = false;
            this.picIMGProduct.Tag = "";
            this.picIMGProduct.Click += new System.EventHandler(this.picIMGProduct_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(407, 57);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(132, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Tên sản phẩm";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // lblTypeProduct
            // 
            this.lblTypeProduct.AutoSize = true;
            this.lblTypeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeProduct.Location = new System.Drawing.Point(407, 124);
            this.lblTypeProduct.Name = "lblTypeProduct";
            this.lblTypeProduct.Size = new System.Drawing.Size(133, 24);
            this.lblTypeProduct.TabIndex = 3;
            this.lblTypeProduct.Text = "Loại sản phẩm";
            this.lblTypeProduct.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBID
            // 
            this.lblBID.AutoSize = true;
            this.lblBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBID.Location = new System.Drawing.Point(407, 253);
            this.lblBID.Name = "lblBID";
            this.lblBID.Size = new System.Drawing.Size(86, 24);
            this.lblBID.TabIndex = 5;
            this.lblBID.Text = "Giá nhập";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(407, 315);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(75, 24);
            this.lblprice.TabIndex = 7;
            this.lblprice.Text = "Giá bán";
            // 
            // iconBtnChooseIMG
            // 
            this.iconBtnChooseIMG.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnChooseIMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconBtnChooseIMG.ForeColor = System.Drawing.Color.Black;
            this.iconBtnChooseIMG.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.iconBtnChooseIMG.IconColor = System.Drawing.Color.Crimson;
            this.iconBtnChooseIMG.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnChooseIMG.IconSize = 40;
            this.iconBtnChooseIMG.Location = new System.Drawing.Point(149, 280);
            this.iconBtnChooseIMG.Name = "iconBtnChooseIMG";
            this.iconBtnChooseIMG.Rotation = 0D;
            this.iconBtnChooseIMG.Size = new System.Drawing.Size(156, 40);
            this.iconBtnChooseIMG.TabIndex = 9;
            this.iconBtnChooseIMG.Text = "Chọn ảnh";
            this.iconBtnChooseIMG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnChooseIMG.UseVisualStyleBackColor = true;
            this.iconBtnChooseIMG.Click += new System.EventHandler(this.iconBtnChooseIMG_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(407, 379);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(86, 24);
            this.lblAmount.TabIndex = 17;
            this.lblAmount.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(648, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "đồng";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(648, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "đồng";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtName.Location = new System.Drawing.Point(411, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(378, 26);
            this.txtName.TabIndex = 24;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtBID
            // 
            this.txtBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBID.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBID.Location = new System.Drawing.Point(411, 280);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(231, 26);
            this.txtBID.TabIndex = 26;
            this.txtBID.Text = "1000";
            this.txtBID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBID.TextChanged += new System.EventHandler(this.txtBID_TextChanged);
            this.txtBID.Enter += new System.EventHandler(this.txtBID_Enter);
            this.txtBID.Leave += new System.EventHandler(this.txtBID_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPrice.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPrice.Location = new System.Drawing.Point(411, 350);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(231, 26);
            this.txtPrice.TabIndex = 27;
            this.txtPrice.Text = "1000";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAmount.ForeColor = System.Drawing.Color.DarkGray;
            this.txtAmount.Location = new System.Drawing.Point(411, 406);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(231, 26);
            this.txtAmount.TabIndex = 28;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.Enter += new System.EventHandler(this.txtAmount_Enter);
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // cbTypeProduct
            // 
            this.cbTypeProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTypeProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTypeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTypeProduct.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cbTypeProduct.FormattingEnabled = true;
            this.cbTypeProduct.Location = new System.Drawing.Point(411, 151);
            this.cbTypeProduct.Name = "cbTypeProduct";
            this.cbTypeProduct.Size = new System.Drawing.Size(249, 28);
            this.cbTypeProduct.TabIndex = 29;
            this.cbTypeProduct.SelectedIndexChanged += new System.EventHandler(this.cbTypeProduct_SelectedIndexChanged);
            this.cbTypeProduct.TextChanged += new System.EventHandler(this.cbTypeProduct_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Location = new System.Drawing.Point(17, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 10);
            this.panel1.TabIndex = 23;
            // 
            // iconBtnClose
            // 
            this.iconBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnClose.BackColor = System.Drawing.SystemColors.Control;
            this.iconBtnClose.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.iconBtnClose.FlatAppearance.BorderSize = 0;
            this.iconBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnClose.ForeColor = System.Drawing.Color.MintCream;
            this.iconBtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconBtnClose.IconColor = System.Drawing.Color.Maroon;
            this.iconBtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnClose.IconSize = 45;
            this.iconBtnClose.Location = new System.Drawing.Point(890, 18);
            this.iconBtnClose.Name = "iconBtnClose";
            this.iconBtnClose.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconBtnClose.Rotation = 0D;
            this.iconBtnClose.Size = new System.Drawing.Size(43, 35);
            this.iconBtnClose.TabIndex = 21;
            this.iconBtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnClose.UseVisualStyleBackColor = false;
            this.iconBtnClose.Click += new System.EventHandler(this.iconBtnClose_Click);
            // 
            // cbSupplier
            // 
            this.cbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbSupplier.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(410, 216);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(250, 28);
            this.cbSupplier.TabIndex = 31;
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(406, 190);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(129, 24);
            this.lblSupplier.TabIndex = 30;
            this.lblSupplier.Text = "Nhà cung cấp";
            // 
            // iconBtnClear
            // 
            this.iconBtnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnClear.IconChar = FontAwesome.Sharp.IconChar.Cannabis;
            this.iconBtnClear.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconBtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnClear.IconSize = 40;
            this.iconBtnClear.Location = new System.Drawing.Point(379, 451);
            this.iconBtnClear.Name = "iconBtnClear";
            this.iconBtnClear.Rotation = 0D;
            this.iconBtnClear.Size = new System.Drawing.Size(213, 51);
            this.iconBtnClear.TabIndex = 32;
            this.iconBtnClear.Text = "Clear";
            this.iconBtnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnClear.UseVisualStyleBackColor = true;
            this.iconBtnClear.Click += new System.EventHandler(this.iconBtnClear_Click);
            // 
            // iconbtnAdd
            // 
            this.iconbtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconbtnAdd.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconbtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnAdd.IconSize = 40;
            this.iconbtnAdd.Location = new System.Drawing.Point(621, 451);
            this.iconbtnAdd.Name = "iconbtnAdd";
            this.iconbtnAdd.Rotation = 0D;
            this.iconbtnAdd.Size = new System.Drawing.Size(242, 51);
            this.iconbtnAdd.TabIndex = 33;
            this.iconbtnAdd.Text = "Thêm sản phẩm";
            this.iconbtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnAdd.UseVisualStyleBackColor = true;
            this.iconbtnAdd.Click += new System.EventHandler(this.iconbtnAdd_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(951, 539);
            this.ControlBox = false;
            this.Controls.Add(this.iconbtnAdd);
            this.Controls.Add(this.iconBtnClear);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbTypeProduct);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtBID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.iconBtnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.iconBtnChooseIMG);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblBID);
            this.Controls.Add(this.lblTypeProduct);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.picIMGProduct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddProduct";
            this.Text = "Thêm sản phẩm";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIMGProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIMGProduct;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lblTypeProduct;
        private System.Windows.Forms.Label lblBID;
        private System.Windows.Forms.Label lblprice;
        private FontAwesome.Sharp.IconButton iconBtnChooseIMG;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cbTypeProduct;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconBtnClose;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private FontAwesome.Sharp.IconButton iconBtnClear;
        private FontAwesome.Sharp.IconButton iconbtnAdd;
    }
}