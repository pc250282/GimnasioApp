namespace Gimnasio.GUI.Pantallas
{
    partial class FrmRegistrarPago
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
            lblApellidoSocio = new MaterialSkin.Controls.MaterialLabel();
            lblAbonoSocio = new MaterialSkin.Controls.MaterialLabel();
            lblNumSocio = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            sltMdp = new MaterialSkin.Controls.MaterialComboBox();
            lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            lblMontoPago = new MaterialSkin.Controls.MaterialLabel();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
            btnRegistrarPago = new MaterialSkin.Controls.MaterialButton();
            lblNombre = new MaterialSkin.Controls.MaterialLabel();
            lblAbonoNuevo = new MaterialSkin.Controls.MaterialLabel();
            lblNuevoValor = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // lblApellidoSocio
            // 
            lblApellidoSocio.AutoSize = true;
            lblApellidoSocio.Depth = 0;
            lblApellidoSocio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblApellidoSocio.Location = new Point(260, 142);
            lblApellidoSocio.MouseState = MaterialSkin.MouseState.HOVER;
            lblApellidoSocio.Name = "lblApellidoSocio";
            lblApellidoSocio.Size = new Size(75, 19);
            lblApellidoSocio.TabIndex = 0;
            lblApellidoSocio.Text = "lblApellido";
            // 
            // lblAbonoSocio
            // 
            lblAbonoSocio.AutoSize = true;
            lblAbonoSocio.Depth = 0;
            lblAbonoSocio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblAbonoSocio.Location = new Point(71, 142);
            lblAbonoSocio.MouseState = MaterialSkin.MouseState.HOVER;
            lblAbonoSocio.Name = "lblAbonoSocio";
            lblAbonoSocio.Size = new Size(64, 19);
            lblAbonoSocio.TabIndex = 1;
            lblAbonoSocio.Text = "lblAbono";
            // 
            // lblNumSocio
            // 
            lblNumSocio.AutoSize = true;
            lblNumSocio.Depth = 0;
            lblNumSocio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNumSocio.Location = new Point(71, 105);
            lblNumSocio.MouseState = MaterialSkin.MouseState.HOVER;
            lblNumSocio.Name = "lblNumSocio";
            lblNumSocio.Size = new Size(92, 19);
            lblNumSocio.TabIndex = 2;
            lblNumSocio.Text = "lblNumSocio";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 74);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(140, 19);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "DATOS DEL SOCIO:";
            // 
            // sltMdp
            // 
            sltMdp.AutoResize = false;
            sltMdp.BackColor = Color.FromArgb(255, 255, 255);
            sltMdp.Depth = 0;
            sltMdp.DrawMode = DrawMode.OwnerDrawVariable;
            sltMdp.DropDownHeight = 174;
            sltMdp.DropDownStyle = ComboBoxStyle.DropDownList;
            sltMdp.DropDownWidth = 121;
            sltMdp.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sltMdp.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sltMdp.FormattingEnabled = true;
            sltMdp.Hint = "Medio de pago";
            sltMdp.IntegralHeight = false;
            sltMdp.ItemHeight = 43;
            sltMdp.Location = new Point(6, 228);
            sltMdp.MaxDropDownItems = 4;
            sltMdp.MouseState = MaterialSkin.MouseState.OUT;
            sltMdp.Name = "sltMdp";
            sltMdp.Size = new Size(204, 49);
            sltMdp.StartIndex = 0;
            sltMdp.TabIndex = 9;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Depth = 0;
            lblTitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitulo.Location = new Point(260, 228);
            lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(109, 19);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Monto a pagar:";
            // 
            // lblMontoPago
            // 
            lblMontoPago.AutoSize = true;
            lblMontoPago.Depth = 0;
            lblMontoPago.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMontoPago.Location = new Point(260, 258);
            lblMontoPago.MouseState = MaterialSkin.MouseState.HOVER;
            lblMontoPago.Name = "lblMontoPago";
            lblMontoPago.Size = new Size(49, 19);
            lblMontoPago.TabIndex = 12;
            lblMontoPago.Text = "$ *****";
            // 
            // btnVolver
            // 
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVolver.Depth = 0;
            btnVolver.HighEmphasis = true;
            btnVolver.Icon = null;
            btnVolver.Location = new Point(7, 378);
            btnVolver.Margin = new Padding(4, 6, 4, 6);
            btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            btnVolver.Name = "btnVolver";
            btnVolver.NoAccentTextColor = Color.Empty;
            btnVolver.Size = new Size(76, 36);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "VOLVER";
            btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVolver.UseAccentColor = false;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegistrarPago.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegistrarPago.Depth = 0;
            btnRegistrarPago.HighEmphasis = true;
            btnRegistrarPago.Icon = null;
            btnRegistrarPago.Location = new Point(161, 330);
            btnRegistrarPago.Margin = new Padding(4, 6, 4, 6);
            btnRegistrarPago.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.NoAccentTextColor = Color.Empty;
            btnRegistrarPago.Size = new Size(148, 36);
            btnRegistrarPago.TabIndex = 14;
            btnRegistrarPago.Text = "CONFIRMAR PAGO";
            btnRegistrarPago.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegistrarPago.UseAccentColor = false;
            btnRegistrarPago.UseVisualStyleBackColor = true;
            btnRegistrarPago.Click += btnRegistrarPago_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Depth = 0;
            lblNombre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNombre.Location = new Point(260, 105);
            lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(74, 19);
            lblNombre.TabIndex = 15;
            lblNombre.Text = "lblNombre";
            // 
            // lblAbonoNuevo
            // 
            lblAbonoNuevo.AutoSize = true;
            lblAbonoNuevo.Depth = 0;
            lblAbonoNuevo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblAbonoNuevo.Location = new Point(71, 181);
            lblAbonoNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            lblAbonoNuevo.Name = "lblAbonoNuevo";
            lblAbonoNuevo.Size = new Size(109, 19);
            lblAbonoNuevo.TabIndex = 16;
            lblAbonoNuevo.Text = "lblAbonoNuevo";
            // 
            // lblNuevoValor
            // 
            lblNuevoValor.AutoSize = true;
            lblNuevoValor.Depth = 0;
            lblNuevoValor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNuevoValor.Location = new Point(260, 181);
            lblNuevoValor.MouseState = MaterialSkin.MouseState.HOVER;
            lblNuevoValor.Name = "lblNuevoValor";
            lblNuevoValor.Size = new Size(100, 19);
            lblNuevoValor.TabIndex = 17;
            lblNuevoValor.Text = "lblNuevoValor";
            // 
            // FrmRegistrarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 423);
            Controls.Add(lblNuevoValor);
            Controls.Add(lblAbonoNuevo);
            Controls.Add(lblNombre);
            Controls.Add(btnRegistrarPago);
            Controls.Add(btnVolver);
            Controls.Add(lblMontoPago);
            Controls.Add(lblTitulo);
            Controls.Add(sltMdp);
            Controls.Add(materialLabel1);
            Controls.Add(lblNumSocio);
            Controls.Add(lblAbonoSocio);
            Controls.Add(lblApellidoSocio);
            Name = "FrmRegistrarPago";
            Text = "RegistrarPago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblApellidoSocio;
        private MaterialSkin.Controls.MaterialLabel lblAbonoSocio;
        private MaterialSkin.Controls.MaterialLabel lblNumSocio;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox sltMdp;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialLabel lblMontoPago;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialButton btnRegistrarPago;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblAbonoNuevo;
        private MaterialSkin.Controls.MaterialLabel lblNuevoValor;
    }
}