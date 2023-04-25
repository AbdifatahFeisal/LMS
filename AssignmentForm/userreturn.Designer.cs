namespace AssignmentForm
{
    partial class userreturn
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.MemberIDTextBox = new System.Windows.Forms.TextBox();
            this.BookTitleComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MemberIDlabel
            // 
            this.MemberIDlabel.AutoSize = true;
            this.MemberIDlabel.Location = new System.Drawing.Point(200, 65);
            this.MemberIDlabel.Name = "MemberIDlabel";
            this.MemberIDlabel.Size = new System.Drawing.Size(122, 25);
            this.MemberIDlabel.TabIndex = 0;
            this.MemberIDlabel.Text = "Member ID:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(418, 154);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(158, 43);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MemberIDTextBox
            // 
            this.MemberIDTextBox.Location = new System.Drawing.Point(362, 65);
            this.MemberIDTextBox.Name = "MemberIDTextBox";
            this.MemberIDTextBox.Size = new System.Drawing.Size(375, 31);
            this.MemberIDTextBox.TabIndex = 3;
            // 
            // BookTitleComboBox
            // 
            this.BookTitleComboBox.FormattingEnabled = true;
            this.BookTitleComboBox.Location = new System.Drawing.Point(192, 254);
            this.BookTitleComboBox.Name = "BookTitleComboBox";
            this.BookTitleComboBox.Size = new System.Drawing.Size(665, 33);
            this.BookTitleComboBox.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnButton.Location = new System.Drawing.Point(862, 552);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(151, 45);
            this.ReturnButton.TabIndex = 6;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // userreturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AssignmentForm.Properties.Resources.thi_business_and_education_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 643);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BookTitleComboBox);
            this.Controls.Add(this.MemberIDTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MemberIDlabel);
            this.Name = "userreturn";
            this.Text = "Return";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MemberIDlabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox MemberIDTextBox;
        private System.Windows.Forms.ComboBox BookTitleComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ReturnButton;
    }
}