namespace WIN
{
    partial class WINAdministrador
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
            this.label5 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.ApellidotextBox = new System.Windows.Forms.TextBox();
            this.TelefonotextBox = new System.Windows.Forms.TextBox();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.AdministradordataGridView = new System.Windows.Forms.DataGridView();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Actualizarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AdministradordataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Clave";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(102, 31);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(198, 22);
            this.NombretextBox.TabIndex = 5;
            // 
            // ApellidotextBox
            // 
            this.ApellidotextBox.Location = new System.Drawing.Point(102, 58);
            this.ApellidotextBox.Name = "ApellidotextBox";
            this.ApellidotextBox.Size = new System.Drawing.Size(198, 22);
            this.ApellidotextBox.TabIndex = 6;
            // 
            // TelefonotextBox
            // 
            this.TelefonotextBox.Location = new System.Drawing.Point(102, 85);
            this.TelefonotextBox.Name = "TelefonotextBox";
            this.TelefonotextBox.Size = new System.Drawing.Size(198, 22);
            this.TelefonotextBox.TabIndex = 7;
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(102, 113);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(198, 22);
            this.UsuariotextBox.TabIndex = 8;
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Location = new System.Drawing.Point(102, 142);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.Size = new System.Drawing.Size(198, 22);
            this.ClavetextBox.TabIndex = 9;
            this.ClavetextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // AdministradordataGridView
            // 
            this.AdministradordataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdministradordataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdministradordataGridView.Location = new System.Drawing.Point(16, 196);
            this.AdministradordataGridView.Name = "AdministradordataGridView";
            this.AdministradordataGridView.RowHeadersVisible = false;
            this.AdministradordataGridView.RowHeadersWidth = 51;
            this.AdministradordataGridView.RowTemplate.Height = 24;
            this.AdministradordataGridView.Size = new System.Drawing.Size(737, 150);
            this.AdministradordataGridView.TabIndex = 10;
            this.AdministradordataGridView.DoubleClick += new System.EventHandler(this.AdministradordataGridView_DoubleClick);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(148, 369);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(83, 23);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Actualizarbutton
            // 
            this.Actualizarbutton.Location = new System.Drawing.Point(259, 369);
            this.Actualizarbutton.Name = "Actualizarbutton";
            this.Actualizarbutton.Size = new System.Drawing.Size(88, 23);
            this.Actualizarbutton.TabIndex = 12;
            this.Actualizarbutton.Text = "Actualizar";
            this.Actualizarbutton.UseVisualStyleBackColor = true;
            this.Actualizarbutton.Click += new System.EventHandler(this.Actualizarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(385, 369);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(83, 23);
            this.Eliminarbutton.TabIndex = 13;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(510, 369);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(89, 23);
            this.Cancelarbutton.TabIndex = 14;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // WINAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Actualizarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.AdministradordataGridView);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.TelefonotextBox);
            this.Controls.Add(this.ApellidotextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WINAdministrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.WINAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdministradordataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox ApellidotextBox;
        private System.Windows.Forms.TextBox TelefonotextBox;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.TextBox ClavetextBox;
        private System.Windows.Forms.DataGridView AdministradordataGridView;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Actualizarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}