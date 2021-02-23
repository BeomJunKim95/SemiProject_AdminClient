
namespace AdminClient.Start
{
    partial class whmanagertest
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gb_CRUD = new System.Windows.Forms.GroupBox();
            this.btn_NoResult = new System.Windows.Forms.Button();
            this.gb_Excel = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_selectDate = new System.Windows.Forms.CheckBox();
            this.rb_Date = new System.Windows.Forms.RadioButton();
            this.rb_Product = new System.Windows.Forms.RadioButton();
            this.cbx_Category = new System.Windows.Forms.CheckBox();
            this.cbx_Company = new System.Windows.Forms.CheckBox();
            this.gb_Company = new System.Windows.Forms.GroupBox();
            this.cbo_compComp = new System.Windows.Forms.ComboBox();
            this.cbo_compCate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.nu_Limit = new System.Windows.Forms.NumericUpDown();
            this.cbx_Limit = new System.Windows.Forms.CheckBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.gb_Category = new System.Windows.Forms.GroupBox();
            this.cbo_cateComp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_cateCate = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgv_ProductList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_ProdImg = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nu_LogCount = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nu_PsyCount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Company = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nu_OrderCount = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.txt_ProdName = new System.Windows.Forms.TextBox();
            this.dgv_ResultInfo = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Valuez = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gb_CRUD.SuspendLayout();
            this.gb_Excel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_Company.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Limit)).BeginInit();
            this.gb_Category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ProdImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_LogCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_PsyCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_OrderCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gb_CRUD);
            this.splitContainer1.Panel1.Controls.Add(this.gb_Excel);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1625, 794);
            this.splitContainer1.SplitterDistance = 464;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // gb_CRUD
            // 
            this.gb_CRUD.Controls.Add(this.btn_NoResult);
            this.gb_CRUD.Location = new System.Drawing.Point(12, 344);
            this.gb_CRUD.Name = "gb_CRUD";
            this.gb_CRUD.Size = new System.Drawing.Size(440, 437);
            this.gb_CRUD.TabIndex = 65;
            this.gb_CRUD.TabStop = false;
            this.gb_CRUD.Text = "간편 검색";
            // 
            // btn_NoResult
            // 
            this.btn_NoResult.Location = new System.Drawing.Point(6, 20);
            this.btn_NoResult.Name = "btn_NoResult";
            this.btn_NoResult.Size = new System.Drawing.Size(423, 71);
            this.btn_NoResult.TabIndex = 45;
            this.btn_NoResult.Text = "입고 전 목록";
            this.btn_NoResult.UseVisualStyleBackColor = true;
            this.btn_NoResult.Click += new System.EventHandler(this.btn_NoResult_Click);
            // 
            // gb_Excel
            // 
            this.gb_Excel.Controls.Add(this.button16);
            this.gb_Excel.Controls.Add(this.button15);
            this.gb_Excel.Location = new System.Drawing.Point(12, 253);
            this.gb_Excel.Name = "gb_Excel";
            this.gb_Excel.Size = new System.Drawing.Size(440, 78);
            this.gb_Excel.TabIndex = 64;
            this.gb_Excel.TabStop = false;
            this.gb_Excel.Text = "엑셀";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(11, 20);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(112, 38);
            this.button16.TabIndex = 47;
            this.button16.Text = "엑셀 가져오기";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(134, 20);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(113, 38);
            this.button15.TabIndex = 49;
            this.button15.Text = "엑셀 내보내기";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_selectDate);
            this.groupBox1.Controls.Add(this.rb_Date);
            this.groupBox1.Controls.Add(this.rb_Product);
            this.groupBox1.Controls.Add(this.cbx_Category);
            this.groupBox1.Controls.Add(this.cbx_Company);
            this.groupBox1.Controls.Add(this.gb_Company);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_To);
            this.groupBox1.Controls.Add(this.dtp_From);
            this.groupBox1.Controls.Add(this.nu_Limit);
            this.groupBox1.Controls.Add(this.cbx_Limit);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.gb_Category);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 228);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색조건";
            // 
            // cbx_selectDate
            // 
            this.cbx_selectDate.AutoSize = true;
            this.cbx_selectDate.Location = new System.Drawing.Point(12, 190);
            this.cbx_selectDate.Name = "cbx_selectDate";
            this.cbx_selectDate.Size = new System.Drawing.Size(48, 16);
            this.cbx_selectDate.TabIndex = 70;
            this.cbx_selectDate.Text = "기간";
            this.cbx_selectDate.UseVisualStyleBackColor = true;
            this.cbx_selectDate.CheckedChanged += new System.EventHandler(this.cbx_selectDate_CheckedChanged);
            // 
            // rb_Date
            // 
            this.rb_Date.AutoSize = true;
            this.rb_Date.Location = new System.Drawing.Point(252, 20);
            this.rb_Date.Name = "rb_Date";
            this.rb_Date.Size = new System.Drawing.Size(59, 16);
            this.rb_Date.TabIndex = 69;
            this.rb_Date.TabStop = true;
            this.rb_Date.Text = "주문별";
            this.rb_Date.UseVisualStyleBackColor = true;
            this.rb_Date.CheckedChanged += new System.EventHandler(this.rb_Date_CheckedChanged);
            // 
            // rb_Product
            // 
            this.rb_Product.AutoSize = true;
            this.rb_Product.Location = new System.Drawing.Point(187, 20);
            this.rb_Product.Name = "rb_Product";
            this.rb_Product.Size = new System.Drawing.Size(59, 16);
            this.rb_Product.TabIndex = 68;
            this.rb_Product.TabStop = true;
            this.rb_Product.Text = "제품별";
            this.rb_Product.UseVisualStyleBackColor = true;
            this.rb_Product.CheckedChanged += new System.EventHandler(this.rb_Product_CheckedChanged);
            // 
            // cbx_Category
            // 
            this.cbx_Category.AutoSize = true;
            this.cbx_Category.Location = new System.Drawing.Point(112, 71);
            this.cbx_Category.Name = "cbx_Category";
            this.cbx_Category.Size = new System.Drawing.Size(15, 14);
            this.cbx_Category.TabIndex = 66;
            this.cbx_Category.UseVisualStyleBackColor = true;
            this.cbx_Category.CheckedChanged += new System.EventHandler(this.cbx_Category_CheckedChanged);
            // 
            // cbx_Company
            // 
            this.cbx_Company.AutoSize = true;
            this.cbx_Company.Location = new System.Drawing.Point(305, 71);
            this.cbx_Company.Name = "cbx_Company";
            this.cbx_Company.Size = new System.Drawing.Size(15, 14);
            this.cbx_Company.TabIndex = 67;
            this.cbx_Company.UseVisualStyleBackColor = true;
            this.cbx_Company.CheckedChanged += new System.EventHandler(this.cbx_Company_CheckedChanged);
            // 
            // gb_Company
            // 
            this.gb_Company.Controls.Add(this.cbo_compComp);
            this.gb_Company.Controls.Add(this.cbo_compCate);
            this.gb_Company.Controls.Add(this.label1);
            this.gb_Company.Controls.Add(this.label6);
            this.gb_Company.Enabled = false;
            this.gb_Company.Location = new System.Drawing.Point(229, 72);
            this.gb_Company.Name = "gb_Company";
            this.gb_Company.Size = new System.Drawing.Size(200, 103);
            this.gb_Company.TabIndex = 65;
            this.gb_Company.TabStop = false;
            this.gb_Company.Text = "유통사 기준";
            // 
            // cbo_compComp
            // 
            this.cbo_compComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_compComp.FormattingEnabled = true;
            this.cbo_compComp.Location = new System.Drawing.Point(68, 29);
            this.cbo_compComp.Name = "cbo_compComp";
            this.cbo_compComp.Size = new System.Drawing.Size(121, 20);
            this.cbo_compComp.TabIndex = 20;
            this.cbo_compComp.SelectedIndexChanged += new System.EventHandler(this.cbo_compComp_SelectedIndexChanged);
            // 
            // cbo_compCate
            // 
            this.cbo_compCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_compCate.FormattingEnabled = true;
            this.cbo_compCate.Location = new System.Drawing.Point(68, 62);
            this.cbo_compCate.Name = "cbo_compCate";
            this.cbo_compCate.Size = new System.Drawing.Size(121, 20);
            this.cbo_compCate.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "유통사";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "카테고리";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "~";
            // 
            // dtp_To
            // 
            this.dtp_To.Enabled = false;
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_To.Location = new System.Drawing.Point(189, 188);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(105, 21);
            this.dtp_To.TabIndex = 24;
            // 
            // dtp_From
            // 
            this.dtp_From.Enabled = false;
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_From.Location = new System.Drawing.Point(62, 188);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(105, 21);
            this.dtp_From.TabIndex = 23;
            // 
            // nu_Limit
            // 
            this.nu_Limit.Enabled = false;
            this.nu_Limit.Location = new System.Drawing.Point(97, 21);
            this.nu_Limit.Name = "nu_Limit";
            this.nu_Limit.Size = new System.Drawing.Size(61, 21);
            this.nu_Limit.TabIndex = 1;
            // 
            // cbx_Limit
            // 
            this.cbx_Limit.AutoSize = true;
            this.cbx_Limit.Location = new System.Drawing.Point(12, 23);
            this.cbx_Limit.Name = "cbx_Limit";
            this.cbx_Limit.Size = new System.Drawing.Size(72, 16);
            this.cbx_Limit.TabIndex = 0;
            this.cbx_Limit.Text = "검색제한";
            this.cbx_Limit.UseVisualStyleBackColor = true;
            this.cbx_Limit.CheckedChanged += new System.EventHandler(this.cbx_Limit_CheckedChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(366, 14);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(68, 23);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // gb_Category
            // 
            this.gb_Category.Controls.Add(this.cbo_cateComp);
            this.gb_Category.Controls.Add(this.label2);
            this.gb_Category.Controls.Add(this.label5);
            this.gb_Category.Controls.Add(this.cbo_cateCate);
            this.gb_Category.Location = new System.Drawing.Point(23, 72);
            this.gb_Category.Name = "gb_Category";
            this.gb_Category.Size = new System.Drawing.Size(200, 103);
            this.gb_Category.TabIndex = 64;
            this.gb_Category.TabStop = false;
            this.gb_Category.Text = "카테고리 기준";
            // 
            // cbo_cateComp
            // 
            this.cbo_cateComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cateComp.FormattingEnabled = true;
            this.cbo_cateComp.Location = new System.Drawing.Point(73, 62);
            this.cbo_cateComp.Name = "cbo_cateComp";
            this.cbo_cateComp.Size = new System.Drawing.Size(121, 20);
            this.cbo_cateComp.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "카테고리";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "유통사";
            // 
            // cbo_cateCate
            // 
            this.cbo_cateCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cateCate.FormattingEnabled = true;
            this.cbo_cateCate.Location = new System.Drawing.Point(73, 29);
            this.cbo_cateCate.Name = "cbo_cateCate";
            this.cbo_cateCate.Size = new System.Drawing.Size(121, 20);
            this.cbo_cateCate.TabIndex = 22;
            this.cbo_cateCate.SelectedIndexChanged += new System.EventHandler(this.cbo_cateCate_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgv_ProductList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Panel2.Controls.Add(this.dgv_ResultInfo);
            this.splitContainer2.Size = new System.Drawing.Size(1151, 794);
            this.splitContainer2.SplitterDistance = 392;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgv_ProductList
            // 
            this.dgv_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ProductList.Location = new System.Drawing.Point(0, 0);
            this.dgv_ProductList.Name = "dgv_ProductList";
            this.dgv_ProductList.RowTemplate.Height = 23;
            this.dgv_ProductList.Size = new System.Drawing.Size(1151, 392);
            this.dgv_ProductList.TabIndex = 0;
            this.dgv_ProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProductList_CellContentClick);
            this.dgv_ProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProductList_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Valuez);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pb_ProdImg);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.nu_LogCount);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.nu_PsyCount);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txt_Company);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.nu_OrderCount);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txt_Category);
            this.panel1.Controls.Add(this.txt_ProdName);
            this.panel1.Location = new System.Drawing.Point(705, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 376);
            this.panel1.TabIndex = 60;
            // 
            // pb_ProdImg
            // 
            this.pb_ProdImg.Location = new System.Drawing.Point(128, 12);
            this.pb_ProdImg.Name = "pb_ProdImg";
            this.pb_ProdImg.Size = new System.Drawing.Size(202, 156);
            this.pb_ProdImg.TabIndex = 41;
            this.pb_ProdImg.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 42;
            this.label9.Text = "물품명";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 43;
            this.label10.Text = "카테고리";
            // 
            // nu_LogCount
            // 
            this.nu_LogCount.Enabled = false;
            this.nu_LogCount.Location = new System.Drawing.Point(338, 257);
            this.nu_LogCount.Name = "nu_LogCount";
            this.nu_LogCount.ReadOnly = true;
            this.nu_LogCount.Size = new System.Drawing.Size(76, 21);
            this.nu_LogCount.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(273, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 12);
            this.label11.TabIndex = 44;
            this.label11.Text = "현재 갯수";
            // 
            // nu_PsyCount
            // 
            this.nu_PsyCount.Enabled = false;
            this.nu_PsyCount.Location = new System.Drawing.Point(338, 218);
            this.nu_PsyCount.Name = "nu_PsyCount";
            this.nu_PsyCount.ReadOnly = true;
            this.nu_PsyCount.Size = new System.Drawing.Size(76, 21);
            this.nu_PsyCount.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 12);
            this.label12.TabIndex = 45;
            this.label12.Text = "논리 갯수";
            // 
            // txt_Company
            // 
            this.txt_Company.Enabled = false;
            this.txt_Company.Location = new System.Drawing.Point(97, 257);
            this.txt_Company.Name = "txt_Company";
            this.txt_Company.ReadOnly = true;
            this.txt_Company.Size = new System.Drawing.Size(137, 21);
            this.txt_Company.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(273, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 46;
            this.label13.Text = "주문수량";
            // 
            // nu_OrderCount
            // 
            this.nu_OrderCount.Enabled = false;
            this.nu_OrderCount.Location = new System.Drawing.Point(338, 179);
            this.nu_OrderCount.Name = "nu_OrderCount";
            this.nu_OrderCount.ReadOnly = true;
            this.nu_OrderCount.Size = new System.Drawing.Size(76, 21);
            this.nu_OrderCount.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 47;
            this.label14.Text = "거래처명";
            // 
            // txt_Category
            // 
            this.txt_Category.Enabled = false;
            this.txt_Category.Location = new System.Drawing.Point(97, 218);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.ReadOnly = true;
            this.txt_Category.Size = new System.Drawing.Size(137, 21);
            this.txt_Category.TabIndex = 49;
            // 
            // txt_ProdName
            // 
            this.txt_ProdName.Enabled = false;
            this.txt_ProdName.Location = new System.Drawing.Point(97, 179);
            this.txt_ProdName.Name = "txt_ProdName";
            this.txt_ProdName.ReadOnly = true;
            this.txt_ProdName.Size = new System.Drawing.Size(137, 21);
            this.txt_ProdName.TabIndex = 48;
            // 
            // dgv_ResultInfo
            // 
            this.dgv_ResultInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ResultInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_ResultInfo.Location = new System.Drawing.Point(0, 0);
            this.dgv_ResultInfo.Name = "dgv_ResultInfo";
            this.dgv_ResultInfo.RowTemplate.Height = 23;
            this.dgv_ResultInfo.Size = new System.Drawing.Size(699, 392);
            this.dgv_ResultInfo.TabIndex = 0;
            this.dgv_ResultInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ResultInfo_CellContentClick);
            this.dgv_ResultInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ResultInfo_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 56;
            this.label3.Text = "정보";
            // 
            // lbl_Valuez
            // 
            this.lbl_Valuez.Location = new System.Drawing.Point(32, 312);
            this.lbl_Valuez.Name = "lbl_Valuez";
            this.lbl_Valuez.Size = new System.Drawing.Size(382, 54);
            this.lbl_Valuez.TabIndex = 57;
            this.lbl_Valuez.Text = "12";
            // 
            // whmanagertest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 794);
            this.Controls.Add(this.splitContainer1);
            this.Name = "whmanagertest";
            this.Text = "whmanagertest";
            this.Load += new System.EventHandler(this.whmanagertest_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gb_CRUD.ResumeLayout(false);
            this.gb_Excel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_Company.ResumeLayout(false);
            this.gb_Company.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Limit)).EndInit();
            this.gb_Category.ResumeLayout(false);
            this.gb_Category.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ProdImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_LogCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_PsyCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_OrderCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbx_Category;
        private System.Windows.Forms.CheckBox cbx_Company;
        private System.Windows.Forms.GroupBox gb_Company;
        private System.Windows.Forms.ComboBox cbo_compComp;
        private System.Windows.Forms.ComboBox cbo_compCate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.NumericUpDown nu_Limit;
        private System.Windows.Forms.CheckBox cbx_Limit;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox gb_Category;
        private System.Windows.Forms.ComboBox cbo_cateComp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_cateCate;
        private System.Windows.Forms.GroupBox gb_CRUD;
        private System.Windows.Forms.GroupBox gb_Excel;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.DataGridView dgv_ProductList;
        private System.Windows.Forms.DataGridView dgv_ResultInfo;
        private System.Windows.Forms.Button btn_NoResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_ProdImg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nu_LogCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nu_PsyCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Company;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nu_OrderCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.TextBox txt_ProdName;
        private System.Windows.Forms.RadioButton rb_Date;
        private System.Windows.Forms.RadioButton rb_Product;
        private System.Windows.Forms.CheckBox cbx_selectDate;
        private System.Windows.Forms.Label lbl_Valuez;
        private System.Windows.Forms.Label label3;
    }
}