﻿namespace Vista
{
    partial class frmRevisarVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAnularBoleta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVendedores = new System.Windows.Forms.ComboBox();
            this.btnBuscarBoleta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarBoleta = new System.Windows.Forms.TextBox();
            this.pnlContenedorGrilla = new System.Windows.Forms.Panel();
            this.pnlTituloGrilla = new System.Windows.Forms.Panel();
            this.nombreGrilla = new System.Windows.Forms.Label();
            this.grdBoleta = new System.Windows.Forms.DataGridView();
            this.pnlContenedorGrillaDetalleBoleta = new System.Windows.Forms.Panel();
            this.grdDetalleBoleta = new System.Windows.Forms.DataGridView();
            this.pnlTituloGrillaDetalle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.pnlContenedorGrilla.SuspendLayout();
            this.pnlTituloGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBoleta)).BeginInit();
            this.pnlContenedorGrillaDetalleBoleta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleBoleta)).BeginInit();
            this.pnlTituloGrillaDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnularBoleta
            // 
            this.btnAnularBoleta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAnularBoleta.Location = new System.Drawing.Point(845, 501);
            this.btnAnularBoleta.Name = "btnAnularBoleta";
            this.btnAnularBoleta.Size = new System.Drawing.Size(128, 21);
            this.btnAnularBoleta.TabIndex = 35;
            this.btnAnularBoleta.Text = "Anular";
            this.btnAnularBoleta.UseVisualStyleBackColor = true;
            this.btnAnularBoleta.Click += new System.EventHandler(this.btnAnularBoleta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cmbMedioPago);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbVendedores);
            this.groupBox2.Controls.Add(this.btnBuscarBoleta);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBuscarBoleta);
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 73);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Boleta:";
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(336, 28);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(181, 21);
            this.cmbMedioPago.TabIndex = 50;
            this.cmbMedioPago.SelectedValueChanged += new System.EventHandler(this.cmbMedioPago_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Medio Pago:";
            // 
            // cmbVendedores
            // 
            this.cmbVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedores.FormattingEnabled = true;
            this.cmbVendedores.Location = new System.Drawing.Point(68, 28);
            this.cmbVendedores.Name = "cmbVendedores";
            this.cmbVendedores.Size = new System.Drawing.Size(181, 21);
            this.cmbVendedores.TabIndex = 48;
            this.cmbVendedores.SelectedIndexChanged += new System.EventHandler(this.cmbVendedores_SelectedIndexChanged);
            // 
            // btnBuscarBoleta
            // 
            this.btnBuscarBoleta.Location = new System.Drawing.Point(729, 27);
            this.btnBuscarBoleta.Name = "btnBuscarBoleta";
            this.btnBuscarBoleta.Size = new System.Drawing.Size(128, 21);
            this.btnBuscarBoleta.TabIndex = 2;
            this.btnBuscarBoleta.Text = "Buscar";
            this.btnBuscarBoleta.UseVisualStyleBackColor = true;
            this.btnBuscarBoleta.Click += new System.EventHandler(this.btnBuscarBoleta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Vendedor:";
            // 
            // txtBuscarBoleta
            // 
            this.txtBuscarBoleta.Location = new System.Drawing.Point(530, 28);
            this.txtBuscarBoleta.Name = "txtBuscarBoleta";
            this.txtBuscarBoleta.Size = new System.Drawing.Size(182, 20);
            this.txtBuscarBoleta.TabIndex = 1;
            // 
            // pnlContenedorGrilla
            // 
            this.pnlContenedorGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorGrilla.Controls.Add(this.grdBoleta);
            this.pnlContenedorGrilla.Controls.Add(this.pnlTituloGrilla);
            this.pnlContenedorGrilla.Location = new System.Drawing.Point(12, 104);
            this.pnlContenedorGrilla.Name = "pnlContenedorGrilla";
            this.pnlContenedorGrilla.Size = new System.Drawing.Size(474, 418);
            this.pnlContenedorGrilla.TabIndex = 45;
            // 
            // pnlTituloGrilla
            // 
            this.pnlTituloGrilla.BackColor = System.Drawing.Color.Silver;
            this.pnlTituloGrilla.Controls.Add(this.nombreGrilla);
            this.pnlTituloGrilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloGrilla.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloGrilla.Name = "pnlTituloGrilla";
            this.pnlTituloGrilla.Size = new System.Drawing.Size(474, 39);
            this.pnlTituloGrilla.TabIndex = 25;
            // 
            // nombreGrilla
            // 
            this.nombreGrilla.AutoSize = true;
            this.nombreGrilla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreGrilla.Location = new System.Drawing.Point(15, 10);
            this.nombreGrilla.Name = "nombreGrilla";
            this.nombreGrilla.Size = new System.Drawing.Size(63, 19);
            this.nombreGrilla.TabIndex = 0;
            this.nombreGrilla.Text = "Boletas";
            // 
            // grdBoleta
            // 
            this.grdBoleta.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            this.grdBoleta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.grdBoleta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdBoleta.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdBoleta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdBoleta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBoleta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.grdBoleta.ColumnHeadersHeight = 30;
            this.grdBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdBoleta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBoleta.EnableHeadersVisualStyles = false;
            this.grdBoleta.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdBoleta.Location = new System.Drawing.Point(0, 39);
            this.grdBoleta.MultiSelect = false;
            this.grdBoleta.Name = "grdBoleta";
            this.grdBoleta.ReadOnly = true;
            this.grdBoleta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBoleta.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.grdBoleta.RowHeadersVisible = false;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            this.grdBoleta.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.grdBoleta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBoleta.Size = new System.Drawing.Size(474, 379);
            this.grdBoleta.TabIndex = 29;
            this.grdBoleta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBoleta_CellClick);
            // 
            // pnlContenedorGrillaDetalleBoleta
            // 
            this.pnlContenedorGrillaDetalleBoleta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorGrillaDetalleBoleta.Controls.Add(this.grdDetalleBoleta);
            this.pnlContenedorGrillaDetalleBoleta.Controls.Add(this.pnlTituloGrillaDetalle);
            this.pnlContenedorGrillaDetalleBoleta.Location = new System.Drawing.Point(492, 104);
            this.pnlContenedorGrillaDetalleBoleta.Name = "pnlContenedorGrillaDetalleBoleta";
            this.pnlContenedorGrillaDetalleBoleta.Size = new System.Drawing.Size(334, 418);
            this.pnlContenedorGrillaDetalleBoleta.TabIndex = 46;
            // 
            // grdDetalleBoleta
            // 
            this.grdDetalleBoleta.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            this.grdDetalleBoleta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.grdDetalleBoleta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDetalleBoleta.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdDetalleBoleta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdDetalleBoleta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalleBoleta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.grdDetalleBoleta.ColumnHeadersHeight = 30;
            this.grdDetalleBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdDetalleBoleta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalleBoleta.EnableHeadersVisualStyles = false;
            this.grdDetalleBoleta.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdDetalleBoleta.Location = new System.Drawing.Point(0, 39);
            this.grdDetalleBoleta.MultiSelect = false;
            this.grdDetalleBoleta.Name = "grdDetalleBoleta";
            this.grdDetalleBoleta.ReadOnly = true;
            this.grdDetalleBoleta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalleBoleta.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.grdDetalleBoleta.RowHeadersVisible = false;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            this.grdDetalleBoleta.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.grdDetalleBoleta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalleBoleta.Size = new System.Drawing.Size(334, 379);
            this.grdDetalleBoleta.TabIndex = 29;
            // 
            // pnlTituloGrillaDetalle
            // 
            this.pnlTituloGrillaDetalle.BackColor = System.Drawing.Color.Silver;
            this.pnlTituloGrillaDetalle.Controls.Add(this.label2);
            this.pnlTituloGrillaDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloGrillaDetalle.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloGrillaDetalle.Name = "pnlTituloGrillaDetalle";
            this.pnlTituloGrillaDetalle.Size = new System.Drawing.Size(334, 39);
            this.pnlTituloGrillaDetalle.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Detalle de boleta";
            // 
            // frmRevisarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pnlContenedorGrillaDetalleBoleta);
            this.Controls.Add(this.pnlContenedorGrilla);
            this.Controls.Add(this.btnAnularBoleta);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRevisarVenta";
            this.Text = "frmVenta";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlContenedorGrilla.ResumeLayout(false);
            this.pnlTituloGrilla.ResumeLayout(false);
            this.pnlTituloGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBoleta)).EndInit();
            this.pnlContenedorGrillaDetalleBoleta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleBoleta)).EndInit();
            this.pnlTituloGrillaDetalle.ResumeLayout(false);
            this.pnlTituloGrillaDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAnularBoleta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarBoleta;
        private System.Windows.Forms.TextBox txtBuscarBoleta;
        private System.Windows.Forms.ComboBox cmbVendedores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMedioPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContenedorGrilla;
        private System.Windows.Forms.Panel pnlTituloGrilla;
        private System.Windows.Forms.Label nombreGrilla;
        protected System.Windows.Forms.DataGridView grdBoleta;
        private System.Windows.Forms.Panel pnlContenedorGrillaDetalleBoleta;
        protected System.Windows.Forms.DataGridView grdDetalleBoleta;
        private System.Windows.Forms.Panel pnlTituloGrillaDetalle;
        private System.Windows.Forms.Label label2;
    }
}