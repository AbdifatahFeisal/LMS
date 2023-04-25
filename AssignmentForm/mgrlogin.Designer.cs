namespace AssignmentForm
{
    partial class mgrlogin
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
            this.apulibrarysystemlabel = new System.Windows.Forms.Label();
            this.useridlabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.useridtextBox = new System.Windows.Forms.TextBox();
            this.pwordtextBox = new System.Windows.Forms.TextBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.showpasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // apulibrarysystemlabel
            // 
            this.apulibrarysystemlabel.AutoSize = true;
            this.apulibrarysystemlabel.Font = new System.Drawing.Font("MV Boli", 18.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.apulibrarysystemlabel.Location = new System.Drawing.Point(138, 32);
            this.apulibrarysystemlabel.Name = "apulibrarysystemlabel";
            this.apulibrarysystemlabel.Size = new System.Drawing.Size(603, 64);
            this.apulibrarysystemlabel.TabIndex = 0;
            this.apulibrarysystemlabel.Text = "APU LIBRARY SYSTEM";
            // 
            // useridlabel
            // 
            this.useridlabel.AutoSize = true;
            this.useridlabel.Location = new System.Drawing.Point(30, 115);
            this.useridlabel.Name = "useridlabel";
            this.useridlabel.Size = new System.Drawing.Size(89, 25);
            this.useridlabel.TabIndex = 1;
            this.useridlabel.Text = "User ID:";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(12, 181);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(112, 25);
            this.passwordlabel.TabIndex = 2;
            this.passwordlabel.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(178, 287);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(112, 49);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "LOG IN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // useridtextBox
            // 
            this.useridtextBox.Location = new System.Drawing.Point(162, 112);
            this.useridtextBox.Name = "useridtextBox";
            this.useridtextBox.Size = new System.Drawing.Size(138, 31);
            this.useridtextBox.TabIndex = 4;
            // 
            // pwordtextBox
            // 
            this.pwordtextBox.Location = new System.Drawing.Point(162, 175);
            this.pwordtextBox.Name = "pwordtextBox";
            this.pwordtextBox.Size = new System.Drawing.Size(138, 31);
            this.pwordtextBox.TabIndex = 5;
            this.pwordtextBox.UseSystemPasswordChar = true;
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(12, 388);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(107, 50);
            this.backbutton.TabIndex = 6;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // showpasswordCheckBox
            // 
            this.showpasswordCheckBox.AutoSize = true;
            this.showpasswordCheckBox.Location = new System.Drawing.Point(162, 230);
            this.showpasswordCheckBox.Name = "showpasswordCheckBox";
            this.showpasswordCheckBox.Size = new System.Drawing.Size(197, 29);
            this.showpasswordCheckBox.TabIndex = 7;
            this.showpasswordCheckBox.Text = "Show Password";
            this.showpasswordCheckBox.UseVisualStyleBackColor = true;
            this.showpasswordCheckBox.CheckedChanged += new System.EventHandler(this.showpasswordCheckBox_CheckedChanged);
            // 
            // mgrlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AssignmentForm.Properties.Resources.dlv_plugin_for_divi___Copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 549);
            this.Controls.Add(this.showpasswordCheckBox);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.pwordtextBox);
            this.Controls.Add(this.useridtextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.useridlabel);
            this.Controls.Add(this.apulibrarysystemlabel);
            this.Name = "mgrlogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label apulibrarysystemlabel;
        private System.Windows.Forms.Label useridlabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox useridtextBox;
        private System.Windows.Forms.TextBox pwordtextBox;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.CheckBox showpasswordCheckBox;
    }
}

