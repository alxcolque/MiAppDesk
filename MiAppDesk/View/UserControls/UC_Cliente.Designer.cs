﻿namespace MiAppDesk.View.UserControls
{
    partial class UC_Cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Cliente));
            this.dgvCli = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscar = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunificbuscar = new Bunifu.Framework.UI.BunifuTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCli
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCli.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCli.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvCli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCli.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCli.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCli.DoubleBuffered = true;
            this.dgvCli.EnableHeadersVisualStyles = false;
            this.dgvCli.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvCli.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCli.Location = new System.Drawing.Point(77, 139);
            this.dgvCli.Name = "dgvCli";
            this.dgvCli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCli.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCli.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCli.Size = new System.Drawing.Size(649, 399);
            this.dgvCli.TabIndex = 111;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(778, 42);
            this.panel4.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.Crimson;
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 0;
            this.btnEliminar.ButtonText = "ELIMINAR";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Iconimage")));
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 0;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 30D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(519, 94);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.Crimson;
            this.btnEliminar.OnHovercolor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(122, 35);
            this.btnEliminar.TabIndex = 115;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Textcolor = System.Drawing.Color.White;
            this.btnEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Activecolor = System.Drawing.Color.Teal;
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.BorderRadius = 0;
            this.btnModificar.ButtonText = "EDITAR";
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.DisabledColor = System.Drawing.Color.Gray;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModificar.Iconimage")));
            this.btnModificar.Iconimage_right = null;
            this.btnModificar.Iconimage_right_Selected = null;
            this.btnModificar.Iconimage_Selected = null;
            this.btnModificar.IconMarginLeft = 0;
            this.btnModificar.IconMarginRight = 0;
            this.btnModificar.IconRightVisible = true;
            this.btnModificar.IconRightZoom = 0D;
            this.btnModificar.IconVisible = true;
            this.btnModificar.IconZoom = 30D;
            this.btnModificar.IsTab = false;
            this.btnModificar.Location = new System.Drawing.Point(395, 94);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModificar.selected = false;
            this.btnModificar.Size = new System.Drawing.Size(116, 35);
            this.btnModificar.TabIndex = 114;
            this.btnModificar.Text = "EDITAR";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificar.Textcolor = System.Drawing.Color.White;
            this.btnModificar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.BorderRadius = 0;
            this.btnNuevo.ButtonText = "NUEVO";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Iconimage")));
            this.btnNuevo.Iconimage_right = null;
            this.btnNuevo.Iconimage_right_Selected = null;
            this.btnNuevo.Iconimage_Selected = null;
            this.btnNuevo.IconMarginLeft = 0;
            this.btnNuevo.IconMarginRight = 0;
            this.btnNuevo.IconRightVisible = true;
            this.btnNuevo.IconRightZoom = 0D;
            this.btnNuevo.IconVisible = true;
            this.btnNuevo.IconZoom = 30D;
            this.btnNuevo.IsTab = false;
            this.btnNuevo.Location = new System.Drawing.Point(277, 94);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnNuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevo.selected = false;
            this.btnNuevo.Size = new System.Drawing.Size(110, 35);
            this.btnNuevo.TabIndex = 113;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.Textcolor = System.Drawing.Color.White;
            this.btnNuevo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar.BackColor = System.Drawing.Color.LightGray;
            this.txtBuscar.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txtBuscar.Location = new System.Drawing.Point(126, 99);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(125, 27);
            this.txtBuscar.TabIndex = 112;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // bunificbuscar
            // 
            this.bunificbuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunificbuscar.BackColor = System.Drawing.Color.LightGray;
            this.bunificbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunificbuscar.BackgroundImage")));
            this.bunificbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunificbuscar.Enabled = false;
            this.bunificbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunificbuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.bunificbuscar.Icon = ((System.Drawing.Image)(resources.GetObject("bunificbuscar.Icon")));
            this.bunificbuscar.Location = new System.Drawing.Point(77, 92);
            this.bunificbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunificbuscar.Name = "bunificbuscar";
            this.bunificbuscar.Size = new System.Drawing.Size(189, 40);
            this.bunificbuscar.TabIndex = 110;
            this.bunificbuscar.text = "";
            // 
            // UC_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvCli);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.bunificbuscar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Cliente";
            this.Size = new System.Drawing.Size(784, 597);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCli;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnModificar;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevo;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuTextbox bunificbuscar;
    }
}
