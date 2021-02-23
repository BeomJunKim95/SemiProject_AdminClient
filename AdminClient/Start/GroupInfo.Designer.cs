namespace AdminClient.Start
{
    partial class GroupInfo
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
            this.dgvGroup = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGroupAuthority = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFormInfo = new System.Windows.Forms.DataGridView();
            this.btn_Fromsreference = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnGruopAdd = new System.Windows.Forms.Button();
            this.btnGruopUpadte = new System.Windows.Forms.Button();
            this.btnGruopDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupAuthority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGroup
            // 
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Location = new System.Drawing.Point(12, 33);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.RowHeadersWidth = 51;
            this.dgvGroup.RowTemplate.Height = 27;
            this.dgvGroup.Size = new System.Drawing.Size(292, 342);
            this.dgvGroup.TabIndex = 0;
            this.dgvGroup.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroup_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "그룹 목록";
            // 
            // dgvGroupAuthority
            // 
            this.dgvGroupAuthority.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupAuthority.Location = new System.Drawing.Point(744, 33);
            this.dgvGroupAuthority.Name = "dgvGroupAuthority";
            this.dgvGroupAuthority.RowHeadersWidth = 51;
            this.dgvGroupAuthority.RowTemplate.Height = 27;
            this.dgvGroupAuthority.Size = new System.Drawing.Size(469, 342);
            this.dgvGroupAuthority.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(741, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "권한 목록";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "폼 목록";
            // 
            // dgvFormInfo
            // 
            this.dgvFormInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormInfo.Location = new System.Drawing.Point(310, 33);
            this.dgvFormInfo.Name = "dgvFormInfo";
            this.dgvFormInfo.RowHeadersWidth = 51;
            this.dgvFormInfo.RowTemplate.Height = 27;
            this.dgvFormInfo.Size = new System.Drawing.Size(313, 342);
            this.dgvFormInfo.TabIndex = 4;
            // 
            // btn_Fromsreference
            // 
            this.btn_Fromsreference.Location = new System.Drawing.Point(629, 284);
            this.btn_Fromsreference.Name = "btn_Fromsreference";
            this.btn_Fromsreference.Size = new System.Drawing.Size(109, 49);
            this.btn_Fromsreference.TabIndex = 6;
            this.btn_Fromsreference.Text = "폼목록\r\n 조회";
            this.btn_Fromsreference.UseVisualStyleBackColor = true;
            this.btn_Fromsreference.Click += new System.EventHandler(this.btn_Fromsreference_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(629, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 49);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "=>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(629, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 49);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "<=";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGruopDelete);
            this.groupBox1.Controls.Add(this.btnGruopUpadte);
            this.groupBox1.Controls.Add(this.btnGruopAdd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 250);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 그룹목록 관리";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(77, 46);
            this.txtNo.MaxLength = 10;
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(146, 25);
            this.txtNo.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 87);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 25);
            this.txtName.TabIndex = 3;
            // 
            // btnGruopAdd
            // 
            this.btnGruopAdd.Location = new System.Drawing.Point(442, 35);
            this.btnGruopAdd.Name = "btnGruopAdd";
            this.btnGruopAdd.Size = new System.Drawing.Size(142, 42);
            this.btnGruopAdd.TabIndex = 4;
            this.btnGruopAdd.Text = "추가";
            this.btnGruopAdd.UseVisualStyleBackColor = true;
            this.btnGruopAdd.Click += new System.EventHandler(this.btnGruopAdd_Click);
            // 
            // btnGruopUpadte
            // 
            this.btnGruopUpadte.Location = new System.Drawing.Point(442, 83);
            this.btnGruopUpadte.Name = "btnGruopUpadte";
            this.btnGruopUpadte.Size = new System.Drawing.Size(142, 42);
            this.btnGruopUpadte.TabIndex = 5;
            this.btnGruopUpadte.Text = "수정";
            this.btnGruopUpadte.UseVisualStyleBackColor = true;
            this.btnGruopUpadte.Click += new System.EventHandler(this.btnGruopUpadte_Click);
            // 
            // btnGruopDelete
            // 
            this.btnGruopDelete.Location = new System.Drawing.Point(442, 131);
            this.btnGruopDelete.Name = "btnGruopDelete";
            this.btnGruopDelete.Size = new System.Drawing.Size(142, 42);
            this.btnGruopDelete.TabIndex = 6;
            this.btnGruopDelete.Text = "삭제";
            this.btnGruopDelete.UseVisualStyleBackColor = true;
            this.btnGruopDelete.Click += new System.EventHandler(this.btnGruopDelete_Click);
            // 
            // GroupInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 689);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn_Fromsreference);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvFormInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvGroupAuthority);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGroup);
            this.Name = "GroupInfo";
            this.Text = "GroupInfo";
            this.Load += new System.EventHandler(this.GroupInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupAuthority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGroupAuthority;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFormInfo;
        private System.Windows.Forms.Button btn_Fromsreference;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGruopDelete;
        private System.Windows.Forms.Button btnGruopUpadte;
        private System.Windows.Forms.Button btnGruopAdd;
    }
}