namespace MiAppDesk.View.Dialogs
{
    partial class AddToCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToCart));
            this.lblItemsSel = new System.Windows.Forms.Label();
            this.btnCancelarOrden = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.curvaForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrdenar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItemsSel
            // 
            this.lblItemsSel.AutoSize = true;
            this.lblItemsSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsSel.ForeColor = System.Drawing.Color.Silver;
            this.lblItemsSel.Location = new System.Drawing.Point(172, 72);
            this.lblItemsSel.Name = "lblItemsSel";
            this.lblItemsSel.Size = new System.Drawing.Size(72, 24);
            this.lblItemsSel.TabIndex = 21;
            this.lblItemsSel.Text = "ITEMS";
            // 
            // btnCancelarOrden
            // 
            this.btnCancelarOrden.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarOrden.Image")));
            this.btnCancelarOrden.ImageActive = null;
            this.btnCancelarOrden.Location = new System.Drawing.Point(378, 3);
            this.btnCancelarOrden.Name = "btnCancelarOrden";
            this.btnCancelarOrden.Size = new System.Drawing.Size(31, 39);
            this.btnCancelarOrden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelarOrden.TabIndex = 19;
            this.btnCancelarOrden.TabStop = false;
            this.btnCancelarOrden.Zoom = 10;
            this.btnCancelarOrden.Click += new System.EventHandler(this.btnCancelarOrden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "INGRESE LA CANTIDAD PARA:";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // curvaForm
            // 
            this.curvaForm.ElipseRadius = 20;
            this.curvaForm.TargetControl = this;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(146, 108);
            this.txtCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 35);
            this.txtCantidad.TabIndex = 22;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnCancelarOrden);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 55);
            this.panel1.TabIndex = 23;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnOrdenar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrdenar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOrdenar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrdenar.BorderRadius = 0;
            this.btnOrdenar.ButtonText = "ORDENAR";
            this.btnOrdenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenar.DisabledColor = System.Drawing.Color.Gray;
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOrdenar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOrdenar.Iconimage")));
            this.btnOrdenar.Iconimage_right = null;
            this.btnOrdenar.Iconimage_right_Selected = null;
            this.btnOrdenar.Iconimage_Selected = null;
            this.btnOrdenar.IconMarginLeft = 0;
            this.btnOrdenar.IconMarginRight = 0;
            this.btnOrdenar.IconRightVisible = true;
            this.btnOrdenar.IconRightZoom = 0D;
            this.btnOrdenar.IconVisible = true;
            this.btnOrdenar.IconZoom = 40D;
            this.btnOrdenar.IsTab = false;
            this.btnOrdenar.Location = new System.Drawing.Point(126, 177);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(5);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnOrdenar.OnHovercolor = System.Drawing.Color.Green;
            this.btnOrdenar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOrdenar.selected = false;
            this.btnOrdenar.Size = new System.Drawing.Size(169, 42);
            this.btnOrdenar.TabIndex = 114;
            this.btnOrdenar.Text = "ORDENAR";
            this.btnOrdenar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOrdenar.Textcolor = System.Drawing.Color.White;
            this.btnOrdenar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // AddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(412, 277);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblItemsSel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddToCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddToCart";
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemsSel;
        private Bunifu.Framework.UI.BunifuImageButton btnCancelarOrden;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse curvaForm;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnOrdenar;
    }
}