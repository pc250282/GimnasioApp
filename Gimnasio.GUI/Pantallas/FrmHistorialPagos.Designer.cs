namespace Gimnasio.GUI.Pantallas
{
    partial class FrmHistorialPagos
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
            tablaPagos = new DataGridView();
            sltPagos = new MaterialSkin.Controls.MaterialComboBox();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
            IdPago = new DataGridViewTextBoxColumn();
            fechaPago = new DataGridViewTextBoxColumn();
            IdSocio = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            nombreAbono = new DataGridViewTextBoxColumn();
            nombreMdp = new DataGridViewTextBoxColumn();
            montoPago = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tablaPagos).BeginInit();
            SuspendLayout();
            // 
            // tablaPagos
            // 
            tablaPagos.AllowUserToAddRows = false;
            tablaPagos.AllowUserToDeleteRows = false;
            tablaPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaPagos.Columns.AddRange(new DataGridViewColumn[] { IdPago, fechaPago, IdSocio, apellido, nombre, nombreAbono, nombreMdp, montoPago });
            tablaPagos.Location = new Point(6, 67);
            tablaPagos.Name = "tablaPagos";
            tablaPagos.ReadOnly = true;
            tablaPagos.RowTemplate.Height = 25;
            tablaPagos.Size = new Size(1044, 284);
            tablaPagos.TabIndex = 1;
            // 
            // sltPagos
            // 
            sltPagos.AutoResize = false;
            sltPagos.BackColor = Color.FromArgb(255, 255, 255);
            sltPagos.Depth = 0;
            sltPagos.DrawMode = DrawMode.OwnerDrawVariable;
            sltPagos.DropDownHeight = 174;
            sltPagos.DropDownStyle = ComboBoxStyle.DropDownList;
            sltPagos.DropDownWidth = 121;
            sltPagos.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sltPagos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sltPagos.FormattingEnabled = true;
            sltPagos.Hint = "ID Pago";
            sltPagos.IntegralHeight = false;
            sltPagos.ItemHeight = 43;
            sltPagos.Location = new Point(53, 405);
            sltPagos.MaxDropDownItems = 4;
            sltPagos.MouseState = MaterialSkin.MouseState.OUT;
            sltPagos.Name = "sltPagos";
            sltPagos.Size = new Size(191, 49);
            sltPagos.StartIndex = 0;
            sltPagos.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVolver.Depth = 0;
            btnVolver.HighEmphasis = true;
            btnVolver.Icon = null;
            btnVolver.Location = new Point(382, 418);
            btnVolver.Margin = new Padding(4, 6, 4, 6);
            btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            btnVolver.Name = "btnVolver";
            btnVolver.NoAccentTextColor = Color.Empty;
            btnVolver.Size = new Size(76, 36);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "volver";
            btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVolver.UseAccentColor = false;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // IdPago
            // 
            IdPago.FillWeight = 120F;
            IdPago.HeaderText = "N° Recibo";
            IdPago.Name = "IdPago";
            IdPago.ReadOnly = true;
            // 
            // fechaPago
            // 
            fechaPago.HeaderText = "Fecha ";
            fechaPago.Name = "fechaPago";
            fechaPago.ReadOnly = true;
            // 
            // IdSocio
            // 
            IdSocio.HeaderText = "Dni Cliente";
            IdSocio.Name = "IdSocio";
            IdSocio.ReadOnly = true;
            IdSocio.Width = 110;
            // 
            // apellido
            // 
            apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            apellido.Width = 76;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 76;
            // 
            // nombreAbono
            // 
            nombreAbono.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nombreAbono.HeaderText = "Abono cobrado";
            nombreAbono.Name = "nombreAbono";
            nombreAbono.ReadOnly = true;
            nombreAbono.Width = 106;
            // 
            // nombreMdp
            // 
            nombreMdp.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nombreMdp.HeaderText = "Medio de pago";
            nombreMdp.Name = "nombreMdp";
            nombreMdp.ReadOnly = true;
            nombreMdp.Width = 79;
            // 
            // montoPago
            // 
            montoPago.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            montoPago.HeaderText = "Monto pagado";
            montoPago.Name = "montoPago";
            montoPago.ReadOnly = true;
            montoPago.Width = 102;
            // 
            // FrmHistorialPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 534);
            Controls.Add(btnVolver);
            Controls.Add(sltPagos);
            Controls.Add(tablaPagos);
            Name = "FrmHistorialPagos";
            Text = "Pagos";
            ((System.ComponentModel.ISupportInitialize)tablaPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablaPagos;
        private MaterialSkin.Controls.MaterialComboBox sltPagos;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private DataGridViewTextBoxColumn IdPago;
        private DataGridViewTextBoxColumn fechaPago;
        private DataGridViewTextBoxColumn IdSocio;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn nombreAbono;
        private DataGridViewTextBoxColumn nombreMdp;
        private DataGridViewTextBoxColumn montoPago;
    }
}