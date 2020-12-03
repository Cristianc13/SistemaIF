namespace WIN
{
    partial class Prueba
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartopproductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartproductosCat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartopproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartproductosCat)).BeginInit();
            this.SuspendLayout();
            // 
            // chartopproductos
            // 
            this.chartopproductos.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartopproductos.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartopproductos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Rotation = 50;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Black;
            this.chartopproductos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartopproductos.Legends.Add(legend1);
            this.chartopproductos.Location = new System.Drawing.Point(36, 3);
            this.chartopproductos.Name = "chartopproductos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartopproductos.Series.Add(series1);
            this.chartopproductos.Size = new System.Drawing.Size(531, 362);
            this.chartopproductos.TabIndex = 0;
            this.chartopproductos.Text = "chart1";
            title1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Titulo";
            title1.Text = "Productos mas vendidos.";
            this.chartopproductos.Titles.Add(title1);
            // 
            // chartproductosCat
            // 
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.Name = "ChartArea1";
            this.chartproductosCat.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartproductosCat.Legends.Add(legend2);
            this.chartproductosCat.Location = new System.Drawing.Point(618, 32);
            this.chartproductosCat.Name = "chartproductosCat";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartproductosCat.Series.Add(series2);
            this.chartproductosCat.Size = new System.Drawing.Size(394, 301);
            this.chartproductosCat.TabIndex = 1;
            this.chartproductosCat.Text = "chart1";
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 636);
            this.Controls.Add(this.chartproductosCat);
            this.Controls.Add(this.chartopproductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prueba";
            this.Load += new System.EventHandler(this.Prueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartopproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartproductosCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartopproductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartproductosCat;
    }
}