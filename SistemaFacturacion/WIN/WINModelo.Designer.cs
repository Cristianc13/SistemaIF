namespace WIN
{
    partial class WINModelo
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
            this.ModelotextBox = new System.Windows.Forms.TextBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Actualizarbutton = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.ModelodataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ModelodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo:";
            // 
            // ModelotextBox
            // 
            this.ModelotextBox.Location = new System.Drawing.Point(80, 19);
            this.ModelotextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModelotextBox.Name = "ModelotextBox";
            this.ModelotextBox.Size = new System.Drawing.Size(138, 20);
            this.ModelotextBox.TabIndex = 1;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(22, 69);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(56, 19);
            this.Guardarbutton.TabIndex = 2;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Actualizarbutton
            // 
            this.Actualizarbutton.Location = new System.Drawing.Point(112, 68);
            this.Actualizarbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Actualizarbutton.Name = "Actualizarbutton";
            this.Actualizarbutton.Size = new System.Drawing.Size(63, 19);
            this.Actualizarbutton.TabIndex = 3;
            this.Actualizarbutton.Text = "Actualizar";
            this.Actualizarbutton.UseVisualStyleBackColor = true;
            this.Actualizarbutton.Click += new System.EventHandler(this.Actualizarbutton_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(210, 68);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(56, 19);
            this.Eliminar.TabIndex = 4;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(310, 68);
            this.Cancelarbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(62, 19);
            this.Cancelarbutton.TabIndex = 5;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // ModelodataGridView
            // 
            this.ModelodataGridView.AllowUserToAddRows = false;
            this.ModelodataGridView.AllowUserToDeleteRows = false;
            this.ModelodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModelodataGridView.Location = new System.Drawing.Point(22, 119);
            this.ModelodataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModelodataGridView.Name = "ModelodataGridView";
            this.ModelodataGridView.ReadOnly = true;
            this.ModelodataGridView.RowHeadersVisible = false;
            this.ModelodataGridView.RowHeadersWidth = 51;
            this.ModelodataGridView.RowTemplate.Height = 24;
            this.ModelodataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ModelodataGridView.Size = new System.Drawing.Size(551, 224);
            this.ModelodataGridView.TabIndex = 6;
            this.ModelodataGridView.DoubleClick += new System.EventHandler(this.ModelodataGridView_DoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // WINModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ModelodataGridView);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Actualizarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.ModelotextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WINModelo";
            this.Text = "Modelo";
            this.Load += new System.EventHandler(this.WINModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModelodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ModelotextBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Actualizarbutton;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.DataGridView ModelodataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}