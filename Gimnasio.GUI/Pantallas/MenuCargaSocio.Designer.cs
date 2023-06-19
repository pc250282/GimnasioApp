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
            sltGenero.Location = new Point(271, 215);
            sltGenero.MaxDropDownItems = 4;
            sltGenero.MouseState = MaterialSkin.MouseState.OUT;
            sltGenero.Name = "sltGenero";
            sltGenero.Size = new Size(205, 49);
            sltGenero.StartIndex = 0;
            sltGenero.TabIndex = 0;
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
            sltAbono.Location = new Point(271, 298);
            sltAbono.MaxDropDownItems = 4;
            sltAbono.MouseState = MaterialSkin.MouseState.OUT;
            sltAbono.Name = "sltAbono";
            sltAbono.Size = new Size(205, 49);
            sltAbono.StartIndex = 0;
            sltAbono.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.Hint = "Nombre";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(41, 79);
            txtNombre.MaxLength = 50;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 50);
            txtNombre.TabIndex = 2;
            txtNombre.Text = "";
            txtNombre.TrailingIcon = null;
            // 
            // txtApellido
            // 
            txtApellido.AnimateReadOnly = false;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Depth = 0;
            txtApellido.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtApellido.Hint = "Apellido";
            txtApellido.LeadingIcon = null;
            txtApellido.Location = new Point(41, 145);
            txtApellido.MaxLength = 50;
            txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            txtApellido.Multiline = false;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(205, 50);
            txtApellido.TabIndex = 3;
            txtApellido.Text = "";
            txtApellido.TrailingIcon = null;
            // 
            // txtDNI
            // 
            txtDNI.AnimateReadOnly = false;
            txtDNI.BorderStyle = BorderStyle.None;
            txtDNI.Depth = 0;
            txtDNI.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDNI.Hint = "N° Documento";
            txtDNI.LeadingIcon = null;
            txtDNI.Location = new Point(41, 214);
            txtDNI.MaxLength = 50;
            txtDNI.MouseState = MaterialSkin.MouseState.OUT;
            txtDNI.Multiline = false;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(205, 50);
            txtDNI.TabIndex = 4;
            txtDNI.Text = "";
            txtDNI.TrailingIcon = null;
            // 
            // txtTelefono
            // 
            txtTelefono.AnimateReadOnly = false;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefono.Hint = "Celular";
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(271, 145);
            txtTelefono.MaxLength = 50;
            txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefono.Multiline = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(205, 50);
            txtTelefono.TabIndex = 5;
            txtTelefono.Text = "";
            txtTelefono.TrailingIcon = null;
            // 
            // txtDireccion
            // 
            txtDireccion.AnimateReadOnly = false;
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Depth = 0;
            txtDireccion.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDireccion.Hint = "Direccion";
            txtDireccion.LeadingIcon = null;
            txtDireccion.Location = new Point(271, 79);
            txtDireccion.MaxLength = 50;
            txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            txtDireccion.Multiline = false;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(205, 50);
            txtDireccion.TabIndex = 6;
            txtDireccion.Text = "";
            txtDireccion.TrailingIcon = null;
            // 
            // checkPago
            // 
            checkPago.AutoSize = true;
            checkPago.Depth = 0;
            checkPago.Location = new Point(528, 102);
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
            btnConfirmaAlta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmaAlta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfirmaAlta.Depth = 0;
            btnConfirmaAlta.HighEmphasis = true;
            btnConfirmaAlta.Icon = null;
            btnConfirmaAlta.Location = new Point(528, 215);
            btnConfirmaAlta.Margin = new Padding(4, 6, 4, 6);
            btnConfirmaAlta.MouseState = MaterialSkin.MouseState.HOVER;
            btnConfirmaAlta.Name = "btnConfirmaAlta";
            btnConfirmaAlta.NoAccentTextColor = Color.Empty;
            btnConfirmaAlta.Size = new Size(111, 36);
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
            lblFecha.Location = new Point(46, 298);
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
            sltFechaNacimiento.Location = new Point(46, 324);
            sltFechaNacimiento.MaxDate = new DateTime(2005, 12, 31, 0, 0, 0, 0);
            sltFechaNacimiento.MinDate = new DateTime(1920, 12, 31, 0, 0, 0, 0);
            sltFechaNacimiento.Name = "sltFechaNacimiento";
            sltFechaNacimiento.Size = new Size(200, 23);
            sltFechaNacimiento.TabIndex = 12;
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
            txtEdad.Location = new Point(46, 388);
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
            btnVolver.Location = new Point(665, 388);
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
            materialLabel1.Location = new Point(46, 366);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(37, 19);
            materialLabel1.TabIndex = 14;
            materialLabel1.Text = "Edad";
            // 
            // MenuCargaSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Text = "Ingreso de socio";
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
    }
}