namespace WIN
{
    partial class WINProVent
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
            this.label1 = new System.Windows.Forms.Label();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.ProductodataGridView = new System.Windows.Forms.DataGridView();
            this.MarcModeltextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo y Nombre:";
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(107, 11);
            this.BuscartextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(208, 20);
            this.BuscartextBox.TabIndex = 1;
            this.BuscartextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscartextBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 9;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(656, 11);
            this.Cancelarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(76, 19);
            this.Cancelarbutton.TabIndex = 13;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // ProductodataGridView
            // 
            this.ProductodataGridView.AllowUserToAddRows = false;
            this.ProductodataGridView.AllowUserToDeleteRows = false;
            this.ProductodataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductodataGridView.Location = new System.Drawing.Point(9, 55);
            this.ProductodataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ProductodataGridView.Name = "ProductodataGridView";
            this.ProductodataGridView.ReadOnly = true;
            this.ProductodataGridView.RowHeadersVisible = false;
            this.ProductodataGridView.RowHeadersWidth = 51;
            this.ProductodataGridView.RowTemplate.Height = 24;
            this.ProductodataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductodataGridView.Size = new System.Drawing.Size(723, 301);
            this.ProductodataGridView.TabIndex = 15;
            this.ProductodataGridView.DoubleClick += new System.EventHandler(this.ProductodataGridView_DoubleClick);
            // 
            // MarcModeltextBox
            // 
            this.MarcModeltextBox.Location = new System.Drawing.Point(425, 11);
            this.MarcModeltextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MarcModeltextBox.Name = "MarcModeltextBox";
            this.MarcModeltextBox.Size = new System.Drawing.Size(208, 20);
            this.MarcModeltextBox.TabIndex = 17;
            this.MarcModeltextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MarcModeltextBox_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Marca y Modelo:";
            // 
            // WINProVent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 366);
            this.Controls.Add(this.MarcModeltextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProductodataGridView);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(757, 405);
            this.MinimumSize = new System.Drawing.Size(757, 405);
            this.Name = "WINProVent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Producto";
            this.Load += new System.EventHandler(this.WINProVent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.DataGridView ProductodataGridView;
        private System.Windows.Forms.TextBox MarcModeltextBox;
        private System.Windows.Forms.Label label8;
    }
}