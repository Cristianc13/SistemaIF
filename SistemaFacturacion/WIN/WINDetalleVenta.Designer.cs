namespace WIN
{
    partial class WINDetalleVenta
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.ImportetextBox = new System.Windows.Forms.TextBox();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductocomboBox = new System.Windows.Forms.ComboBox();
            this.DVentadataGridView = new System.Windows.Forms.DataGridView();
            this.cnombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cprecioSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cimporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOpciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVentadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Guardarbutton);
            this.splitContainer1.Panel1.Controls.Add(this.Agregarbutton);
            this.splitContainer1.Panel1.Controls.Add(this.ImportetextBox);
            this.splitContainer1.Panel1.Controls.Add(this.PreciotextBox);
            this.splitContainer1.Panel1.Controls.Add(this.CantidadtextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.ProductocomboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DVentadataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(744, 518);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 0;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(153, 136);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(86, 30);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(42, 136);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(86, 30);
            this.Agregarbutton.TabIndex = 8;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // ImportetextBox
            // 
            this.ImportetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportetextBox.Location = new System.Drawing.Point(474, 91);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.ReadOnly = true;
            this.ImportetextBox.Size = new System.Drawing.Size(199, 23);
            this.ImportetextBox.TabIndex = 7;
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreciotextBox.Location = new System.Drawing.Point(474, 36);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(199, 23);
            this.PreciotextBox.TabIndex = 6;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadtextBox.Location = new System.Drawing.Point(107, 91);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(231, 23);
            this.CantidadtextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Importe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductocomboBox
            // 
            this.ProductocomboBox.DropDownHeight = 115;
            this.ProductocomboBox.DropDownWidth = 240;
            this.ProductocomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductocomboBox.FormattingEnabled = true;
            this.ProductocomboBox.IntegralHeight = false;
            this.ProductocomboBox.Location = new System.Drawing.Point(107, 33);
            this.ProductocomboBox.Name = "ProductocomboBox";
            this.ProductocomboBox.Size = new System.Drawing.Size(231, 24);
            this.ProductocomboBox.TabIndex = 0;
            this.ProductocomboBox.SelectedIndexChanged += new System.EventHandler(this.ProductocomboBox_SelectedIndexChanged);
            // 
            // DVentadataGridView
            // 
            this.DVentadataGridView.AllowUserToAddRows = false;
            this.DVentadataGridView.AllowUserToDeleteRows = false;
            this.DVentadataGridView.AllowUserToResizeColumns = false;
            this.DVentadataGridView.AllowUserToResizeRows = false;
            this.DVentadataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DVentadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVentadataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnombreProducto,
            this.ccantidadProducto,
            this.cprecioSalida,
            this.cIVA,
            this.cimporte,
            this.cOpciones});
            this.DVentadataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVentadataGridView.Location = new System.Drawing.Point(0, 0);
            this.DVentadataGridView.Name = "DVentadataGridView";
            this.DVentadataGridView.ReadOnly = true;
            this.DVentadataGridView.RowHeadersVisible = false;
            this.DVentadataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVentadataGridView.Size = new System.Drawing.Size(744, 333);
            this.DVentadataGridView.TabIndex = 0;
            this.DVentadataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVentadataGridView_CellClick);
            // 
            // cnombreProducto
            // 
            this.cnombreProducto.HeaderText = "Producto";
            this.cnombreProducto.Name = "cnombreProducto";
            this.cnombreProducto.ReadOnly = true;
            // 
            // ccantidadProducto
            // 
            this.ccantidadProducto.HeaderText = "Cantidad";
            this.ccantidadProducto.Name = "ccantidadProducto";
            this.ccantidadProducto.ReadOnly = true;
            // 
            // cprecioSalida
            // 
            this.cprecioSalida.HeaderText = "Precio";
            this.cprecioSalida.Name = "cprecioSalida";
            this.cprecioSalida.ReadOnly = true;
            // 
            // cIVA
            // 
            this.cIVA.HeaderText = "IVA";
            this.cIVA.Name = "cIVA";
            this.cIVA.ReadOnly = true;
            // 
            // cimporte
            // 
            this.cimporte.HeaderText = "Importe";
            this.cimporte.Name = "cimporte";
            this.cimporte.ReadOnly = true;
            // 
            // cOpciones
            // 
            this.cOpciones.HeaderText = "Opciones";
            this.cOpciones.Name = "cOpciones";
            this.cOpciones.ReadOnly = true;
            // 
            // WINDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 518);
            this.Controls.Add(this.splitContainer1);
            this.Name = "WINDetalleVenta";
            this.Text = "WINDetalleVenta";
            this.Load += new System.EventHandler(this.WINDetalleVenta_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DVentadataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProductocomboBox;
        private System.Windows.Forms.DataGridView DVentadataGridView;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.TextBox ImportetextBox;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cprecioSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cimporte;
        private System.Windows.Forms.DataGridViewButtonColumn cOpciones;
    }
}