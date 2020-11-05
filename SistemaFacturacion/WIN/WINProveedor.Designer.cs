namespace WIN
{
    partial class WINProveedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombreProv = new System.Windows.Forms.TextBox();
            this.txttelefonoProv = new System.Windows.Forms.TextBox();
            this.txtnombreCompañia = new System.Windows.Forms.TextBox();
            this.txtnumeroCompañia = new System.Windows.Forms.TextBox();
            this.dataGridProovedor = new System.Windows.Forms.DataGridView();
            this.GuardarProv = new System.Windows.Forms.Button();
            this.ActualizarProv = new System.Windows.Forms.Button();
            this.EliminarProv = new System.Windows.Forms.Button();
            this.CancelarProv = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProovedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de Compañia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono de la Compañia:";
            // 
            // txtnombreProv
            // 
            this.txtnombreProv.Location = new System.Drawing.Point(103, 29);
            this.txtnombreProv.Name = "txtnombreProv";
            this.txtnombreProv.Size = new System.Drawing.Size(200, 20);
            this.txtnombreProv.TabIndex = 4;
            // 
            // txttelefonoProv
            // 
            this.txttelefonoProv.Location = new System.Drawing.Point(103, 81);
            this.txttelefonoProv.Name = "txttelefonoProv";
            this.txttelefonoProv.Size = new System.Drawing.Size(200, 20);
            this.txttelefonoProv.TabIndex = 5;
            // 
            // txtnombreCompañia
            // 
            this.txtnombreCompañia.Location = new System.Drawing.Point(487, 29);
            this.txtnombreCompañia.Name = "txtnombreCompañia";
            this.txtnombreCompañia.Size = new System.Drawing.Size(205, 20);
            this.txtnombreCompañia.TabIndex = 6;
            // 
            // txtnumeroCompañia
            // 
            this.txtnumeroCompañia.Location = new System.Drawing.Point(487, 81);
            this.txtnumeroCompañia.Name = "txtnumeroCompañia";
            this.txtnumeroCompañia.Size = new System.Drawing.Size(205, 20);
            this.txtnumeroCompañia.TabIndex = 7;
            // 
            // dataGridProovedor
            // 
            this.dataGridProovedor.AllowUserToAddRows = false;
            this.dataGridProovedor.AllowUserToDeleteRows = false;
            this.dataGridProovedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProovedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridProovedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProovedor.Location = new System.Drawing.Point(26, 156);
            this.dataGridProovedor.Name = "dataGridProovedor";
            this.dataGridProovedor.ReadOnly = true;
            this.dataGridProovedor.RowHeadersVisible = false;
            this.dataGridProovedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProovedor.Size = new System.Drawing.Size(666, 150);
            this.dataGridProovedor.TabIndex = 8;
            this.dataGridProovedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProovedor_CellContentClick);
            this.dataGridProovedor.DoubleClick += new System.EventHandler(this.dataGridProovedor_DoubleClick);
            // 
            // GuardarProv
            // 
            this.GuardarProv.Location = new System.Drawing.Point(71, 338);
            this.GuardarProv.Name = "GuardarProv";
            this.GuardarProv.Size = new System.Drawing.Size(75, 23);
            this.GuardarProv.TabIndex = 9;
            this.GuardarProv.Text = "Guardar";
            this.GuardarProv.UseVisualStyleBackColor = true;
            this.GuardarProv.Click += new System.EventHandler(this.GuardarProv_Click);
            // 
            // ActualizarProv
            // 
            this.ActualizarProv.Location = new System.Drawing.Point(246, 338);
            this.ActualizarProv.Name = "ActualizarProv";
            this.ActualizarProv.Size = new System.Drawing.Size(75, 23);
            this.ActualizarProv.TabIndex = 10;
            this.ActualizarProv.Text = "Actualizar";
            this.ActualizarProv.UseVisualStyleBackColor = true;
            this.ActualizarProv.Click += new System.EventHandler(this.ActualizarProv_Click);
            // 
            // EliminarProv
            // 
            this.EliminarProv.Location = new System.Drawing.Point(411, 338);
            this.EliminarProv.Name = "EliminarProv";
            this.EliminarProv.Size = new System.Drawing.Size(75, 23);
            this.EliminarProv.TabIndex = 11;
            this.EliminarProv.Text = "Eliminar";
            this.EliminarProv.UseVisualStyleBackColor = true;
            this.EliminarProv.Click += new System.EventHandler(this.EliminarProv_Click);
            // 
            // CancelarProv
            // 
            this.CancelarProv.Location = new System.Drawing.Point(578, 338);
            this.CancelarProv.Name = "CancelarProv";
            this.CancelarProv.Size = new System.Drawing.Size(75, 23);
            this.CancelarProv.TabIndex = 12;
            this.CancelarProv.Text = "Cancelar";
            this.CancelarProv.UseVisualStyleBackColor = true;
            this.CancelarProv.Click += new System.EventHandler(this.CancelarProv_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // WINProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.CancelarProv);
            this.Controls.Add(this.EliminarProv);
            this.Controls.Add(this.ActualizarProv);
            this.Controls.Add(this.GuardarProv);
            this.Controls.Add(this.dataGridProovedor);
            this.Controls.Add(this.txtnumeroCompañia);
            this.Controls.Add(this.txtnombreCompañia);
            this.Controls.Add(this.txttelefonoProv);
            this.Controls.Add(this.txtnombreProv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WINProveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.WINProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProovedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombreProv;
        private System.Windows.Forms.TextBox txttelefonoProv;
        private System.Windows.Forms.TextBox txtnombreCompañia;
        private System.Windows.Forms.TextBox txtnumeroCompañia;
        private System.Windows.Forms.DataGridView dataGridProovedor;
        private System.Windows.Forms.Button GuardarProv;
        private System.Windows.Forms.Button ActualizarProv;
        private System.Windows.Forms.Button EliminarProv;
        private System.Windows.Forms.Button CancelarProv;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}