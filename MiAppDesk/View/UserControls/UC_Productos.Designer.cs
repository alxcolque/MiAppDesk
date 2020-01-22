namespace MiAppDesk.View.UserControls
{
    partial class UC_Productos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Productos));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTipos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.curvaBTNtipos = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.btnTipos);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(778, 42);
            this.panel4.TabIndex = 18;
            // 
            // btnTipos
            // 
            this.btnTipos.Activecolor = System.Drawing.Color.Teal;
            this.btnTipos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTipos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTipos.BorderRadius = 0;
            this.btnTipos.ButtonText = "Ver Tipos";
            this.btnTipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTipos.DisabledColor = System.Drawing.Color.Gray;
            this.btnTipos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTipos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTipos.Iconimage")));
            this.btnTipos.Iconimage_right = null;
            this.btnTipos.Iconimage_right_Selected = null;
            this.btnTipos.Iconimage_Selected = null;
            this.btnTipos.IconMarginLeft = 0;
            this.btnTipos.IconMarginRight = 0;
            this.btnTipos.IconRightVisible = true;
            this.btnTipos.IconRightZoom = 0D;
            this.btnTipos.IconVisible = true;
            this.btnTipos.IconZoom = 30D;
            this.btnTipos.IsTab = false;
            this.btnTipos.Location = new System.Drawing.Point(641, 7);
            this.btnTipos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnTipos.Name = "btnTipos";
            this.btnTipos.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.btnTipos.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnTipos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTipos.selected = false;
            this.btnTipos.Size = new System.Drawing.Size(132, 28);
            this.btnTipos.TabIndex = 77;
            this.btnTipos.Text = "Ver Tipos";
            this.btnTipos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTipos.Textcolor = System.Drawing.Color.White;
            this.btnTipos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipos.Click += new System.EventHandler(this.btnTipos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " Productos ";
            // 
            // curvaBTNtipos
            // 
            this.curvaBTNtipos.ElipseRadius = 30;
            this.curvaBTNtipos.TargetControl = this.btnTipos;
            // 
            // UC_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_Productos";
            this.Size = new System.Drawing.Size(784, 597);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnTipos;
        private Bunifu.Framework.UI.BunifuElipse curvaBTNtipos;
    }
}
