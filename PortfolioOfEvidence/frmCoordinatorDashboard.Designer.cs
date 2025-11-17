namespace PortfolioOfEvidence
{
    partial class frmCoordinatorDashboard
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
            groupBox1 = new GroupBox();
            btnPendingClaims = new Button();
            btnReviewedClaims = new Button();
            btnProfile = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnProfile);
            groupBox1.Controls.Add(btnReviewedClaims);
            groupBox1.Controls.Add(btnPendingClaims);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 699);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Navigation";
           
            // 
            // btnPendingClaims
            // 
            btnPendingClaims.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPendingClaims.Location = new Point(11, 52);
            btnPendingClaims.Name = "btnPendingClaims";
            btnPendingClaims.Size = new Size(143, 41);
            btnPendingClaims.TabIndex = 0;
            btnPendingClaims.Text = "Pending Claims";
            btnPendingClaims.UseVisualStyleBackColor = true;
            btnPendingClaims.Click += button1_Click;
            // 
            // btnReviewedClaims
            // 
            btnReviewedClaims.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReviewedClaims.Location = new Point(182, 52);
            btnReviewedClaims.Name = "btnReviewedClaims";
            btnReviewedClaims.Size = new Size(162, 41);
            btnReviewedClaims.TabIndex = 1;
            btnReviewedClaims.Text = "Reviewed Claims";
            btnReviewedClaims.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(371, 52);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(141, 41);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 116);
            label1.Name = "label1";
            label1.Size = new Size(250, 28);
            label1.TabIndex = 3;
            label1.Text = "PENDING CLAIMS TABLE:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(556, 233);
            dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(11, 454);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(556, 188);
            dataGridView2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 409);
            label2.Name = "label2";
            label2.Size = new Size(195, 28);
            label2.TabIndex = 6;
            label2.Text = "REVIEWED CLAIMS:";
            // 
            // frmCoordinatorDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 712);
            Controls.Add(groupBox1);
            Name = "frmCoordinatorDashboard";
            Text = "Coordinator Dashboard - CMCS";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnProfile;
        private Button btnReviewedClaims;
        private Button btnPendingClaims;
        private Label label2;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Label label1;
    }
}