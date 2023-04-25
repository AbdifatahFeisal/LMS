namespace AssignmentForm
{
    partial class userLogn
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
            this.signinbutton = new System.Windows.Forms.Button();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.apulibrarysystemlabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // signinbutton
            // 
            this.signinbutton.Location = new System.Drawing.Point(180, 298);
            this.signinbutton.Name = "signinbutton";
            this.signinbutton.Size = new System.Drawing.Size(141, 59);
            this.signinbutton.TabIndex = 3;
            this.signinbutton.Text = "LOGIN";
            this.signinbutton.UseVisualStyleBackColor = true;
            this.signinbutton.Click += new System.EventHandler(this.signinbutton_Click);
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(167, 184);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(177, 31);
            this.passwordtextbox.TabIndex = 2;
            this.passwordtextbox.UseSystemPasswordChar = true;
            // 
            // usernametextbox
            // 
            this.usernametextbox.Location = new System.Drawing.Point(167, 107);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(177, 31);
            this.usernametextbox.TabIndex = 1;
            // 
            // apulibrarysystemlabel
            // 
            this.apulibrarysystemlabel.AutoSize = true;
            this.apulibrarysystemlabel.Font = new System.Drawing.Font("MV Boli", 18.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.apulibrarysystemlabel.Location = new System.Drawing.Point(89, 18);
            this.apulibrarysystemlabel.Name = "apulibrarysystemlabel";
            this.apulibrarysystemlabel.Size = new System.Drawing.Size(603, 64);
            this.apulibrarysystemlabel.TabIndex = 3;
            this.apulibrarysystemlabel.Text = "APU LIBRARY SYSTEM";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(24, 113);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(113, 25);
            this.usernamelabel.TabIndex = 4;
            this.usernamelabel.Text = "username:";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(24, 190);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(110, 25);
            this.passwordlabel.TabIndex = 5;
            this.passwordlabel.Text = "password:";
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(12, 384);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(116, 43);
            this.backbutton.TabIndex = 6;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Location = new System.Drawing.Point(167, 234);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(197, 29);
            this.showPassword.TabIndex = 7;
            this.showPassword.Text = "Show Password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // userLogn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AssignmentForm.Properties.Resources.dlv_plugin_for_divi___Copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.apulibrarysystemlabel);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.signinbutton);
            this.Name = "userLogn";
            this.Text = "userLogn";
            this.Load += new System.EventHandler(this.userLogn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signinbutton;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.Label apulibrarysystemlabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.CheckBox showPassword;
    }
}