namespace PortfolioOfEvidence
{
    partial class frmLecturerDashboard
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnSubmitClaim = new Button();
            button2 = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 22);
            label1.Name = "label1";
            label1.Size = new Size(263, 31);
            label1.TabIndex = 0;
            label1.Text = "Submit Monthly Claim:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 89);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 1;
            label2.Text = "Hours Worked:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 144);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 2;
            label3.Text = "Hourly Rate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 201);
            label4.Name = "label4";
            label4.Size = new Size(175, 23);
            label4.TabIndex = 3;
            label4.Text = "Total Claim Amount:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(212, 200);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 27);
            textBox3.TabIndex = 6;
            // 
            // btnSubmitClaim
            // 
            btnSubmitClaim.BackColor = SystemColors.ButtonHighlight;
            btnSubmitClaim.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitClaim.Location = new Point(17, 275);
            btnSubmitClaim.Name = "btnSubmitClaim";
            btnSubmitClaim.Size = new Size(131, 37);
            btnSubmitClaim.TabIndex = 7;
            btnSubmitClaim.Text = "Submit Claim";
            btnSubmitClaim.UseCompatibleTextRendering = true;
            btnSubmitClaim.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(212, 276);
            button2.Name = "button2";
            button2.Size = new Size(151, 37);
            button2.TabIndex = 8;
            button2.Text = "Upload";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 372);
            label5.Name = "label5";
            label5.Size = new Size(167, 31);
            label5.TabIndex = 9;
            label5.Text = "Claim History:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 425);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(493, 282);
            dataGridView1.TabIndex = 10;
            // 
            // frmLecturerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 776);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(btnSubmitClaim);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLecturerDashboard";
            Text = "Lecturer Dashboard - CMCS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnSubmitClaim;
        private Button button2;
        private Label label5;
        private DataGridView dataGridView1;
    }
}