namespace GraphPlotter
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPoints = new System.Windows.Forms.ListBox();
            this.btnBuildGraph = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGraph
            // 
            chartArea12.AxisX.Interval = 1D;
            chartArea12.AxisX.Maximum = 6D;
            chartArea12.AxisX.Minimum = 0D;
            chartArea12.AxisX.Title = "Ox";
            chartArea12.AxisY.Title = "Oy";
            chartArea12.BorderWidth = 3;
            chartArea12.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chartGraph.Legends.Add(legend12);
            this.chartGraph.Location = new System.Drawing.Point(228, 13);
            this.chartGraph.Name = "chartGraph";
            series12.BorderWidth = 5;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.Crimson;
            series12.Legend = "Legend1";
            series12.Name = "y=(x-2)^2";
            this.chartGraph.Series.Add(series12);
            this.chartGraph.Size = new System.Drawing.Size(660, 420);
            this.chartGraph.TabIndex = 0;
            this.chartGraph.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Координаты точек";
            // 
            // listBoxPoints
            // 
            this.listBoxPoints.FormattingEnabled = true;
            this.listBoxPoints.HorizontalScrollbar = true;
            this.listBoxPoints.ItemHeight = 16;
            this.listBoxPoints.Location = new System.Drawing.Point(15, 37);
            this.listBoxPoints.Name = "listBoxPoints";
            this.listBoxPoints.Size = new System.Drawing.Size(136, 276);
            this.listBoxPoints.TabIndex = 2;
            // 
            // btnBuildGraph
            // 
            this.btnBuildGraph.Location = new System.Drawing.Point(15, 321);
            this.btnBuildGraph.Name = "btnBuildGraph";
            this.btnBuildGraph.Size = new System.Drawing.Size(207, 53);
            this.btnBuildGraph.TabIndex = 3;
            this.btnBuildGraph.Text = "Построить график";
            this.btnBuildGraph.UseVisualStyleBackColor = true;
            this.btnBuildGraph.Click += new System.EventHandler(this.BtnBuildGraph_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Enabled = false;
            this.btnSaveFile.Location = new System.Drawing.Point(15, 380);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(207, 53);
            this.btnSaveFile.TabIndex = 4;
            this.btnSaveFile.Text = "Записать в файл";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 447);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnBuildGraph);
            this.Controls.Add(this.listBoxPoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartGraph);
            this.Name = "MainForm";
            this.Text = "Построение графика";
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPoints;
        private System.Windows.Forms.Button btnBuildGraph;
        private System.Windows.Forms.Button btnSaveFile;
    }
}