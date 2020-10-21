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
            ((System.ComponentModel.ISupportInitialize)(this.ProductodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Producto:";
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(153, 17);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(477, 22);
            this.BuscartextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Costo:";
            // 
            // ProductotextBox
            // 
            this.ProductotextBox.Location = new System.Drawing.Point(153, 66);
            this.ProductotextBox.Name = "ProductotextBox";
            this.ProductotextBox.ReadOnly = true;
            this.ProductotextBox.Size = new System.Drawing.Size(140, 22);
            this.ProductotextBox.TabIndex = 6;
            // 
            // CostotextBox
            // 
            this.CostotextBox.Location = new System.Drawing.Point(153, 114);
            this.CostotextBox.Name = "CostotextBox";
            this.CostotextBox.ReadOnly = true;
            this.CostotextBox.Size = new System.Drawing.Size(140, 22);
            this.CostotextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Precio Salida:";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(487, 65);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.ReadOnly = true;
            this.PreciotextBox.Size = new System.Drawing.Size(143, 22);
            this.PreciotextBox.TabIndex = 11;
            // 
            // StocktextBox
            // 
            this.StocktextBox.Location = new System.Drawing.Point(487, 114);
            this.StocktextBox.Name = "StocktextBox";
            this.StocktextBox.ReadOnly = true;
            this.StocktextBox.Size = new System.Drawing.Size(143, 22);
            this.StocktextBox.TabIndex = 12;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(663, 64);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(101, 23);
            this.Cancelarbutton.TabIndex = 13;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Enviarbutton
            // 
            this.Enviarbutton.Location = new System.Drawing.Point(663, 113);
            this.Enviarbutton.Name = "Enviarbutton";
            this.Enviarbutton.Size = new System.Drawing.Size(101, 23);
            this.Enviarbutton.TabIndex = 14;
            this.Enviarbutton.Text = "Enviar";
            this.Enviarbutton.UseVisualStyleBackColor = true;
            this.Enviarbutton.Click += new System.EventHandler(this.Enviarbutton_Click);
            // 
            // ProductodataGridView
            // 
            this.ProductodataGridView.AllowUserToAddRows = false;
            this.ProductodataGridView.AllowUserToDeleteRows = false;
            this.ProductodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductodataGridView.Location = new System.Drawing.Point(12, 161);
            this.ProductodataGridView.Name = "ProductodataGridView";
            this.ProductodataGridView.ReadOnly = true;
            this.ProductodataGridView.RowHeadersWidth = 51;
            this.ProductodataGridView.RowTemplate.Height = 24;
            this.ProductodataGridView.Size = new System.Drawing.Size(776, 277);
            this.ProductodataGridView.TabIndex = 15;
            this.ProductodataGridView.DoubleClick += new System.EventHandler(this.ProductodataGridView_DoubleClick);
            // 
            // WINProVent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "WINProVent";
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
    }
}