namespace AssignmentForm
{
    partial class useraction
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
            this.actionlabel = new System.Windows.Forms.Label();
            this.borrowbutton = new System.Windows.Forms.Button();
            this.returnbutton = new System.Windows.Forms.Button();
            this.renewbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // actionlabel
            // 
            this.actionlabel.AutoSize = true;
            this.actionlabel.Location = new System.Drawing.Point(270, 150);
            this.actionlabel.Name = "actionlabel";
            this.actionlabel.Size = new System.Drawing.Size(272, 25);
            this.actionlabel.TabIndex = 0;
            this.actionlabel.Text = "Please choose your action:";
            // 
            // borrowbutton
            // 
            this.borrowbutton.Location = new System.Drawing.Point(145, 299);
            this.borrowbutton.Name = "borrowbutton";
            this.borrowbutton.Size = new System.Drawing.Size(96, 58);
            this.borrowbutton.TabIndex = 1;
            this.borrowbutton.Text = "Borrow";
            this.borrowbutton.UseVisualStyleBackColor = true;
            this.borrowbutton.Click += new System.EventHandler(this.borrowbutton_Click);
            // 
            // returnbutton
            // 
            this.returnbutton.Location = new System.Drawing.Point(333, 299);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(105, 58);
            this.returnbutton.TabIndex = 2;
            this.returnbutton.Text = "Return";
            this.returnbutton.UseVisualStyleBackColor = true;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            // 
            // renewbutton
            // 
            this.renewbutton.Location = new System.Drawing.Point(532, 299);
            this.renewbutton.Name = "renewbutton";
            this.renewbutton.Size = new System.Drawing.Size(98, 58);
            this.renewbutton.TabIndex = 3;
            this.renewbutton.Text = "Renew";
            this.renewbutton.UseVisualStyleBackColor = true;
            this.renewbutton.Click += new System.EventHandler(this.renewbutton_Click);
            // 
            // useraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AssignmentForm.Properties.Resources.thi_business_and_education_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.renewbutton);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.borrowbutton);
            this.Controls.Add(this.actionlabel);
            this.Name = "useraction";
            this.Text = "userlogin";
            this.Load += new System.EventHandler(this.useraction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label actionlabel;
        private System.Windows.Forms.Button borrowbutton;
        private System.Windows.Forms.Button returnbutton;
        private System.Windows.Forms.Button renewbutton;
    }
}