namespace WIN
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.slidebar = new System.Windows.Forms.Panel();
            this.wrapper = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnprincipal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnproducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnventa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncompra = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnproveedor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncategoria = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnmodelo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnmarca = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnestado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flecha = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.slidebar.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // slidebar
            // 
            this.slidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.slidebar.Controls.Add(this.flecha);
            this.slidebar.Controls.Add(this.btnestado);
            this.slidebar.Controls.Add(this.btncategoria);
            this.slidebar.Controls.Add(this.btnmodelo);
            this.slidebar.Controls.Add(this.btnmarca);
            this.slidebar.Controls.Add(this.btnproveedor);
            this.slidebar.Controls.Add(this.btncliente);
            this.slidebar.Controls.Add(this.btncompra);
            this.slidebar.Controls.Add(this.btnventa);
            this.slidebar.Controls.Add(this.btnproducto);
            this.slidebar.Controls.Add(this.btnprincipal);
            this.slidebar.Controls.Add(this.label3);
            this.slidebar.Controls.Add(this.pictureBox2);
            this.slidebar.Controls.Add(this.label2);
            this.slidebar.Controls.Add(this.pictureBox1);
            this.slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidebar.Location = new System.Drawing.Point(0, 0);
            this.slidebar.Name = "slidebar";
            this.slidebar.Size = new System.Drawing.Size(270, 900);
            this.slidebar.TabIndex = 0;
            // 
            // wrapper
            // 
            this.wrapper.BackColor = System.Drawing.SystemColors.Control;
            this.wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapper.Location = new System.Drawing.Point(270, 60);
            this.wrapper.Name = "wrapper";
            this.wrapper.Size = new System.Drawing.Size(1260, 840);
            this.wrapper.TabIndex = 1;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.minimizar);
            this.header.Controls.Add(this.lbltitulo);
            this.header.Controls.Add(this.salir);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(270, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1260, 60);
            this.header.TabIndex = 1;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.lbltitulo.Location = new System.Drawing.Point(6, 18);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(179, 20);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Panel de Administracion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "LOGO";
            // 
            // salir
            // 
            this.salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salir.Image = global::WIN.Properties.Resources.icerrar;
            this.salir.Location = new System.Drawing.Point(1222, 3);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(35, 35);
            this.salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salir.TabIndex = 0;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(90, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WIN.Properties.Resources.javascript_logo_50px;
            this.pictureBox1.Location = new System.Drawing.Point(47, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ADMINISTRADOR";
            // 
            // btnprincipal
            // 
            this.btnprincipal.Activecolor = System.Drawing.Color.Transparent;
            this.btnprincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnprincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnprincipal.BorderRadius = 0;
            this.btnprincipal.ButtonText = "   Panel Principal";
            this.btnprincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprincipal.DisabledColor = System.Drawing.Color.Gray;
            this.btnprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprincipal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnprincipal.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnprincipal.Iconimage")));
            this.btnprincipal.Iconimage_right = null;
            this.btnprincipal.Iconimage_right_Selected = null;
            this.btnprincipal.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnprincipal.Iconimage_Selected")));
            this.btnprincipal.IconMarginLeft = 0;
            this.btnprincipal.IconMarginRight = 0;
            this.btnprincipal.IconRightVisible = true;
            this.btnprincipal.IconRightZoom = 0D;
            this.btnprincipal.IconVisible = true;
            this.btnprincipal.IconZoom = 60D;
            this.btnprincipal.IsTab = true;
            this.btnprincipal.Location = new System.Drawing.Point(-1, 205);
            this.btnprincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnprincipal.Name = "btnprincipal";
            this.btnprincipal.Normalcolor = System.Drawing.Color.Transparent;
            this.btnprincipal.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnprincipal.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnprincipal.selected = false;
            this.btnprincipal.Size = new System.Drawing.Size(270, 46);
            this.btnprincipal.TabIndex = 5;
            this.btnprincipal.Text = "   Panel Principal";
            this.btnprincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprincipal.Textcolor = System.Drawing.Color.White;
            this.btnprincipal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprincipal.Click += new System.EventHandler(this.btnprincipal_Click);
            // 
            // btnproducto
            // 
            this.btnproducto.Activecolor = System.Drawing.Color.Transparent;
            this.btnproducto.BackColor = System.Drawing.Color.Transparent;
            this.btnproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnproducto.BorderRadius = 0;
            this.btnproducto.ButtonText = "   Producto";
            this.btnproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnproducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnproducto.Iconimage")));
            this.btnproducto.Iconimage_right = null;
            this.btnproducto.Iconimage_right_Selected = null;
            this.btnproducto.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnproducto.Iconimage_Selected")));
            this.btnproducto.IconMarginLeft = 0;
            this.btnproducto.IconMarginRight = 0;
            this.btnproducto.IconRightVisible = true;
            this.btnproducto.IconRightZoom = 0D;
            this.btnproducto.IconVisible = true;
            this.btnproducto.IconZoom = 60D;
            this.btnproducto.IsTab = true;
            this.btnproducto.Location = new System.Drawing.Point(-1, 259);
            this.btnproducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Normalcolor = System.Drawing.Color.Transparent;
            this.btnproducto.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnproducto.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnproducto.selected = false;
            this.btnproducto.Size = new System.Drawing.Size(270, 46);
            this.btnproducto.TabIndex = 6;
            this.btnproducto.Text = "   Producto";
            this.btnproducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproducto.Textcolor = System.Drawing.Color.White;
            this.btnproducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducto.Click += new System.EventHandler(this.btnproducto_Click);
            // 
            // btnventa
            // 
            this.btnventa.Activecolor = System.Drawing.Color.Transparent;
            this.btnventa.BackColor = System.Drawing.Color.Transparent;
            this.btnventa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnventa.BorderRadius = 0;
            this.btnventa.ButtonText = "   Venta";
            this.btnventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnventa.DisabledColor = System.Drawing.Color.Gray;
            this.btnventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnventa.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnventa.Iconimage")));
            this.btnventa.Iconimage_right = null;
            this.btnventa.Iconimage_right_Selected = null;
            this.btnventa.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnventa.Iconimage_Selected")));
            this.btnventa.IconMarginLeft = 0;
            this.btnventa.IconMarginRight = 0;
            this.btnventa.IconRightVisible = true;
            this.btnventa.IconRightZoom = 0D;
            this.btnventa.IconVisible = true;
            this.btnventa.IconZoom = 64D;
            this.btnventa.IsTab = true;
            this.btnventa.Location = new System.Drawing.Point(-1, 313);
            this.btnventa.Margin = new System.Windows.Forms.Padding(4);
            this.btnventa.Name = "btnventa";
            this.btnventa.Normalcolor = System.Drawing.Color.Transparent;
            this.btnventa.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnventa.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnventa.selected = false;
            this.btnventa.Size = new System.Drawing.Size(270, 46);
            this.btnventa.TabIndex = 7;
            this.btnventa.Text = "   Venta";
            this.btnventa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnventa.Textcolor = System.Drawing.Color.White;
            this.btnventa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventa.Click += new System.EventHandler(this.btnventa_Click);
            // 
            // btncompra
            // 
            this.btncompra.Activecolor = System.Drawing.Color.Transparent;
            this.btncompra.BackColor = System.Drawing.Color.Transparent;
            this.btncompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncompra.BorderRadius = 0;
            this.btncompra.ButtonText = "   Compra";
            this.btncompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncompra.DisabledColor = System.Drawing.Color.Gray;
            this.btncompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompra.Iconcolor = System.Drawing.Color.Transparent;
            this.btncompra.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncompra.Iconimage")));
            this.btncompra.Iconimage_right = null;
            this.btncompra.Iconimage_right_Selected = null;
            this.btncompra.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btncompra.Iconimage_Selected")));
            this.btncompra.IconMarginLeft = 0;
            this.btncompra.IconMarginRight = 0;
            this.btncompra.IconRightVisible = true;
            this.btncompra.IconRightZoom = 0D;
            this.btncompra.IconVisible = true;
            this.btncompra.IconZoom = 60D;
            this.btncompra.IsTab = true;
            this.btncompra.Location = new System.Drawing.Point(-1, 367);
            this.btncompra.Margin = new System.Windows.Forms.Padding(4);
            this.btncompra.Name = "btncompra";
            this.btncompra.Normalcolor = System.Drawing.Color.Transparent;
            this.btncompra.OnHovercolor = System.Drawing.Color.Transparent;
            this.btncompra.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btncompra.selected = false;
            this.btncompra.Size = new System.Drawing.Size(270, 46);
            this.btncompra.TabIndex = 8;
            this.btncompra.Text = "   Compra";
            this.btncompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncompra.Textcolor = System.Drawing.Color.White;
            this.btncompra.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompra.Click += new System.EventHandler(this.btncompra_Click);
            // 
            // btncliente
            // 
            this.btncliente.Activecolor = System.Drawing.Color.Transparent;
            this.btncliente.BackColor = System.Drawing.Color.Transparent;
            this.btncliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncliente.BorderRadius = 0;
            this.btncliente.ButtonText = "   Cliente";
            this.btncliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncliente.DisabledColor = System.Drawing.Color.Gray;
            this.btncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btncliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncliente.Iconimage")));
            this.btncliente.Iconimage_right = null;
            this.btncliente.Iconimage_right_Selected = null;
            this.btncliente.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btncliente.Iconimage_Selected")));
            this.btncliente.IconMarginLeft = 0;
            this.btncliente.IconMarginRight = 0;
            this.btncliente.IconRightVisible = true;
            this.btncliente.IconRightZoom = 0D;
            this.btncliente.IconVisible = true;
            this.btncliente.IconZoom = 60D;
            this.btncliente.IsTab = true;
            this.btncliente.Location = new System.Drawing.Point(-1, 421);
            this.btncliente.Margin = new System.Windows.Forms.Padding(4);
            this.btncliente.Name = "btncliente";
            this.btncliente.Normalcolor = System.Drawing.Color.Transparent;
            this.btncliente.OnHovercolor = System.Drawing.Color.Transparent;
            this.btncliente.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btncliente.selected = false;
            this.btncliente.Size = new System.Drawing.Size(270, 46);
            this.btncliente.TabIndex = 9;
            this.btncliente.Text = "   Cliente";
            this.btncliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncliente.Textcolor = System.Drawing.Color.White;
            this.btncliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // btnproveedor
            // 
            this.btnproveedor.Activecolor = System.Drawing.Color.Transparent;
            this.btnproveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnproveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnproveedor.BorderRadius = 0;
            this.btnproveedor.ButtonText = "   Proveedor";
            this.btnproveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproveedor.DisabledColor = System.Drawing.Color.Gray;
            this.btnproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproveedor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnproveedor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnproveedor.Iconimage")));
            this.btnproveedor.Iconimage_right = null;
            this.btnproveedor.Iconimage_right_Selected = null;
            this.btnproveedor.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnproveedor.Iconimage_Selected")));
            this.btnproveedor.IconMarginLeft = 0;
            this.btnproveedor.IconMarginRight = 0;
            this.btnproveedor.IconRightVisible = true;
            this.btnproveedor.IconRightZoom = 0D;
            this.btnproveedor.IconVisible = true;
            this.btnproveedor.IconZoom = 60D;
            this.btnproveedor.IsTab = true;
            this.btnproveedor.Location = new System.Drawing.Point(-1, 475);
            this.btnproveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnproveedor.Name = "btnproveedor";
            this.btnproveedor.Normalcolor = System.Drawing.Color.Transparent;
            this.btnproveedor.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnproveedor.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnproveedor.selected = false;
            this.btnproveedor.Size = new System.Drawing.Size(270, 46);
            this.btnproveedor.TabIndex = 10;
            this.btnproveedor.Text = "   Proveedor";
            this.btnproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproveedor.Textcolor = System.Drawing.Color.White;
            this.btnproveedor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproveedor.Click += new System.EventHandler(this.btnproveedor_Click);
            // 
            // btncategoria
            // 
            this.btncategoria.Activecolor = System.Drawing.Color.Transparent;
            this.btncategoria.BackColor = System.Drawing.Color.Transparent;
            this.btncategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncategoria.BorderRadius = 0;
            this.btncategoria.ButtonText = "   Categoria";
            this.btncategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncategoria.DisabledColor = System.Drawing.Color.Gray;
            this.btncategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategoria.Iconcolor = System.Drawing.Color.Transparent;
            this.btncategoria.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncategoria.Iconimage")));
            this.btncategoria.Iconimage_right = null;
            this.btncategoria.Iconimage_right_Selected = null;
            this.btncategoria.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btncategoria.Iconimage_Selected")));
            this.btncategoria.IconMarginLeft = 0;
            this.btncategoria.IconMarginRight = 0;
            this.btncategoria.IconRightVisible = true;
            this.btncategoria.IconRightZoom = 0D;
            this.btncategoria.IconVisible = true;
            this.btncategoria.IconZoom = 60D;
            this.btncategoria.IsTab = true;
            this.btncategoria.Location = new System.Drawing.Point(-1, 639);
            this.btncategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btncategoria.Name = "btncategoria";
            this.btncategoria.Normalcolor = System.Drawing.Color.Transparent;
            this.btncategoria.OnHovercolor = System.Drawing.Color.Transparent;
            this.btncategoria.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btncategoria.selected = false;
            this.btncategoria.Size = new System.Drawing.Size(270, 46);
            this.btncategoria.TabIndex = 13;
            this.btncategoria.Text = "   Categoria";
            this.btncategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategoria.Textcolor = System.Drawing.Color.White;
            this.btncategoria.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategoria.Click += new System.EventHandler(this.btncategoria_Click);
            // 
            // btnmodelo
            // 
            this.btnmodelo.Activecolor = System.Drawing.Color.Transparent;
            this.btnmodelo.BackColor = System.Drawing.Color.Transparent;
            this.btnmodelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodelo.BorderRadius = 0;
            this.btnmodelo.ButtonText = "   Modelo";
            this.btnmodelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodelo.DisabledColor = System.Drawing.Color.Gray;
            this.btnmodelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodelo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnmodelo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnmodelo.Iconimage")));
            this.btnmodelo.Iconimage_right = null;
            this.btnmodelo.Iconimage_right_Selected = null;
            this.btnmodelo.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnmodelo.Iconimage_Selected")));
            this.btnmodelo.IconMarginLeft = 0;
            this.btnmodelo.IconMarginRight = 0;
            this.btnmodelo.IconRightVisible = true;
            this.btnmodelo.IconRightZoom = 0D;
            this.btnmodelo.IconVisible = true;
            this.btnmodelo.IconZoom = 60D;
            this.btnmodelo.IsTab = true;
            this.btnmodelo.Location = new System.Drawing.Point(-1, 585);
            this.btnmodelo.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodelo.Name = "btnmodelo";
            this.btnmodelo.Normalcolor = System.Drawing.Color.Transparent;
            this.btnmodelo.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnmodelo.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnmodelo.selected = false;
            this.btnmodelo.Size = new System.Drawing.Size(270, 46);
            this.btnmodelo.TabIndex = 12;
            this.btnmodelo.Text = "   Modelo";
            this.btnmodelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodelo.Textcolor = System.Drawing.Color.White;
            this.btnmodelo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodelo.Click += new System.EventHandler(this.btnmodelo_Click);
            // 
            // btnmarca
            // 
            this.btnmarca.Activecolor = System.Drawing.Color.Transparent;
            this.btnmarca.BackColor = System.Drawing.Color.Transparent;
            this.btnmarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmarca.BorderRadius = 0;
            this.btnmarca.ButtonText = "   Marca";
            this.btnmarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmarca.DisabledColor = System.Drawing.Color.Gray;
            this.btnmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarca.Iconcolor = System.Drawing.Color.Transparent;
            this.btnmarca.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnmarca.Iconimage")));
            this.btnmarca.Iconimage_right = null;
            this.btnmarca.Iconimage_right_Selected = null;
            this.btnmarca.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnmarca.Iconimage_Selected")));
            this.btnmarca.IconMarginLeft = 0;
            this.btnmarca.IconMarginRight = 0;
            this.btnmarca.IconRightVisible = true;
            this.btnmarca.IconRightZoom = 0D;
            this.btnmarca.IconVisible = true;
            this.btnmarca.IconZoom = 60D;
            this.btnmarca.IsTab = true;
            this.btnmarca.Location = new System.Drawing.Point(-1, 531);
            this.btnmarca.Margin = new System.Windows.Forms.Padding(4);
            this.btnmarca.Name = "btnmarca";
            this.btnmarca.Normalcolor = System.Drawing.Color.Transparent;
            this.btnmarca.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnmarca.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnmarca.selected = false;
            this.btnmarca.Size = new System.Drawing.Size(270, 46);
            this.btnmarca.TabIndex = 11;
            this.btnmarca.Text = "   Marca";
            this.btnmarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmarca.Textcolor = System.Drawing.Color.White;
            this.btnmarca.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarca.Click += new System.EventHandler(this.btnmarca_Click);
            // 
            // btnestado
            // 
            this.btnestado.Activecolor = System.Drawing.Color.Transparent;
            this.btnestado.BackColor = System.Drawing.Color.Transparent;
            this.btnestado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnestado.BorderRadius = 0;
            this.btnestado.ButtonText = "   Estado";
            this.btnestado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnestado.DisabledColor = System.Drawing.Color.Gray;
            this.btnestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestado.Iconcolor = System.Drawing.Color.Transparent;
            this.btnestado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnestado.Iconimage")));
            this.btnestado.Iconimage_right = null;
            this.btnestado.Iconimage_right_Selected = null;
            this.btnestado.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnestado.Iconimage_Selected")));
            this.btnestado.IconMarginLeft = 0;
            this.btnestado.IconMarginRight = 0;
            this.btnestado.IconRightVisible = true;
            this.btnestado.IconRightZoom = 0D;
            this.btnestado.IconVisible = true;
            this.btnestado.IconZoom = 60D;
            this.btnestado.IsTab = true;
            this.btnestado.Location = new System.Drawing.Point(-1, 693);
            this.btnestado.Margin = new System.Windows.Forms.Padding(4);
            this.btnestado.Name = "btnestado";
            this.btnestado.Normalcolor = System.Drawing.Color.Transparent;
            this.btnestado.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnestado.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnestado.selected = false;
            this.btnestado.Size = new System.Drawing.Size(270, 46);
            this.btnestado.TabIndex = 14;
            this.btnestado.Text = "   Estado";
            this.btnestado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnestado.Textcolor = System.Drawing.Color.White;
            this.btnestado.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestado.Click += new System.EventHandler(this.btnestado_Click);
            // 
            // flecha
            // 
            this.flecha.Image = ((System.Drawing.Image)(resources.GetObject("flecha.Image")));
            this.flecha.Location = new System.Drawing.Point(237, 208);
            this.flecha.Name = "flecha";
            this.flecha.Size = new System.Drawing.Size(35, 35);
            this.flecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flecha.TabIndex = 0;
            this.flecha.TabStop = false;
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(1181, 3);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(35, 35);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 2;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 900);
            this.Controls.Add(this.wrapper);
            this.Controls.Add(this.header);
            this.Controls.Add(this.slidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.slidebar.ResumeLayout(false);
            this.slidebar.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel slidebar;
        private System.Windows.Forms.Panel wrapper;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnprincipal;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnproducto;
        private Bunifu.Framework.UI.BunifuFlatButton btnproveedor;
        private Bunifu.Framework.UI.BunifuFlatButton btncliente;
        private Bunifu.Framework.UI.BunifuFlatButton btncompra;
        private Bunifu.Framework.UI.BunifuFlatButton btnventa;
        private Bunifu.Framework.UI.BunifuFlatButton btnestado;
        private Bunifu.Framework.UI.BunifuFlatButton btncategoria;
        private Bunifu.Framework.UI.BunifuFlatButton btnmodelo;
        private Bunifu.Framework.UI.BunifuFlatButton btnmarca;
        private System.Windows.Forms.PictureBox flecha;
        private System.Windows.Forms.PictureBox minimizar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

