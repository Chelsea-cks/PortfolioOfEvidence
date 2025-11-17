namespace PortfolioOfEvidence
{
    partial class frmManagerDashboard
    {
        private System.ComponentModel.IContainer components = null;
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

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbLecturerFilter = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cmbCoordinatorFilter = new ComboBox();
            btnapply = new Button();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(246, 38);
            label1.TabIndex = 0;
            label1.Text = "Claims Summary:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 93);
            label2.Name = "label2";
            label2.Size = new Size(138, 23);
            label2.TabIndex = 1;
            label2.Text = "Pending Claims:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 139);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 2;
            label3.Text = "Approved Claims:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 182);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 3;
            label4.Text = "Rejected Claims:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 232);
            label5.Name = "label5";
            label5.Size = new Size(180, 31);
            label5.TabIndex = 4;
            label5.Text = "FILTER CLAIMS:";
            // 
            // cmbLecturerFilter
            // 
            cmbLecturerFilter.FormattingEnabled = true;
            cmbLecturerFilter.Location = new Point(178, 288);
            cmbLecturerFilter.Name = "cmbLecturerFilter";
            cmbLecturerFilter.Size = new Size(180, 28);
            cmbLecturerFilter.TabIndex = 5;
            cmbLecturerFilter.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 289);
            label6.Name = "label6";
            label6.Size = new Size(97, 23);
            label6.TabIndex = 6;
            label6.Text = "LECTURER:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 350);
            label7.Name = "label7";
            label7.Size = new Size(138, 23);
            label7.TabIndex = 7;
            label7.Text = "COORDINATOR:";
            // 
            // cmbCoordinatorFilter
            // 
            cmbCoordinatorFilter.FormattingEnabled = true;
            cmbCoordinatorFilter.Location = new Point(178, 349);
            cmbCoordinatorFilter.Name = "cmbCoordinatorFilter";
            cmbCoordinatorFilter.Size = new Size(180, 28);
            cmbCoordinatorFilter.TabIndex = 8;
            // 
            // btnapply
            // 
            btnapply.Location = new Point(18, 409);
            btnapply.Name = "btnapply";
            btnapply.Size = new Size(138, 29);
            btnapply.TabIndex = 9;
            btnapply.Text = "APPLY";
            btnapply.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 461);
            label8.Name = "label8";
            label8.Size = new Size(354, 38);
            label8.TabIndex = 10;
            label8.Text = "Pending Approval Claims:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 502);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(435, 223);
            dataGridView1.TabIndex = 11;
            // 
            // frmManagerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 750);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(btnapply);
            Controls.Add(cmbCoordinatorFilter);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbLecturerFilter);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmManagerDashboard";
            Text = "Manager Dashboard - CMCS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbLecturerFilter;
        private Label label6;
        private Label label7;
        private ComboBox cmbCoordinatorFilter;
        private Button btnapply;
        private Label label8;
        private DataGridView dataGridView1;
    }
}