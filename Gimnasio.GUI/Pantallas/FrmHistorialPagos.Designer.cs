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
            IdPago = new DataGridViewTextBoxColumn();
            fechaPago = new DataGridViewTextBoxColumn();
            IdSocio = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            nombreAbono = new DataGridViewTextBoxColumn();
            nombreMdp = new DataGridViewTextBoxColumn();
            montoPago = new DataGridViewTextBoxColumn();
            sltPagos = new MaterialSkin.Controls.MaterialComboBox();
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
            tablaPagos.Size = new Size(788, 250);
            tablaPagos.TabIndex = 1;
            // 
            // IdPago
            // 
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
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // nombreAbono
            // 
            nombreAbono.HeaderText = "Abono cobrado";
            nombreAbono.Name = "nombreAbono";
            nombreAbono.ReadOnly = true;
            // 
            // nombreMdp
            // 
            nombreMdp.HeaderText = "Medio de pago";
            nombreMdp.Name = "nombreMdp";
            nombreMdp.ReadOnly = true;
            // 
            // montoPago
            // 
            montoPago.HeaderText = "Monto pagado";
            montoPago.Name = "montoPago";
            montoPago.ReadOnly = true;
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
            sltPagos.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sltPagos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sltPagos.FormattingEnabled = true;
            sltPagos.IntegralHeight = false;
            sltPagos.ItemHeight = 43;
            sltPagos.Location = new Point(6, 323);
            sltPagos.MaxDropDownItems = 4;
            sltPagos.MouseState = MaterialSkin.MouseState.OUT;
            sltPagos.Name = "sltPagos";
            sltPagos.Size = new Size(121, 49);
            sltPagos.StartIndex = 0;
            sltPagos.TabIndex = 2;
            // 
            // FrmHistorialPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sltPagos);
            Controls.Add(tablaPagos);
            Name = "FrmHistorialPagos";
            Text = "Pagos";
            ((System.ComponentModel.ISupportInitialize)tablaPagos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tablaPagos;
        private DataGridViewTextBoxColumn IdPago;
        private DataGridViewTextBoxColumn fechaPago;
        private DataGridViewTextBoxColumn IdSocio;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn nombreAbono;
        private DataGridViewTextBoxColumn nombreMdp;
        private DataGridViewTextBoxColumn montoPago;
        private MaterialSkin.Controls.MaterialComboBox sltPagos;
    }
}