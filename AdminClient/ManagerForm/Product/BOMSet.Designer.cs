
namespace AdminClient
{
    partial class BOMSet
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
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCountUpdate = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_sherch = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ben_Close = new System.Windows.Forms.Button();
            this.dgv_BOMList = new System.Windows.Forms.DataGridView();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BOMList)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(177, 575);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 50);
            this.button6.TabIndex = 46;
            this.button6.Text = "삭제";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "품목명 :";
            // 
            // btnCountUpdate
            // 
            this.btnCountUpdate.Location = new System.Drawing.Point(54, 575);
            this.btnCountUpdate.Name = "btnCountUpdate";
            this.btnCountUpdate.Size = new System.Drawing.Size(80, 50);
            this.btnCountUpdate.TabIndex = 40;
            this.btnCountUpdate.Text = "수정";
            this.btnCountUpdate.UseVisualStyleBackColor = true;
            this.btnCountUpdate.Click += new System.EventHandler(this.btnCountUpdate_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(68, 480);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 21);
            this.numericUpDown1.TabIndex = 39;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_sherch
            // 
            this.btn_sherch.Location = new System.Drawing.Point(320, 420);
            this.btn_sherch.Name = "btn_sherch";
            this.btn_sherch.Size = new System.Drawing.Size(135, 54);
            this.btn_sherch.TabIndex = 38;
            this.btn_sherch.Text = "품목 검색 및 추가";
            this.btn_sherch.UseVisualStyleBackColor = true;
            this.btn_sherch.Click += new System.EventHandler(this.btn_sherch_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(68, 453);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(246, 21);
            this.txtProductName.TabIndex = 35;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Location = new System.Drawing.Point(68, 420);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.ReadOnly = true;
            this.txt_ProductID.Size = new System.Drawing.Size(246, 21);
            this.txt_ProductID.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 33;
            this.label4.Text = "품목이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 32;
            this.label3.Text = "수량";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "품목코드";
            // 
            // ben_Close
            // 
            this.ben_Close.Location = new System.Drawing.Point(307, 575);
            this.ben_Close.Name = "ben_Close";
            this.ben_Close.Size = new System.Drawing.Size(100, 50);
            this.ben_Close.TabIndex = 29;
            this.ben_Close.Text = "닫기";
            this.ben_Close.UseVisualStyleBackColor = true;
            this.ben_Close.Click += new System.EventHandler(this.ben_Close_Click);
            // 
            // dgv_BOMList
            // 
            this.dgv_BOMList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_BOMList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BOMList.Location = new System.Drawing.Point(14, 24);
            this.dgv_BOMList.Name = "dgv_BOMList";
            this.dgv_BOMList.RowTemplate.Height = 23;
            this.dgv_BOMList.Size = new System.Drawing.Size(1256, 366);
            this.dgv_BOMList.TabIndex = 27;
            this.dgv_BOMList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BOMList_CellContentClick);
            this.dgv_BOMList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BOMList_CellDoubleClick);
            this.dgv_BOMList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_BOMList_DataBindingComplete);
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(66, 9);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(41, 12);
            this.lbl_ProductName.TabIndex = 47;
            this.lbl_ProductName.Text = "품목명";
            // 
            // BOMSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 640);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCountUpdate);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_sherch);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ben_Close);
            this.Controls.Add(this.dgv_BOMList);
            this.Name = "BOMSet";
            this.Text = "BOMSet";
            this.Load += new System.EventHandler(this.BOMSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BOMList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCountUpdate;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_sherch;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ben_Close;
        private System.Windows.Forms.DataGridView dgv_BOMList;
        private System.Windows.Forms.Label lbl_ProductName;
    }
}