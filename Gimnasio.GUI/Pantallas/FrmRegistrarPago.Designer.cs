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
            btnEnvioComprobante = new MaterialSkin.Controls.MaterialButton();
            txtMail = new MaterialSkin.Controls.MaterialTextBox2();
            imgPago = new PictureBox();
            groupBox1 = new GroupBox();
            txtDescripcionPago = new Label();
            ((System.ComponentModel.ISupportInitialize)imgPago).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblApellidoSocio
            // 
            lblApellidoSocio.AutoSize = true;
            lblApellidoSocio.Depth = 0;
            lblApellidoSocio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblApellidoSocio.Location = new Point(9, 195);
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
            lblAbonoSocio.Location = new Point(260, 116);
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
            lblNumSocio.Location = new Point(9, 116);
            lblNumSocio.MouseState = MaterialSkin.MouseState.HOVER;
            lblNumSocio.Name = "lblNumSocio";
            lblNumSocio.Size = new Size(66, 19);
            lblNumSocio.TabIndex = 2;
            lblNumSocio.Text = "N° Socio:";
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel1.Location = new Point(69, 74);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(224, 31);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "DATOS DEL SOCIO";
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
            sltMdp.Location = new Point(7, 254);
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
            lblTitulo.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblTitulo.Location = new Point(260, 228);
            lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(136, 24);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Monto a pagar:";
            // 
            // lblMontoPago
            // 
            lblMontoPago.AutoSize = true;
            lblMontoPago.Depth = 0;
            lblMontoPago.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblMontoPago.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblMontoPago.Location = new Point(260, 274);
            lblMontoPago.MouseState = MaterialSkin.MouseState.HOVER;
            lblMontoPago.Name = "lblMontoPago";
            lblMontoPago.Size = new Size(70, 29);
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
            btnRegistrarPago.Location = new Point(177, 378);
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
            lblNombre.Location = new Point(9, 156);
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
            lblAbonoNuevo.Location = new Point(260, 156);
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
            lblNuevoValor.Location = new Point(260, 195);
            lblNuevoValor.MouseState = MaterialSkin.MouseState.HOVER;
            lblNuevoValor.Name = "lblNuevoValor";
            lblNuevoValor.Size = new Size(100, 19);
            lblNuevoValor.TabIndex = 17;
            lblNuevoValor.Text = "lblNuevoValor";
            // 
            // btnEnvioComprobante
            // 
            btnEnvioComprobante.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEnvioComprobante.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEnvioComprobante.Depth = 0;
            btnEnvioComprobante.HighEmphasis = true;
            btnEnvioComprobante.Icon = null;
            btnEnvioComprobante.Location = new Point(0, 316);
            btnEnvioComprobante.Margin = new Padding(4, 6, 4, 6);
            btnEnvioComprobante.MouseState = MaterialSkin.MouseState.HOVER;
            btnEnvioComprobante.Name = "btnEnvioComprobante";
            btnEnvioComprobante.NoAccentTextColor = Color.Empty;
            btnEnvioComprobante.Size = new Size(185, 36);
            btnEnvioComprobante.TabIndex = 18;
            btnEnvioComprobante.Text = "ENVIAR COMPROBANTE";
            btnEnvioComprobante.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEnvioComprobante.UseAccentColor = false;
            btnEnvioComprobante.UseVisualStyleBackColor = true;
            btnEnvioComprobante.Click += btnEnvioComprobante_Click;
            // 
            // txtMail
            // 
            txtMail.AnimateReadOnly = false;
            txtMail.BackgroundImageLayout = ImageLayout.None;
            txtMail.CharacterCasing = CharacterCasing.Normal;
            txtMail.Depth = 0;
            txtMail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMail.HelperText = "Mail para el envio";
            txtMail.HideSelection = true;
            txtMail.LeadingIcon = null;
            txtMail.Location = new Point(206, 316);
            txtMail.MaxLength = 32767;
            txtMail.MouseState = MaterialSkin.MouseState.OUT;
            txtMail.Name = "txtMail";
            txtMail.PasswordChar = '\0';
            txtMail.PrefixSuffixText = null;
            txtMail.ReadOnly = true;
            txtMail.RightToLeft = RightToLeft.No;
            txtMail.SelectedText = "";
            txtMail.SelectionLength = 0;
            txtMail.SelectionStart = 0;
            txtMail.ShortcutsEnabled = true;
            txtMail.Size = new Size(250, 36);
            txtMail.TabIndex = 19;
            txtMail.TabStop = false;
            txtMail.TextAlign = HorizontalAlignment.Left;
            txtMail.TrailingIcon = null;
            txtMail.UseSystemPasswordChar = false;
            txtMail.UseTallSize = false;
            // 
            // imgPago
            // 
            imgPago.Image = Properties.Resources.payOk;
            imgPago.Location = new Point(268, 22);
            imgPago.Name = "imgPago";
            imgPago.Size = new Size(227, 219);
            imgPago.TabIndex = 20;
            imgPago.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDescripcionPago);
            groupBox1.Controls.Add(btnEnvioComprobante);
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(imgPago);
            groupBox1.Location = new Point(9, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(501, 379);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle:";
            groupBox1.Visible = false;
            // 
            // txtDescripcionPago
            // 
            txtDescripcionPago.AutoSize = true;
            txtDescripcionPago.Location = new Point(6, 22);
            txtDescripcionPago.Name = "txtDescripcionPago";
            txtDescripcionPago.Size = new Size(38, 15);
            txtDescripcionPago.TabIndex = 21;
            txtDescripcionPago.Text = "label1";
            // 
            // FrmRegistrarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 478);
            Controls.Add(groupBox1);
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
            Text = "Registro de pago";
            ((System.ComponentModel.ISupportInitialize)imgPago).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private MaterialSkin.Controls.MaterialButton btnEnvioComprobante;
        private MaterialSkin.Controls.MaterialTextBox2 txtMail;
        private PictureBox imgPago;
        private GroupBox groupBox1;
        private Label txtDescripcionPago;
    }
}