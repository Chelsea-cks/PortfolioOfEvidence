namespace PortfolioOfEvidence
{
    partial class UploadDocument
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
            btnBrowseFile = new Button();
            lblSelectedFile = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 41);
            label1.TabIndex = 0;
            label1.Text = "Document Upload";
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowseFile.Location = new Point(12, 77);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new Size(105, 32);
            btnBrowseFile.TabIndex = 1;
            btnBrowseFile.Text = "BROWSE";
            btnBrowseFile.UseVisualStyleBackColor = true;
            btnBrowseFile.Click += btnBrowseFile_Click;
            // 
            // lblSelectedFile
            // 
            lblSelectedFile.AutoSize = true;
            lblSelectedFile.Location = new Point(190, 84);
            lblSelectedFile.Name = "lblSelectedFile";
            lblSelectedFile.Size = new Size(132, 20);
            lblSelectedFile.TabIndex = 2;
            lblSelectedFile.Text = "NO FILE SELECTED";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 149);
            button1.Name = "button1";
            button1.Size = new Size(105, 29);
            button1.TabIndex = 3;
            button1.Text = "UPLOAD";
            button1.UseVisualStyleBackColor = true;
            // 
            // UploadDocument
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 541);
            Controls.Add(button1);
            Controls.Add(lblSelectedFile);
            Controls.Add(btnBrowseFile);
            Controls.Add(label1);
            Name = "UploadDocument";
            Text = "UploadDocument";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBrowseFile;
        private Label lblSelectedFile;
        private Button button1;
    }
}