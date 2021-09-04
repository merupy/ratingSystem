
namespace ratingSystem
{
    partial class report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.feedbackGrid = new System.Windows.Forms.DataGridView();
            this.feedbackChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackChart)).BeginInit();
            this.SuspendLayout();
            // 
            // feedbackGrid
            // 
            this.feedbackGrid.AllowUserToAddRows = false;
            this.feedbackGrid.AllowUserToDeleteRows = false;
            this.feedbackGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.feedbackGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedbackGrid.Location = new System.Drawing.Point(12, 336);
            this.feedbackGrid.Name = "feedbackGrid";
            this.feedbackGrid.RowHeadersWidth = 51;
            this.feedbackGrid.RowTemplate.Height = 24;
            this.feedbackGrid.Size = new System.Drawing.Size(991, 284);
            this.feedbackGrid.TabIndex = 0;
            // 
            // feedbackChart
            // 
            chartArea1.Name = "ChartArea1";
            this.feedbackChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.feedbackChart.Legends.Add(legend1);
            this.feedbackChart.Location = new System.Drawing.Point(217, 12);
            this.feedbackChart.Name = "feedbackChart";
            this.feedbackChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.feedbackChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.SandyBrown};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Criteria Rate";
            this.feedbackChart.Series.Add(series1);
            this.feedbackChart.Size = new System.Drawing.Size(660, 300);
            this.feedbackChart.TabIndex = 1;
            this.feedbackChart.Text = "chart1";
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSort.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSort.Location = new System.Drawing.Point(12, 644);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(172, 37);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort by Date";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(851, 644);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 37);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1015, 718);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.feedbackChart);
            this.Controls.Add(this.feedbackGrid);
            this.Name = "report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feedbackGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView feedbackGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart feedbackChart;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnBack;
    }
}