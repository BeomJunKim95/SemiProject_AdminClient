namespace AdminClient.Start
{
    partial class ProductForProp
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
            this.dgvDivition = new System.Windows.Forms.DataGridView();
            this.gpbDivition = new System.Windows.Forms.GroupBox();
            this.btnDivistionDelete = new System.Windows.Forms.Button();
            this.btnDivistionUpdate = new System.Windows.Forms.Button();
            this.btnDivistionadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDivitionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDivitionID = new System.Windows.Forms.TextBox();
            this.gpbCategory = new System.Windows.Forms.GroupBox();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnCategoryadd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCDivitionID = new System.Windows.Forms.TextBox();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.gpbFeature = new System.Windows.Forms.GroupBox();
            this.btnFeatureDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFeatureUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFeatureAdd = new System.Windows.Forms.Button();
            this.dgvFeature = new System.Windows.Forms.DataGridView();
            this.txtFeatureName = new System.Windows.Forms.TextBox();
            this.txtFCategoryID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFeatureID = new System.Windows.Forms.TextBox();
            this.gpbValue = new System.Windows.Forms.GroupBox();
            this.btnValueDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnValueUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnValueAdd = new System.Windows.Forms.Button();
            this.dgvValue = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValueName = new System.Windows.Forms.TextBox();
            this.txtValueID = new System.Windows.Forms.TextBox();
            this.txtVFeatureID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivition)).BeginInit();
            this.gpbDivition.SuspendLayout();
            this.gpbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.gpbFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeature)).BeginInit();
            this.gpbValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDivition
            // 
            this.dgvDivition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDivition.Location = new System.Drawing.Point(6, 20);
            this.dgvDivition.Name = "dgvDivition";
            this.dgvDivition.RowTemplate.Height = 23;
            this.dgvDivition.Size = new System.Drawing.Size(202, 248);
            this.dgvDivition.TabIndex = 0;
            this.dgvDivition.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDivition_CellDoubleClick);
            // 
            // gpbDivition
            // 
            this.gpbDivition.Controls.Add(this.btnDivistionDelete);
            this.gpbDivition.Controls.Add(this.btnDivistionUpdate);
            this.gpbDivition.Controls.Add(this.btnDivistionadd);
            this.gpbDivition.Controls.Add(this.label2);
            this.gpbDivition.Controls.Add(this.txtDivitionName);
            this.gpbDivition.Controls.Add(this.label1);
            this.gpbDivition.Controls.Add(this.txtDivitionID);
            this.gpbDivition.Controls.Add(this.dgvDivition);
            this.gpbDivition.Location = new System.Drawing.Point(12, 12);
            this.gpbDivition.Name = "gpbDivition";
            this.gpbDivition.Size = new System.Drawing.Size(216, 618);
            this.gpbDivition.TabIndex = 1;
            this.gpbDivition.TabStop = false;
            this.gpbDivition.Text = "Divition";
            // 
            // btnDivistionDelete
            // 
            this.btnDivistionDelete.Location = new System.Drawing.Point(6, 581);
            this.btnDivistionDelete.Name = "btnDivistionDelete";
            this.btnDivistionDelete.Size = new System.Drawing.Size(127, 28);
            this.btnDivistionDelete.TabIndex = 7;
            this.btnDivistionDelete.Text = "삭제";
            this.btnDivistionDelete.UseVisualStyleBackColor = true;
            this.btnDivistionDelete.Click += new System.EventHandler(this.btnDivistionDelete_Click);
            // 
            // btnDivistionUpdate
            // 
            this.btnDivistionUpdate.Location = new System.Drawing.Point(6, 547);
            this.btnDivistionUpdate.Name = "btnDivistionUpdate";
            this.btnDivistionUpdate.Size = new System.Drawing.Size(127, 28);
            this.btnDivistionUpdate.TabIndex = 6;
            this.btnDivistionUpdate.Text = "수정";
            this.btnDivistionUpdate.UseVisualStyleBackColor = true;
            this.btnDivistionUpdate.Click += new System.EventHandler(this.btnDivistionUpdate_Click);
            // 
            // btnDivistionadd
            // 
            this.btnDivistionadd.Location = new System.Drawing.Point(6, 513);
            this.btnDivistionadd.Name = "btnDivistionadd";
            this.btnDivistionadd.Size = new System.Drawing.Size(127, 28);
            this.btnDivistionadd.TabIndex = 5;
            this.btnDivistionadd.Text = "추가";
            this.btnDivistionadd.UseVisualStyleBackColor = true;
            this.btnDivistionadd.Click += new System.EventHandler(this.btnDivistionadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "DivitionName";
            // 
            // txtDivitionName
            // 
            this.txtDivitionName.Location = new System.Drawing.Point(8, 380);
            this.txtDivitionName.MaxLength = 100;
            this.txtDivitionName.Name = "txtDivitionName";
            this.txtDivitionName.Size = new System.Drawing.Size(167, 21);
            this.txtDivitionName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "DivitionID";
            // 
            // txtDivitionID
            // 
            this.txtDivitionID.Location = new System.Drawing.Point(6, 331);
            this.txtDivitionID.MaxLength = 10;
            this.txtDivitionID.Name = "txtDivitionID";
            this.txtDivitionID.Size = new System.Drawing.Size(167, 21);
            this.txtDivitionID.TabIndex = 1;
            // 
            // gpbCategory
            // 
            this.gpbCategory.Controls.Add(this.btnCategoryDelete);
            this.gpbCategory.Controls.Add(this.label5);
            this.gpbCategory.Controls.Add(this.btnCategoryUpdate);
            this.gpbCategory.Controls.Add(this.txtCategoryName);
            this.gpbCategory.Controls.Add(this.btnCategoryadd);
            this.gpbCategory.Controls.Add(this.label4);
            this.gpbCategory.Controls.Add(this.txtCategoryID);
            this.gpbCategory.Controls.Add(this.label3);
            this.gpbCategory.Controls.Add(this.txtCDivitionID);
            this.gpbCategory.Controls.Add(this.dgvCategory);
            this.gpbCategory.Location = new System.Drawing.Point(234, 12);
            this.gpbCategory.Name = "gpbCategory";
            this.gpbCategory.Size = new System.Drawing.Size(299, 618);
            this.gpbCategory.TabIndex = 2;
            this.gpbCategory.TabStop = false;
            this.gpbCategory.Text = "Category";
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(21, 581);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(127, 28);
            this.btnCategoryDelete.TabIndex = 10;
            this.btnCategoryDelete.Text = "삭제";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "CategoryName";
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(21, 547);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(127, 28);
            this.btnCategoryUpdate.TabIndex = 9;
            this.btnCategoryUpdate.Text = "수정";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(21, 409);
            this.txtCategoryName.MaxLength = 100;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(167, 21);
            this.txtCategoryName.TabIndex = 12;
            // 
            // btnCategoryadd
            // 
            this.btnCategoryadd.Location = new System.Drawing.Point(21, 513);
            this.btnCategoryadd.Name = "btnCategoryadd";
            this.btnCategoryadd.Size = new System.Drawing.Size(127, 28);
            this.btnCategoryadd.TabIndex = 8;
            this.btnCategoryadd.Text = "추가";
            this.btnCategoryadd.UseVisualStyleBackColor = true;
            this.btnCategoryadd.Click += new System.EventHandler(this.btnCategoryadd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "CategoryID";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(21, 370);
            this.txtCategoryID.MaxLength = 10;
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(167, 21);
            this.txtCategoryID.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "DivitionID";
            // 
            // txtCDivitionID
            // 
            this.txtCDivitionID.Location = new System.Drawing.Point(21, 331);
            this.txtCDivitionID.MaxLength = 10;
            this.txtCDivitionID.Name = "txtCDivitionID";
            this.txtCDivitionID.Size = new System.Drawing.Size(167, 21);
            this.txtCDivitionID.TabIndex = 8;
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(6, 20);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowTemplate.Height = 23;
            this.dgvCategory.Size = new System.Drawing.Size(286, 248);
            this.dgvCategory.TabIndex = 0;
            this.dgvCategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellDoubleClick);
            // 
            // gpbFeature
            // 
            this.gpbFeature.Controls.Add(this.btnFeatureDelete);
            this.gpbFeature.Controls.Add(this.label8);
            this.gpbFeature.Controls.Add(this.btnFeatureUpdate);
            this.gpbFeature.Controls.Add(this.label6);
            this.gpbFeature.Controls.Add(this.btnFeatureAdd);
            this.gpbFeature.Controls.Add(this.dgvFeature);
            this.gpbFeature.Controls.Add(this.txtFeatureName);
            this.gpbFeature.Controls.Add(this.txtFCategoryID);
            this.gpbFeature.Controls.Add(this.label7);
            this.gpbFeature.Controls.Add(this.txtFeatureID);
            this.gpbFeature.Location = new System.Drawing.Point(538, 12);
            this.gpbFeature.Name = "gpbFeature";
            this.gpbFeature.Size = new System.Drawing.Size(297, 618);
            this.gpbFeature.TabIndex = 3;
            this.gpbFeature.TabStop = false;
            this.gpbFeature.Text = "Feature";
            // 
            // btnFeatureDelete
            // 
            this.btnFeatureDelete.Location = new System.Drawing.Point(26, 581);
            this.btnFeatureDelete.Name = "btnFeatureDelete";
            this.btnFeatureDelete.Size = new System.Drawing.Size(127, 28);
            this.btnFeatureDelete.TabIndex = 15;
            this.btnFeatureDelete.Text = "삭제";
            this.btnFeatureDelete.UseVisualStyleBackColor = true;
            this.btnFeatureDelete.Click += new System.EventHandler(this.btnFeatureDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "FeatureID";
            // 
            // btnFeatureUpdate
            // 
            this.btnFeatureUpdate.Location = new System.Drawing.Point(26, 547);
            this.btnFeatureUpdate.Name = "btnFeatureUpdate";
            this.btnFeatureUpdate.Size = new System.Drawing.Size(127, 28);
            this.btnFeatureUpdate.TabIndex = 14;
            this.btnFeatureUpdate.Text = "수정";
            this.btnFeatureUpdate.UseVisualStyleBackColor = true;
            this.btnFeatureUpdate.Click += new System.EventHandler(this.btnFeatureUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "FeatureName";
            // 
            // btnFeatureAdd
            // 
            this.btnFeatureAdd.Location = new System.Drawing.Point(26, 513);
            this.btnFeatureAdd.Name = "btnFeatureAdd";
            this.btnFeatureAdd.Size = new System.Drawing.Size(127, 28);
            this.btnFeatureAdd.TabIndex = 13;
            this.btnFeatureAdd.Text = "추가";
            this.btnFeatureAdd.UseVisualStyleBackColor = true;
            this.btnFeatureAdd.Click += new System.EventHandler(this.btnFeatureAdd_Click);
            // 
            // dgvFeature
            // 
            this.dgvFeature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeature.Location = new System.Drawing.Point(6, 20);
            this.dgvFeature.Name = "dgvFeature";
            this.dgvFeature.RowTemplate.Height = 23;
            this.dgvFeature.Size = new System.Drawing.Size(285, 248);
            this.dgvFeature.TabIndex = 0;
            this.dgvFeature.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeature_CellDoubleClick);
            // 
            // txtFeatureName
            // 
            this.txtFeatureName.Location = new System.Drawing.Point(26, 409);
            this.txtFeatureName.MaxLength = 100;
            this.txtFeatureName.Name = "txtFeatureName";
            this.txtFeatureName.Size = new System.Drawing.Size(167, 21);
            this.txtFeatureName.TabIndex = 18;
            // 
            // txtFCategoryID
            // 
            this.txtFCategoryID.Location = new System.Drawing.Point(26, 331);
            this.txtFCategoryID.MaxLength = 10;
            this.txtFCategoryID.Name = "txtFCategoryID";
            this.txtFCategoryID.Size = new System.Drawing.Size(167, 21);
            this.txtFCategoryID.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "CategoryID";
            // 
            // txtFeatureID
            // 
            this.txtFeatureID.Location = new System.Drawing.Point(26, 370);
            this.txtFeatureID.MaxLength = 10;
            this.txtFeatureID.Name = "txtFeatureID";
            this.txtFeatureID.Size = new System.Drawing.Size(167, 21);
            this.txtFeatureID.TabIndex = 16;
            // 
            // gpbValue
            // 
            this.gpbValue.Controls.Add(this.btnValueDelete);
            this.gpbValue.Controls.Add(this.label11);
            this.gpbValue.Controls.Add(this.btnValueUpdate);
            this.gpbValue.Controls.Add(this.label9);
            this.gpbValue.Controls.Add(this.btnValueAdd);
            this.gpbValue.Controls.Add(this.dgvValue);
            this.gpbValue.Controls.Add(this.label10);
            this.gpbValue.Controls.Add(this.txtValueName);
            this.gpbValue.Controls.Add(this.txtValueID);
            this.gpbValue.Controls.Add(this.txtVFeatureID);
            this.gpbValue.Location = new System.Drawing.Point(841, 12);
            this.gpbValue.Name = "gpbValue";
            this.gpbValue.Size = new System.Drawing.Size(328, 618);
            this.gpbValue.TabIndex = 4;
            this.gpbValue.TabStop = false;
            this.gpbValue.Text = "Value";
            // 
            // btnValueDelete
            // 
            this.btnValueDelete.Location = new System.Drawing.Point(16, 581);
            this.btnValueDelete.Name = "btnValueDelete";
            this.btnValueDelete.Size = new System.Drawing.Size(127, 28);
            this.btnValueDelete.TabIndex = 22;
            this.btnValueDelete.Text = "삭제";
            this.btnValueDelete.UseVisualStyleBackColor = true;
            this.btnValueDelete.Click += new System.EventHandler(this.btnValueDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "ValueID";
            // 
            // btnValueUpdate
            // 
            this.btnValueUpdate.Location = new System.Drawing.Point(16, 547);
            this.btnValueUpdate.Name = "btnValueUpdate";
            this.btnValueUpdate.Size = new System.Drawing.Size(127, 28);
            this.btnValueUpdate.TabIndex = 21;
            this.btnValueUpdate.Text = "수정";
            this.btnValueUpdate.UseVisualStyleBackColor = true;
            this.btnValueUpdate.Click += new System.EventHandler(this.btnValueUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "FeatureID";
            // 
            // btnValueAdd
            // 
            this.btnValueAdd.Location = new System.Drawing.Point(16, 513);
            this.btnValueAdd.Name = "btnValueAdd";
            this.btnValueAdd.Size = new System.Drawing.Size(127, 28);
            this.btnValueAdd.TabIndex = 20;
            this.btnValueAdd.Text = "추가";
            this.btnValueAdd.UseVisualStyleBackColor = true;
            this.btnValueAdd.Click += new System.EventHandler(this.btnValueAdd_Click);
            // 
            // dgvValue
            // 
            this.dgvValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValue.Location = new System.Drawing.Point(6, 20);
            this.dgvValue.Name = "dgvValue";
            this.dgvValue.RowTemplate.Height = 23;
            this.dgvValue.Size = new System.Drawing.Size(310, 248);
            this.dgvValue.TabIndex = 0;
            this.dgvValue.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvValue_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "ValueName";
            // 
            // txtValueName
            // 
            this.txtValueName.Location = new System.Drawing.Point(16, 409);
            this.txtValueName.MaxLength = 100;
            this.txtValueName.Name = "txtValueName";
            this.txtValueName.Size = new System.Drawing.Size(167, 21);
            this.txtValueName.TabIndex = 24;
            // 
            // txtValueID
            // 
            this.txtValueID.Location = new System.Drawing.Point(16, 370);
            this.txtValueID.MaxLength = 10;
            this.txtValueID.Name = "txtValueID";
            this.txtValueID.Size = new System.Drawing.Size(167, 21);
            this.txtValueID.TabIndex = 22;
            // 
            // txtVFeatureID
            // 
            this.txtVFeatureID.Location = new System.Drawing.Point(16, 331);
            this.txtVFeatureID.MaxLength = 10;
            this.txtVFeatureID.Name = "txtVFeatureID";
            this.txtVFeatureID.Size = new System.Drawing.Size(167, 21);
            this.txtVFeatureID.TabIndex = 20;
            // 
            // ProductForProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 647);
            this.Controls.Add(this.gpbValue);
            this.Controls.Add(this.gpbFeature);
            this.Controls.Add(this.gpbCategory);
            this.Controls.Add(this.gpbDivition);
            this.Name = "ProductForProp";
            this.Text = "ProductForProp";
            this.Load += new System.EventHandler(this.ProductForProp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivition)).EndInit();
            this.gpbDivition.ResumeLayout(false);
            this.gpbDivition.PerformLayout();
            this.gpbCategory.ResumeLayout(false);
            this.gpbCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.gpbFeature.ResumeLayout(false);
            this.gpbFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeature)).EndInit();
            this.gpbValue.ResumeLayout(false);
            this.gpbValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDivition;
        private System.Windows.Forms.GroupBox gpbDivition;
        private System.Windows.Forms.GroupBox gpbCategory;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.GroupBox gpbFeature;
        private System.Windows.Forms.DataGridView dgvFeature;
        private System.Windows.Forms.GroupBox gpbValue;
        private System.Windows.Forms.DataGridView dgvValue;
        private System.Windows.Forms.Button btnDivistionDelete;
        private System.Windows.Forms.Button btnDivistionUpdate;
        private System.Windows.Forms.Button btnDivistionadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDivitionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDivitionID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnCategoryadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtCDivitionID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFeatureName;
        private System.Windows.Forms.TextBox txtFCategoryID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFeatureID;
        private System.Windows.Forms.Button btnFeatureDelete;
        private System.Windows.Forms.Button btnFeatureUpdate;
        private System.Windows.Forms.Button btnFeatureAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValueName;
        private System.Windows.Forms.TextBox txtValueID;
        private System.Windows.Forms.TextBox txtVFeatureID;
        private System.Windows.Forms.Button btnValueDelete;
        private System.Windows.Forms.Button btnValueUpdate;
        private System.Windows.Forms.Button btnValueAdd;
    }
}