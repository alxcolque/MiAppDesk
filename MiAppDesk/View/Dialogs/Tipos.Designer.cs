namespace MiAppDesk.View.Dialogs
{
    partial class Tipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tipos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipo = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnElimT = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnUptT = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNewT = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvTi = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.btnElimT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUptT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTi)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(208, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 93;
            this.label2.Text = "&Nombre Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTipo.Location = new System.Drawing.Point(208, 90);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(193, 20);
            this.txtTipo.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(210, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 91;
            this.label1.Text = "GESTIONAR TIPO";
            // 
            // btnElimT
            // 
            this.btnElimT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnElimT.BackColor = System.Drawing.Color.Crimson;
            this.btnElimT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnElimT.Image = ((System.Drawing.Image)(resources.GetObject("btnElimT.Image")));
            this.btnElimT.ImageActive = null;
            this.btnElimT.Location = new System.Drawing.Point(349, 132);
            this.btnElimT.Name = "btnElimT";
            this.btnElimT.Size = new System.Drawing.Size(53, 46);
            this.btnElimT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnElimT.TabIndex = 90;
            this.btnElimT.TabStop = false;
            this.btnElimT.Zoom = 10;
            // 
            // btnUptT
            // 
            this.btnUptT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUptT.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUptT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnUptT.Image = ((System.Drawing.Image)(resources.GetObject("btnUptT.Image")));
            this.btnUptT.ImageActive = null;
            this.btnUptT.Location = new System.Drawing.Point(278, 132);
            this.btnUptT.Name = "btnUptT";
            this.btnUptT.Size = new System.Drawing.Size(53, 46);
            this.btnUptT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUptT.TabIndex = 89;
            this.btnUptT.TabStop = false;
            this.btnUptT.Zoom = 10;
            // 
            // btnNewT
            // 
            this.btnNewT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewT.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNewT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnNewT.Image = ((System.Drawing.Image)(resources.GetObject("btnNewT.Image")));
            this.btnNewT.ImageActive = null;
            this.btnNewT.Location = new System.Drawing.Point(209, 132);
            this.btnNewT.Name = "btnNewT";
            this.btnNewT.Size = new System.Drawing.Size(53, 46);
            this.btnNewT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNewT.TabIndex = 88;
            this.btnNewT.TabStop = false;
            this.btnNewT.Zoom = 10;
            this.btnNewT.Click += new System.EventHandler(this.btnNewT_Click);
            // 
            // dgvTi
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.dgvTi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTi.DoubleBuffered = true;
            this.dgvTi.EnableHeadersVisualStyles = false;
            this.dgvTi.GridColor = System.Drawing.Color.Teal;
            this.dgvTi.HeaderBgColor = System.Drawing.Color.DarkCyan;
            this.dgvTi.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dgvTi.Location = new System.Drawing.Point(163, 196);
            this.dgvTi.Name = "dgvTi";
            this.dgvTi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTi.Size = new System.Drawing.Size(262, 214);
            this.dgvTi.TabIndex = 87;
            // 
            // Tipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(588, 415);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnElimT);
            this.Controls.Add(this.btnUptT);
            this.Controls.Add(this.btnNewT);
            this.Controls.Add(this.dgvTi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos";
            ((System.ComponentModel.ISupportInitialize)(this.btnElimT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUptT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTipo;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnElimT;
        private Bunifu.Framework.UI.BunifuImageButton btnUptT;
        private Bunifu.Framework.UI.BunifuImageButton btnNewT;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgvTi;
    }
}