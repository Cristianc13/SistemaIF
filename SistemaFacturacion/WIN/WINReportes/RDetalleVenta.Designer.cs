namespace WIN.WINReportes
{
    partial class RDetalleVenta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RBLReporteVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Semanabutton = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Mesbutton = new System.Windows.Forms.Button();
            this.Aniobutton = new System.Windows.Forms.Button();
            this.Totalbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RBLReporteVentasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RBLReporteVentasBindingSource
            // 
            this.RBLReporteVentasBindingSource.DataMember = "listaVentas";
            this.RBLReporteVentasBindingSource.DataSource = typeof(BL.RBLReporteVentas);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Totalbutton);
            this.panel1.Controls.Add(this.Aniobutton);
            this.panel1.Controls.Add(this.Mesbutton);
            this.panel1.Controls.Add(this.Semanabutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 643);
            this.panel1.TabIndex = 0;
            // 
            // Semanabutton
            // 
            this.Semanabutton.Location = new System.Drawing.Point(9, 67);
            this.Semanabutton.Name = "Semanabutton";
            this.Semanabutton.Size = new System.Drawing.Size(181, 23);
            this.Semanabutton.TabIndex = 0;
            this.Semanabutton.Text = "Semana";
            this.Semanabutton.UseVisualStyleBackColor = true;
            this.Semanabutton.Click += new System.EventHandler(this.Semanabutton_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.RBLReporteVentasBindingSource;
            reportDataSource4.Name = "VEntasReporte";
            reportDataSource4.Value = this.RBLReporteVentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WIN.WINReportes.Reportes.RDetalleVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(200, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(600, 643);
            this.reportViewer1.TabIndex = 1;
            // 
            // Mesbutton
            // 
            this.Mesbutton.Location = new System.Drawing.Point(9, 133);
            this.Mesbutton.Name = "Mesbutton";
            this.Mesbutton.Size = new System.Drawing.Size(181, 23);
            this.Mesbutton.TabIndex = 1;
            this.Mesbutton.Text = "Mes";
            this.Mesbutton.UseVisualStyleBackColor = true;
            this.Mesbutton.Click += new System.EventHandler(this.Mesbutton_Click);
            // 
            // Aniobutton
            // 
            this.Aniobutton.Location = new System.Drawing.Point(9, 197);
            this.Aniobutton.Name = "Aniobutton";
            this.Aniobutton.Size = new System.Drawing.Size(181, 23);
            this.Aniobutton.TabIndex = 2;
            this.Aniobutton.Text = "Año ";
            this.Aniobutton.UseVisualStyleBackColor = true;
            this.Aniobutton.Click += new System.EventHandler(this.Aniobutton_Click);
            // 
            // Totalbutton
            // 
            this.Totalbutton.Location = new System.Drawing.Point(9, 262);
            this.Totalbutton.Name = "Totalbutton";
            this.Totalbutton.Size = new System.Drawing.Size(181, 23);
            this.Totalbutton.TabIndex = 3;
            this.Totalbutton.Text = "Total";
            this.Totalbutton.UseVisualStyleBackColor = true;
            // 
            // RDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "RDetalleVenta";
            this.Text = "RDetalleVenta";
            this.Load += new System.EventHandler(this.RDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RBLReporteVentasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Semanabutton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RBLReporteVentasBindingSource;
        private System.Windows.Forms.Button Totalbutton;
        private System.Windows.Forms.Button Aniobutton;
        private System.Windows.Forms.Button Mesbutton;
    }
}