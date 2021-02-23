namespace AdminClient
{
    partial class ProductPopUp
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
            System.Dynamic.ExpandoObject expandoObject6 = new System.Dynamic.ExpandoObject();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPsyCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLogCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStand = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btn_Image = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.productFeature = new AdminClient.ProductFeature();
            this.cbo_catagory = new System.Windows.Forms.ComboBox();
            this.cbo_divition = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductImage
            // 
            this.ProductImage.Location = new System.Drawing.Point(10, 22);
            this.ProductImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(226, 177);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImage.TabIndex = 0;
            this.ProductImage.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(252, 22);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(85, 21);
            this.txtID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(252, 61);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 21);
            this.txtName.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(252, 142);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.MaxLength = 10;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(111, 21);
            this.txtPrice.TabIndex = 3;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(252, 181);
            this.txtMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMin.MaxLength = 8;
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(107, 21);
            this.txtMin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "가격";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "최소 물량";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "최대 물량";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(252, 218);
            this.txtMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMax.MaxLength = 8;
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(107, 21);
            this.txtMax.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "물리갯수";
            // 
            // txtPsyCount
            // 
            this.txtPsyCount.Location = new System.Drawing.Point(377, 181);
            this.txtPsyCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPsyCount.MaxLength = 8;
            this.txtPsyCount.Name = "txtPsyCount";
            this.txtPsyCount.Size = new System.Drawing.Size(107, 21);
            this.txtPsyCount.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "논리갯수";
            // 
            // txtLogCount
            // 
            this.txtLogCount.Location = new System.Drawing.Point(377, 219);
            this.txtLogCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogCount.MaxLength = 8;
            this.txtLogCount.Name = "txtLogCount";
            this.txtLogCount.Size = new System.Drawing.Size(107, 21);
            this.txtLogCount.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(248, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "상태";
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(250, 256);
            this.cboState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(234, 20);
            this.cboState.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "규격";
            // 
            // txtStand
            // 
            this.txtStand.Location = new System.Drawing.Point(252, 106);
            this.txtStand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStand.MaxLength = 100;
            this.txtStand.Name = "txtStand";
            this.txtStand.Size = new System.Drawing.Size(153, 21);
            this.txtStand.TabIndex = 20;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(10, 399);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(66, 25);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "추가";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btnDeleted
            // 
            this.btnDeleted.Location = new System.Drawing.Point(154, 399);
            this.btnDeleted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(66, 25);
            this.btnDeleted.TabIndex = 23;
            this.btnDeleted.Text = "삭제";
            this.btnDeleted.UseVisualStyleBackColor = true;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(82, 399);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 25);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btn_Image
            // 
            this.btn_Image.Location = new System.Drawing.Point(10, 209);
            this.btn_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(66, 29);
            this.btn_Image.TabIndex = 25;
            this.btn_Image.Text = "이미지";
            this.btn_Image.UseVisualStyleBackColor = true;
            this.btn_Image.Click += new System.EventHandler(this.btn_Image_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "카테고리";
            // 
            // txtCategory
            // 
            this.txtCategory.Enabled = false;
            this.txtCategory.Location = new System.Drawing.Point(379, 142);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategory.MaxLength = 10;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(111, 21);
            this.txtCategory.TabIndex = 26;
            // 
            // productFeature
            // 
            this.productFeature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productFeature.Info = expandoObject6;
            this.productFeature.Location = new System.Drawing.Point(250, 292);
            this.productFeature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productFeature.Name = "productFeature";
            this.productFeature.Size = new System.Drawing.Size(462, 205);
            this.productFeature.TabIndex = 28;
            // 
            // cbo_catagory
            // 
            this.cbo_catagory.FormattingEnabled = true;
            this.cbo_catagory.Location = new System.Drawing.Point(510, 182);
            this.cbo_catagory.Name = "cbo_catagory";
            this.cbo_catagory.Size = new System.Drawing.Size(121, 20);
            this.cbo_catagory.TabIndex = 29;
            this.cbo_catagory.SelectedIndexChanged += new System.EventHandler(this.cbo_catagory_SelectedIndexChanged);
            // 
            // cbo_divition
            // 
            this.cbo_divition.FormattingEnabled = true;
            this.cbo_divition.Location = new System.Drawing.Point(510, 143);
            this.cbo_divition.Name = "cbo_divition";
            this.cbo_divition.Size = new System.Drawing.Size(121, 20);
            this.cbo_divition.TabIndex = 30;
            this.cbo_divition.SelectedIndexChanged += new System.EventHandler(this.cbo_divition_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(508, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 31;
            this.label11.Text = "분류";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(508, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 32;
            this.label12.Text = "카테고리";
            // 
            // ProductPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 506);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbo_divition);
            this.Controls.Add(this.cbo_catagory);
            this.Controls.Add(this.productFeature);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.btn_Image);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtStand);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLogCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPsyCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ProductImage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductPopUp";
            this.Text = "ProductPopUp";
            this.Load += new System.EventHandler(this.ProductPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProductImage;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPsyCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLogCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStand;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btnDeleted;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btn_Image;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCategory;
        private ProductFeature productFeature;
        private System.Windows.Forms.ComboBox cbo_catagory;
        private System.Windows.Forms.ComboBox cbo_divition;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}