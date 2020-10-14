namespace WIN
{
    partial class WINMarca
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
            this.MarcadataGridView = new System.Windows.Forms.DataGridView();
            this.MarcatextBox = new System.Windows.Forms.TextBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Actualizarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MarcadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // MarcadataGridView
            // 
            this.MarcadataGridView.AllowUserToAddRows = false;
            this.MarcadataGridView.AllowUserToDeleteRows = false;
            this.MarcadataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MarcadataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MarcadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarcadataGridView.Location = new System.Drawing.Point(28, 108);
            this.MarcadataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MarcadataGridView.Name = "MarcadataGridView";
            this.MarcadataGridView.ReadOnly = true;
            this.MarcadataGridView.RowHeadersVisible = false;
            this.MarcadataGridView.RowHeadersWidth = 51;
            this.MarcadataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MarcadataGridView.Size = new System.Drawing.Size(935, 354);
            this.MarcadataGridView.TabIndex = 0;
            this.MarcadataGridView.DoubleClick += new System.EventHandler(this.MarcadataGridView_DoubleClick);
            // 
            // MarcatextBox
            // 
            this.MarcatextBox.Location = new System.Drawing.Point(101, 49);
            this.MarcatextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MarcatextBox.Name = "MarcatextBox";
            this.MarcatextBox.Size = new System.Drawing.Size(179, 22);
            this.MarcatextBox.TabIndex = 1;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Guardarbutton.Location = new System.Drawing.Point(301, 484);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(100, 28);
            this.Guardarbutton.TabIndex = 2;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Actualizarbutton
            // 
            this.Actualizarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Actualizarbutton.Location = new System.Drawing.Point(475, 484);
            this.Actualizarbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Actualizarbutton.Name = "Actualizarbutton";
            this.Actualizarbutton.Size = new System.Drawing.Size(100, 28);
            this.Actualizarbutton.TabIndex = 3;
            this.Actualizarbutton.Text = "Actualizar";
            this.Actualizarbutton.UseVisualStyleBackColor = true;
            this.Actualizarbutton.Click += new System.EventHandler(this.Actualizarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marca";
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Eliminarbutton.Location = new System.Drawing.Point(663, 484);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(100, 28);
            this.Eliminarbutton.TabIndex = 5;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancelarbutton.Location = new System.Drawing.Point(827, 484);
            this.Cancelarbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(100, 28);
            this.Cancelarbutton.TabIndex = 6;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 562);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // WINMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 543);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Actualizarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.MarcatextBox);
            this.Controls.Add(this.MarcadataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WINMarca";
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.WINMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MarcadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MarcadataGridView;
        private System.Windows.Forms.TextBox MarcatextBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Actualizarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
    }
}