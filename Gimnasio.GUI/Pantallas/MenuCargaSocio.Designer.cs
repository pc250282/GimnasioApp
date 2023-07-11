namespace Gimnasio.GUI
{
    partial class MenuCargaSocio
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
            sltGenero = new MaterialSkin.Controls.MaterialComboBox();
            sltAbono = new MaterialSkin.Controls.MaterialComboBox();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            txtDNI = new MaterialSkin.Controls.MaterialTextBox();
            txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            checkPago = new MaterialSkin.Controls.MaterialCheckbox();
            btnConfirmaAlta = new MaterialSkin.Controls.MaterialButton();
            lblFecha = new MaterialSkin.Controls.MaterialLabel();
            sltFechaNacimiento = new DateTimePicker();
            txtEdad = new MaterialSkin.Controls.MaterialTextBox();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtMail = new MaterialSkin.Controls.MaterialTextBox2();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sltGenero
            // 
            sltGenero.AutoResize = false;
            sltGenero.BackColor = Color.FromArgb(255, 255, 255);
            sltGenero.Depth = 0;
            sltGenero.DrawMode = DrawMode.OwnerDrawVariable;
            sltGenero.DropDownHeight = 174;
            sltGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            sltGenero.DropDownWidth = 121;
            sltGenero.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sltGenero.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sltGenero.FormattingEnabled = true;
            sltGenero.Hint = "Genero";
            sltGenero.IntegralHeight = false;
            sltGenero.ItemHeight = 43;
            sltGenero.Location = new Point(225, 215);
            sltGenero.MaxDropDownItems = 4;
            sltGenero.MouseState = MaterialSkin.MouseState.OUT;
            sltGenero.Name = "sltGenero";
            sltGenero.Size = new Size(246, 49);
            sltGenero.StartIndex = 0;
            sltGenero.TabIndex = 6;
            // 
            // sltAbono
            // 
            sltAbono.AutoResize = false;
            sltAbono.BackColor = Color.FromArgb(255, 255, 255);
            sltAbono.Depth = 0;
            sltAbono.DrawMode = DrawMode.OwnerDrawVariable;
            sltAbono.DropDownHeight = 174;
            sltAbono.DropDownStyle = ComboBoxStyle.DropDownList;
            sltAbono.DropDownWidth = 121;
            sltAbono.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sltAbono.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sltAbono.FormattingEnabled = true;
            sltAbono.Hint = "Abonos disponibles";
            sltAbono.IntegralHeight = false;
            sltAbono.ItemHeight = 43;
            sltAbono.Location = new Point(484, 80);
            sltAbono.MaxDropDownItems = 4;
            sltAbono.MouseState = MaterialSkin.MouseState.OUT;
            sltAbono.Name = "sltAbono";
            sltAbono.Size = new Size(248, 49);
            sltAbono.StartIndex = 0;
            sltAbono.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.Hint = "Nombre";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(6, 79);
            txtNombre.MaxLength = 50;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 50);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "";
            txtNombre.TrailingIcon = null;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.AnimateReadOnly = false;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Depth = 0;
            txtApellido.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtApellido.Hint = "Apellido";
            txtApellido.LeadingIcon = null;
            txtApellido.Location = new Point(6, 145);
            txtApellido.MaxLength = 50;
            txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            txtApellido.Multiline = false;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(205, 50);
            txtApellido.TabIndex = 2;
            txtApellido.Text = "";
            txtApellido.TrailingIcon = null;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtDNI
            // 
            txtDNI.AnimateReadOnly = false;
            txtDNI.BorderStyle = BorderStyle.None;
            txtDNI.Depth = 0;
            txtDNI.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDNI.Hint = "N° Documento";
            txtDNI.LeadingIcon = null;
            txtDNI.LeaveOnEnterKey = true;
            txtDNI.Location = new Point(6, 214);
            txtDNI.MaxLength = 8;
            txtDNI.MouseState = MaterialSkin.MouseState.OUT;
            txtDNI.Multiline = false;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(205, 50);
            txtDNI.TabIndex = 3;
            txtDNI.Text = "";
            txtDNI.TrailingIcon = null;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // txtTelefono
            // 
            txtTelefono.AnimateReadOnly = false;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefono.Hint = "Celular";
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(225, 145);
            txtTelefono.MaxLength = 10;
            txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefono.Multiline = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(246, 50);
            txtTelefono.TabIndex = 5;
            txtTelefono.Text = "";
            txtTelefono.TrailingIcon = null;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.AnimateReadOnly = false;
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Depth = 0;
            txtDireccion.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDireccion.Hint = "Direccion";
            txtDireccion.LeadingIcon = null;
            txtDireccion.Location = new Point(225, 79);
            txtDireccion.MaxLength = 50;
            txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            txtDireccion.Multiline = false;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(246, 50);
            txtDireccion.TabIndex = 4;
            txtDireccion.Text = "";
            txtDireccion.TrailingIcon = null;
            // 
            // checkPago
            // 
            checkPago.AutoSize = true;
            checkPago.Depth = 0;
            checkPago.Location = new Point(484, 158);
            checkPago.Margin = new Padding(0);
            checkPago.MouseLocation = new Point(-1, -1);
            checkPago.MouseState = MaterialSkin.MouseState.HOVER;
            checkPago.Name = "checkPago";
            checkPago.ReadOnly = false;
            checkPago.Ripple = true;
            checkPago.Size = new Size(147, 37);
            checkPago.TabIndex = 8;
            checkPago.Text = "Registrar abono";
            checkPago.UseVisualStyleBackColor = true;
            // 
            // btnConfirmaAlta
            // 
            btnConfirmaAlta.AutoSize = false;
            btnConfirmaAlta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmaAlta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfirmaAlta.Depth = 0;
            btnConfirmaAlta.HighEmphasis = true;
            btnConfirmaAlta.Icon = null;
            btnConfirmaAlta.Location = new Point(245, 391);
            btnConfirmaAlta.Margin = new Padding(4, 6, 4, 6);
            btnConfirmaAlta.MouseState = MaterialSkin.MouseState.HOVER;
            btnConfirmaAlta.Name = "btnConfirmaAlta";
            btnConfirmaAlta.NoAccentTextColor = Color.Empty;
            btnConfirmaAlta.Size = new Size(226, 36);
            btnConfirmaAlta.TabIndex = 9;
            btnConfirmaAlta.Text = "Dar de alta";
            btnConfirmaAlta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfirmaAlta.UseAccentColor = false;
            btnConfirmaAlta.UseVisualStyleBackColor = true;
            btnConfirmaAlta.Click += btnConfirmaAlta_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Depth = 0;
            lblFecha.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFecha.Location = new Point(6, 278);
            lblFecha.MouseState = MaterialSkin.MouseState.HOVER;
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(148, 19);
            lblFecha.TabIndex = 11;
            lblFecha.Text = "Fecha de nacimiento";
            // 
            // sltFechaNacimiento
            // 
            sltFechaNacimiento.CalendarMonthBackground = SystemColors.ScrollBar;
            sltFechaNacimiento.Format = DateTimePickerFormat.Short;
            sltFechaNacimiento.Location = new Point(6, 329);
            sltFechaNacimiento.MaxDate = new DateTime(2005, 12, 31, 0, 0, 0, 0);
            sltFechaNacimiento.MinDate = new DateTime(1920, 12, 31, 0, 0, 0, 0);
            sltFechaNacimiento.Name = "sltFechaNacimiento";
            sltFechaNacimiento.Size = new Size(200, 23);
            sltFechaNacimiento.TabIndex = 7;
            sltFechaNacimiento.Value = new DateTime(2005, 12, 31, 0, 0, 0, 0);
            sltFechaNacimiento.MouseEnter += sltFechaNacimiento_MouseEnter_1;
            // 
            // txtEdad
            // 
            txtEdad.AnimateReadOnly = false;
            txtEdad.BorderStyle = BorderStyle.None;
            txtEdad.Depth = 0;
            txtEdad.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEdad.LeadingIcon = null;
            txtEdad.Location = new Point(6, 391);
            txtEdad.MaxLength = 50;
            txtEdad.MouseState = MaterialSkin.MouseState.OUT;
            txtEdad.Multiline = false;
            txtEdad.Name = "txtEdad";
            txtEdad.ReadOnly = true;
            txtEdad.Size = new Size(121, 50);
            txtEdad.TabIndex = 10;
            txtEdad.Text = "";
            txtEdad.TrailingIcon = null;
            // 
            // btnVolver
            // 
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVolver.Depth = 0;
            btnVolver.HighEmphasis = true;
            btnVolver.Icon = null;
            btnVolver.Location = new Point(151, 391);
            btnVolver.Margin = new Padding(4, 6, 4, 6);
            btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            btnVolver.Name = "btnVolver";
            btnVolver.NoAccentTextColor = Color.Empty;
            btnVolver.Size = new Size(76, 36);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVolver.UseAccentColor = false;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 369);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(85, 19);
            materialLabel1.TabIndex = 14;
            materialLabel1.Text = "Edad actual";
            // 
            // txtMail
            // 
            txtMail.AnimateReadOnly = false;
            txtMail.BackgroundImageLayout = ImageLayout.None;
            txtMail.CharacterCasing = CharacterCasing.Normal;
            txtMail.Depth = 0;
            txtMail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMail.HelperText = "ejemplo@gmail.com";
            txtMail.HideSelection = true;
            txtMail.Hint = "Correo electronico";
            txtMail.LeadingIcon = null;
            txtMail.Location = new Point(225, 304);
            txtMail.MaxLength = 32767;
            txtMail.MouseState = MaterialSkin.MouseState.OUT;
            txtMail.Name = "txtMail";
            txtMail.PasswordChar = '\0';
            txtMail.PrefixSuffixText = null;
            txtMail.ReadOnly = false;
            txtMail.RightToLeft = RightToLeft.No;
            txtMail.SelectedText = "";
            txtMail.SelectionLength = 0;
            txtMail.SelectionStart = 0;
            txtMail.ShortcutsEnabled = true;
            txtMail.Size = new Size(246, 48);
            txtMail.TabIndex = 8;
            txtMail.TabStop = false;
            txtMail.TextAlign = HorizontalAlignment.Left;
            txtMail.TrailingIcon = null;
            txtMail.UseSystemPasswordChar = false;
            txtMail.KeyDown += txtMail_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.socioImagen;
            pictureBox1.Location = new Point(484, 229);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 215);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // MenuCargaSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtMail);
            Controls.Add(materialLabel1);
            Controls.Add(btnVolver);
            Controls.Add(sltFechaNacimiento);
            Controls.Add(lblFecha);
            Controls.Add(txtEdad);
            Controls.Add(btnConfirmaAlta);
            Controls.Add(checkPago);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(sltAbono);
            Controls.Add(sltGenero);
            Name = "MenuCargaSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso de socio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox sltGenero;
        private MaterialSkin.Controls.MaterialComboBox sltAbono;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtApellido;
        private MaterialSkin.Controls.MaterialTextBox txtDNI;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtDireccion;
        private MaterialSkin.Controls.MaterialCheckbox checkPago;
        private MaterialSkin.Controls.MaterialButton btnConfirmaAlta;
        private MaterialSkin.Controls.MaterialLabel lblFecha;
        private DateTimePicker sltFechaNacimiento;
        private MaterialSkin.Controls.MaterialTextBox txtEdad;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtMail;
        private PictureBox pictureBox1;
    }
}