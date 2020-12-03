namespace WIN
{
    partial class WINDetalleCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbNFactura = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bmbproducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.DetalleCompraGridView1 = new System.Windows.Forms.DataGridView();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.Comprabutton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtfechacompra = new System.Windows.Forms.TextBox();
            this.txtdescr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIVAdetalleC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtnumeroCompañia = new System.Windows.Forms.TextBox();
            this.txtnombreCompañia = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtnombreprov = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txttelefonoProv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleCompraGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbNFactura
            // 
            this.cmbNFactura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNFactura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNFactura.DropDownHeight = 115;
            this.cmbNFactura.DropDownWidth = 240;
            this.cmbNFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNFactura.FormattingEnabled = true;
            this.cmbNFactura.IntegralHeight = false;
            this.cmbNFactura.Location = new System.Drawing.Point(171, 164);
            this.cmbNFactura.Name = "cmbNFactura";
            this.cmbNFactura.Size = new System.Drawing.Size(224, 28);
            this.cmbNFactura.TabIndex = 2;
            this.cmbNFactura.SelectedIndexChanged += new System.EventHandler(this.cmbNFactura_SelectedIndexChanged);
            this.cmbNFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNFactura_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "N° Factura:";
            // 
            // bmbproducto
            // 
            this.bmbproducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bmbproducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bmbproducto.DropDownHeight = 115;
            this.bmbproducto.DropDownWidth = 240;
            this.bmbproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmbproducto.FormattingEnabled = true;
            this.bmbproducto.IntegralHeight = false;
            this.bmbproducto.Location = new System.Drawing.Point(155, 281);
            this.bmbproducto.Name = "bmbproducto";
            this.bmbproducto.Size = new System.Drawing.Size(231, 28);
            this.bmbproducto.TabIndex = 4;
            this.bmbproducto.SelectedIndexChanged += new System.EventHandler(this.bmbproducto_SelectedIndexChanged);
            this.bmbproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bmbproducto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Producto:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(770, 248);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(231, 26);
            this.txtcantidad.TabIndex = 8;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(657, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad:";
            // 
            // txtcosto
            // 
            this.txtcosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcosto.Location = new System.Drawing.Point(769, 284);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(231, 26);
            this.txtcosto.TabIndex = 10;
            this.txtcosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcosto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(679, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Costo:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(36, 328);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 33);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // DetalleCompraGridView1
            // 
            this.DetalleCompraGridView1.AllowUserToAddRows = false;
            this.DetalleCompraGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            this.DetalleCompraGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DetalleCompraGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetalleCompraGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.DetalleCompraGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetalleCompraGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DetalleCompraGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetalleCompraGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.DetalleCompraGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetalleCompraGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DetalleCompraGridView1.Location = new System.Drawing.Point(0, 0);
            this.DetalleCompraGridView1.Name = "DetalleCompraGridView1";
            this.DetalleCompraGridView1.ReadOnly = true;
            this.DetalleCompraGridView1.RowHeadersVisible = false;
            this.DetalleCompraGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetalleCompraGridView1.Size = new System.Drawing.Size(1100, 171);
            this.DetalleCompraGridView1.TabIndex = 15;
            this.DetalleCompraGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalleCompraGridView1_CellClick);
            this.DetalleCompraGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalleCompraGridView1_CellContentClick);
            this.DetalleCompraGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalleCompraGridView1_CellDoubleClick);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(891, 116);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(109, 33);
            this.btnguardar.TabIndex = 14;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(164, 328);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(109, 33);
            this.btnactualizar.TabIndex = 12;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(292, 328);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 33);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.label5.Location = new System.Drawing.Point(822, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Subtotal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(852, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "IVA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(844, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total:";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(897, 12);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(103, 26);
            this.txtsubtotal.TabIndex = 19;
            // 
            // txtIVA
            // 
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(897, 50);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(103, 26);
            this.txtIVA.TabIndex = 20;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(897, 84);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(103, 26);
            this.txtTotal.TabIndex = 21;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(423, 328);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 33);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Comprabutton
            // 
            this.Comprabutton.Location = new System.Drawing.Point(413, 164);
            this.Comprabutton.Name = "Comprabutton";
            this.Comprabutton.Size = new System.Drawing.Size(33, 28);
            this.Comprabutton.TabIndex = 14;
            this.Comprabutton.Text = "+";
            this.Comprabutton.UseVisualStyleBackColor = true;
            this.Comprabutton.Click += new System.EventHandler(this.Comprabutton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(594, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fecha de Compra:";
            // 
            // txtfechacompra
            // 
            this.txtfechacompra.Location = new System.Drawing.Point(770, 164);
            this.txtfechacompra.Multiline = true;
            this.txtfechacompra.Name = "txtfechacompra";
            this.txtfechacompra.Size = new System.Drawing.Size(226, 28);
            this.txtfechacompra.TabIndex = 17;
            // 
            // txtdescr
            // 
            this.txtdescr.Location = new System.Drawing.Point(171, 204);
            this.txtdescr.Multiline = true;
            this.txtdescr.Name = "txtdescr";
            this.txtdescr.Size = new System.Drawing.Size(224, 25);
            this.txtdescr.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Descripcion:";
            // 
            // txtIVAdetalleC
            // 
            this.txtIVAdetalleC.Location = new System.Drawing.Point(770, 204);
            this.txtIVAdetalleC.Multiline = true;
            this.txtIVAdetalleC.Name = "txtIVAdetalleC";
            this.txtIVAdetalleC.Size = new System.Drawing.Size(226, 28);
            this.txtIVAdetalleC.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(694, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "IVA:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Detalles de la compra:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(556, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Telefono de la Compañia:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(578, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(167, 20);
            this.label16.TabIndex = 26;
            this.label16.Text = "Nombre de Compañia:";
            // 
            // txtnumeroCompañia
            // 
            this.txtnumeroCompañia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumeroCompañia.Location = new System.Drawing.Point(770, 99);
            this.txtnumeroCompañia.Name = "txtnumeroCompañia";
            this.txtnumeroCompañia.Size = new System.Drawing.Size(226, 26);
            this.txtnumeroCompañia.TabIndex = 31;
            // 
            // txtnombreCompañia
            // 
            this.txtnombreCompañia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreCompañia.Location = new System.Drawing.Point(770, 60);
            this.txtnombreCompañia.Name = "txtnombreCompañia";
            this.txtnombreCompañia.Size = new System.Drawing.Size(226, 26);
            this.txtnombreCompañia.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(32, 245);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(182, 20);
            this.label17.TabIndex = 32;
            this.label17.Text = "Detalles de Producto:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtnombreprov);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.cmbNFactura);
            this.panel1.Controls.Add(this.btnactualizar);
            this.panel1.Controls.Add(this.txtIVAdetalleC);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtcosto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.bmbproducto);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtcantidad);
            this.panel1.Controls.Add(this.Comprabutton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txttelefonoProv);
            this.panel1.Controls.Add(this.txtfechacompra);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtnumeroCompañia);
            this.panel1.Controls.Add(this.txtdescr);
            this.panel1.Controls.Add(this.txtnombreCompañia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 366);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtsubtotal);
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtIVA);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 537);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 155);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.DetalleCompraGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 366);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 171);
            this.panel3.TabIndex = 35;
            // 
            // txtnombreprov
            // 
            this.txtnombreprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreprov.Location = new System.Drawing.Point(164, 63);
            this.txtnombreprov.Name = "txtnombreprov";
            this.txtnombreprov.Size = new System.Drawing.Size(231, 26);
            this.txtnombreprov.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(41, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Nombre:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(41, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Telefono:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Detalles del Proveedor:";
            // 
            // txttelefonoProv
            // 
            this.txttelefonoProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefonoProv.Location = new System.Drawing.Point(164, 102);
            this.txttelefonoProv.Name = "txttelefonoProv";
            this.txttelefonoProv.Size = new System.Drawing.Size(231, 26);
            this.txttelefonoProv.TabIndex = 29;
            // 
            // WINDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 692);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WINDetalleCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.WINDetalleCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleCompraGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbNFactura;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox bmbproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView DetalleCompraGridView1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Comprabutton;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIVAdetalleC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdescr;
        private System.Windows.Forms.TextBox txtfechacompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtnumeroCompañia;
        private System.Windows.Forms.TextBox txtnombreCompañia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtnombreprov;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttelefonoProv;
    }
}