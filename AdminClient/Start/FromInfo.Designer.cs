namespace AdminClient.Start
{
    partial class FromInfo
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
            this.components = new System.ComponentModel.Container();
            this.dgvSelectForm = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNonSelectForm = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFromName = new System.Windows.Forms.TextBox();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvdeleted = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonSelectForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeleted)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectForm
            // 
            this.dgvSelectForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectForm.Location = new System.Drawing.Point(488, 24);
            this.dgvSelectForm.Name = "dgvSelectForm";
            this.dgvSelectForm.RowHeadersWidth = 51;
            this.dgvSelectForm.RowTemplate.Height = 23;
            this.dgvSelectForm.Size = new System.Drawing.Size(408, 256);
            this.dgvSelectForm.TabIndex = 1;
            this.dgvSelectForm.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectForm_CellDoubleClick);
            this.dgvSelectForm.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dgvSelectForm_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "할당되지 않은 폼";
            // 
            // dgvNonSelectForm
            // 
            this.dgvNonSelectForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNonSelectForm.Location = new System.Drawing.Point(12, 24);
            this.dgvNonSelectForm.Name = "dgvNonSelectForm";
            this.dgvNonSelectForm.RowHeadersWidth = 51;
            this.dgvNonSelectForm.RowTemplate.Height = 23;
            this.dgvNonSelectForm.Size = new System.Drawing.Size(220, 256);
            this.dgvNonSelectForm.TabIndex = 3;
            this.dgvNonSelectForm.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNonSelectForm_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(486, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "할당된 폼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "폼이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "메뉴이름";
            // 
            // txtFromName
            // 
            this.txtFromName.Location = new System.Drawing.Point(91, 314);
            this.txtFromName.Name = "txtFromName";
            this.txtFromName.Size = new System.Drawing.Size(164, 21);
            this.txtFromName.TabIndex = 7;
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(91, 360);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(164, 21);
            this.txtMenuName.TabIndex = 8;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("굴림", 15F);
            this.BtnAdd.Location = new System.Drawing.Point(561, 333);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(108, 67);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "추가";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("굴림", 15F);
            this.BtnUpdate.Location = new System.Drawing.Point(675, 333);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(110, 67);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "수정";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("굴림", 15F);
            this.BtnDelete.Location = new System.Drawing.Point(791, 333);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(108, 67);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(236, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "존재 하지 않은 폼";
            // 
            // dgvdeleted
            // 
            this.dgvdeleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeleted.Location = new System.Drawing.Point(238, 24);
            this.dgvdeleted.Name = "dgvdeleted";
            this.dgvdeleted.RowHeadersWidth = 51;
            this.dgvdeleted.RowTemplate.Height = 23;
            this.dgvdeleted.Size = new System.Drawing.Size(244, 256);
            this.dgvdeleted.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FromInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 462);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvdeleted);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.txtFromName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNonSelectForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSelectForm);
            this.Name = "FromInfo";
            this.Text = "FromInfo";
            this.Load += new System.EventHandler(this.FromInfo_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FromInfo_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonSelectForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeleted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSelectForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNonSelectForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFromName;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvdeleted;
        private System.Windows.Forms.Timer timer1;
    }
}