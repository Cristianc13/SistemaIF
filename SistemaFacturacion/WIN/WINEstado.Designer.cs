namespace WIN
{
    partial class WINEstado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WINEstado));
            this.lblestado = new System.Windows.Forms.Label();
            this.txtestados = new System.Windows.Forms.TextBox();
            this.EstadodataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnclose = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.EstadodataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblestado.Location = new System.Drawing.Point(40, 22);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(64, 20);
            this.lblestado.TabIndex = 0;
            this.lblestado.Text = "Estado:";
            // 
            // txtestados
            // 
            this.txtestados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtestados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtestados.Location = new System.Drawing.Point(113, 25);
            this.txtestados.Name = "txtestados";
            this.txtestados.Size = new System.Drawing.Size(252, 19);
            this.txtestados.TabIndex = 1;
            // 
            // EstadodataGridView1
            // 
            this.EstadodataGridView1.AllowUserToAddRows = false;
            this.EstadodataGridView1.AllowUserToDeleteRows = false;
            this.EstadodataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.EstadodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstadodataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EstadodataGridView1.Location = new System.Drawing.Point(0, 0);
            this.EstadodataGridView1.Name = "EstadodataGridView1";
            this.EstadodataGridView1.ReadOnly = true;
            this.EstadodataGridView1.RowHeadersVisible = false;
            this.EstadodataGridView1.Size = new System.Drawing.Size(465, 171);
            this.EstadodataGridView1.TabIndex = 2;
            this.EstadodataGridView1.DoubleClick += new System.EventHandler(this.EstadodataGridView1_DoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.header.Controls.Add(this.label2);
            this.header.Controls.Add(this.btnclose);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(465, 32);
            this.header.TabIndex = 7;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Estado";
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.btnclose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnclose.IconColor = System.Drawing.Color.White;
            this.btnclose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclose.Location = new System.Drawing.Point(433, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(32, 32);
            this.btnclose.TabIndex = 46;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.btneditar);
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.lblestado);
            this.panel2.Controls.Add(this.txtestados);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 130);
            this.panel2.TabIndex = 8;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton1.Location = new System.Drawing.Point(244, 78);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(109, 35);
            this.iconButton1.TabIndex = 54;
            this.iconButton1.Text = "Cancelar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btneditar.IconColor = System.Drawing.Color.White;
            this.btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneditar.IconSize = 30;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btneditar.Location = new System.Drawing.Point(134, 78);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(104, 35);
            this.btneditar.TabIndex = 53;
            this.btneditar.Text = "Editar";
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 30;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnguardar.Location = new System.Drawing.Point(23, 78);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(104, 35);
            this.btnguardar.TabIndex = 52;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(106, 18);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(266, 35);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 51;
            this.pictureBox10.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.EstadodataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 171);
            this.panel3.TabIndex = 9;
            // 
            // WINEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 333);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WINEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WINEstado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstadodataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtestados;
        private System.Windows.Forms.DataGridView EstadodataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel header;
        private FontAwesome.Sharp.IconPictureBox btnclose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox10;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btneditar;
        private FontAwesome.Sharp.IconButton btnguardar;
    }
}