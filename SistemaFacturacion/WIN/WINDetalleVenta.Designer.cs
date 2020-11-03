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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label5 = new System.Windows.Forms.Label();
            this.DescuentotextBox = new System.Windows.Forms.TextBox();
            this.ClientecomboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DVentadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clientebutton
            // 
            this.Clientebutton.Location = new System.Drawing.Point(465, 25);
            this.Clientebutton.Name = "Clientebutton";
            this.Clientebutton.Size = new System.Drawing.Size(30, 30);
            this.Clientebutton.TabIndex = 16;
            this.Clientebutton.Text = "+";
            this.Clientebutton.UseVisualStyleBackColor = true;
            this.Clientebutton.Click += new System.EventHandler(this.Clientebutton_Click);
            // 
            // TelefonotextBox
            // 
            this.TelefonotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonotextBox.Location = new System.Drawing.Point(623, 25);
            this.TelefonotextBox.Name = "TelefonotextBox";
            this.TelefonotextBox.ReadOnly = true;
            this.TelefonotextBox.Size = new System.Drawing.Size(199, 26);
            this.TelefonotextBox.TabIndex = 15;
            this.TelefonotextBox.TextChanged += new System.EventHandler(this.ProductocomboBox_SelectedIndexChanged);
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.BackColor = System.Drawing.Color.White;
            this.Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(537, 26);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(75, 20);
            this.Telefono.TabIndex = 14;
            this.Telefono.Text = "Telefono:";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.BackColor = System.Drawing.Color.White;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(180, 25);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(62, 20);
            this.Cliente.TabIndex = 12;
            this.Cliente.Text = "Cliente:";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(465, 69);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(30, 30);
            this.Buscarbutton.TabIndex = 11;
            this.Buscarbutton.Text = "+";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(368, 169);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(86, 30);
            this.Cancelarbutton.TabIndex = 10;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(276, 167);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(86, 30);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(184, 167);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(86, 30);
            this.Agregarbutton.TabIndex = 8;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // ImportetextBox
            // 
            this.ImportetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportetextBox.Location = new System.Drawing.Point(622, 115);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.ReadOnly = true;
            this.ImportetextBox.Size = new System.Drawing.Size(199, 26);
            this.ImportetextBox.TabIndex = 7;
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreciotextBox.Location = new System.Drawing.Point(622, 68);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.ReadOnly = true;
            this.PreciotextBox.Size = new System.Drawing.Size(199, 26);
            this.PreciotextBox.TabIndex = 6;
            this.PreciotextBox.TextChanged += new System.EventHandler(this.PreciotextBox_TextChanged);
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadtextBox.Location = new System.Drawing.Point(255, 116);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(204, 26);
            this.CantidadtextBox.TabIndex = 5;
            this.CantidadtextBox.TextChanged += new System.EventHandler(this.CantidadtextBox_TextChanged);
            this.CantidadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadtextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Importe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductocomboBox
            // 
            this.ProductocomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ProductocomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductocomboBox.DropDownHeight = 115;
            this.ProductocomboBox.DropDownWidth = 240;
            this.ProductocomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductocomboBox.FormattingEnabled = true;
            this.ProductocomboBox.IntegralHeight = false;
            this.ProductocomboBox.Location = new System.Drawing.Point(255, 67);
            this.ProductocomboBox.Name = "ProductocomboBox";
            this.ProductocomboBox.Size = new System.Drawing.Size(204, 28);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            this.DVentadataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DVentadataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DVentadataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DVentadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DVentadataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DVentadataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVentadataGridView.Location = new System.Drawing.Point(0, 0);
            this.DVentadataGridView.Name = "DVentadataGridView";
            this.DVentadataGridView.ReadOnly = true;
            this.DVentadataGridView.RowHeadersVisible = false;
            this.DVentadataGridView.RowHeadersWidth = 51;
            this.DVentadataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVentadataGridView.Size = new System.Drawing.Size(1203, 277);
            this.DVentadataGridView.TabIndex = 0;
            this.DVentadataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVentadataGridView_CellClick);
            this.DVentadataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVentadataGridView_CellContentClick);
            this.DVentadataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DVentadataGridView_CellPainting);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(837, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Descuento:";
            // 
            // DescuentotextBox
            // 
            this.DescuentotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescuentotextBox.Location = new System.Drawing.Point(953, 69);
            this.DescuentotextBox.Name = "DescuentotextBox";
            this.DescuentotextBox.Size = new System.Drawing.Size(126, 26);
            this.DescuentotextBox.TabIndex = 19;
            this.DescuentotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescuentotextBox_KeyPress);
            // 
            // ClientecomboBox
            // 
            this.ClientecomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ClientecomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ClientecomboBox.DropDownHeight = 115;
            this.ClientecomboBox.DropDownWidth = 240;
            this.ClientecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientecomboBox.FormattingEnabled = true;
            this.ClientecomboBox.IntegralHeight = false;
            this.ClientecomboBox.Location = new System.Drawing.Point(255, 23);
            this.ClientecomboBox.Name = "ClientecomboBox";
            this.ClientecomboBox.Size = new System.Drawing.Size(204, 28);
            this.ClientecomboBox.TabIndex = 18;
            this.ClientecomboBox.SelectedIndexChanged += new System.EventHandler(this.ClientecomboBox_SelectedIndexChanged);
            this.ClientecomboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientecomboBox_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Cliente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TelefonotextBox);
            this.panel1.Controls.Add(this.DescuentotextBox);
            this.panel1.Controls.Add(this.Buscarbutton);
            this.panel1.Controls.Add(this.CantidadtextBox);
            this.panel1.Controls.Add(this.Cancelarbutton);
            this.panel1.Controls.Add(this.PreciotextBox);
            this.panel1.Controls.Add(this.ProductocomboBox);
            this.panel1.Controls.Add(this.Guardarbutton);
            this.panel1.Controls.Add(this.Clientebutton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ClientecomboBox);
            this.panel1.Controls.Add(this.ImportetextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Telefono);
            this.panel1.Controls.Add(this.Agregarbutton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 217);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1203, 57);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.DVentadataGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1203, 277);
            this.panel3.TabIndex = 23;
            // 
            // WINDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 551);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WINDetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WINDetalleVenta";
            this.Load += new System.EventHandler(this.WINDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVentadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
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
        public System.Windows.Forms.ComboBox ClientecomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DescuentotextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}