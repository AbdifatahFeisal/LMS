namespace AssignmentForm
{
    partial class mgraction
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
            this.components = new System.ComponentModel.Container();
            this.assignmentDatabaseDataSet = new AssignmentForm.AssignmentDatabaseDataSet();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new AssignmentForm.AssignmentDatabaseDataSetTableAdapters.loginTableAdapter();
            this.actionlabel = new System.Windows.Forms.Label();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.RenewButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // assignmentDatabaseDataSet
            // 
            this.assignmentDatabaseDataSet.DataSetName = "AssignmentDatabaseDataSet";
            this.assignmentDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.assignmentDatabaseDataSet;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // actionlabel
            // 
            this.actionlabel.AutoSize = true;
            this.actionlabel.Location = new System.Drawing.Point(239, 163);
            this.actionlabel.Name = "actionlabel";
            this.actionlabel.Size = new System.Drawing.Size(303, 25);
            this.actionlabel.TabIndex = 0;
            this.actionlabel.Text = "Please choose what you want:";
            // 
            // BorrowButton
            // 
            this.BorrowButton.Location = new System.Drawing.Point(151, 271);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(97, 49);
            this.BorrowButton.TabIndex = 1;
            this.BorrowButton.Text = "Borrow";
            this.BorrowButton.UseVisualStyleBackColor = true;
            this.BorrowButton.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // RenewButton
            // 
            this.RenewButton.Location = new System.Drawing.Point(291, 271);
            this.RenewButton.Name = "RenewButton";
            this.RenewButton.Size = new System.Drawing.Size(108, 49);
            this.RenewButton.TabIndex = 2;
            this.RenewButton.Text = "Renew";
            this.RenewButton.UseVisualStyleBackColor = true;
            this.RenewButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(459, 271);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(103, 49);
            this.ReturnButton.TabIndex = 3;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.Location = new System.Drawing.Point(594, 271);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(98, 49);
            this.ReportsButton.TabIndex = 4;
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // mgraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AssignmentForm.Properties.Resources.thi_business_and_education_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.RenewButton);
            this.Controls.Add(this.BorrowButton);
            this.Controls.Add(this.actionlabel);
            this.Name = "mgraction";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AssignmentDatabaseDataSet assignmentDatabaseDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private AssignmentDatabaseDataSetTableAdapters.loginTableAdapter loginTableAdapter;
        private System.Windows.Forms.Label actionlabel;
        private System.Windows.Forms.Button BorrowButton;
        private System.Windows.Forms.Button RenewButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button ReportsButton;
    }
}