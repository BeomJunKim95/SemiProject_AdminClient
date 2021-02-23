
namespace AdminClient
{
    partial class Product_SearchAdd
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
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_AddList = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cbo_keyword = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_keyword = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_AddApply = new System.Windows.Forms.Button();
            this.dgv_SearchList = new System.Windows.Forms.DataGridView();
            this.cbx_Category = new System.Windows.Forms.CheckBox();
            this.cbx_Company = new System.Windows.Forms.CheckBox();
            this.gb_Company = new System.Windows.Forms.GroupBox();
            this.cbo_compComp = new System.Windows.Forms.ComboBox();
            this.cbo_compCate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_Category = new System.Windows.Forms.GroupBox();
            this.cbo_cateComp = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbo_cateCate = new System.Windows.Forms.ComboBox();
            this.nu_Limit = new System.Windows.Forms.NumericUpDown();
            this.cbx_Limit = new System.Windows.Forms.CheckBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_ProdInfo = new System.Windows.Forms.GroupBox();
            this.cbo_compT = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_cateT = new System.Windows.Forms.ComboBox();
            this.cbo_gubunT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_detail = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_state = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_Divs = new System.Windows.Forms.ComboBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.cbo_detailCompany = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_sortProdID = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_SortPrice = new System.Windows.Forms.Button();
            this.cbo_detailCategory = new System.Windows.Forms.ComboBox();
            this.btn_sortCategory = new System.Windows.Forms.Button();
            this.btn_sortCompany = new System.Windows.Forms.Button();
            this.btn_MinDanger = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbx_ProdInfo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AddList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchList)).BeginInit();
            this.gb_Company.SuspendLayout();
            this.gb_Category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Limit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_ProdInfo.SuspendLayout();
            this.gb_detail.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(471, 447);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 19);
            this.label11.TabIndex = 42;
            this.label11.Text = "추가한 품목 리스트";
            // 
            // dgv_AddList
            // 
            this.dgv_AddList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_AddList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AddList.Location = new System.Drawing.Point(473, 471);
            this.dgv_AddList.Name = "dgv_AddList";
            this.dgv_AddList.RowTemplate.Height = 23;
            this.dgv_AddList.Size = new System.Drawing.Size(727, 334);
            this.dgv_AddList.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(471, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "조회된 품목 리스트";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(988, 408);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(107, 40);
            this.btn_Delete.TabIndex = 36;
            this.btn_Delete.Text = "빼기\r\n△";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(778, 408);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(107, 40);
            this.btn_Add.TabIndex = 35;
            this.btn_Add.Text = "추가\r\n▽";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cbo_keyword
            // 
            this.cbo_keyword.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_keyword.FormattingEnabled = true;
            this.cbo_keyword.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cbo_keyword.Location = new System.Drawing.Point(73, 20);
            this.cbo_keyword.Name = "cbo_keyword";
            this.cbo_keyword.Size = new System.Drawing.Size(79, 20);
            this.cbo_keyword.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "검색방식";
            // 
            // txt_keyword
            // 
            this.txt_keyword.Location = new System.Drawing.Point(159, 20);
            this.txt_keyword.Name = "txt_keyword";
            this.txt_keyword.Size = new System.Drawing.Size(209, 21);
            this.txt_keyword.TabIndex = 28;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(1138, 825);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(62, 50);
            this.btn_Close.TabIndex = 27;
            this.btn_Close.Text = "닫기";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_AddApply
            // 
            this.btn_AddApply.Location = new System.Drawing.Point(988, 825);
            this.btn_AddApply.Name = "btn_AddApply";
            this.btn_AddApply.Size = new System.Drawing.Size(122, 50);
            this.btn_AddApply.TabIndex = 26;
            this.btn_AddApply.Text = "적용\r\n";
            this.btn_AddApply.UseVisualStyleBackColor = true;
            this.btn_AddApply.Click += new System.EventHandler(this.btn_AddApply_Click);
            // 
            // dgv_SearchList
            // 
            this.dgv_SearchList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_SearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchList.Location = new System.Drawing.Point(473, 48);
            this.dgv_SearchList.Name = "dgv_SearchList";
            this.dgv_SearchList.RowTemplate.Height = 23;
            this.dgv_SearchList.Size = new System.Drawing.Size(727, 334);
            this.dgv_SearchList.TabIndex = 25;
            // 
            // cbx_Category
            // 
            this.cbx_Category.AutoSize = true;
            this.cbx_Category.Location = new System.Drawing.Point(99, 62);
            this.cbx_Category.Name = "cbx_Category";
            this.cbx_Category.Size = new System.Drawing.Size(15, 14);
            this.cbx_Category.TabIndex = 70;
            this.cbx_Category.UseVisualStyleBackColor = true;
            this.cbx_Category.CheckedChanged += new System.EventHandler(this.cbx_Category_CheckedChanged);
            // 
            // cbx_Company
            // 
            this.cbx_Company.AutoSize = true;
            this.cbx_Company.Location = new System.Drawing.Point(293, 63);
            this.cbx_Company.Name = "cbx_Company";
            this.cbx_Company.Size = new System.Drawing.Size(15, 14);
            this.cbx_Company.TabIndex = 71;
            this.cbx_Company.UseVisualStyleBackColor = true;
            this.cbx_Company.CheckedChanged += new System.EventHandler(this.cbx_Company_CheckedChanged);
            // 
            // gb_Company
            // 
            this.gb_Company.Controls.Add(this.cbo_compComp);
            this.gb_Company.Controls.Add(this.cbo_compCate);
            this.gb_Company.Controls.Add(this.label1);
            this.gb_Company.Controls.Add(this.label2);
            this.gb_Company.Enabled = false;
            this.gb_Company.Location = new System.Drawing.Point(217, 63);
            this.gb_Company.Name = "gb_Company";
            this.gb_Company.Size = new System.Drawing.Size(200, 103);
            this.gb_Company.TabIndex = 69;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "카테고리";
            // 
            // gb_Category
            // 
            this.gb_Category.Controls.Add(this.cbo_cateComp);
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
            // cbo_cateComp
            // 
            this.cbo_cateComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cateComp.FormattingEnabled = true;
            this.cbo_cateComp.Location = new System.Drawing.Point(73, 62);
            this.cbo_cateComp.Name = "cbo_cateComp";
            this.cbo_cateComp.Size = new System.Drawing.Size(121, 20);
            this.cbo_cateComp.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 21;
            this.label12.Text = "카테고리";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 29;
            this.label13.Text = "유통사";
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
            // nu_Limit
            // 
            this.nu_Limit.Enabled = false;
            this.nu_Limit.Location = new System.Drawing.Point(104, 25);
            this.nu_Limit.Name = "nu_Limit";
            this.nu_Limit.Size = new System.Drawing.Size(61, 21);
            this.nu_Limit.TabIndex = 73;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_ProdInfo);
            this.groupBox1.Controls.Add(this.gb_ProdInfo);
            this.groupBox1.Controls.Add(this.cbx_Company);
            this.groupBox1.Controls.Add(this.cbx_Category);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbx_Limit);
            this.groupBox1.Controls.Add(this.nu_Limit);
            this.groupBox1.Controls.Add(this.gb_Category);
            this.groupBox1.Controls.Add(this.gb_Company);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 282);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색조건";
            // 
            // gb_ProdInfo
            // 
            this.gb_ProdInfo.Controls.Add(this.cbo_compT);
            this.gb_ProdInfo.Controls.Add(this.label15);
            this.gb_ProdInfo.Controls.Add(this.label14);
            this.gb_ProdInfo.Controls.Add(this.label10);
            this.gb_ProdInfo.Controls.Add(this.cbo_cateT);
            this.gb_ProdInfo.Controls.Add(this.cbo_gubunT);
            this.gb_ProdInfo.Enabled = false;
            this.gb_ProdInfo.Location = new System.Drawing.Point(11, 172);
            this.gb_ProdInfo.Name = "gb_ProdInfo";
            this.gb_ProdInfo.Size = new System.Drawing.Size(406, 78);
            this.gb_ProdInfo.TabIndex = 77;
            this.gb_ProdInfo.TabStop = false;
            this.gb_ProdInfo.Text = "물품정보";
            // 
            // cbo_compT
            // 
            this.cbo_compT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_compT.FormattingEnabled = true;
            this.cbo_compT.Location = new System.Drawing.Point(278, 39);
            this.cbo_compT.Name = "cbo_compT";
            this.cbo_compT.Size = new System.Drawing.Size(121, 20);
            this.cbo_compT.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(278, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 31;
            this.label15.Text = "유통사";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(147, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 31;
            this.label14.Text = "카테고리";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "구분";
            // 
            // cbo_cateT
            // 
            this.cbo_cateT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cateT.FormattingEnabled = true;
            this.cbo_cateT.Location = new System.Drawing.Point(147, 39);
            this.cbo_cateT.Name = "cbo_cateT";
            this.cbo_cateT.Size = new System.Drawing.Size(121, 20);
            this.cbo_cateT.TabIndex = 32;
            this.cbo_cateT.SelectedIndexChanged += new System.EventHandler(this.cbo_cateT_SelectedIndexChanged);
            // 
            // cbo_gubunT
            // 
            this.cbo_gubunT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_gubunT.FormattingEnabled = true;
            this.cbo_gubunT.Location = new System.Drawing.Point(16, 39);
            this.cbo_gubunT.Name = "cbo_gubunT";
            this.cbo_gubunT.Size = new System.Drawing.Size(121, 20);
            this.cbo_gubunT.TabIndex = 32;
            this.cbo_gubunT.SelectedIndexChanged += new System.EventHandler(this.cbo_gubunT_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(9, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 12);
            this.label4.TabIndex = 76;
            this.label4.Text = "※미선택시 모든 물품을 조회하며 양이 많을 경우 시간이 걸릴 수 있습니다.";
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.label9);
            this.gb_detail.Controls.Add(this.cbo_state);
            this.gb_detail.Controls.Add(this.label8);
            this.gb_detail.Controls.Add(this.cbo_Divs);
            this.gb_detail.Controls.Add(this.btn_apply);
            this.gb_detail.Controls.Add(this.cbo_detailCompany);
            this.gb_detail.Controls.Add(this.label5);
            this.gb_detail.Controls.Add(this.btn_sortProdID);
            this.gb_detail.Controls.Add(this.label6);
            this.gb_detail.Controls.Add(this.btn_SortPrice);
            this.gb_detail.Controls.Add(this.cbo_detailCategory);
            this.gb_detail.Controls.Add(this.btn_sortCategory);
            this.gb_detail.Controls.Add(this.btn_sortCompany);
            this.gb_detail.Controls.Add(this.label3);
            this.gb_detail.Controls.Add(this.txt_keyword);
            this.gb_detail.Controls.Add(this.cbo_keyword);
            this.gb_detail.Enabled = false;
            this.gb_detail.Location = new System.Drawing.Point(15, 344);
            this.gb_detail.Name = "gb_detail";
            this.gb_detail.Size = new System.Drawing.Size(434, 175);
            this.gb_detail.TabIndex = 76;
            this.gb_detail.TabStop = false;
            this.gb_detail.Text = "세부검색";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 78;
            this.label9.Text = "판매여부";
            // 
            // cbo_state
            // 
            this.cbo_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_state.FormattingEnabled = true;
            this.cbo_state.Location = new System.Drawing.Point(73, 98);
            this.cbo_state.Name = "cbo_state";
            this.cbo_state.Size = new System.Drawing.Size(121, 20);
            this.cbo_state.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 76;
            this.label8.Text = "구분";
            // 
            // cbo_Divs
            // 
            this.cbo_Divs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Divs.FormattingEnabled = true;
            this.cbo_Divs.Location = new System.Drawing.Point(247, 98);
            this.cbo_Divs.Name = "cbo_Divs";
            this.cbo_Divs.Size = new System.Drawing.Size(121, 20);
            this.cbo_Divs.TabIndex = 77;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(374, 20);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(54, 60);
            this.btn_apply.TabIndex = 75;
            this.btn_apply.Text = "조건\r\n\r\n적용";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // cbo_detailCompany
            // 
            this.cbo_detailCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_detailCompany.FormattingEnabled = true;
            this.cbo_detailCompany.Location = new System.Drawing.Point(247, 60);
            this.cbo_detailCompany.Name = "cbo_detailCompany";
            this.cbo_detailCompany.Size = new System.Drawing.Size(121, 20);
            this.cbo_detailCompany.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 71;
            this.label5.Text = "카테고리";
            // 
            // btn_sortProdID
            // 
            this.btn_sortProdID.Location = new System.Drawing.Point(8, 124);
            this.btn_sortProdID.Name = "btn_sortProdID";
            this.btn_sortProdID.Size = new System.Drawing.Size(105, 40);
            this.btn_sortProdID.TabIndex = 35;
            this.btn_sortProdID.Tag = "sort";
            this.btn_sortProdID.Text = "품목코드 정렬";
            this.btn_sortProdID.UseVisualStyleBackColor = true;
            this.btn_sortProdID.Click += new System.EventHandler(this.btn_sortProdID_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 73;
            this.label6.Text = "유통사";
            // 
            // btn_SortPrice
            // 
            this.btn_SortPrice.Location = new System.Drawing.Point(323, 124);
            this.btn_SortPrice.Name = "btn_SortPrice";
            this.btn_SortPrice.Size = new System.Drawing.Size(105, 40);
            this.btn_SortPrice.TabIndex = 34;
            this.btn_SortPrice.Tag = "sort";
            this.btn_SortPrice.Text = "단가 정렬";
            this.btn_SortPrice.UseVisualStyleBackColor = true;
            this.btn_SortPrice.Click += new System.EventHandler(this.btn_SortPrice_Click);
            // 
            // cbo_detailCategory
            // 
            this.cbo_detailCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_detailCategory.FormattingEnabled = true;
            this.cbo_detailCategory.Location = new System.Drawing.Point(73, 60);
            this.cbo_detailCategory.Name = "cbo_detailCategory";
            this.cbo_detailCategory.Size = new System.Drawing.Size(121, 20);
            this.cbo_detailCategory.TabIndex = 72;
            // 
            // btn_sortCategory
            // 
            this.btn_sortCategory.Location = new System.Drawing.Point(218, 124);
            this.btn_sortCategory.Name = "btn_sortCategory";
            this.btn_sortCategory.Size = new System.Drawing.Size(105, 40);
            this.btn_sortCategory.TabIndex = 33;
            this.btn_sortCategory.Tag = "sort";
            this.btn_sortCategory.Text = "카테고리 정렬";
            this.btn_sortCategory.UseVisualStyleBackColor = true;
            this.btn_sortCategory.Click += new System.EventHandler(this.btn_sortCategory_Click);
            // 
            // btn_sortCompany
            // 
            this.btn_sortCompany.Location = new System.Drawing.Point(113, 124);
            this.btn_sortCompany.Name = "btn_sortCompany";
            this.btn_sortCompany.Size = new System.Drawing.Size(105, 40);
            this.btn_sortCompany.TabIndex = 32;
            this.btn_sortCompany.Tag = "sort";
            this.btn_sortCompany.Text = "유통사별 정렬";
            this.btn_sortCompany.UseVisualStyleBackColor = true;
            this.btn_sortCompany.Click += new System.EventHandler(this.btn_sortCompany_Click);
            // 
            // btn_MinDanger
            // 
            this.btn_MinDanger.Location = new System.Drawing.Point(6, 34);
            this.btn_MinDanger.Name = "btn_MinDanger";
            this.btn_MinDanger.Size = new System.Drawing.Size(408, 52);
            this.btn_MinDanger.TabIndex = 32;
            this.btn_MinDanger.Text = "수량부족 물품 리스트";
            this.btn_MinDanger.UseVisualStyleBackColor = true;
            this.btn_MinDanger.Click += new System.EventHandler(this.btn_MinDanger_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_MinDanger);
            this.groupBox3.Location = new System.Drawing.Point(15, 577);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 195);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "간편검색";
            // 
            // cbx_ProdInfo
            // 
            this.cbx_ProdInfo.AutoSize = true;
            this.cbx_ProdInfo.Location = new System.Drawing.Point(71, 171);
            this.cbx_ProdInfo.Name = "cbx_ProdInfo";
            this.cbx_ProdInfo.Size = new System.Drawing.Size(15, 14);
            this.cbx_ProdInfo.TabIndex = 78;
            this.cbx_ProdInfo.UseVisualStyleBackColor = true;
            this.cbx_ProdInfo.CheckedChanged += new System.EventHandler(this.cbx_ProdInfo_CheckedChanged);
            // 
            // Product_SearchAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 897);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_detail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgv_AddList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_AddApply);
            this.Controls.Add(this.dgv_SearchList);
            this.Name = "Product_SearchAdd";
            this.Text = "Product_SearchAdd";
            this.Load += new System.EventHandler(this.Product_SearchAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AddList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchList)).EndInit();
            this.gb_Company.ResumeLayout(false);
            this.gb_Company.PerformLayout();
            this.gb_Category.ResumeLayout(false);
            this.gb_Category.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Limit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_ProdInfo.ResumeLayout(false);
            this.gb_ProdInfo.PerformLayout();
            this.gb_detail.ResumeLayout(false);
            this.gb_detail.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_AddList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cbo_keyword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_keyword;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_AddApply;
        private System.Windows.Forms.DataGridView dgv_SearchList;
        private System.Windows.Forms.CheckBox cbx_Category;
        private System.Windows.Forms.CheckBox cbx_Company;
        private System.Windows.Forms.GroupBox gb_Company;
        private System.Windows.Forms.ComboBox cbo_compComp;
        private System.Windows.Forms.ComboBox cbo_compCate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_Category;
        private System.Windows.Forms.ComboBox cbo_cateComp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbo_cateCate;
        private System.Windows.Forms.NumericUpDown nu_Limit;
        private System.Windows.Forms.CheckBox cbx_Limit;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb_detail;
        private System.Windows.Forms.ComboBox cbo_detailCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_sortProdID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_SortPrice;
        private System.Windows.Forms.ComboBox cbo_detailCategory;
        private System.Windows.Forms.Button btn_sortCategory;
        private System.Windows.Forms.Button btn_sortCompany;
        private System.Windows.Forms.Button btn_MinDanger;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_state;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_Divs;
        private System.Windows.Forms.GroupBox gb_ProdInfo;
        private System.Windows.Forms.ComboBox cbo_compT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbo_cateT;
        private System.Windows.Forms.ComboBox cbo_gubunT;
        private System.Windows.Forms.CheckBox cbx_ProdInfo;
    }
}