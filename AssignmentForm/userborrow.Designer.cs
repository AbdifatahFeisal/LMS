namespace AssignmentForm
{
    partial class userborrow
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
            this.selectbooklabel = new System.Windows.Forms.Label();
            this.MemeberIDlabel = new System.Windows.Forms.Label();
            this.MemberNameLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LoanDurationLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.BookIDLabel = new System.Windows.Forms.Label();
            this.BorrowDateLabel = new System.Windows.Forms.Label();
            this.MemberIDTextBox = new System.Windows.Forms.TextBox();
            this.MemberNameTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.LoanDurationTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.BookIDTextBox = new System.Windows.Forms.TextBox();
            this.BorrowDateTextBox = new System.Windows.Forms.TextBox();
            this.BookComboBox = new System.Windows.Forms.ComboBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectbooklabel
            // 
            this.selectbooklabel.AutoSize = true;
            this.selectbooklabel.Location = new System.Drawing.Point(34, 52);
            this.selectbooklabel.Name = "selectbooklabel";
            this.selectbooklabel.Size = new System.Drawing.Size(421, 25);
            this.selectbooklabel.TabIndex = 0;
            this.selectbooklabel.Text = "Please select the book you wish to borrow:";
            // 
            // MemeberIDlabel
            // 
            this.MemeberIDlabel.AutoSize = true;
            this.MemeberIDlabel.Location = new System.Drawing.Point(313, 217);
            this.MemeberIDlabel.Name = "MemeberIDlabel";
            this.MemeberIDlabel.Size = new System.Drawing.Size(116, 25);
            this.MemeberIDlabel.TabIndex = 1;
            this.MemeberIDlabel.Text = "Member ID";
            // 
            // MemberNameLabel
            // 
            this.MemberNameLabel.AutoSize = true;
            this.MemberNameLabel.Location = new System.Drawing.Point(313, 279);
            this.MemberNameLabel.Name = "MemberNameLabel";
            this.MemberNameLabel.Size = new System.Drawing.Size(158, 25);
            this.MemberNameLabel.TabIndex = 2;
            this.MemberNameLabel.Text = "Member Name:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(313, 342);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(59, 25);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title:";
            // 
            // LoanDurationLabel
            // 
            this.LoanDurationLabel.AutoSize = true;
            this.LoanDurationLabel.Location = new System.Drawing.Point(313, 402);
            this.LoanDurationLabel.Name = "LoanDurationLabel";
            this.LoanDurationLabel.Size = new System.Drawing.Size(153, 25);
            this.LoanDurationLabel.TabIndex = 4;
            this.LoanDurationLabel.Text = "Loan Duration:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(313, 463);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(66, 25);
            this.TypeLabel.TabIndex = 5;
            this.TypeLabel.Text = "Type:";
            // 
            // BookIDLabel
            // 
            this.BookIDLabel.AutoSize = true;
            this.BookIDLabel.Location = new System.Drawing.Point(313, 511);
            this.BookIDLabel.Name = "BookIDLabel";
            this.BookIDLabel.Size = new System.Drawing.Size(81, 25);
            this.BookIDLabel.TabIndex = 6;
            this.BookIDLabel.Text = "BookID";
            // 
            // BorrowDateLabel
            // 
            this.BorrowDateLabel.AutoSize = true;
            this.BorrowDateLabel.Location = new System.Drawing.Point(313, 575);
            this.BorrowDateLabel.Name = "BorrowDateLabel";
            this.BorrowDateLabel.Size = new System.Drawing.Size(136, 25);
            this.BorrowDateLabel.TabIndex = 7;
            this.BorrowDateLabel.Text = "Borrow Date:";
            // 
            // MemberIDTextBox
            // 
            this.MemberIDTextBox.Location = new System.Drawing.Point(503, 211);
            this.MemberIDTextBox.Name = "MemberIDTextBox";
            this.MemberIDTextBox.Size = new System.Drawing.Size(190, 31);
            this.MemberIDTextBox.TabIndex = 9;
            this.MemberIDTextBox.TextChanged += new System.EventHandler(this.MemberIDTextBox_TextChanged);
            // 
            // MemberNameTextBox
            // 
            this.MemberNameTextBox.Location = new System.Drawing.Point(503, 273);
            this.MemberNameTextBox.Name = "MemberNameTextBox";
            this.MemberNameTextBox.Size = new System.Drawing.Size(190, 31);
            this.MemberNameTextBox.TabIndex = 10;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(503, 336);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(190, 31);
            this.TitleTextBox.TabIndex = 11;
            // 
            // LoanDurationTextBox
            // 
            this.LoanDurationTextBox.Location = new System.Drawing.Point(503, 402);
            this.LoanDurationTextBox.Name = "LoanDurationTextBox";
            this.LoanDurationTextBox.Size = new System.Drawing.Size(190, 31);
            this.LoanDurationTextBox.TabIndex = 12;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(503, 457);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(190, 31);
            this.TypeTextBox.TabIndex = 13;
            // 
            // BookIDTextBox
            // 
            this.BookIDTextBox.Location = new System.Drawing.Point(503, 508);
            this.BookIDTextBox.Name = "BookIDTextBox";
            this.BookIDTextBox.Size = new System.Drawing.Size(190, 31);
            this.BookIDTextBox.TabIndex = 14;
            // 
            // BorrowDateTextBox
            // 
            this.BorrowDateTextBox.Location = new System.Drawing.Point(503, 569);
            this.BorrowDateTextBox.Name = "BorrowDateTextBox";
            this.BorrowDateTextBox.Size = new System.Drawing.Size(190, 31);
            this.BorrowDateTextBox.TabIndex = 15;
            // 
            // BookComboBox
            // 
            this.BookComboBox.FormattingEnabled = true;
            this.BookComboBox.Location = new System.Drawing.Point(39, 90);
            this.BookComboBox.Name = "BookComboBox";
            this.BookComboBox.Size = new System.Drawing.Size(956, 33);
            this.BookComboBox.TabIndex = 16;
            this.BookComboBox.SelectedIndexChanged += new System.EventHandler(this.BookComboBox_SelectedIndexChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(833, 686);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(192, 55);
            this.ConfirmButton.TabIndex = 17;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(39, 673);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(135, 58);
            this.BackButton.TabIndex = 18;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // userborrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AssignmentForm.Properties.Resources.thi_business_and_education_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1312, 863);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.BookComboBox);
            this.Controls.Add(this.BorrowDateTextBox);
            this.Controls.Add(this.BookIDTextBox);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.LoanDurationTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.MemberNameTextBox);
            this.Controls.Add(this.MemberIDTextBox);
            this.Controls.Add(this.BorrowDateLabel);
            this.Controls.Add(this.BookIDLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.LoanDurationLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MemberNameLabel);
            this.Controls.Add(this.MemeberIDlabel);
            this.Controls.Add(this.selectbooklabel);
            this.Name = "userborrow";
            this.Text = "Borrow";
            this.Load += new System.EventHandler(this.Borrow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectbooklabel;
        private System.Windows.Forms.Label MemeberIDlabel;
        private System.Windows.Forms.Label MemberNameLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label LoanDurationLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label BookIDLabel;
        private System.Windows.Forms.Label BorrowDateLabel;
        private System.Windows.Forms.TextBox MemberIDTextBox;
        private System.Windows.Forms.TextBox MemberNameTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox LoanDurationTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox BookIDTextBox;
        private System.Windows.Forms.TextBox BorrowDateTextBox;
        private System.Windows.Forms.ComboBox BookComboBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button BackButton;
    }
}