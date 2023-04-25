namespace AssignmentForm
{
    partial class mgrreturn
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
            this.MemberIDlabel = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MemberIDTextBox = new System.Windows.Forms.TextBox();
            this.BookTitleComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MemberIDlabel
            // 
            this.MemberIDlabel.AutoSize = true;
            this.MemberIDlabel.Location = new System.Drawing.Point(290, 69);
            this.MemberIDlabel.Name = "MemberIDlabel";
            this.MemberIDlabel.Size = new System.Drawing.Size(122, 25);
            this.MemberIDlabel.TabIndex = 0;
            this.MemberIDlabel.Text = "Member ID:";
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(808, 541);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(146, 50);
            this.ReturnButton.TabIndex = 1;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(72, 531);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(136, 50);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(471, 148);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(131, 41);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MemberIDTextBox
            // 
            this.MemberIDTextBox.Location = new System.Drawing.Point(431, 63);
            this.MemberIDTextBox.Name = "MemberIDTextBox";
            this.MemberIDTextBox.Size = new System.Drawing.Size(282, 31);
            this.MemberIDTextBox.TabIndex = 5;
            // 
            // BookTitleComboBox
            // 
            this.BookTitleComboBox.FormattingEnabled = true;
            this.BookTitleComboBox.Location = new System.Drawing.Point(72, 234);
            this.BookTitleComboBox.Name = "BookTitleComboBox";
            this.BookTitleComboBox.Size = new System.Drawing.Size(882, 33);
            this.BookTitleComboBox.TabIndex = 6;
            // 
            // mgrreturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AssignmentForm.Properties.Resources.thi_business_and_education_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 641);
            this.Controls.Add(this.BookTitleComboBox);
            this.Controls.Add(this.MemberIDTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.MemberIDlabel);
            this.Name = "mgrreturn";
            this.Text = "mgrreturn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MemberIDlabel;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox MemberIDTextBox;
        private System.Windows.Forms.ComboBox BookTitleComboBox;
    }
}