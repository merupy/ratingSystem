
namespace ratingSystem
{
    partial class adminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPanel));
            this.btnaddCriteria = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnimportData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnaddCriteria
            // 
            this.btnaddCriteria.BackColor = System.Drawing.Color.SandyBrown;
            this.btnaddCriteria.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddCriteria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnaddCriteria.Location = new System.Drawing.Point(246, 342);
            this.btnaddCriteria.Name = "btnaddCriteria";
            this.btnaddCriteria.Size = new System.Drawing.Size(187, 46);
            this.btnaddCriteria.TabIndex = 0;
            this.btnaddCriteria.Text = "Add Criteria";
            this.btnaddCriteria.UseVisualStyleBackColor = false;
            this.btnaddCriteria.Click += new System.EventHandler(this.btnaddCriteria_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.SandyBrown;
            this.btnReport.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReport.Location = new System.Drawing.Point(246, 403);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(187, 40);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnimportData
            // 
            this.btnimportData.BackColor = System.Drawing.Color.SandyBrown;
            this.btnimportData.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimportData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnimportData.Location = new System.Drawing.Point(246, 465);
            this.btnimportData.Name = "btnimportData";
            this.btnimportData.Size = new System.Drawing.Size(187, 46);
            this.btnimportData.TabIndex = 2;
            this.btnimportData.Text = "Import Data";
            this.btnimportData.UseVisualStyleBackColor = false;
            this.btnimportData.Click += new System.EventHandler(this.btnimportData_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 327);
            this.panel1.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SandyBrown;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(246, 530);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "Open";
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(630, 587);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnimportData);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnaddCriteria);
            this.Name = "adminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnaddCriteria;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnimportData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}