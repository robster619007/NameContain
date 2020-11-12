namespace NameContain
{
    partial class Form1
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
            this.empID = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.Label();
            this.empDept = new System.Windows.Forms.Label();
            this.empID_Text = new System.Windows.Forms.TextBox();
            this.empName_Text = new System.Windows.Forms.TextBox();
            this.empDept_Text = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Emp_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // empID
            // 
            this.empID.AutoSize = true;
            this.empID.Location = new System.Drawing.Point(96, 47);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(63, 20);
            this.empID.TabIndex = 0;
            this.empID.Text = "Emp ID";
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.Location = new System.Drawing.Point(96, 119);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(51, 20);
            this.empName.TabIndex = 1;
            this.empName.Text = "Name";
            this.empName.Click += new System.EventHandler(this.empName_Click);
            // 
            // empDept
            // 
            this.empDept.AutoSize = true;
            this.empDept.Location = new System.Drawing.Point(96, 188);
            this.empDept.Name = "empDept";
            this.empDept.Size = new System.Drawing.Size(44, 20);
            this.empDept.TabIndex = 2;
            this.empDept.Text = "Dept";
            // 
            // empID_Text
            // 
            this.empID_Text.Location = new System.Drawing.Point(187, 47);
            this.empID_Text.Name = "empID_Text";
            this.empID_Text.Size = new System.Drawing.Size(100, 26);
            this.empID_Text.TabIndex = 3;
            // 
            // empName_Text
            // 
            this.empName_Text.Location = new System.Drawing.Point(187, 116);
            this.empName_Text.Name = "empName_Text";
            this.empName_Text.Size = new System.Drawing.Size(100, 26);
            this.empName_Text.TabIndex = 4;
            // 
            // empDept_Text
            // 
            this.empDept_Text.Location = new System.Drawing.Point(187, 185);
            this.empDept_Text.Name = "empDept_Text";
            this.empDept_Text.Size = new System.Drawing.Size(100, 26);
            this.empDept_Text.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(423, 115);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 59);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Emp_ID,
            this.Emp_Name,
            this.Emp_Dept});
            this.dataGridView1.Location = new System.Drawing.Point(47, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(509, 222);
            this.dataGridView1.TabIndex = 7;
            // 
            // Emp_ID
            // 
            this.Emp_ID.HeaderText = "Employee ID";
            this.Emp_ID.MinimumWidth = 8;
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.Width = 150;
            // 
            // Emp_Name
            // 
            this.Emp_Name.HeaderText = "Employee Name";
            this.Emp_Name.MinimumWidth = 8;
            this.Emp_Name.Name = "Emp_Name";
            this.Emp_Name.Width = 150;
            // 
            // Emp_Dept
            // 
            this.Emp_Dept.HeaderText = "Employee Dept";
            this.Emp_Dept.MinimumWidth = 8;
            this.Emp_Dept.Name = "Emp_Dept";
            this.Emp_Dept.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.empDept_Text);
            this.Controls.Add(this.empName_Text);
            this.Controls.Add(this.empID_Text);
            this.Controls.Add(this.empDept);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.empID);
            this.Name = "Form1";
            this.Text = "Name Container";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label empID;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.Label empDept;
        private System.Windows.Forms.TextBox empID_Text;
        private System.Windows.Forms.TextBox empName_Text;
        private System.Windows.Forms.TextBox empDept_Text;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Dept;
    }
}

