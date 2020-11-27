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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Area3DStyle.Inclination = 15;
            chartArea3.Area3DStyle.IsRightAngleAxes = false;
            chartArea3.Area3DStyle.Rotation = 50;
            chartArea3.BackColor = System.Drawing.Color.White;
            chartArea3.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea3.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.Black;
            this.chartopproductos.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartopproductos.Legends.Add(legend3);
            this.chartopproductos.Location = new System.Drawing.Point(36, 3);
            this.chartopproductos.Name = "chartopproductos";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.LabelBackColor = System.Drawing.Color.Transparent;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartopproductos.Series.Add(series3);
            this.chartopproductos.Size = new System.Drawing.Size(531, 362);
            this.chartopproductos.TabIndex = 0;
            this.chartopproductos.Text = "chart1";
            title2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Titulo";
            title2.Text = "Productos mas vendidos.";
            this.chartopproductos.Titles.Add(title2);
            // 
            // chartproductosCat
            // 
            chartArea4.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.Name = "ChartArea1";
            this.chartproductosCat.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartproductosCat.Legends.Add(legend4);
            this.chartproductosCat.Location = new System.Drawing.Point(618, 32);
            this.chartproductosCat.Name = "chartproductosCat";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartproductosCat.Series.Add(series4);
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
            this.Name = "Prueba";
            this.Text = "Prueba";
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