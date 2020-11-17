namespace QuanLyBanHoa
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.dataGridViewListProduct = new System.Windows.Forms.DataGridView();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelListProduct = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.iconBtnSearch = new FontAwesome.Sharp.IconButton();
            this.txtIDProduct = new System.Windows.Forms.TextBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.iconbtnClear = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.iconbtnReset = new FontAwesome.Sharp.IconButton();
            this.iconbtnUpdate = new FontAwesome.Sharp.IconButton();
            this.iconbtnAdd = new FontAwesome.Sharp.IconButton();
            this.iconbtnDelete = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblBid = new System.Windows.Forms.Label();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.labelmoney1 = new System.Windows.Forms.Label();
            this.labelmoney2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMaHH = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblIDType = new System.Windows.Forms.Label();
            this.txtIDType = new System.Windows.Forms.TextBox();
            this.labelTypeProductName = new System.Windows.Forms.Label();
            this.txtTypeProductName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProduct)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListProduct
            // 
            this.dataGridViewListProduct.AllowDrop = true;
            this.dataGridViewListProduct.AllowUserToAddRows = false;
            this.dataGridViewListProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewListProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewListProduct.ColumnHeadersHeight = 40;
            this.dataGridViewListProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHH,
            this.TenHH,
            this.MaLoai,
            this.TenLoai,
            this.GiaNhap,
            this.GiaBan,
            this.Soluong});
            this.dataGridViewListProduct.Location = new System.Drawing.Point(3, 164);
            this.dataGridViewListProduct.MaximumSize = new System.Drawing.Size(800, 1200);
            this.dataGridViewListProduct.Name = "dataGridViewListProduct";
            this.dataGridViewListProduct.ReadOnly = true;
            this.dataGridViewListProduct.RowHeadersWidth = 51;
            this.dataGridViewListProduct.RowTemplate.Height = 70;
            this.dataGridViewListProduct.RowTemplate.ReadOnly = true;
            this.dataGridViewListProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListProduct.Size = new System.Drawing.Size(550, 464);
            this.dataGridViewListProduct.TabIndex = 15;
            this.dataGridViewListProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListProduct_CellClick);
            this.dataGridViewListProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListProduct_CellContentClick);
            this.dataGridViewListProduct.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewListProduct_CellPainting_1);
            // 
            // MaHH
            // 
            this.MaHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaHH.DataPropertyName = "MaHH";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MaHH.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaHH.HeaderText = "Mã HH";
            this.MaHH.MinimumWidth = 6;
            this.MaHH.Name = "MaHH";
            this.MaHH.ReadOnly = true;
            this.MaHH.Width = 61;
            // 
            // TenHH
            // 
            this.TenHH.DataPropertyName = "Ten";
            this.TenHH.HeaderText = "Tên HH";
            this.TenHH.MinimumWidth = 6;
            this.TenHH.Name = "TenHH";
            this.TenHH.ReadOnly = true;
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã Loại";
            this.MaLoai.MinimumWidth = 6;
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.HeaderText = "TenLoai";
            this.TenLoai.MinimumWidth = 6;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá Nhập";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "SoLuong";
            this.Soluong.HeaderText = "Số Lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(3, 124);
            this.panel1.MaximumSize = new System.Drawing.Size(800, 10);
            this.panel1.MinimumSize = new System.Drawing.Size(564, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 10);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(3, 32);
            this.panel2.MaximumSize = new System.Drawing.Size(800, 10);
            this.panel2.MinimumSize = new System.Drawing.Size(565, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 10);
            this.panel2.TabIndex = 5;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(8, 5);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(196, 24);
            this.labelSearch.TabIndex = 6;
            this.labelSearch.Text = "TRA CỨU SẢN PHẨM";
            // 
            // labelListProduct
            // 
            this.labelListProduct.AutoSize = true;
            this.labelListProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListProduct.Location = new System.Drawing.Point(8, 137);
            this.labelListProduct.Name = "labelListProduct";
            this.labelListProduct.Size = new System.Drawing.Size(215, 24);
            this.labelListProduct.TabIndex = 7;
            this.labelListProduct.Text = "DANH MỤC SẢN PHẨM";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.AllowDrop = true;
            this.txtNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProduct.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNameProduct.Location = new System.Drawing.Point(9, 86);
            this.txtNameProduct.MaximumSize = new System.Drawing.Size(550, 30);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(299, 26);
            this.txtNameProduct.TabIndex = 1;
            this.txtNameProduct.Text = "Tên sản phẩm";
            this.txtNameProduct.TextChanged += new System.EventHandler(this.txtNameProduct_TextChanged);
            this.txtNameProduct.Enter += new System.EventHandler(this.txtNameProduct_Enter);
            this.txtNameProduct.Leave += new System.EventHandler(this.txtNameProduct_Leave);
            // 
            // iconBtnSearch
            // 
            this.iconBtnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconBtnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconBtnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconBtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBtnSearch.IconColor = System.Drawing.Color.Black;
            this.iconBtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSearch.IconSize = 30;
            this.iconBtnSearch.Location = new System.Drawing.Point(314, 51);
            this.iconBtnSearch.MaximumSize = new System.Drawing.Size(155, 75);
            this.iconBtnSearch.Name = "iconBtnSearch";
            this.iconBtnSearch.Rotation = 0D;
            this.iconBtnSearch.Size = new System.Drawing.Size(112, 61);
            this.iconBtnSearch.TabIndex = 2;
            this.iconBtnSearch.Text = "Tìm Kiếm";
            this.iconBtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSearch.UseVisualStyleBackColor = true;
            this.iconBtnSearch.Click += new System.EventHandler(this.iconBtnSearch_Click);
            // 
            // txtIDProduct
            // 
            this.txtIDProduct.AllowDrop = true;
            this.txtIDProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProduct.ForeColor = System.Drawing.Color.LightGray;
            this.txtIDProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtIDProduct.Location = new System.Drawing.Point(9, 51);
            this.txtIDProduct.MaximumSize = new System.Drawing.Size(550, 30);
            this.txtIDProduct.Name = "txtIDProduct";
            this.txtIDProduct.Size = new System.Drawing.Size(299, 26);
            this.txtIDProduct.TabIndex = 0;
            this.txtIDProduct.Text = "Mã sản phẩm";
            this.txtIDProduct.WordWrap = false;
            this.txtIDProduct.TextChanged += new System.EventHandler(this.txtIDProduct_TextChanged);
            this.txtIDProduct.Enter += new System.EventHandler(this.txtIDProduct_Enter);
            this.txtIDProduct.Leave += new System.EventHandler(this.txtIDProduct_Leave);
            // 
            // panelLeft
            // 
            this.panelLeft.AutoSize = true;
            this.panelLeft.Controls.Add(this.iconbtnClear);
            this.panelLeft.Controls.Add(this.txtIDProduct);
            this.panelLeft.Controls.Add(this.dataGridViewListProduct);
            this.panelLeft.Controls.Add(this.labelListProduct);
            this.panelLeft.Controls.Add(this.iconBtnSearch);
            this.panelLeft.Controls.Add(this.txtNameProduct);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.labelSearch);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.MaximumSize = new System.Drawing.Size(800, 1200);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(556, 640);
            this.panelLeft.TabIndex = 10;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint_1);
            // 
            // iconbtnClear
            // 
            this.iconbtnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconbtnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconbtnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconbtnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconbtnClear.IconColor = System.Drawing.Color.Black;
            this.iconbtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnClear.IconSize = 30;
            this.iconbtnClear.Location = new System.Drawing.Point(432, 51);
            this.iconbtnClear.MaximumSize = new System.Drawing.Size(155, 75);
            this.iconbtnClear.Name = "iconbtnClear";
            this.iconbtnClear.Rotation = 0D;
            this.iconbtnClear.Size = new System.Drawing.Size(112, 61);
            this.iconbtnClear.TabIndex = 3;
            this.iconbtnClear.Text = "Làm Mới";
            this.iconbtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnClear.UseVisualStyleBackColor = true;
            this.iconbtnClear.Click += new System.EventHandler(this.iconbtnClear_Click_1);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1110, 0);
            this.panel3.MaximumSize = new System.Drawing.Size(910, 1200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 640);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(556, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(554, 640);
            this.panel4.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.iconbtnAdd);
            this.panel8.Controls.Add(this.iconbtnDelete);
            this.panel8.Location = new System.Drawing.Point(22, 479);
            this.panel8.MaximumSize = new System.Drawing.Size(650, 142);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(483, 142);
            this.panel8.TabIndex = 18;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.Controls.Add(this.iconbtnReset);
            this.panel10.Controls.Add(this.iconbtnUpdate);
            this.panel10.Location = new System.Drawing.Point(7, 0);
            this.panel10.MaximumSize = new System.Drawing.Size(375, 65);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(302, 65);
            this.panel10.TabIndex = 9;
            // 
            // iconbtnReset
            // 
            this.iconbtnReset.AutoSize = true;
            this.iconbtnReset.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnReset.IconChar = FontAwesome.Sharp.IconChar.FeatherAlt;
            this.iconbtnReset.IconColor = System.Drawing.Color.Black;
            this.iconbtnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnReset.IconSize = 48;
            this.iconbtnReset.Location = new System.Drawing.Point(3, 6);
            this.iconbtnReset.MaximumSize = new System.Drawing.Size(170, 56);
            this.iconbtnReset.Name = "iconbtnReset";
            this.iconbtnReset.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconbtnReset.Rotation = 0D;
            this.iconbtnReset.Size = new System.Drawing.Size(146, 56);
            this.iconbtnReset.TabIndex = 11;
            this.iconbtnReset.Text = "Clear";
            this.iconbtnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnReset.UseVisualStyleBackColor = true;
            this.iconbtnReset.Click += new System.EventHandler(this.iconbtnReset_Click);
            // 
            // iconbtnUpdate
            // 
            this.iconbtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconbtnUpdate.AutoSize = true;
            this.iconbtnUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconbtnUpdate.IconColor = System.Drawing.Color.Black;
            this.iconbtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnUpdate.IconSize = 48;
            this.iconbtnUpdate.Location = new System.Drawing.Point(151, 6);
            this.iconbtnUpdate.MaximumSize = new System.Drawing.Size(175, 56);
            this.iconbtnUpdate.Name = "iconbtnUpdate";
            this.iconbtnUpdate.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconbtnUpdate.Rotation = 0D;
            this.iconbtnUpdate.Size = new System.Drawing.Size(150, 56);
            this.iconbtnUpdate.TabIndex = 12;
            this.iconbtnUpdate.Text = "Cập nhật";
            this.iconbtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnUpdate.UseVisualStyleBackColor = true;
            this.iconbtnUpdate.Click += new System.EventHandler(this.iconbtnUpdate_Click);
            // 
            // iconbtnAdd
            // 
            this.iconbtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconbtnAdd.IconColor = System.Drawing.Color.Black;
            this.iconbtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnAdd.IconSize = 35;
            this.iconbtnAdd.Location = new System.Drawing.Point(8, 71);
            this.iconbtnAdd.Name = "iconbtnAdd";
            this.iconbtnAdd.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconbtnAdd.Rotation = 0D;
            this.iconbtnAdd.Size = new System.Drawing.Size(468, 58);
            this.iconbtnAdd.TabIndex = 14;
            this.iconbtnAdd.Text = "Thêm sản phẩm mới";
            this.iconbtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnAdd.UseVisualStyleBackColor = true;
            this.iconbtnAdd.Click += new System.EventHandler(this.iconbtnAdd_Click);
            // 
            // iconbtnDelete
            // 
            this.iconbtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnDelete.AutoSize = true;
            this.iconbtnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconbtnDelete.IconColor = System.Drawing.Color.Black;
            this.iconbtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnDelete.IconSize = 48;
            this.iconbtnDelete.Location = new System.Drawing.Point(310, 6);
            this.iconbtnDelete.MaximumSize = new System.Drawing.Size(170, 56);
            this.iconbtnDelete.Name = "iconbtnDelete";
            this.iconbtnDelete.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconbtnDelete.Rotation = 0D;
            this.iconbtnDelete.Size = new System.Drawing.Size(167, 56);
            this.iconbtnDelete.TabIndex = 13;
            this.iconbtnDelete.Text = "Xóa mặt hàng";
            this.iconbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnDelete.UseVisualStyleBackColor = true;
            this.iconbtnDelete.Click += new System.EventHandler(this.iconbtnDelete_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.picture);
            this.panel7.Location = new System.Drawing.Point(22, 11);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(210, 217);
            this.panel7.TabIndex = 17;
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picture.ErrorImage")));
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.InitialImage = ((System.Drawing.Image)(resources.GetObject("picture.InitialImage")));
            this.picture.Location = new System.Drawing.Point(3, 12);
            this.picture.MaximumSize = new System.Drawing.Size(300, 270);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(200, 197);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.lblBid);
            this.panel6.Controls.Add(this.txtBid);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.txtPrice);
            this.panel6.Controls.Add(this.lblAmount);
            this.panel6.Controls.Add(this.lblprice);
            this.panel6.Controls.Add(this.txtAmount);
            this.panel6.Controls.Add(this.txtName);
            this.panel6.Controls.Add(this.lblName);
            this.panel6.Location = new System.Drawing.Point(22, 231);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(478, 242);
            this.panel6.TabIndex = 16;
            // 
            // lblBid
            // 
            this.lblBid.AutoSize = true;
            this.lblBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBid.Location = new System.Drawing.Point(4, 62);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(86, 24);
            this.lblBid.TabIndex = 11;
            this.lblBid.Text = "Giá nhập";
            // 
            // txtBid
            // 
            this.txtBid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBid.Location = new System.Drawing.Point(8, 89);
            this.txtBid.MaximumSize = new System.Drawing.Size(400, 35);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(314, 27);
            this.txtBid.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel9.Controls.Add(this.labelmoney1);
            this.panel9.Controls.Add(this.labelmoney2);
            this.panel9.Location = new System.Drawing.Point(328, 88);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(84, 85);
            this.panel9.TabIndex = 17;
            // 
            // labelmoney1
            // 
            this.labelmoney1.AutoSize = true;
            this.labelmoney1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmoney1.Location = new System.Drawing.Point(4, 1);
            this.labelmoney1.Name = "labelmoney1";
            this.labelmoney1.Size = new System.Drawing.Size(55, 24);
            this.labelmoney1.TabIndex = 15;
            this.labelmoney1.Text = "đồng";
            this.labelmoney1.Click += new System.EventHandler(this.labelmoney1_Click);
            // 
            // labelmoney2
            // 
            this.labelmoney2.AutoSize = true;
            this.labelmoney2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmoney2.Location = new System.Drawing.Point(4, 58);
            this.labelmoney2.Name = "labelmoney2";
            this.labelmoney2.Size = new System.Drawing.Size(55, 24);
            this.labelmoney2.TabIndex = 16;
            this.labelmoney2.Text = "đồng";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(7, 146);
            this.txtPrice.MaximumSize = new System.Drawing.Size(400, 35);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(315, 27);
            this.txtPrice.TabIndex = 9;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(4, 176);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(86, 24);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "Số lượng";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(4, 119);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(75, 24);
            this.lblprice.TabIndex = 9;
            this.lblprice.Text = "Giá bán";
            this.lblprice.Click += new System.EventHandler(this.lblprice_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(7, 203);
            this.txtAmount.MaximumSize = new System.Drawing.Size(400, 35);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(315, 27);
            this.txtAmount.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(6, 32);
            this.txtName.MaximumSize = new System.Drawing.Size(630, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(459, 27);
            this.txtName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(127, 24);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Tên mặt hàng";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.lblMaHH);
            this.panel5.Controls.Add(this.txtID);
            this.panel5.Controls.Add(this.lblIDType);
            this.panel5.Controls.Add(this.txtIDType);
            this.panel5.Controls.Add(this.labelTypeProductName);
            this.panel5.Controls.Add(this.txtTypeProductName);
            this.panel5.Location = new System.Drawing.Point(245, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 217);
            this.panel5.TabIndex = 15;
            // 
            // lblMaHH
            // 
            this.lblMaHH.AutoSize = true;
            this.lblMaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHH.Location = new System.Drawing.Point(17, 12);
            this.lblMaHH.Name = "lblMaHH";
            this.lblMaHH.Size = new System.Drawing.Size(124, 24);
            this.lblMaHH.TabIndex = 1;
            this.lblMaHH.Text = "Mã sản phẩm";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(21, 41);
            this.txtID.MaximumSize = new System.Drawing.Size(400, 35);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(221, 27);
            this.txtID.TabIndex = 4;
            // 
            // lblIDType
            // 
            this.lblIDType.AutoSize = true;
            this.lblIDType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDType.Location = new System.Drawing.Point(17, 71);
            this.lblIDType.Name = "lblIDType";
            this.lblIDType.Size = new System.Drawing.Size(158, 24);
            this.lblIDType.TabIndex = 5;
            this.lblIDType.Text = "Mã loại sản phẩm";
            // 
            // txtIDType
            // 
            this.txtIDType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDType.Location = new System.Drawing.Point(21, 100);
            this.txtIDType.MaximumSize = new System.Drawing.Size(400, 35);
            this.txtIDType.Name = "txtIDType";
            this.txtIDType.ReadOnly = true;
            this.txtIDType.Size = new System.Drawing.Size(221, 27);
            this.txtIDType.TabIndex = 5;
            // 
            // labelTypeProductName
            // 
            this.labelTypeProductName.AutoSize = true;
            this.labelTypeProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeProductName.Location = new System.Drawing.Point(17, 135);
            this.labelTypeProductName.Name = "labelTypeProductName";
            this.labelTypeProductName.Size = new System.Drawing.Size(166, 24);
            this.labelTypeProductName.TabIndex = 7;
            this.labelTypeProductName.Text = "Tên loại sản phẩm";
            // 
            // txtTypeProductName
            // 
            this.txtTypeProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTypeProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeProductName.Location = new System.Drawing.Point(21, 164);
            this.txtTypeProductName.MaximumSize = new System.Drawing.Size(400, 35);
            this.txtTypeProductName.Name = "txtTypeProductName";
            this.txtTypeProductName.Size = new System.Drawing.Size(221, 27);
            this.txtTypeProductName.TabIndex = 6;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 640);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProduct)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelListProduct;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewListProduct;
        private System.Windows.Forms.TextBox txtIDProduct;
        private FontAwesome.Sharp.IconButton iconBtnSearch;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.Label lblBid;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtTypeProductName;
        private System.Windows.Forms.Label labelTypeProductName;
        private System.Windows.Forms.TextBox txtIDType;
        private System.Windows.Forms.Label lblIDType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblMaHH;
        private System.Windows.Forms.PictureBox picture;
        private FontAwesome.Sharp.IconButton iconbtnDelete;
        private FontAwesome.Sharp.IconButton iconbtnUpdate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label labelmoney1;
        private System.Windows.Forms.Label labelmoney2;
        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconButton iconbtnAdd;
        private FontAwesome.Sharp.IconButton iconbtnReset;
        private FontAwesome.Sharp.IconButton iconbtnClear;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
    }
}