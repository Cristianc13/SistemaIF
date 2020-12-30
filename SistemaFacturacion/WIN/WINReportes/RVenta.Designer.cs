namespace WIN.WINReportes
{
    partial class RVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RVenta));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.DetalleVenta1 = new WIN.WINReportes.ReporteCristal.DetalleVenta();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtfrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnpersonalizado = new FontAwesome.Sharp.IconButton();
            this.aniobtn = new FontAwesome.Sharp.IconButton();
            this.totalbtn = new FontAwesome.Sharp.IconButton();
            this.mesbtn = new FontAwesome.Sharp.IconButton();
            this.Semanabtn = new FontAwesome.Sharp.IconButton();
            this.dtdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.DetalleVenta1;
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.ShowZoomButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1110, 708);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.dtfrom);
            this.panel1.Controls.Add(this.btnpersonalizado);
            this.panel1.Controls.Add(this.aniobtn);
            this.panel1.Controls.Add(this.totalbtn);
            this.panel1.Controls.Add(this.mesbtn);
            this.panel1.Controls.Add(this.Semanabtn);
            this.panel1.Controls.Add(this.dtdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 708);
            this.panel1.TabIndex = 1;
            // 
            // dtfrom
            // 
            this.dtfrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtfrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.dtfrom.BorderRadius = 0;
            this.dtfrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtfrom.ForeColor = System.Drawing.Color.White;
            this.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfrom.FormatCustom = null;
            this.dtfrom.Location = new System.Drawing.Point(8, 430);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(225, 34);
            this.dtfrom.TabIndex = 50;
            this.dtfrom.Value = new System.DateTime(2020, 12, 9, 10, 31, 53, 0);
            // 
            // btnpersonalizado
            // 
            this.btnpersonalizado.FlatAppearance.BorderSize = 0;
            this.btnpersonalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpersonalizado.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpersonalizado.ForeColor = System.Drawing.Color.White;
            this.btnpersonalizado.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnpersonalizado.IconColor = System.Drawing.Color.White;
            this.btnpersonalizado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnpersonalizado.IconSize = 30;
            this.btnpersonalizado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpersonalizado.Location = new System.Drawing.Point(6, 481);
            this.btnpersonalizado.Name = "btnpersonalizado";
            this.btnpersonalizado.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnpersonalizado.Size = new System.Drawing.Size(226, 46);
            this.btnpersonalizado.TabIndex = 49;
            this.btnpersonalizado.Text = "Generar";
            this.btnpersonalizado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpersonalizado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpersonalizado.UseVisualStyleBackColor = true;
            this.btnpersonalizado.Click += new System.EventHandler(this.btnpersonalizado_Click);
            // 
            // aniobtn
            // 
            this.aniobtn.FlatAppearance.BorderSize = 0;
            this.aniobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aniobtn.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aniobtn.ForeColor = System.Drawing.Color.White;
            this.aniobtn.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.aniobtn.IconColor = System.Drawing.Color.White;
            this.aniobtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.aniobtn.IconSize = 30;
            this.aniobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aniobtn.Location = new System.Drawing.Point(8, 274);
            this.aniobtn.Name = "aniobtn";
            this.aniobtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.aniobtn.Size = new System.Drawing.Size(226, 46);
            this.aniobtn.TabIndex = 48;
            this.aniobtn.Text = "Anual";
            this.aniobtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aniobtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aniobtn.UseVisualStyleBackColor = true;
            this.aniobtn.Click += new System.EventHandler(this.aniobtn_Click);
            // 
            // totalbtn
            // 
            this.totalbtn.FlatAppearance.BorderSize = 0;
            this.totalbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalbtn.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbtn.ForeColor = System.Drawing.Color.White;
            this.totalbtn.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.totalbtn.IconColor = System.Drawing.Color.White;
            this.totalbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.totalbtn.IconSize = 30;
            this.totalbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalbtn.Location = new System.Drawing.Point(8, 326);
            this.totalbtn.Name = "totalbtn";
            this.totalbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.totalbtn.Size = new System.Drawing.Size(226, 46);
            this.totalbtn.TabIndex = 47;
            this.totalbtn.Text = "Ventas totales";
            this.totalbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.totalbtn.UseVisualStyleBackColor = true;
            this.totalbtn.Click += new System.EventHandler(this.totalbtn_Click);
            // 
            // mesbtn
            // 
            this.mesbtn.FlatAppearance.BorderSize = 0;
            this.mesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mesbtn.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesbtn.ForeColor = System.Drawing.Color.White;
            this.mesbtn.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.mesbtn.IconColor = System.Drawing.Color.White;
            this.mesbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mesbtn.IconSize = 30;
            this.mesbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mesbtn.Location = new System.Drawing.Point(7, 219);
            this.mesbtn.Name = "mesbtn";
            this.mesbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.mesbtn.Size = new System.Drawing.Size(226, 46);
            this.mesbtn.TabIndex = 46;
            this.mesbtn.Text = "Ultimos 30 dias";
            this.mesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mesbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mesbtn.UseVisualStyleBackColor = true;
            this.mesbtn.Click += new System.EventHandler(this.mesbtn_Click);
            // 
            // Semanabtn
            // 
            this.Semanabtn.FlatAppearance.BorderSize = 0;
            this.Semanabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Semanabtn.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Semanabtn.ForeColor = System.Drawing.Color.White;
            this.Semanabtn.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.Semanabtn.IconColor = System.Drawing.Color.White;
            this.Semanabtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Semanabtn.IconSize = 30;
            this.Semanabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Semanabtn.Location = new System.Drawing.Point(8, 164);
            this.Semanabtn.Name = "Semanabtn";
            this.Semanabtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Semanabtn.Size = new System.Drawing.Size(226, 46);
            this.Semanabtn.TabIndex = 45;
            this.Semanabtn.Text = "Ultimos 7 dias";
            this.Semanabtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Semanabtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Semanabtn.UseVisualStyleBackColor = true;
            this.Semanabtn.Click += new System.EventHandler(this.Semanabtn_Click);
            // 
            // dtdate
            // 
            this.dtdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.dtdate.BorderRadius = 0;
            this.dtdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtdate.ForeColor = System.Drawing.Color.White;
            this.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtdate.FormatCustom = null;
            this.dtdate.Location = new System.Drawing.Point(8, 384);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(224, 34);
            this.dtdate.TabIndex = 44;
            this.dtdate.Value = new System.DateTime(2020, 12, 9, 10, 31, 53, 0);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.crystalReportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(240, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 708);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.panel3.Controls.Add(this.btnmaximizar);
            this.panel3.Controls.Add(this.btnrestaurar);
            this.panel3.Controls.Add(this.minimizar);
            this.panel3.Controls.Add(this.salir);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1350, 44);
            this.panel3.TabIndex = 12;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximizar.Image")));
            this.btnmaximizar.Location = new System.Drawing.Point(1276, 4);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(35, 35);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnmaximizar.TabIndex = 47;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnrestaurar.Image")));
            this.btnrestaurar.Location = new System.Drawing.Point(1276, 4);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(35, 35);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnrestaurar.TabIndex = 48;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(1240, 4);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(35, 35);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 46;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // salir
            // 
            this.salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salir.Image = global::WIN.Properties.Resources.icerrar;
            this.salir.Location = new System.Drawing.Point(1312, 4);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(35, 35);
            this.salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salir.TabIndex = 45;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Reportes de Venta ";
            // 
            // RVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 752);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "RVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RVenta";
            this.Load += new System.EventHandler(this.RVenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private ReporteCristal.DetalleVenta DetalleVenta1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDatepicker dtdate;
        private Bunifu.Framework.UI.BunifuDatepicker dtfrom;
        private FontAwesome.Sharp.IconButton btnpersonalizado;
        private FontAwesome.Sharp.IconButton aniobtn;
        private FontAwesome.Sharp.IconButton totalbtn;
        private FontAwesome.Sharp.IconButton mesbtn;
        private FontAwesome.Sharp.IconButton Semanabtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.PictureBox btnrestaurar;
    }
}