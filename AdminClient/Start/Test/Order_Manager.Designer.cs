
namespace AdminClient.Start
{
    partial class OrderManager
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
            this.dgv_DetailInfo = new System.Windows.Forms.DataGridView();
            this.dgv_OrderInfo = new System.Windows.Forms.DataGridView();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_Category = new System.Windows.Forms.CheckBox();
            this.cbx_Company = new System.Windows.Forms.CheckBox();
            this.gb_Company = new System.Windows.Forms.GroupBox();
            this.cbo_compComp = new System.Windows.Forms.ComboBox();
            this.cbo_compCate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.nu_Limit = new System.Windows.Forms.NumericUpDown();
            this.cbx_Limit = new System.Windows.Forms.CheckBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.gb_Category = new System.Windows.Forms.GroupBox();
            this.cbo_cateComp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_cateCate = new System.Windows.Forms.ComboBox();
            this.btn_GetAllOrder = new System.Windows.Forms.Button();
            this.btn_OrderDel = new System.Windows.Forms.Button();
            this.btn_OrderUpdate = new System.Windows.Forms.Button();
            this.btn_OrderAdd = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gb_CRUD = new System.Windows.Forms.GroupBox();
            this.gb_Excel = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_DetailUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_ProdImg = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nu_LogCount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nu_PsyCount = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Company = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nu_OrderCount = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.txt_ProdName = new System.Windows.Forms.TextBox();
            this.btn_DetailAdd = new System.Windows.Forms.Button();
            this.btn_DetailDelete = new System.Windows.Forms.Button();
            this.lbl_valuez = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetailInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_Company.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Limit)).BeginInit();
            this.gb_Category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gb_CRUD.SuspendLayout();
            this.gb_Excel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ProdImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_LogCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_PsyCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_OrderCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DetailInfo
            // 
            this.dgv_DetailInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DetailInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_DetailInfo.Location = new System.Drawing.Point(0, 0);
            this.dgv_DetailInfo.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_DetailInfo.Name = "dgv_DetailInfo";
            this.dgv_DetailInfo.RowTemplate.Height = 23;
            this.dgv_DetailInfo.Size = new System.Drawing.Size(500, 373);
            this.dgv_DetailInfo.TabIndex = 40;
            this.dgv_DetailInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DetailInfo_CellDoubleClick);
            // 
            // dgv_OrderInfo
            // 
            this.dgv_OrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_OrderInfo.Location = new System.Drawing.Point(0, 0);
            this.dgv_OrderInfo.Name = "dgv_OrderInfo";
            this.dgv_OrderInfo.RowTemplate.Height = 23;
            this.dgv_OrderInfo.Size = new System.Drawing.Size(949, 375);
            this.dgv_OrderInfo.TabIndex = 39;
            this.dgv_OrderInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_OrderInfo_CellContentClick);
            this.dgv_OrderInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_OrderInfo_CellDoubleClick);
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
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(11, 20);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(112, 38);
            this.button16.TabIndex = 47;
            this.button16.Text = "엑셀 가져오기";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbx_Category);
            this.groupBox1.Controls.Add(this.cbx_Company);
            this.groupBox1.Controls.Add(this.gb_Company);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_To);
            this.groupBox1.Controls.Add(this.dtp_From);
            this.groupBox1.Controls.Add(this.comboBox18);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.nu_Limit);
            this.groupBox1.Controls.Add(this.cbx_Limit);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.gb_Category);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 239);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색조건";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "신청대기",
            "신청완료"});
            this.comboBox1.Location = new System.Drawing.Point(87, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 20);
            this.comboBox1.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 68;
            this.label7.Text = "발주상태";
            // 
            // cbx_Category
            // 
            this.cbx_Category.AutoSize = true;
            this.cbx_Category.Location = new System.Drawing.Point(112, 47);
            this.cbx_Category.Name = "cbx_Category";
            this.cbx_Category.Size = new System.Drawing.Size(15, 14);
            this.cbx_Category.TabIndex = 66;
            this.cbx_Category.UseVisualStyleBackColor = true;
            this.cbx_Category.CheckedChanged += new System.EventHandler(this.cbx_Category_CheckedChanged);
            // 
            // cbx_Company
            // 
            this.cbx_Company.AutoSize = true;
            this.cbx_Company.Location = new System.Drawing.Point(305, 47);
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
            this.gb_Company.Location = new System.Drawing.Point(229, 48);
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
            this.label4.Location = new System.Drawing.Point(194, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "~";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "기간";
            // 
            // dtp_To
            // 
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_To.Location = new System.Drawing.Point(211, 163);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(105, 21);
            this.dtp_To.TabIndex = 24;
            this.dtp_To.ValueChanged += new System.EventHandler(this.dtp_To_ValueChanged);
            // 
            // dtp_From
            // 
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_From.Location = new System.Drawing.Point(87, 163);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(105, 21);
            this.dtp_From.TabIndex = 23;
            this.dtp_From.ValueChanged += new System.EventHandler(this.dtp_From_ValueChanged);
            // 
            // comboBox18
            // 
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Items.AddRange(new object[] {
            "",
            "진행",
            "완료"});
            this.comboBox18.Location = new System.Drawing.Point(252, 204);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(86, 20);
            this.comboBox18.TabIndex = 16;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(186, 208);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(53, 12);
            this.label29.TabIndex = 15;
            this.label29.Text = "발주결과";
            // 
            // nu_Limit
            // 
            this.nu_Limit.Enabled = false;
            this.nu_Limit.Location = new System.Drawing.Point(97, 19);
            this.nu_Limit.Name = "nu_Limit";
            this.nu_Limit.Size = new System.Drawing.Size(61, 21);
            this.nu_Limit.TabIndex = 1;
            // 
            // cbx_Limit
            // 
            this.cbx_Limit.AutoSize = true;
            this.cbx_Limit.Location = new System.Drawing.Point(12, 21);
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
            this.gb_Category.Location = new System.Drawing.Point(23, 48);
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
            // btn_GetAllOrder
            // 
            this.btn_GetAllOrder.Location = new System.Drawing.Point(12, 20);
            this.btn_GetAllOrder.Name = "btn_GetAllOrder";
            this.btn_GetAllOrder.Size = new System.Drawing.Size(423, 71);
            this.btn_GetAllOrder.TabIndex = 44;
            this.btn_GetAllOrder.Text = "모든 발주 보기";
            this.btn_GetAllOrder.UseVisualStyleBackColor = true;
            this.btn_GetAllOrder.Click += new System.EventHandler(this.btn_GetAllOrder_Click);
            // 
            // btn_OrderDel
            // 
            this.btn_OrderDel.Location = new System.Drawing.Point(12, 317);
            this.btn_OrderDel.Name = "btn_OrderDel";
            this.btn_OrderDel.Size = new System.Drawing.Size(423, 71);
            this.btn_OrderDel.TabIndex = 43;
            this.btn_OrderDel.Text = "삭제";
            this.btn_OrderDel.UseVisualStyleBackColor = true;
            this.btn_OrderDel.Click += new System.EventHandler(this.btn_OrderDel_Click);
            // 
            // btn_OrderUpdate
            // 
            this.btn_OrderUpdate.Location = new System.Drawing.Point(12, 218);
            this.btn_OrderUpdate.Name = "btn_OrderUpdate";
            this.btn_OrderUpdate.Size = new System.Drawing.Size(423, 71);
            this.btn_OrderUpdate.TabIndex = 42;
            this.btn_OrderUpdate.Text = "수정";
            this.btn_OrderUpdate.UseVisualStyleBackColor = true;
            this.btn_OrderUpdate.Click += new System.EventHandler(this.btn_OrderUpdate_Click);
            // 
            // btn_OrderAdd
            // 
            this.btn_OrderAdd.Location = new System.Drawing.Point(12, 119);
            this.btn_OrderAdd.Name = "btn_OrderAdd";
            this.btn_OrderAdd.Size = new System.Drawing.Size(423, 71);
            this.btn_OrderAdd.TabIndex = 41;
            this.btn_OrderAdd.Text = "추가";
            this.btn_OrderAdd.UseVisualStyleBackColor = true;
            this.btn_OrderAdd.Click += new System.EventHandler(this.btn_OrderAdd_Click);
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
            this.splitContainer1.Size = new System.Drawing.Size(1419, 758);
            this.splitContainer1.SplitterDistance = 460;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 62;
            // 
            // gb_CRUD
            // 
            this.gb_CRUD.Controls.Add(this.btn_GetAllOrder);
            this.gb_CRUD.Controls.Add(this.btn_OrderAdd);
            this.gb_CRUD.Controls.Add(this.btn_OrderUpdate);
            this.gb_CRUD.Controls.Add(this.btn_OrderDel);
            this.gb_CRUD.Location = new System.Drawing.Point(12, 350);
            this.gb_CRUD.Name = "gb_CRUD";
            this.gb_CRUD.Size = new System.Drawing.Size(440, 396);
            this.gb_CRUD.TabIndex = 63;
            this.gb_CRUD.TabStop = false;
            this.gb_CRUD.Text = "메뉴";
            // 
            // gb_Excel
            // 
            this.gb_Excel.Controls.Add(this.button16);
            this.gb_Excel.Controls.Add(this.button15);
            this.gb_Excel.Location = new System.Drawing.Point(12, 261);
            this.gb_Excel.Name = "gb_Excel";
            this.gb_Excel.Size = new System.Drawing.Size(440, 71);
            this.gb_Excel.TabIndex = 62;
            this.gb_Excel.TabStop = false;
            this.gb_Excel.Text = "엑셀";
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
            this.splitContainer2.Panel1.Controls.Add(this.dgv_OrderInfo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn_DetailUpdate);
            this.splitContainer2.Panel2.Controls.Add(this.dgv_DetailInfo);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Panel2.Controls.Add(this.btn_DetailAdd);
            this.splitContainer2.Panel2.Controls.Add(this.btn_DetailDelete);
            this.splitContainer2.Size = new System.Drawing.Size(949, 758);
            this.splitContainer2.SplitterDistance = 375;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 0;
            // 
            // btn_DetailUpdate
            // 
            this.btn_DetailUpdate.Location = new System.Drawing.Point(690, 328);
            this.btn_DetailUpdate.Name = "btn_DetailUpdate";
            this.btn_DetailUpdate.Size = new System.Drawing.Size(87, 33);
            this.btn_DetailUpdate.TabIndex = 58;
            this.btn_DetailUpdate.Text = "수정";
            this.btn_DetailUpdate.UseVisualStyleBackColor = true;
            this.btn_DetailUpdate.Click += new System.EventHandler(this.btn_DetailUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_valuez);
            this.panel1.Controls.Add(this.pb_ProdImg);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.nu_LogCount);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.nu_PsyCount);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_Company);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.nu_OrderCount);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txt_Category);
            this.panel1.Controls.Add(this.txt_ProdName);
            this.panel1.Location = new System.Drawing.Point(503, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 316);
            this.panel1.TabIndex = 59;
            // 
            // pb_ProdImg
            // 
            this.pb_ProdImg.Location = new System.Drawing.Point(142, 3);
            this.pb_ProdImg.Name = "pb_ProdImg";
            this.pb_ProdImg.Size = new System.Drawing.Size(174, 119);
            this.pb_ProdImg.TabIndex = 41;
            this.pb_ProdImg.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 42;
            this.label8.Text = "물품명";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 43;
            this.label9.Text = "카테고리";
            // 
            // nu_LogCount
            // 
            this.nu_LogCount.Enabled = false;
            this.nu_LogCount.Location = new System.Drawing.Point(338, 218);
            this.nu_LogCount.Name = "nu_LogCount";
            this.nu_LogCount.ReadOnly = true;
            this.nu_LogCount.Size = new System.Drawing.Size(76, 21);
            this.nu_LogCount.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(273, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 44;
            this.label10.Text = "현재 갯수";
            // 
            // nu_PsyCount
            // 
            this.nu_PsyCount.Enabled = false;
            this.nu_PsyCount.Location = new System.Drawing.Point(338, 179);
            this.nu_PsyCount.Name = "nu_PsyCount";
            this.nu_PsyCount.ReadOnly = true;
            this.nu_PsyCount.Size = new System.Drawing.Size(76, 21);
            this.nu_PsyCount.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(273, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 12);
            this.label11.TabIndex = 45;
            this.label11.Text = "논리 갯수";
            // 
            // txt_Company
            // 
            this.txt_Company.Enabled = false;
            this.txt_Company.Location = new System.Drawing.Point(97, 218);
            this.txt_Company.Name = "txt_Company";
            this.txt_Company.ReadOnly = true;
            this.txt_Company.Size = new System.Drawing.Size(137, 21);
            this.txt_Company.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 46;
            this.label12.Text = "주문수량";
            // 
            // nu_OrderCount
            // 
            this.nu_OrderCount.Location = new System.Drawing.Point(338, 140);
            this.nu_OrderCount.Name = "nu_OrderCount";
            this.nu_OrderCount.Size = new System.Drawing.Size(76, 21);
            this.nu_OrderCount.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 47;
            this.label13.Text = "거래처명";
            // 
            // txt_Category
            // 
            this.txt_Category.Enabled = false;
            this.txt_Category.Location = new System.Drawing.Point(97, 179);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.ReadOnly = true;
            this.txt_Category.Size = new System.Drawing.Size(137, 21);
            this.txt_Category.TabIndex = 49;
            // 
            // txt_ProdName
            // 
            this.txt_ProdName.Enabled = false;
            this.txt_ProdName.Location = new System.Drawing.Point(97, 140);
            this.txt_ProdName.Name = "txt_ProdName";
            this.txt_ProdName.ReadOnly = true;
            this.txt_ProdName.Size = new System.Drawing.Size(137, 21);
            this.txt_ProdName.TabIndex = 48;
            // 
            // btn_DetailAdd
            // 
            this.btn_DetailAdd.Location = new System.Drawing.Point(561, 328);
            this.btn_DetailAdd.Name = "btn_DetailAdd";
            this.btn_DetailAdd.Size = new System.Drawing.Size(87, 33);
            this.btn_DetailAdd.TabIndex = 56;
            this.btn_DetailAdd.Text = "추가";
            this.btn_DetailAdd.UseVisualStyleBackColor = true;
            this.btn_DetailAdd.Click += new System.EventHandler(this.btn_DetailAdd_Click);
            // 
            // btn_DetailDelete
            // 
            this.btn_DetailDelete.Location = new System.Drawing.Point(819, 328);
            this.btn_DetailDelete.Name = "btn_DetailDelete";
            this.btn_DetailDelete.Size = new System.Drawing.Size(87, 33);
            this.btn_DetailDelete.TabIndex = 57;
            this.btn_DetailDelete.Text = "삭제";
            this.btn_DetailDelete.UseVisualStyleBackColor = true;
            this.btn_DetailDelete.Click += new System.EventHandler(this.btn_DetailDelete_Click);
            // 
            // lbl_valuez
            // 
            this.lbl_valuez.Location = new System.Drawing.Point(34, 256);
            this.lbl_valuez.Name = "lbl_valuez";
            this.lbl_valuez.Size = new System.Drawing.Size(380, 49);
            this.lbl_valuez.TabIndex = 56;
            this.lbl_valuez.Text = "label14";
            // 
            // OrderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 758);
            this.Controls.Add(this.splitContainer1);
            this.Name = "OrderManager";
            this.Text = "OrderManager";
            this.Load += new System.EventHandler(this.OrderManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetailInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_Company.ResumeLayout(false);
            this.gb_Company.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Limit)).EndInit();
            this.gb_Category.ResumeLayout(false);
            this.gb_Category.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gb_CRUD.ResumeLayout(false);
            this.gb_Excel.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ProdImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_LogCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_PsyCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_OrderCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DetailInfo;
        private System.Windows.Forms.DataGridView dgv_OrderInfo;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.ComboBox comboBox18;
        private System.Windows.Forms.ComboBox cbo_cateCate;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nu_Limit;
        private System.Windows.Forms.ComboBox cbo_compComp;
        private System.Windows.Forms.CheckBox cbx_Limit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_GetAllOrder;
        private System.Windows.Forms.Button btn_OrderDel;
        private System.Windows.Forms.Button btn_OrderUpdate;
        private System.Windows.Forms.Button btn_OrderAdd;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gb_CRUD;
        private System.Windows.Forms.GroupBox gb_Excel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox cbo_cateComp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_compCate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb_Company;
        private System.Windows.Forms.CheckBox cbx_Company;
        private System.Windows.Forms.GroupBox gb_Category;
        private System.Windows.Forms.CheckBox cbx_Category;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_DetailUpdate;
        private System.Windows.Forms.Button btn_DetailDelete;
        private System.Windows.Forms.Button btn_DetailAdd;
        private System.Windows.Forms.NumericUpDown nu_LogCount;
        private System.Windows.Forms.NumericUpDown nu_PsyCount;
        private System.Windows.Forms.TextBox txt_Company;
        private System.Windows.Forms.NumericUpDown nu_OrderCount;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.TextBox txt_ProdName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pb_ProdImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_valuez;
    }
}