namespace MiAppDesk
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.ptbxLogo = new System.Windows.Forms.PictureBox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAcceder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbxLogo
            // 
            this.ptbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbxLogo.Image")));
            this.ptbxLogo.Location = new System.Drawing.Point(93, 115);
            this.ptbxLogo.Name = "ptbxLogo";
            this.ptbxLogo.Size = new System.Drawing.Size(47, 52);
            this.ptbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxLogo.TabIndex = 18;
            this.ptbxLogo.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(139, 115);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(253, 52);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.Text = "admin";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtUsuario.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtUsuario.BorderThickness = 2;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtUsuario.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.txtUsuario.isPassword = false;
            this.txtUsuario.Location = new System.Drawing.Point(139, 47);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(253, 52);
            this.txtUsuario.TabIndex = 19;
            this.txtUsuario.Text = "admin";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnAcceder
            // 
            this.btnAcceder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAcceder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAcceder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAcceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcceder.BorderRadius = 2;
            this.btnAcceder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAcceder.ButtonText = "ACCEDER";
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.DisabledColor = System.Drawing.Color.Gray;
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAcceder.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAcceder.Iconimage")));
            this.btnAcceder.Iconimage_right = null;
            this.btnAcceder.Iconimage_right_Selected = null;
            this.btnAcceder.Iconimage_Selected = null;
            this.btnAcceder.IconMarginLeft = 0;
            this.btnAcceder.IconMarginRight = 0;
            this.btnAcceder.IconRightVisible = true;
            this.btnAcceder.IconRightZoom = 0D;
            this.btnAcceder.IconVisible = true;
            this.btnAcceder.IconZoom = 50D;
            this.btnAcceder.IsTab = false;
            this.btnAcceder.Location = new System.Drawing.Point(139, 195);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnAcceder.OnHovercolor = System.Drawing.Color.Teal;
            this.btnAcceder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAcceder.selected = false;
            this.btnAcceder.Size = new System.Drawing.Size(228, 50);
            this.btnAcceder.TabIndex = 21;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAcceder.Textcolor = System.Drawing.Color.White;
            this.btnAcceder.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            this.btnAcceder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAcceder_KeyPress);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(154, 267);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(201, 29);
            this.progressBar1.TabIndex = 23;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(485, 323);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ptbxLogo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAcceder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            ((System.ComponentModel.ISupportInitialize)(this.ptbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbxLogo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal Bunifu.Framework.UI.BunifuFlatButton btnAcceder;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

