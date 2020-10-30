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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductotextBox = new System.Windows.Forms.TextBox();
            this.CostotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.StocktextBox = new System.Windows.Forms.TextBox();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Enviarbutton = new System.Windows.Forms.Button();
            this.ProductodataGridView = new System.Windows.Forms.DataGridView();
            this.MarcModeltextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
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
            this.BuscartextBox.Location = new System.Drawing.Point(115, 14);
            this.BuscartextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(110, 20);
            this.BuscartextBox.TabIndex = 1;
            this.BuscartextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscartextBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Costo:";
            // 
            // ProductotextBox
            // 
            this.ProductotextBox.Location = new System.Drawing.Point(115, 54);
            this.ProductotextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductotextBox.Name = "ProductotextBox";
            this.ProductotextBox.ReadOnly = true;
            this.ProductotextBox.Size = new System.Drawing.Size(106, 20);
            this.ProductotextBox.TabIndex = 6;
            // 
            // CostotextBox
            // 
            this.CostotextBox.Location = new System.Drawing.Point(115, 93);
            this.CostotextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CostotextBox.Name = "CostotextBox";
            this.CostotextBox.ReadOnly = true;
            this.CostotextBox.Size = new System.Drawing.Size(106, 20);
            this.CostotextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stock:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Precio Salida:";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(365, 53);
            this.PreciotextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.ReadOnly = true;
            this.PreciotextBox.Size = new System.Drawing.Size(108, 20);
            this.PreciotextBox.TabIndex = 11;
            // 
            // StocktextBox
            // 
            this.StocktextBox.Location = new System.Drawing.Point(365, 93);
            this.StocktextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StocktextBox.Name = "StocktextBox";
            this.StocktextBox.ReadOnly = true;
            this.StocktextBox.Size = new System.Drawing.Size(108, 20);
            this.StocktextBox.TabIndex = 12;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(497, 13);
            this.Cancelarbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(76, 19);
            this.Cancelarbutton.TabIndex = 13;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Enviarbutton
            // 
            this.Enviarbutton.Location = new System.Drawing.Point(607, 13);
            this.Enviarbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Enviarbutton.Name = "Enviarbutton";
            this.Enviarbutton.Size = new System.Drawing.Size(76, 19);
            this.Enviarbutton.TabIndex = 14;
            this.Enviarbutton.Text = "Enviar";
            this.Enviarbutton.UseVisualStyleBackColor = true;
            this.Enviarbutton.Click += new System.EventHandler(this.Enviarbutton_Click);
            // 
            // ProductodataGridView
            // 
            this.ProductodataGridView.AllowUserToAddRows = false;
            this.ProductodataGridView.AllowUserToDeleteRows = false;
            this.ProductodataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductodataGridView.Location = new System.Drawing.Point(9, 131);
            this.ProductodataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductodataGridView.Name = "ProductodataGridView";
            this.ProductodataGridView.ReadOnly = true;
            this.ProductodataGridView.RowHeadersVisible = false;
            this.ProductodataGridView.RowHeadersWidth = 51;
            this.ProductodataGridView.RowTemplate.Height = 24;
            this.ProductodataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductodataGridView.Size = new System.Drawing.Size(723, 225);
            this.ProductodataGridView.TabIndex = 15;
            this.ProductodataGridView.DoubleClick += new System.EventHandler(this.ProductodataGridView_DoubleClick);
            // 
            // MarcModeltextBox
            // 
            this.MarcModeltextBox.Location = new System.Drawing.Point(363, 14);
            this.MarcModeltextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MarcModeltextBox.Name = "MarcModeltextBox";
            this.MarcModeltextBox.Size = new System.Drawing.Size(110, 20);
            this.MarcModeltextBox.TabIndex = 17;
            this.MarcModeltextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MarcModeltextBox_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Marca y Modelo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(570, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Descripcion:";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(497, 53);
            this.DescripciontextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescripciontextBox.Multiline = true;
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.ReadOnly = true;
            this.DescripciontextBox.Size = new System.Drawing.Size(218, 59);
            this.DescripciontextBox.TabIndex = 19;
            // 
            // WINProVent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 366);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MarcModeltextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProductodataGridView);
            this.Controls.Add(this.Enviarbutton);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.StocktextBox);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CostotextBox);
            this.Controls.Add(this.ProductotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CostotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StocktextBox;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Enviarbutton;
        private System.Windows.Forms.DataGridView ProductodataGridView;
        public System.Windows.Forms.TextBox ProductotextBox;
        public System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.TextBox MarcModeltextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DescripciontextBox;
    }
}