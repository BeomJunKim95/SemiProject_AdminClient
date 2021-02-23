namespace AdminClient
{
    partial class EmpGroupAdd
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
            this.dgv_empGroup = new System.Windows.Forms.DataGridView();
            this.dgv_Group = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Group)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_empGroup
            // 
            this.dgv_empGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empGroup.Location = new System.Drawing.Point(22, 53);
            this.dgv_empGroup.Name = "dgv_empGroup";
            this.dgv_empGroup.RowTemplate.Height = 23;
            this.dgv_empGroup.Size = new System.Drawing.Size(295, 295);
            this.dgv_empGroup.TabIndex = 0;
            // 
            // dgv_Group
            // 
            this.dgv_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Group.Location = new System.Drawing.Point(435, 53);
            this.dgv_Group.Name = "dgv_Group";
            this.dgv_Group.RowTemplate.Height = 23;
            this.dgv_Group.Size = new System.Drawing.Size(316, 295);
            this.dgv_Group.TabIndex = 1;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(347, 247);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(55, 31);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "=>";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(347, 87);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(55, 31);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "<=";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "직원 그룹";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "그룹 목록";
            // 
            // EmpGroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dgv_Group);
            this.Controls.Add(this.dgv_empGroup);
            this.Name = "EmpGroupAdd";
            this.Text = "EmpGroupAdd";
            this.Load += new System.EventHandler(this.EmpGroupAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Group)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_empGroup;
        private System.Windows.Forms.DataGridView dgv_Group;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}