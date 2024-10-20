namespace winformstrain
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExistingUsersListContainer = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            ExistingUsersListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ExistingUsersListContainer
            // 
            ExistingUsersListContainer.AutoSize = true;
            ExistingUsersListContainer.Controls.Add(dataGridView1);
            ExistingUsersListContainer.Location = new Point(42, 200);
            ExistingUsersListContainer.Name = "ExistingUsersListContainer";
            ExistingUsersListContainer.Padding = new Padding(15);
            ExistingUsersListContainer.Size = new Size(411, 272);
            ExistingUsersListContainer.TabIndex = 1;
            ExistingUsersListContainer.TabStop = false;
            ExistingUsersListContainer.Text = "Existing Users";
            ExistingUsersListContainer.Enter += groupBox1_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(383, 213);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(42, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 144);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create User";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 521);
            Controls.Add(groupBox1);
            Controls.Add(ExistingUsersListContainer);
            Name = "Form1";
            Text = "User Management";
            Load += Form1_Load;
            ExistingUsersListContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox ExistingUsersListContainer;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}
