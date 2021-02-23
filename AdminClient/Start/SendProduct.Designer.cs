
namespace AdminClient.Start
{
    partial class SendProduct
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Today = new System.Windows.Forms.Button();
            this.btn_NoSend = new System.Windows.Forms.Button();
            this.btn_SendAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_SetDate = new System.Windows.Forms.CheckBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_Limit = new System.Windows.Forms.CheckBox();
            this.nu_Limit = new System.Windows.Forms.NumericUpDown();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sortPrice = new System.Windows.Forms.Button();
            this.btn_sortstate = new System.Windows.Forms.Button();
            this.btn_sortDate = new System.Windows.Forms.Button();
            this.btn_sortCnt = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_Send = new System.Windows.Forms.Button();
            this.lbl_pID = new System.Windows.Forms.Label();
            this.txt_infoEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_infoReceiver = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_infoDetailAddr = new System.Windows.Forms.TextBox();
            this.txt_infoAddr = new System.Windows.Forms.TextBox();
            this.txt_infoPostcode = new System.Windows.Forms.TextBox();
            this.txt_infoTel = new System.Windows.Forms.TextBox();
            this.txt_infoID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Purchase = new System.Windows.Forms.DataGridView();
            this.dgv_ProductList = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Limit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.btn_SendAll);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1399, 799);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Today);
            this.groupBox3.Controls.Add(this.btn_NoSend);
            this.groupBox3.Location = new System.Drawing.Point(12, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 248);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "간편검색";
            // 
            // btn_Today
            // 
            this.btn_Today.Location = new System.Drawing.Point(16, 39);
            this.btn_Today.Name = "btn_Today";
            this.btn_Today.Size = new System.Drawing.Size(318, 42);
            this.btn_Today.TabIndex = 2;
            this.btn_Today.Text = "오늘 주문건";
            this.btn_Today.UseVisualStyleBackColor = true;
            this.btn_Today.Click += new System.EventHandler(this.btn_Today_Click);
            // 
            // btn_NoSend
            // 
            this.btn_NoSend.Location = new System.Drawing.Point(16, 87);
            this.btn_NoSend.Name = "btn_NoSend";
            this.btn_NoSend.Size = new System.Drawing.Size(318, 42);
            this.btn_NoSend.TabIndex = 1;
            this.btn_NoSend.Text = "비배송 주문건";
            this.btn_NoSend.UseVisualStyleBackColor = true;
            this.btn_NoSend.Click += new System.EventHandler(this.btn_NoSend_Click);
            // 
            // btn_SendAll
            // 
            this.btn_SendAll.Location = new System.Drawing.Point(12, 166);
            this.btn_SendAll.Name = "btn_SendAll";
            this.btn_SendAll.Size = new System.Drawing.Size(352, 56);
            this.btn_SendAll.TabIndex = 29;
            this.btn_SendAll.Text = "배송시작(일괄)";
            this.btn_SendAll.UseVisualStyleBackColor = true;
            this.btn_SendAll.Click += new System.EventHandler(this.btn_SendAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_SetDate);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbx_Limit);
            this.groupBox2.Controls.Add(this.nu_Limit);
            this.groupBox2.Controls.Add(this.dtp_To);
            this.groupBox2.Controls.Add(this.dtp_From);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 137);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "검색조건";
            // 
            // cbx_SetDate
            // 
            this.cbx_SetDate.AutoSize = true;
            this.cbx_SetDate.Location = new System.Drawing.Point(17, 94);
            this.cbx_SetDate.Name = "cbx_SetDate";
            this.cbx_SetDate.Size = new System.Drawing.Size(48, 16);
            this.cbx_SetDate.TabIndex = 30;
            this.cbx_SetDate.Text = "기간";
            this.cbx_SetDate.UseVisualStyleBackColor = true;
            this.cbx_SetDate.CheckedChanged += new System.EventHandler(this.cbx_SetDate_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(262, 24);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "~";
            // 
            // cbx_Limit
            // 
            this.cbx_Limit.AutoSize = true;
            this.cbx_Limit.Location = new System.Drawing.Point(19, 31);
            this.cbx_Limit.Name = "cbx_Limit";
            this.cbx_Limit.Size = new System.Drawing.Size(72, 16);
            this.cbx_Limit.TabIndex = 2;
            this.cbx_Limit.Text = "검색제한";
            this.cbx_Limit.UseVisualStyleBackColor = true;
            this.cbx_Limit.CheckedChanged += new System.EventHandler(this.cbx_Limit_CheckedChanged);
            // 
            // nu_Limit
            // 
            this.nu_Limit.Enabled = false;
            this.nu_Limit.Location = new System.Drawing.Point(97, 30);
            this.nu_Limit.Name = "nu_Limit";
            this.nu_Limit.Size = new System.Drawing.Size(61, 21);
            this.nu_Limit.TabIndex = 3;
            // 
            // dtp_To
            // 
            this.dtp_To.Enabled = false;
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_To.Location = new System.Drawing.Point(199, 92);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(105, 21);
            this.dtp_To.TabIndex = 28;
            // 
            // dtp_From
            // 
            this.dtp_From.Enabled = false;
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_From.Location = new System.Drawing.Point(72, 92);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(105, 21);
            this.dtp_From.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_sortPrice);
            this.groupBox1.Controls.Add(this.btn_sortstate);
            this.groupBox1.Controls.Add(this.btn_sortDate);
            this.groupBox1.Controls.Add(this.btn_sortCnt);
            this.groupBox1.Location = new System.Drawing.Point(12, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "정렬";
            // 
            // btn_sortPrice
            // 
            this.btn_sortPrice.Location = new System.Drawing.Point(262, 31);
            this.btn_sortPrice.Name = "btn_sortPrice";
            this.btn_sortPrice.Size = new System.Drawing.Size(75, 23);
            this.btn_sortPrice.TabIndex = 3;
            this.btn_sortPrice.Tag = "true|SumPrice";
            this.btn_sortPrice.Text = "가격순";
            this.btn_sortPrice.UseVisualStyleBackColor = true;
            this.btn_sortPrice.Click += new System.EventHandler(this.btn_Sorts);
            // 
            // btn_sortstate
            // 
            this.btn_sortstate.Location = new System.Drawing.Point(181, 31);
            this.btn_sortstate.Name = "btn_sortstate";
            this.btn_sortstate.Size = new System.Drawing.Size(75, 23);
            this.btn_sortstate.TabIndex = 2;
            this.btn_sortstate.Tag = "true|Common_Code";
            this.btn_sortstate.Text = "배송여부";
            this.btn_sortstate.UseVisualStyleBackColor = true;
            this.btn_sortstate.Click += new System.EventHandler(this.btn_Sorts);
            // 
            // btn_sortDate
            // 
            this.btn_sortDate.Location = new System.Drawing.Point(100, 31);
            this.btn_sortDate.Name = "btn_sortDate";
            this.btn_sortDate.Size = new System.Drawing.Size(75, 23);
            this.btn_sortDate.TabIndex = 1;
            this.btn_sortDate.Tag = "true|Purchase_Date";
            this.btn_sortDate.Text = "날짜순";
            this.btn_sortDate.UseVisualStyleBackColor = true;
            this.btn_sortDate.Click += new System.EventHandler(this.btn_Sorts);
            // 
            // btn_sortCnt
            // 
            this.btn_sortCnt.Location = new System.Drawing.Point(19, 31);
            this.btn_sortCnt.Name = "btn_sortCnt";
            this.btn_sortCnt.Size = new System.Drawing.Size(75, 23);
            this.btn_sortCnt.TabIndex = 0;
            this.btn_sortCnt.Tag = "true|Cnt";
            this.btn_sortCnt.Text = "물품갯수";
            this.btn_sortCnt.UseVisualStyleBackColor = true;
            this.btn_sortCnt.Click += new System.EventHandler(this.btn_Sorts);
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
            this.splitContainer2.Panel1.Controls.Add(this.btn_Send);
            this.splitContainer2.Panel1.Controls.Add(this.lbl_pID);
            this.splitContainer2.Panel1.Controls.Add(this.txt_infoEmail);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.txt_infoReceiver);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.txt_infoDetailAddr);
            this.splitContainer2.Panel1.Controls.Add(this.txt_infoAddr);
            this.splitContainer2.Panel1.Controls.Add(this.txt_infoPostcode);
            this.splitContainer2.Panel1.Controls.Add(this.txt_infoTel);
            this.splitContainer2.Panel1.Controls.Add(this.txt_infoID);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.dgv_Purchase);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgv_ProductList);
            this.splitContainer2.Size = new System.Drawing.Size(1012, 799);
            this.splitContainer2.SplitterDistance = 390;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 0;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(818, 341);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(130, 33);
            this.btn_Send.TabIndex = 32;
            this.btn_Send.Text = "배송시작";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // lbl_pID
            // 
            this.lbl_pID.Location = new System.Drawing.Point(838, 9);
            this.lbl_pID.Name = "lbl_pID";
            this.lbl_pID.Size = new System.Drawing.Size(162, 19);
            this.lbl_pID.TabIndex = 30;
            this.lbl_pID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_infoEmail
            // 
            this.txt_infoEmail.Enabled = false;
            this.txt_infoEmail.Location = new System.Drawing.Point(766, 142);
            this.txt_infoEmail.Name = "txt_infoEmail";
            this.txt_infoEmail.ReadOnly = true;
            this.txt_infoEmail.Size = new System.Drawing.Size(234, 21);
            this.txt_infoEmail.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(764, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "이메일";
            // 
            // txt_infoReceiver
            // 
            this.txt_infoReceiver.Enabled = false;
            this.txt_infoReceiver.Location = new System.Drawing.Point(766, 185);
            this.txt_infoReceiver.Name = "txt_infoReceiver";
            this.txt_infoReceiver.ReadOnly = true;
            this.txt_infoReceiver.Size = new System.Drawing.Size(234, 21);
            this.txt_infoReceiver.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(764, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "수령자";
            // 
            // txt_infoDetailAddr
            // 
            this.txt_infoDetailAddr.Enabled = false;
            this.txt_infoDetailAddr.Location = new System.Drawing.Point(766, 314);
            this.txt_infoDetailAddr.Name = "txt_infoDetailAddr";
            this.txt_infoDetailAddr.ReadOnly = true;
            this.txt_infoDetailAddr.Size = new System.Drawing.Size(234, 21);
            this.txt_infoDetailAddr.TabIndex = 24;
            // 
            // txt_infoAddr
            // 
            this.txt_infoAddr.Enabled = false;
            this.txt_infoAddr.Location = new System.Drawing.Point(766, 271);
            this.txt_infoAddr.Name = "txt_infoAddr";
            this.txt_infoAddr.ReadOnly = true;
            this.txt_infoAddr.Size = new System.Drawing.Size(234, 21);
            this.txt_infoAddr.TabIndex = 23;
            // 
            // txt_infoPostcode
            // 
            this.txt_infoPostcode.Enabled = false;
            this.txt_infoPostcode.Location = new System.Drawing.Point(766, 228);
            this.txt_infoPostcode.Name = "txt_infoPostcode";
            this.txt_infoPostcode.ReadOnly = true;
            this.txt_infoPostcode.Size = new System.Drawing.Size(234, 21);
            this.txt_infoPostcode.TabIndex = 22;
            // 
            // txt_infoTel
            // 
            this.txt_infoTel.Enabled = false;
            this.txt_infoTel.Location = new System.Drawing.Point(766, 99);
            this.txt_infoTel.Name = "txt_infoTel";
            this.txt_infoTel.ReadOnly = true;
            this.txt_infoTel.Size = new System.Drawing.Size(234, 21);
            this.txt_infoTel.TabIndex = 21;
            // 
            // txt_infoID
            // 
            this.txt_infoID.Enabled = false;
            this.txt_infoID.Location = new System.Drawing.Point(766, 56);
            this.txt_infoID.Name = "txt_infoID";
            this.txt_infoID.ReadOnly = true;
            this.txt_infoID.Size = new System.Drawing.Size(234, 21);
            this.txt_infoID.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(764, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "상세주소";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(764, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "주소";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "우편번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(764, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "전화번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "구매자";
            // 
            // dgv_Purchase
            // 
            this.dgv_Purchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Purchase.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_Purchase.Location = new System.Drawing.Point(0, 0);
            this.dgv_Purchase.Name = "dgv_Purchase";
            this.dgv_Purchase.RowTemplate.Height = 23;
            this.dgv_Purchase.Size = new System.Drawing.Size(758, 390);
            this.dgv_Purchase.TabIndex = 0;
            this.dgv_Purchase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Purchase_CellDoubleClick);
            // 
            // dgv_ProductList
            // 
            this.dgv_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ProductList.Location = new System.Drawing.Point(0, 0);
            this.dgv_ProductList.Name = "dgv_ProductList";
            this.dgv_ProductList.RowTemplate.Height = 23;
            this.dgv_ProductList.Size = new System.Drawing.Size(1012, 399);
            this.dgv_ProductList.TabIndex = 0;
            // 
            // SendProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 799);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SendProduct";
            this.Text = "SendProduct";
            this.Load += new System.EventHandler(this.SendProduct_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Limit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgv_Purchase;
        private System.Windows.Forms.DataGridView dgv_ProductList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_sortDate;
        private System.Windows.Forms.Button btn_sortCnt;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.NumericUpDown nu_Limit;
        private System.Windows.Forms.CheckBox cbx_Limit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Today;
        private System.Windows.Forms.Button btn_NoSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbx_SetDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.Button btn_sortPrice;
        private System.Windows.Forms.Button btn_sortstate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_infoEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_infoReceiver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_infoDetailAddr;
        private System.Windows.Forms.TextBox txt_infoAddr;
        private System.Windows.Forms.TextBox txt_infoPostcode;
        private System.Windows.Forms.TextBox txt_infoTel;
        private System.Windows.Forms.TextBox txt_infoID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SendAll;
        private System.Windows.Forms.Label lbl_pID;
        private System.Windows.Forms.Button btn_Send;
    }
}