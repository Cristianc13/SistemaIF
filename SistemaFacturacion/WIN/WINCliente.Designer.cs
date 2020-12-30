namespace WIN
{
    partial class WINCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WINCliente));
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.ClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Actualizarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btnagregar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.Location = new System.Drawing.Point(93, 46);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(196, 20);
            this.NombreTextBox.TabIndex = 2;
            this.NombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreTextBox_KeyPress);
            this.NombreTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NombreTextBox_KeyUp);
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoTextBox.Location = new System.Drawing.Point(93, 89);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(196, 20);
            this.ApellidoTextBox.TabIndex = 4;
            this.ApellidoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidoTextBox_KeyPress);
            this.ApellidoTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ApellidoTextBox_KeyUp);
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TelefonoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoTextBox.Location = new System.Drawing.Point(406, 48);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(196, 20);
            this.TelefonoTextBox.TabIndex = 5;
            this.TelefonoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoTextBox_KeyPress);
            // 
            // ClienteDataGridView
            // 
            this.ClienteDataGridView.AllowUserToAddRows = false;
            this.ClienteDataGridView.AllowUserToDeleteRows = false;
            this.ClienteDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClienteDataGridView.Location = new System.Drawing.Point(0, 166);
            this.ClienteDataGridView.Name = "ClienteDataGridView";
            this.ClienteDataGridView.ReadOnly = true;
            this.ClienteDataGridView.RowHeadersVisible = false;
            this.ClienteDataGridView.RowHeadersWidth = 51;
            this.ClienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClienteDataGridView.Size = new System.Drawing.Size(622, 188);
            this.ClienteDataGridView.TabIndex = 6;
            this.ClienteDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClienteDataGridView_CellClick);
            this.ClienteDataGridView.DoubleClick += new System.EventHandler(this.ClienteDataGridView_DoubleClick);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Agregarbutton.Location = new System.Drawing.Point(31, 356);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 23);
            this.Agregarbutton.TabIndex = 7;
            this.Agregarbutton.Text = "Guardar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            // 
            // Actualizarbutton
            // 
            this.Actualizarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Actualizarbutton.Location = new System.Drawing.Point(182, 356);
            this.Actualizarbutton.MaximumSize = new System.Drawing.Size(75, 23);
            this.Actualizarbutton.MinimumSize = new System.Drawing.Size(75, 23);
            this.Actualizarbutton.Name = "Actualizarbutton";
            this.Actualizarbutton.Size = new System.Drawing.Size(75, 23);
            this.Actualizarbutton.TabIndex = 8;
            this.Actualizarbutton.Text = "Actualizar";
            this.Actualizarbutton.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Eliminarbutton.Location = new System.Drawing.Point(335, 356);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(74, 23);
            this.Eliminarbutton.TabIndex = 9;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancelarbutton.Location = new System.Drawing.Point(481, 356);
            this.Cancelarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(77, 23);
            this.Cancelarbutton.TabIndex = 10;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 32);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnclose.IconColor = System.Drawing.Color.White;
            this.btnclose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclose.Location = new System.Drawing.Point(589, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(32, 32);
            this.btnclose.TabIndex = 45;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Detalles del Cliente";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(87, 38);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(210, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Apellido:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(400, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(322, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Telefono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Buscar:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(400, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(210, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(406, 91);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(196, 20);
            this.textBoxBuscar.TabIndex = 43;
            this.textBoxBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscar_KeyUp);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btncancelar.IconColor = System.Drawing.Color.White;
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.IconSize = 30;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btncancelar.Location = new System.Drawing.Point(493, 126);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(109, 35);
            this.btncancelar.TabIndex = 47;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnagregar.IconColor = System.Drawing.Color.White;
            this.btnagregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregar.IconSize = 30;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnagregar.Location = new System.Drawing.Point(185, 125);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(104, 35);
            this.btnagregar.TabIndex = 44;
            this.btnagregar.Text = "Editar";
            this.btnagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 30;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnguardar.Location = new System.Drawing.Point(31, 125);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(104, 35);
            this.btnguardar.TabIndex = 45;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btneliminar.IconColor = System.Drawing.Color.White;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 30;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btneliminar.Location = new System.Drawing.Point(335, 126);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(104, 35);
            this.btneliminar.TabIndex = 48;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // WINCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 352);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Actualizarbutton);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.ClienteDataGridView);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(622, 350);
            this.Name = "WINCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.WINCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.DataGridView ClienteDataGridView;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button Actualizarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox btnclose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btnagregar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btneliminar;
    }
}