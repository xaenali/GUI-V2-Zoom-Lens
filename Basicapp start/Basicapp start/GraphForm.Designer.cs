namespace Basicapp_start
{
    partial class ZoomCurvesForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DistanceChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // DistanceChart1
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.Title = "Distance From 1st Lens";
            chartArea1.AxisY.Title = "Magnification";
            chartArea1.Name = "ChartArea1";
            this.DistanceChart1.ChartAreas.Add(chartArea1);
            this.DistanceChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.DistanceChart1.Legends.Add(legend1);
            this.DistanceChart1.Location = new System.Drawing.Point(0, 0);
            this.DistanceChart1.Margin = new System.Windows.Forms.Padding(4);
            this.DistanceChart1.Name = "DistanceChart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "D0";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "D1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "D2";
            this.DistanceChart1.Series.Add(series1);
            this.DistanceChart1.Series.Add(series2);
            this.DistanceChart1.Series.Add(series3);
            this.DistanceChart1.Size = new System.Drawing.Size(816, 550);
            this.DistanceChart1.TabIndex = 0;
            this.DistanceChart1.Text = "chart1";
            this.DistanceChart1.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.DistanceChart1_GetToolTipText);
            this.DistanceChart1.Click += new System.EventHandler(this.DistanceChart1_Click);
            this.DistanceChart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DistanceChart1_MouseClick);
            this.DistanceChart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DistanceChart1_MouseMove);
            // 
            // ZoomCurvesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 550);
            this.Controls.Add(this.DistanceChart1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ZoomCurvesForm";
            this.Text = "ZoomCurves Graph";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ZoomCurves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DistanceChart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart DistanceChart1;
    }
}