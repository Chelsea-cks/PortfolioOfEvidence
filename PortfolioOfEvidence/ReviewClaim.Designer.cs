namespace PortfolioOfEvidence
{
    partial class ReviewClaim
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
            txtHoursWorked = new TextBox();
            txtTotalAmount = new TextBox();
            txtHourlyRate = new TextBox();
            label5 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 38);
            label1.TabIndex = 0;
            label1.Text = "CLAIM REVIEWS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "Hours Worked:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 2;
            label3.Text = "Hourly Rate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 188);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 3;
            label4.Text = "Total Amount:";
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.BackColor = SystemColors.ButtonShadow;
            txtHoursWorked.Location = new Point(197, 78);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.ReadOnly = true;
            txtHoursWorked.Size = new Size(220, 27);
            txtHoursWorked.TabIndex = 4;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BackColor = SystemColors.ButtonShadow;
            txtTotalAmount.Location = new Point(197, 185);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(220, 27);
            txtTotalAmount.TabIndex = 5;
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.BackColor = SystemColors.ButtonShadow;
            txtHourlyRate.Location = new Point(197, 131);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.ReadOnly = true;
            txtHourlyRate.Size = new Size(220, 27);
            txtHourlyRate.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 242);
            label5.Name = "label5";
            label5.Size = new Size(186, 20);
            label5.TabIndex = 7;
            label5.Text = "UPLOADED DOCUMENTS";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 275);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(405, 164);
            listBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Green;
            button1.Location = new Point(28, 460);
            button1.Name = "button1";
            button1.Size = new Size(116, 39);
            button1.TabIndex = 9;
            button1.Text = "APPROVE";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(271, 460);
            button2.Name = "button2";
            button2.Size = new Size(127, 39);
            button2.TabIndex = 10;
            button2.Text = "REJECT";
            button2.UseVisualStyleBackColor = true;
            // 
            // ReviewClaim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 675);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(txtHourlyRate);
            Controls.Add(txtTotalAmount);
            Controls.Add(txtHoursWorked);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReviewClaim";
            Text = "ReviewClaim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtHoursWorked;
        private TextBox txtTotalAmount;
        private TextBox txtHourlyRate;
        private Label label5;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
    }
}