namespace AssignmentForm
{
    partial class selection
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
            this.userbutton = new System.Windows.Forms.Button();
            this.managerbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userbutton
            // 
            this.userbutton.Location = new System.Drawing.Point(371, 171);
            this.userbutton.Name = "userbutton";
            this.userbutton.Size = new System.Drawing.Size(118, 50);
            this.userbutton.TabIndex = 1;
            this.userbutton.Text = "User";
            this.userbutton.UseVisualStyleBackColor = true;
            this.userbutton.Click += new System.EventHandler(this.userbutton_Click);
            // 
            // managerbutton
            // 
            this.managerbutton.Location = new System.Drawing.Point(371, 271);
            this.managerbutton.Name = "managerbutton";
            this.managerbutton.Size = new System.Drawing.Size(118, 54);
            this.managerbutton.TabIndex = 2;
            this.managerbutton.Text = "Manager";
            this.managerbutton.UseVisualStyleBackColor = true;
            this.managerbutton.Click += new System.EventHandler(this.managerbutton_Click);
            // 
            // selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AssignmentForm.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(806, 511);
            this.Controls.Add(this.managerbutton);
            this.Controls.Add(this.userbutton);
            this.Name = "selection";
            this.Text = "selection";
            this.Load += new System.EventHandler(this.selection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userbutton;
        private System.Windows.Forms.Button managerbutton;
    }
}