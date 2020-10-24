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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.ClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Actualizarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Enviarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(183, 7);
            this.NombreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(132, 22);
            this.NombreTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefono:";
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(183, 44);
            this.ApellidoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(132, 22);
            this.ApellidoTextBox.TabIndex = 4;
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(183, 85);
            this.TelefonoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(132, 22);
            this.TelefonoTextBox.TabIndex = 5;
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
            this.ClienteDataGridView.Location = new System.Drawing.Point(16, 139);
            this.ClienteDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ClienteDataGridView.Name = "ClienteDataGridView";
            this.ClienteDataGridView.ReadOnly = true;
            this.ClienteDataGridView.RowHeadersVisible = false;
            this.ClienteDataGridView.RowHeadersWidth = 51;
            this.ClienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClienteDataGridView.Size = new System.Drawing.Size(895, 144);
            this.ClienteDataGridView.TabIndex = 6;
            this.ClienteDataGridView.Click += new System.EventHandler(this.ClienteDataGridView_Click);
            this.ClienteDataGridView.DoubleClick += new System.EventHandler(this.ClienteDataGridView_DoubleClick);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Agregarbutton.Location = new System.Drawing.Point(157, 320);
            this.Agregarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(100, 28);
            this.Agregarbutton.TabIndex = 7;
            this.Agregarbutton.Text = "Guardar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // Actualizarbutton
            // 
            this.Actualizarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Actualizarbutton.Location = new System.Drawing.Point(279, 320);
            this.Actualizarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Actualizarbutton.Name = "Actualizarbutton";
            this.Actualizarbutton.Size = new System.Drawing.Size(100, 28);
            this.Actualizarbutton.TabIndex = 8;
            this.Actualizarbutton.Text = "Actualizar";
            this.Actualizarbutton.UseVisualStyleBackColor = true;
            this.Actualizarbutton.Click += new System.EventHandler(this.Actualizarbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Eliminarbutton.Location = new System.Drawing.Point(409, 320);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(87, 28);
            this.Eliminarbutton.TabIndex = 9;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancelarbutton.Location = new System.Drawing.Point(521, 320);
            this.Cancelarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(85, 28);
            this.Cancelarbutton.TabIndex = 10;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Enviarbutton
            // 
            this.Enviarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Enviarbutton.Location = new System.Drawing.Point(633, 320);
            this.Enviarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Enviarbutton.Name = "Enviarbutton";
            this.Enviarbutton.Size = new System.Drawing.Size(85, 28);
            this.Enviarbutton.TabIndex = 11;
            this.Enviarbutton.Text = "Enviar";
            this.Enviarbutton.UseVisualStyleBackColor = true;
            this.Enviarbutton.Click += new System.EventHandler(this.Enviarbutton_Click);
            // 
            // WINCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 383);
            this.Controls.Add(this.Enviarbutton);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Actualizarbutton);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.ClienteDataGridView);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WINCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.WINCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.DataGridView ClienteDataGridView;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button Actualizarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Enviarbutton;
    }
}