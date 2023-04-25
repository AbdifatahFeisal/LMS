namespace AssignmentForm
{
    partial class Reports
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
            this.displaybutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusreportlabel = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.displayallbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // displaybutton
            // 
            this.displaybutton.Location = new System.Drawing.Point(747, 68);
            this.displaybutton.Name = "displaybutton";
            this.displaybutton.Size = new System.Drawing.Size(147, 46);
            this.displaybutton.TabIndex = 0;
            this.displaybutton.Text = "Display";
            this.displaybutton.UseVisualStyleBackColor = true;
            this.displaybutton.Click += new System.EventHandler(this.displaybutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(142, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1113, 299);
            this.dataGridView1.TabIndex = 1;
            // 
            // statusreportlabel
            // 
            this.statusreportlabel.AutoSize = true;
            this.statusreportlabel.Location = new System.Drawing.Point(452, 26);
            this.statusreportlabel.Name = "statusreportlabel";
            this.statusreportlabel.Size = new System.Drawing.Size(149, 25);
            this.statusreportlabel.TabIndex = 2;
            this.statusreportlabel.Text = "Status Report:";
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(39, 666);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(156, 55);
            this.backbutton.TabIndex = 3;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(281, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(413, 31);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // displayallbutton
            // 
            this.displayallbutton.Location = new System.Drawing.Point(576, 199);
            this.displayallbutton.Name = "displayallbutton";
            this.displayallbutton.Size = new System.Drawing.Size(165, 46);
            this.displayallbutton.TabIndex = 5;
            this.displayallbutton.Text = "Display All";
            this.displayallbutton.UseVisualStyleBackColor = true;
            this.displayallbutton.Click += new System.EventHandler(this.displayallbutton_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AssignmentForm.Properties.Resources.thi_business_and_education_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1519, 792);
            this.Controls.Add(this.displayallbutton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.statusreportlabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.displaybutton);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displaybutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label statusreportlabel;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button displayallbutton;
    }
}