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
            this.ModelodataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ModelotextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ActualizarButton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ModelodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ModelodataGridView
            // 
            this.ModelodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModelodataGridView.Location = new System.Drawing.Point(12, 141);
            this.ModelodataGridView.Name = "ModelodataGridView";
            this.ModelodataGridView.RowHeadersVisible = false;
            this.ModelodataGridView.RowHeadersWidth = 51;
            this.ModelodataGridView.RowTemplate.Height = 24;
            this.ModelodataGridView.Size = new System.Drawing.Size(717, 257);
            this.ModelodataGridView.TabIndex = 0;
            this.ModelodataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModelodataGridView_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelo:";
            // 
            // ModelotextBox
            // 
            this.ModelotextBox.Location = new System.Drawing.Point(97, 34);
            this.ModelotextBox.Name = "ModelotextBox";
            this.ModelotextBox.Size = new System.Drawing.Size(149, 22);
            this.ModelotextBox.TabIndex = 2;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(28, 87);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 3;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.Location = new System.Drawing.Point(155, 87);
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Size = new System.Drawing.Size(89, 23);
            this.ActualizarButton.TabIndex = 4;
            this.ActualizarButton.Text = "Actualizar";
            this.ActualizarButton.UseVisualStyleBackColor = true;
            this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(289, 87);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 5;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(406, 86);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(85, 23);
            this.CancelarButton.TabIndex = 6;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // WINModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 410);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.ActualizarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModelotextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModelodataGridView);
            this.Name = "WINModelo";
            this.Text = "Modelo";
            this.Load += new System.EventHandler(this.WINModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModelodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ModelodataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ModelotextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button ActualizarButton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}