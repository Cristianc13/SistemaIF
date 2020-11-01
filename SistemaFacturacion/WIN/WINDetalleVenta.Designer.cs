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
            this.Clientebutton = new System.Windows.Forms.Button();
            this.TelefonotextBox = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.DescuentotextBox = new System.Windows.Forms.TextBox();
            this.ClientecomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DVentadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clientebutton
            // 
            this.Clientebutton.Location = new System.Drawing.Point(349, 8);
            this.Clientebutton.Name = "Clientebutton";
            this.Clientebutton.Size = new System.Drawing.Size(30, 30);
            this.Clientebutton.TabIndex = 16;
            this.Clientebutton.Text = "+";
            this.Clientebutton.UseVisualStyleBackColor = true;
            this.Clientebutton.Click += new System.EventHandler(this.Clientebutton_Click);
            // 
            // TelefonotextBox
            // 
            this.TelefonotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonotextBox.Location = new System.Drawing.Point(479, 12);
            this.TelefonotextBox.Name = "TelefonotextBox";
            this.TelefonotextBox.ReadOnly = true;
            this.TelefonotextBox.Size = new System.Drawing.Size(199, 23);
            this.TelefonotextBox.TabIndex = 15;
            this.TelefonotextBox.TextChanged += new System.EventHandler(this.ProductocomboBox_SelectedIndexChanged);
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(399, 13);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(71, 20);
            this.Telefono.TabIndex = 14;
            this.Telefono.Text = "Telefono";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(17, 13);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(58, 20);
            this.Cliente.TabIndex = 12;
            this.Cliente.Text = "Cliente";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(349, 46);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(30, 30);
            this.Buscarbutton.TabIndex = 11;
            this.Buscarbutton.Text = "+";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(228, 124);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(86, 30);
            this.Cancelarbutton.TabIndex = 10;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(126, 123);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(86, 30);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(21, 123);
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
            this.ImportetextBox.Location = new System.Drawing.Point(479, 87);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.ReadOnly = true;
            this.ImportetextBox.Size = new System.Drawing.Size(199, 23);
            this.ImportetextBox.TabIndex = 7;
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreciotextBox.Location = new System.Drawing.Point(479, 50);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.ReadOnly = true;
            this.PreciotextBox.Size = new System.Drawing.Size(199, 23);
            this.PreciotextBox.TabIndex = 6;
            this.PreciotextBox.TextChanged += new System.EventHandler(this.PreciotextBox_TextChanged);
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadtextBox.Location = new System.Drawing.Point(112, 87);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(231, 23);
            this.CantidadtextBox.TabIndex = 5;
            this.CantidadtextBox.TextChanged += new System.EventHandler(this.CantidadtextBox_TextChanged);
            this.CantidadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadtextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Importe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
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
            this.ProductocomboBox.Location = new System.Drawing.Point(112, 49);
            this.ProductocomboBox.Name = "ProductocomboBox";
            this.ProductocomboBox.Size = new System.Drawing.Size(231, 24);
            this.ProductocomboBox.TabIndex = 0;
            this.ProductocomboBox.SelectedIndexChanged += new System.EventHandler(this.ProductocomboBox_SelectedIndexChanged);
            this.ProductocomboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductocomboBox_KeyPress);
            // 
            // DVentadataGridView
            // 
            this.DVentadataGridView.AllowUserToAddRows = false;
            this.DVentadataGridView.AllowUserToDeleteRows = false;
            this.DVentadataGridView.AllowUserToResizeColumns = false;
            this.DVentadataGridView.AllowUserToResizeRows = false;
            this.DVentadataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DVentadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVentadataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVentadataGridView.Location = new System.Drawing.Point(0, 0);
            this.DVentadataGridView.Name = "DVentadataGridView";
            this.DVentadataGridView.ReadOnly = true;
            this.DVentadataGridView.RowHeadersVisible = false;
            this.DVentadataGridView.RowHeadersWidth = 51;
            this.DVentadataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVentadataGridView.Size = new System.Drawing.Size(935, 309);
            this.DVentadataGridView.TabIndex = 0;
            this.DVentadataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVentadataGridView_CellClick);
            this.DVentadataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVentadataGridView_CellContentClick);
            this.DVentadataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DVentadataGridView_CellPainting);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DVentadataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 219);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 309);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.DescuentotextBox);
            this.panel2.Controls.Add(this.Cancelarbutton);
            this.panel2.Controls.Add(this.Guardarbutton);
            this.panel2.Controls.Add(this.ClientecomboBox);
            this.panel2.Controls.Add(this.Agregarbutton);
            this.panel2.Controls.Add(this.Cliente);
            this.panel2.Controls.Add(this.ImportetextBox);
            this.panel2.Controls.Add(this.Clientebutton);
            this.panel2.Controls.Add(this.PreciotextBox);
            this.panel2.Controls.Add(this.Buscarbutton);
            this.panel2.Controls.Add(this.TelefonotextBox);
            this.panel2.Controls.Add(this.CantidadtextBox);
            this.panel2.Controls.Add(this.ProductocomboBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Telefono);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 219);
            this.panel2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(701, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Descuento";
            // 
            // DescuentotextBox
            // 
            this.DescuentotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescuentotextBox.Location = new System.Drawing.Point(797, 50);
            this.DescuentotextBox.Name = "DescuentotextBox";
            this.DescuentotextBox.Size = new System.Drawing.Size(84, 23);
            this.DescuentotextBox.TabIndex = 19;
            this.DescuentotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescuentotextBox_KeyPress);
            // 
            // ClientecomboBox
            // 
            this.ClientecomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ClientecomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ClientecomboBox.DropDownHeight = 115;
            this.ClientecomboBox.DropDownWidth = 240;
            this.ClientecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientecomboBox.FormattingEnabled = true;
            this.ClientecomboBox.IntegralHeight = false;
            this.ClientecomboBox.Location = new System.Drawing.Point(112, 10);
            this.ClientecomboBox.Name = "ClientecomboBox";
            this.ClientecomboBox.Size = new System.Drawing.Size(231, 24);
            this.ClientecomboBox.TabIndex = 18;
            this.ClientecomboBox.SelectedIndexChanged += new System.EventHandler(this.ClientecomboBox_SelectedIndexChanged);
            this.ClientecomboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientecomboBox_KeyPress);
            // 
            // WINDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "WINDetalleVenta";
            this.Text = "WINDetalleVenta";
            this.Load += new System.EventHandler(this.WINDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVentadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DVentadataGridView;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.TextBox ImportetextBox;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        public System.Windows.Forms.ComboBox ProductocomboBox;
        public System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Button Clientebutton;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Cliente;
        public System.Windows.Forms.TextBox TelefonotextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox ClientecomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DescuentotextBox;
    }
}