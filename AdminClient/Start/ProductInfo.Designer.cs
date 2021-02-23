namespace AdminClient.Start
{
    partial class ProductInfo
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
            System.Dynamic.ExpandoObject expandoObject1 = new System.Dynamic.ExpandoObject();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnl_Prop = new System.Windows.Forms.Panel();
            this.cbo_Catagory = new System.Windows.Forms.ComboBox();
            this.cbo_Divition = new System.Windows.Forms.ComboBox();
            this.gb_Excel = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.gbo_Serch = new System.Windows.Forms.GroupBox();
            this.cbo_Sortkey = new System.Windows.Forms.ComboBox();
            this.rd_descending = new System.Windows.Forms.RadioButton();
            this.rd_ascending = new System.Windows.Forms.RadioButton();
            this.cbo_Key = new System.Windows.Forms.ComboBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_SortPrice = new System.Windows.Forms.Button();
            this.cbo_detailCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_keyword = new System.Windows.Forms.TextBox();
            this.cbo_keyword = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_Common = new System.Windows.Forms.ComboBox();
            this.cbx_Category = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_ProductCount = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_Limit = new System.Windows.Forms.CheckBox();
            this.nu_Limit = new System.Windows.Forms.NumericUpDown();
            this.gb_Category = new System.Windows.Forms.GroupBox();
            this.cbo_CDivition = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbo_cateCate = new System.Windows.Forms.ComboBox();
            this.gb_ProductCount = new System.Windows.Forms.GroupBox();
            this.rdo_ProductCount3 = new System.Windows.Forms.RadioButton();
            this.rdo_ProductCount1 = new System.Windows.Forms.RadioButton();
            this.rdo_ProductCount2 = new System.Windows.Forms.RadioButton();
            this.btn_Search = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_Products = new System.Windows.Forms.DataGridView();
            this.productFeature = new AdminClient.ProductFeature();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnl_Prop.SuspendLayout();
            this.gb_Excel.SuspendLayout();
            this.gbo_Serch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Limit)).BeginInit();
            this.gb_Category.SuspendLayout();
            this.gb_ProductCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.pnl_Prop);
            this.splitContainer1.Panel1.Controls.Add(this.gb_Excel);
            this.splitContainer1.Panel1.Controls.Add(this.gbo_Serch);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1506, 739);
            this.splitContainer1.SplitterDistance = 451;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // pnl_Prop
            // 
            this.pnl_Prop.Controls.Add(this.cbo_Catagory);
            this.pnl_Prop.Controls.Add(this.cbo_Divition);
            this.pnl_Prop.Controls.Add(this.productFeature);
            this.pnl_Prop.Enabled = false;
            this.pnl_Prop.Location = new System.Drawing.Point(3, 454);
            this.pnl_Prop.Name = "pnl_Prop";
            this.pnl_Prop.Size = new System.Drawing.Size(446, 284);
            this.pnl_Prop.TabIndex = 81;
            // 
            // cbo_Catagory
            // 
            this.cbo_Catagory.FormattingEnabled = true;
            this.cbo_Catagory.Location = new System.Drawing.Point(18, 32);
            this.cbo_Catagory.Name = "cbo_Catagory";
            this.cbo_Catagory.Size = new System.Drawing.Size(406, 20);
            this.cbo_Catagory.TabIndex = 78;
            this.cbo_Catagory.SelectedIndexChanged += new System.EventHandler(this.cbo_Catagory_SelectedIndexChanged);
            // 
            // cbo_Divition
            // 
            this.cbo_Divition.FormattingEnabled = true;
            this.cbo_Divition.Location = new System.Drawing.Point(19, 6);
            this.cbo_Divition.Name = "cbo_Divition";
            this.cbo_Divition.Size = new System.Drawing.Size(406, 20);
            this.cbo_Divition.TabIndex = 77;
            this.cbo_Divition.SelectedIndexChanged += new System.EventHandler(this.cbo_Divition_SelectedIndexChanged);
            // 
            // gb_Excel
            // 
            this.gb_Excel.Controls.Add(this.button16);
            this.gb_Excel.Controls.Add(this.button15);
            this.gb_Excel.Enabled = false;
            this.gb_Excel.Location = new System.Drawing.Point(3, 380);
            this.gb_Excel.Name = "gb_Excel";
            this.gb_Excel.Size = new System.Drawing.Size(437, 71);
            this.gb_Excel.TabIndex = 80;
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
            // gbo_Serch
            // 
            this.gbo_Serch.Controls.Add(this.cbo_Sortkey);
            this.gbo_Serch.Controls.Add(this.rd_descending);
            this.gbo_Serch.Controls.Add(this.rd_ascending);
            this.gbo_Serch.Controls.Add(this.cbo_Key);
            this.gbo_Serch.Controls.Add(this.btn_apply);
            this.gbo_Serch.Controls.Add(this.label5);
            this.gbo_Serch.Controls.Add(this.btn_SortPrice);
            this.gbo_Serch.Controls.Add(this.cbo_detailCategory);
            this.gbo_Serch.Controls.Add(this.label3);
            this.gbo_Serch.Controls.Add(this.txt_keyword);
            this.gbo_Serch.Controls.Add(this.cbo_keyword);
            this.gbo_Serch.Enabled = false;
            this.gbo_Serch.Location = new System.Drawing.Point(3, 200);
            this.gbo_Serch.Name = "gbo_Serch";
            this.gbo_Serch.Size = new System.Drawing.Size(434, 178);
            this.gbo_Serch.TabIndex = 79;
            this.gbo_Serch.TabStop = false;
            this.gbo_Serch.Text = "세부검색";
            // 
            // cbo_Sortkey
            // 
            this.cbo_Sortkey.FormattingEnabled = true;
            this.cbo_Sortkey.Location = new System.Drawing.Point(9, 141);
            this.cbo_Sortkey.Name = "cbo_Sortkey";
            this.cbo_Sortkey.Size = new System.Drawing.Size(98, 20);
            this.cbo_Sortkey.TabIndex = 79;
            // 
            // rd_descending
            // 
            this.rd_descending.AutoSize = true;
            this.rd_descending.Location = new System.Drawing.Point(127, 110);
            this.rd_descending.Name = "rd_descending";
            this.rd_descending.Size = new System.Drawing.Size(90, 16);
            this.rd_descending.TabIndex = 78;
            this.rd_descending.Text = "Descending";
            this.rd_descending.UseVisualStyleBackColor = true;
            // 
            // rd_ascending
            // 
            this.rd_ascending.AutoSize = true;
            this.rd_ascending.Checked = true;
            this.rd_ascending.Location = new System.Drawing.Point(28, 110);
            this.rd_ascending.Name = "rd_ascending";
            this.rd_ascending.Size = new System.Drawing.Size(83, 16);
            this.rd_ascending.TabIndex = 77;
            this.rd_ascending.TabStop = true;
            this.rd_ascending.Text = "Ascending";
            this.rd_ascending.UseVisualStyleBackColor = true;
            // 
            // cbo_Key
            // 
            this.cbo_Key.FormattingEnabled = true;
            this.cbo_Key.Location = new System.Drawing.Point(10, 38);
            this.cbo_Key.Name = "cbo_Key";
            this.cbo_Key.Size = new System.Drawing.Size(98, 20);
            this.cbo_Key.TabIndex = 76;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(371, 38);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(54, 60);
            this.btn_apply.TabIndex = 75;
            this.btn_apply.Text = "조건\r\n\r\n적용";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 71;
            this.label5.Text = "카테고리";
            // 
            // btn_SortPrice
            // 
            this.btn_SortPrice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SortPrice.Location = new System.Drawing.Point(117, 130);
            this.btn_SortPrice.Name = "btn_SortPrice";
            this.btn_SortPrice.Size = new System.Drawing.Size(105, 40);
            this.btn_SortPrice.TabIndex = 34;
            this.btn_SortPrice.Tag = "sort";
            this.btn_SortPrice.Text = "정렬";
            this.btn_SortPrice.UseVisualStyleBackColor = false;
            this.btn_SortPrice.Click += new System.EventHandler(this.btn_SortPrice_Click);
            // 
            // cbo_detailCategory
            // 
            this.cbo_detailCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_detailCategory.FormattingEnabled = true;
            this.cbo_detailCategory.Location = new System.Drawing.Point(69, 69);
            this.cbo_detailCategory.Name = "cbo_detailCategory";
            this.cbo_detailCategory.Size = new System.Drawing.Size(121, 20);
            this.cbo_detailCategory.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "검색방식";
            // 
            // txt_keyword
            // 
            this.txt_keyword.Location = new System.Drawing.Point(210, 37);
            this.txt_keyword.Name = "txt_keyword";
            this.txt_keyword.Size = new System.Drawing.Size(152, 21);
            this.txt_keyword.TabIndex = 28;
            // 
            // cbo_keyword
            // 
            this.cbo_keyword.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_keyword.FormattingEnabled = true;
            this.cbo_keyword.Location = new System.Drawing.Point(120, 38);
            this.cbo_keyword.Name = "cbo_keyword";
            this.cbo_keyword.Size = new System.Drawing.Size(79, 20);
            this.cbo_keyword.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_Common);
            this.groupBox1.Controls.Add(this.cbx_Category);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbx_ProductCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbx_Limit);
            this.groupBox1.Controls.Add(this.nu_Limit);
            this.groupBox1.Controls.Add(this.gb_Category);
            this.groupBox1.Controls.Add(this.gb_ProductCount);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 191);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색조건";
            // 
            // cbo_Common
            // 
            this.cbo_Common.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Common.FormattingEnabled = true;
            this.cbo_Common.Location = new System.Drawing.Point(230, 25);
            this.cbo_Common.Name = "cbo_Common";
            this.cbo_Common.Size = new System.Drawing.Size(114, 20);
            this.cbo_Common.TabIndex = 80;
            // 
            // cbx_Category
            // 
            this.cbx_Category.AutoSize = true;
            this.cbx_Category.Location = new System.Drawing.Point(98, 61);
            this.cbx_Category.Name = "cbx_Category";
            this.cbx_Category.Size = new System.Drawing.Size(15, 14);
            this.cbx_Category.TabIndex = 70;
            this.cbx_Category.UseVisualStyleBackColor = true;
            this.cbx_Category.CheckedChanged += new System.EventHandler(this.cbx_Category_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 79;
            this.label7.Text = "물품상태";
            // 
            // cbx_ProductCount
            // 
            this.cbx_ProductCount.AutoSize = true;
            this.cbx_ProductCount.Location = new System.Drawing.Point(276, 62);
            this.cbx_ProductCount.Name = "cbx_ProductCount";
            this.cbx_ProductCount.Size = new System.Drawing.Size(15, 14);
            this.cbx_ProductCount.TabIndex = 71;
            this.cbx_ProductCount.UseVisualStyleBackColor = true;
            this.cbx_ProductCount.CheckedChanged += new System.EventHandler(this.cbx_ProductCount_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(9, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 12);
            this.label4.TabIndex = 76;
            this.label4.Text = "※미선택시 모든 물품을 조회하며 양이 많을 경우 시간이 걸릴 수 있습니다.";
            // 
            // cbx_Limit
            // 
            this.cbx_Limit.AutoSize = true;
            this.cbx_Limit.Location = new System.Drawing.Point(19, 27);
            this.cbx_Limit.Name = "cbx_Limit";
            this.cbx_Limit.Size = new System.Drawing.Size(72, 16);
            this.cbx_Limit.TabIndex = 72;
            this.cbx_Limit.Text = "검색제한";
            this.cbx_Limit.UseVisualStyleBackColor = true;
            this.cbx_Limit.CheckedChanged += new System.EventHandler(this.cbx_Limit_CheckedChanged);
            // 
            // nu_Limit
            // 
            this.nu_Limit.Enabled = false;
            this.nu_Limit.Location = new System.Drawing.Point(104, 25);
            this.nu_Limit.Name = "nu_Limit";
            this.nu_Limit.Size = new System.Drawing.Size(61, 21);
            this.nu_Limit.TabIndex = 73;
            // 
            // gb_Category
            // 
            this.gb_Category.Controls.Add(this.cbo_CDivition);
            this.gb_Category.Controls.Add(this.label12);
            this.gb_Category.Controls.Add(this.label13);
            this.gb_Category.Controls.Add(this.cbo_cateCate);
            this.gb_Category.Enabled = false;
            this.gb_Category.Location = new System.Drawing.Point(11, 63);
            this.gb_Category.Name = "gb_Category";
            this.gb_Category.Size = new System.Drawing.Size(200, 103);
            this.gb_Category.TabIndex = 68;
            this.gb_Category.TabStop = false;
            this.gb_Category.Text = "카테고리 기준";
            // 
            // cbo_CDivition
            // 
            this.cbo_CDivition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_CDivition.FormattingEnabled = true;
            this.cbo_CDivition.Location = new System.Drawing.Point(70, 26);
            this.cbo_CDivition.Name = "cbo_CDivition";
            this.cbo_CDivition.Size = new System.Drawing.Size(121, 20);
            this.cbo_CDivition.TabIndex = 30;
            this.cbo_CDivition.SelectedIndexChanged += new System.EventHandler(this.cbo_CDivition_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 21;
            this.label12.Text = "카테고리";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 29;
            this.label13.Text = "구분";
            // 
            // cbo_cateCate
            // 
            this.cbo_cateCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cateCate.FormattingEnabled = true;
            this.cbo_cateCate.Location = new System.Drawing.Point(70, 61);
            this.cbo_cateCate.Name = "cbo_cateCate";
            this.cbo_cateCate.Size = new System.Drawing.Size(121, 20);
            this.cbo_cateCate.TabIndex = 22;
            // 
            // gb_ProductCount
            // 
            this.gb_ProductCount.Controls.Add(this.rdo_ProductCount3);
            this.gb_ProductCount.Controls.Add(this.rdo_ProductCount1);
            this.gb_ProductCount.Controls.Add(this.rdo_ProductCount2);
            this.gb_ProductCount.Enabled = false;
            this.gb_ProductCount.Location = new System.Drawing.Point(217, 63);
            this.gb_ProductCount.Name = "gb_ProductCount";
            this.gb_ProductCount.Size = new System.Drawing.Size(200, 103);
            this.gb_ProductCount.TabIndex = 69;
            this.gb_ProductCount.TabStop = false;
            this.gb_ProductCount.Text = "물품갯수";
            // 
            // rdo_ProductCount3
            // 
            this.rdo_ProductCount3.AutoSize = true;
            this.rdo_ProductCount3.Location = new System.Drawing.Point(25, 73);
            this.rdo_ProductCount3.Name = "rdo_ProductCount3";
            this.rdo_ProductCount3.Size = new System.Drawing.Size(131, 16);
            this.rdo_ProductCount3.TabIndex = 74;
            this.rdo_ProductCount3.Tag = " Product_PsyCount > Product_Max ";
            this.rdo_ProductCount3.Text = "제한 수량 범위 초과";
            this.rdo_ProductCount3.UseVisualStyleBackColor = true;
            // 
            // rdo_ProductCount1
            // 
            this.rdo_ProductCount1.AutoSize = true;
            this.rdo_ProductCount1.Checked = true;
            this.rdo_ProductCount1.Location = new System.Drawing.Point(25, 30);
            this.rdo_ProductCount1.Name = "rdo_ProductCount1";
            this.rdo_ProductCount1.Size = new System.Drawing.Size(131, 16);
            this.rdo_ProductCount1.TabIndex = 73;
            this.rdo_ProductCount1.TabStop = true;
            this.rdo_ProductCount1.Tag = " Product_PsyCount < Product_Min ";
            this.rdo_ProductCount1.Text = "제한 수량 범위 아래";
            this.rdo_ProductCount1.UseVisualStyleBackColor = true;
            // 
            // rdo_ProductCount2
            // 
            this.rdo_ProductCount2.AutoSize = true;
            this.rdo_ProductCount2.Location = new System.Drawing.Point(25, 52);
            this.rdo_ProductCount2.Name = "rdo_ProductCount2";
            this.rdo_ProductCount2.Size = new System.Drawing.Size(119, 16);
            this.rdo_ProductCount2.TabIndex = 72;
            this.rdo_ProductCount2.Tag = " Product_PsyCount >= Product_Min and Product_PsyCount <= Product_Max ";
            this.rdo_ProductCount2.Text = "제한 수량 범위 내";
            this.rdo_ProductCount2.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(350, 24);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(68, 23);
            this.btn_Search.TabIndex = 74;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
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
            this.splitContainer2.Panel1.Controls.Add(this.btn_add);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgv_Products);
            this.splitContainer2.Size = new System.Drawing.Size(1047, 739);
            this.splitContainer2.SplitterDistance = 65;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Enabled = false;
            this.btn_add.Location = new System.Drawing.Point(12, 11);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(176, 45);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "추가";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_Products
            // 
            this.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Products.Location = new System.Drawing.Point(0, 0);
            this.dgv_Products.Name = "dgv_Products";
            this.dgv_Products.RowTemplate.Height = 23;
            this.dgv_Products.Size = new System.Drawing.Size(1047, 668);
            this.dgv_Products.TabIndex = 0;
            this.dgv_Products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Products_CellContentClick);
            this.dgv_Products.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Products_CellDoubleClick);
            this.dgv_Products.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_Products_DataBindingComplete);
            // 
            // productFeature
            // 
            this.productFeature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productFeature.Info = expandoObject1;
            this.productFeature.Location = new System.Drawing.Point(6, 58);
            this.productFeature.Name = "productFeature";
            this.productFeature.Size = new System.Drawing.Size(431, 215);
            this.productFeature.TabIndex = 0;
            // 
            // ProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 739);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProductInfo";
            this.Text = "ProductInfo";
            this.Load += new System.EventHandler(this.ProductInfo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnl_Prop.ResumeLayout(false);
            this.gb_Excel.ResumeLayout(false);
            this.gbo_Serch.ResumeLayout(false);
            this.gbo_Serch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Limit)).EndInit();
            this.gb_Category.ResumeLayout(false);
            this.gb_Category.PerformLayout();
            this.gb_ProductCount.ResumeLayout(false);
            this.gb_ProductCount.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbx_Category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbx_Limit;
        private System.Windows.Forms.NumericUpDown nu_Limit;
        private System.Windows.Forms.GroupBox gb_Category;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbo_cateCate;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox gbo_Serch;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_SortPrice;
        private System.Windows.Forms.ComboBox cbo_detailCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_keyword;
        private System.Windows.Forms.ComboBox cbo_keyword;
        private System.Windows.Forms.ComboBox cbo_Key;
        private System.Windows.Forms.RadioButton rd_descending;
        private System.Windows.Forms.RadioButton rd_ascending;
        private System.Windows.Forms.GroupBox gb_Excel;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.ComboBox cbo_Common;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_CDivition;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gb_ProductCount;
        private System.Windows.Forms.RadioButton rdo_ProductCount3;
        private System.Windows.Forms.RadioButton rdo_ProductCount1;
        private System.Windows.Forms.RadioButton rdo_ProductCount2;
        private System.Windows.Forms.CheckBox cbx_ProductCount;
        private System.Windows.Forms.DataGridView dgv_Products;
        private System.Windows.Forms.ComboBox cbo_Sortkey;
        private System.Windows.Forms.Panel pnl_Prop;
        private System.Windows.Forms.ComboBox cbo_Catagory;
        private System.Windows.Forms.ComboBox cbo_Divition;
        private ProductFeature productFeature;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_add;
    }
}