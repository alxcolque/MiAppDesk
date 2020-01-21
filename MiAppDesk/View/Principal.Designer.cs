namespace MiAppDesk.View
{
    partial class Principal
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.animacion1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlSidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGraficos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelAct = new System.Windows.Forms.Panel();
            this.btnVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrincipal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnItems = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblTimer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.curvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.curvaCerrar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tiempoReal = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.animacion2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlLeft.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // animacion1
            // 
            this.animacion1.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.animacion1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 1;
            animation3.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.animacion1.DefaultAnimation = animation3;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pnlLeft.Controls.Add(this.pnlSidebar);
            this.animacion2.SetDecoration(this.pnlLeft, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.pnlLeft, BunifuAnimatorNS.DecorationType.None);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 46);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 615);
            this.pnlLeft.TabIndex = 7;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSidebar.BackgroundImage")));
            this.pnlSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSidebar.Controls.Add(this.lblAdmin);
            this.pnlSidebar.Controls.Add(this.pictureBox1);
            this.pnlSidebar.Controls.Add(this.btnGraficos);
            this.pnlSidebar.Controls.Add(this.panelAct);
            this.pnlSidebar.Controls.Add(this.btnVentas);
            this.pnlSidebar.Controls.Add(this.btnPrincipal);
            this.pnlSidebar.Controls.Add(this.btnClientes);
            this.pnlSidebar.Controls.Add(this.btnItems);
            this.pnlSidebar.Controls.Add(this.btnStock);
            this.animacion2.SetDecoration(this.pnlSidebar, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.pnlSidebar, BunifuAnimatorNS.DecorationType.None);
            this.pnlSidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.pnlSidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.pnlSidebar.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.pnlSidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.pnlSidebar.Location = new System.Drawing.Point(9, 3);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Quality = 10;
            this.pnlSidebar.Size = new System.Drawing.Size(182, 609);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.animacion1.SetDecoration(this.lblAdmin, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.lblAdmin, BunifuAnimatorNS.DecorationType.None);
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAdmin.Location = new System.Drawing.Point(5, 71);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(75, 25);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.animacion1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGraficos
            // 
            this.btnGraficos.Activecolor = System.Drawing.Color.Transparent;
            this.btnGraficos.BackColor = System.Drawing.Color.Transparent;
            this.btnGraficos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGraficos.BorderRadius = 0;
            this.btnGraficos.ButtonText = "    Gráficos";
            this.btnGraficos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion2.SetDecoration(this.btnGraficos, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnGraficos, BunifuAnimatorNS.DecorationType.None);
            this.btnGraficos.DisabledColor = System.Drawing.Color.Gray;
            this.btnGraficos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGraficos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGraficos.Iconimage")));
            this.btnGraficos.Iconimage_right = null;
            this.btnGraficos.Iconimage_right_Selected = null;
            this.btnGraficos.Iconimage_Selected = null;
            this.btnGraficos.IconMarginLeft = 0;
            this.btnGraficos.IconMarginRight = 0;
            this.btnGraficos.IconRightVisible = true;
            this.btnGraficos.IconRightZoom = 0D;
            this.btnGraficos.IconVisible = true;
            this.btnGraficos.IconZoom = 50D;
            this.btnGraficos.IsTab = false;
            this.btnGraficos.Location = new System.Drawing.Point(10, 446);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGraficos.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnGraficos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGraficos.selected = false;
            this.btnGraficos.Size = new System.Drawing.Size(168, 48);
            this.btnGraficos.TabIndex = 15;
            this.btnGraficos.Text = "    Gráficos";
            this.btnGraficos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraficos.Textcolor = System.Drawing.Color.White;
            this.btnGraficos.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelAct
            // 
            this.panelAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.animacion2.SetDecoration(this.panelAct, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.panelAct, BunifuAnimatorNS.DecorationType.None);
            this.panelAct.Location = new System.Drawing.Point(3, 99);
            this.panelAct.Name = "panelAct";
            this.panelAct.Size = new System.Drawing.Size(10, 48);
            this.panelAct.TabIndex = 14;
            // 
            // btnVentas
            // 
            this.btnVentas.Activecolor = System.Drawing.Color.Transparent;
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.BorderRadius = 0;
            this.btnVentas.ButtonText = "      VENTAS";
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion2.SetDecoration(this.btnVentas, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnVentas, BunifuAnimatorNS.DecorationType.None);
            this.btnVentas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVentas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVentas.Iconimage")));
            this.btnVentas.Iconimage_right = null;
            this.btnVentas.Iconimage_right_Selected = null;
            this.btnVentas.Iconimage_Selected = null;
            this.btnVentas.IconMarginLeft = 0;
            this.btnVentas.IconMarginRight = 0;
            this.btnVentas.IconRightVisible = true;
            this.btnVentas.IconRightZoom = 0D;
            this.btnVentas.IconVisible = true;
            this.btnVentas.IconZoom = 50D;
            this.btnVentas.IsTab = false;
            this.btnVentas.Location = new System.Drawing.Point(8, 372);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVentas.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnVentas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVentas.selected = false;
            this.btnVentas.Size = new System.Drawing.Size(178, 48);
            this.btnVentas.TabIndex = 12;
            this.btnVentas.Text = "      VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Textcolor = System.Drawing.Color.White;
            this.btnVentas.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Activecolor = System.Drawing.Color.Transparent;
            this.btnPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrincipal.BorderRadius = 0;
            this.btnPrincipal.ButtonText = "      INICIO";
            this.btnPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion2.SetDecoration(this.btnPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.btnPrincipal.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrincipal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrincipal.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrincipal.Iconimage")));
            this.btnPrincipal.Iconimage_right = null;
            this.btnPrincipal.Iconimage_right_Selected = null;
            this.btnPrincipal.Iconimage_Selected = null;
            this.btnPrincipal.IconMarginLeft = 0;
            this.btnPrincipal.IconMarginRight = 0;
            this.btnPrincipal.IconRightVisible = true;
            this.btnPrincipal.IconRightZoom = 0D;
            this.btnPrincipal.IconVisible = true;
            this.btnPrincipal.IconZoom = 50D;
            this.btnPrincipal.IsTab = false;
            this.btnPrincipal.Location = new System.Drawing.Point(8, 98);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPrincipal.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnPrincipal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrincipal.selected = false;
            this.btnPrincipal.Size = new System.Drawing.Size(178, 48);
            this.btnPrincipal.TabIndex = 8;
            this.btnPrincipal.Text = "      INICIO";
            this.btnPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.Textcolor = System.Drawing.Color.White;
            this.btnPrincipal.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnClientes
            // 
            this.btnClientes.Activecolor = System.Drawing.Color.Transparent;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.BorderRadius = 0;
            this.btnClientes.ButtonText = "      &CLIENTES";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion2.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClientes.Iconimage")));
            this.btnClientes.Iconimage_right = null;
            this.btnClientes.Iconimage_right_Selected = null;
            this.btnClientes.Iconimage_Selected = null;
            this.btnClientes.IconMarginLeft = 0;
            this.btnClientes.IconMarginRight = 0;
            this.btnClientes.IconRightVisible = true;
            this.btnClientes.IconRightZoom = 0D;
            this.btnClientes.IconVisible = true;
            this.btnClientes.IconZoom = 50D;
            this.btnClientes.IsTab = false;
            this.btnClientes.Location = new System.Drawing.Point(8, 302);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClientes.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClientes.selected = false;
            this.btnClientes.Size = new System.Drawing.Size(176, 48);
            this.btnClientes.TabIndex = 11;
            this.btnClientes.Text = "      &CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Textcolor = System.Drawing.Color.White;
            this.btnClientes.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnItems
            // 
            this.btnItems.Activecolor = System.Drawing.Color.Transparent;
            this.btnItems.BackColor = System.Drawing.Color.Transparent;
            this.btnItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItems.BorderRadius = 0;
            this.btnItems.ButtonText = "      PRODUCTOS";
            this.btnItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion2.SetDecoration(this.btnItems, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnItems, BunifuAnimatorNS.DecorationType.None);
            this.btnItems.DisabledColor = System.Drawing.Color.Gray;
            this.btnItems.Iconcolor = System.Drawing.Color.Transparent;
            this.btnItems.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnItems.Iconimage")));
            this.btnItems.Iconimage_right = null;
            this.btnItems.Iconimage_right_Selected = null;
            this.btnItems.Iconimage_Selected = null;
            this.btnItems.IconMarginLeft = 0;
            this.btnItems.IconMarginRight = 0;
            this.btnItems.IconRightVisible = true;
            this.btnItems.IconRightZoom = 0D;
            this.btnItems.IconVisible = true;
            this.btnItems.IconZoom = 50D;
            this.btnItems.IsTab = false;
            this.btnItems.Location = new System.Drawing.Point(10, 162);
            this.btnItems.Name = "btnItems";
            this.btnItems.Normalcolor = System.Drawing.Color.Transparent;
            this.btnItems.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnItems.OnHoverTextColor = System.Drawing.Color.White;
            this.btnItems.selected = false;
            this.btnItems.Size = new System.Drawing.Size(172, 48);
            this.btnItems.TabIndex = 9;
            this.btnItems.Text = "      PRODUCTOS";
            this.btnItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItems.Textcolor = System.Drawing.Color.White;
            this.btnItems.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnStock
            // 
            this.btnStock.Activecolor = System.Drawing.Color.Transparent;
            this.btnStock.BackColor = System.Drawing.Color.Transparent;
            this.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStock.BorderRadius = 0;
            this.btnStock.ButtonText = "      STOCK";
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion2.SetDecoration(this.btnStock, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnStock, BunifuAnimatorNS.DecorationType.None);
            this.btnStock.DisabledColor = System.Drawing.Color.Gray;
            this.btnStock.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStock.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStock.Iconimage")));
            this.btnStock.Iconimage_right = null;
            this.btnStock.Iconimage_right_Selected = null;
            this.btnStock.Iconimage_Selected = null;
            this.btnStock.IconMarginLeft = 0;
            this.btnStock.IconMarginRight = 0;
            this.btnStock.IconRightVisible = true;
            this.btnStock.IconRightZoom = 0D;
            this.btnStock.IconVisible = true;
            this.btnStock.IconZoom = 50D;
            this.btnStock.IsTab = false;
            this.btnStock.Location = new System.Drawing.Point(8, 233);
            this.btnStock.Name = "btnStock";
            this.btnStock.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStock.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnStock.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStock.selected = false;
            this.btnStock.Size = new System.Drawing.Size(176, 48);
            this.btnStock.TabIndex = 10;
            this.btnStock.Text = "      STOCK";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Textcolor = System.Drawing.Color.White;
            this.btnStock.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.pnlSuperior.Controls.Add(this.lblTimer);
            this.pnlSuperior.Controls.Add(this.btnMenu);
            this.animacion2.SetDecoration(this.pnlSuperior, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.pnlSuperior, BunifuAnimatorNS.DecorationType.None);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(984, 46);
            this.pnlSuperior.TabIndex = 6;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.AutoSize = true;
            this.animacion1.SetDecoration(this.lblTimer, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.lblTimer, BunifuAnimatorNS.DecorationType.None);
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(890, 10);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(82, 16);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "HH:MM:SS";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion2.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(30, 10);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(25, 25);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 13;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.animacion2.SetDecoration(this.pnlCuerpo, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.pnlCuerpo, BunifuAnimatorNS.DecorationType.None);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.ForeColor = System.Drawing.Color.Black;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 0);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(984, 661);
            this.pnlCuerpo.TabIndex = 8;
            // 
            // curvaSidebar
            // 
            this.curvaSidebar.ElipseRadius = 10;
            this.curvaSidebar.TargetControl = this.pnlSidebar;
            // 
            // curvaCerrar
            // 
            this.curvaCerrar.ElipseRadius = 20;
            // 
            // animacion2
            // 
            this.animacion2.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.animacion2.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.animacion2.DefaultAnimation = animation4;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlCuerpo);
            this.animacion1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.pnlLeft.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition animacion1;
        private System.Windows.Forms.Panel pnlLeft;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlSidebar;
        private System.Windows.Forms.Label lblAdmin;
        private BunifuAnimatorNS.BunifuTransition animacion2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnGraficos;
        private System.Windows.Forms.Panel panelAct;
        private Bunifu.Framework.UI.BunifuFlatButton btnVentas;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrincipal;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnItems;
        private Bunifu.Framework.UI.BunifuFlatButton btnStock;
        private System.Windows.Forms.Panel pnlSuperior;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTimer;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.Panel pnlCuerpo;
        private Bunifu.Framework.UI.BunifuElipse curvaSidebar;
        private Bunifu.Framework.UI.BunifuElipse curvaCerrar;
        private System.Windows.Forms.Timer tiempoReal;
        private System.Windows.Forms.Timer timer1;
    }
}