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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Cancelarbutton = new System.Windows.Forms.Button();
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
            this.cidProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVentadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Buscarbutton);
            this.splitContainer1.Panel1.Controls.Add(this.Cancelarbutton);
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
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DVentadataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(992, 740);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(357, 167);
            this.Cancelarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(115, 37);
            this.Cancelarbutton.TabIndex = 10;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(204, 167);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(115, 37);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(56, 167);
            this.Agregarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(115, 37);
            this.Agregarbutton.TabIndex = 8;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // ImportetextBox
            // 
            this.ImportetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportetextBox.Location = new System.Drawing.Point(632, 112);
            this.ImportetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.ReadOnly = true;
            this.ImportetextBox.Size = new System.Drawing.Size(264, 26);
            this.ImportetextBox.TabIndex = 7;
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreciotextBox.Location = new System.Drawing.Point(632, 44);
            this.PreciotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(264, 26);
            this.PreciotextBox.TabIndex = 6;
            this.PreciotextBox.TextChanged += new System.EventHandler(this.PreciotextBox_TextChanged);
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadtextBox.Location = new System.Drawing.Point(143, 112);
            this.CantidadtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(307, 26);
            this.CantidadtextBox.TabIndex = 5;
            this.CantidadtextBox.TextChanged += new System.EventHandler(this.CantidadtextBox_TextChanged);
            this.CantidadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadtextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Importe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductocomboBox
            // 
            this.ProductocomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ProductocomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductocomboBox.DropDownHeight = 115;
            this.ProductocomboBox.DropDownWidth = 240;
            this.ProductocomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductocomboBox.FormattingEnabled = true;
            this.ProductocomboBox.IntegralHeight = false;
            this.ProductocomboBox.Location = new System.Drawing.Point(143, 41);
            this.ProductocomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductocomboBox.Name = "ProductocomboBox";
            this.ProductocomboBox.Size = new System.Drawing.Size(307, 28);
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
            this.cOpciones,
            this.cidProducto});
            this.DVentadataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVentadataGridView.Location = new System.Drawing.Point(0, 0);
            this.DVentadataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DVentadataGridView.Name = "DVentadataGridView";
            this.DVentadataGridView.ReadOnly = true;
            this.DVentadataGridView.RowHeadersVisible = false;
            this.DVentadataGridView.RowHeadersWidth = 51;
            this.DVentadataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVentadataGridView.Size = new System.Drawing.Size(992, 464);
            this.DVentadataGridView.TabIndex = 0;
            this.DVentadataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVentadataGridView_CellClick);
            // 
            // cnombreProducto
            // 
            this.cnombreProducto.HeaderText = "Producto";
            this.cnombreProducto.MinimumWidth = 6;
            this.cnombreProducto.Name = "cnombreProducto";
            this.cnombreProducto.ReadOnly = true;
            // 
            // ccantidadProducto
            // 
            this.ccantidadProducto.HeaderText = "Cantidad";
            this.ccantidadProducto.MinimumWidth = 6;
            this.ccantidadProducto.Name = "ccantidadProducto";
            this.ccantidadProducto.ReadOnly = true;
            // 
            // cprecioSalida
            // 
            this.cprecioSalida.HeaderText = "Precio";
            this.cprecioSalida.MinimumWidth = 6;
            this.cprecioSalida.Name = "cprecioSalida";
            this.cprecioSalida.ReadOnly = true;
            // 
            // cIVA
            // 
            this.cIVA.HeaderText = "IVA";
            this.cIVA.MinimumWidth = 6;
            this.cIVA.Name = "cIVA";
            this.cIVA.ReadOnly = true;
            // 
            // cimporte
            // 
            this.cimporte.HeaderText = "Importe";
            this.cimporte.MinimumWidth = 6;
            this.cimporte.Name = "cimporte";
            this.cimporte.ReadOnly = true;
            // 
            // cOpciones
            // 
            this.cOpciones.HeaderText = "Opciones";
            this.cOpciones.MinimumWidth = 6;
            this.cOpciones.Name = "cOpciones";
            this.cOpciones.ReadOnly = true;
            // 
            // cidProducto
            // 
            this.cidProducto.HeaderText = "idP";
            this.cidProducto.MinimumWidth = 6;
            this.cidProducto.Name = "cidProducto";
            this.cidProducto.ReadOnly = true;
            this.cidProducto.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(508, 167);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(115, 37);
            this.Buscarbutton.TabIndex = 11;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // WINDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 740);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WINDetalleVenta";
            this.Text = "WINDetalleVenta";
            this.Load += new System.EventHandler(this.WINDetalleVenta_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DVentadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DVentadataGridView;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.TextBox ImportetextBox;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cidProducto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        public System.Windows.Forms.ComboBox ProductocomboBox;
        public System.Windows.Forms.TextBox PreciotextBox;
    }
}