namespace Gimnasio.GUI
{
    partial class MenuProfesores
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
            txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            txtDNI = new MaterialSkin.Controls.MaterialTextBox();
            sltGenero = new MaterialSkin.Controls.MaterialComboBox();
            sltFechaNacimiento = new DateTimePicker();
            lblFecha = new MaterialSkin.Controls.MaterialLabel();
            btnRegistro = new MaterialSkin.Controls.MaterialButton();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
            txtMail = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // txtApellido
            // 
            txtApellido.AnimateReadOnly = false;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Depth = 0;
            txtApellido.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtApellido.Hint = "Apellido";
            txtApellido.LeadingIcon = null;
            txtApellido.Location = new Point(13, 149);
            txtApellido.MaxLength = 25;
            txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            txtApellido.Multiline = false;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(232, 50);
            txtApellido.TabIndex = 3;
            txtApellido.Text = "";
            txtApellido.TrailingIcon = null;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.Hint = "Nombre";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(13, 82);
            txtNombre.MaxLength = 25;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 50);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "";
            txtNombre.TrailingIcon = null;
            // 
            // txtTelefono
            // 
            txtTelefono.AnimateReadOnly = false;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefono.Hint = "Telefono";
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(228, 214);
            txtTelefono.MaxLength = 10;
            txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefono.Multiline = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(180, 50);
            txtTelefono.TabIndex = 6;
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
            txtDireccion.Location = new Point(264, 149);
            txtDireccion.MaxLength = 50;
            txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            txtDireccion.Multiline = false;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(264, 50);
            txtDireccion.TabIndex = 4;
            txtDireccion.Text = "";
            txtDireccion.TrailingIcon = null;
            // 
            // txtDNI
            // 
            txtDNI.AnimateReadOnly = false;
            txtDNI.BorderStyle = BorderStyle.None;
            txtDNI.Depth = 0;
            txtDNI.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDNI.Hint = "N° Documento";
            txtDNI.LeadingIcon = null;
            txtDNI.Location = new Point(13, 214);
            txtDNI.MaxLength = 8;
            txtDNI.MouseState = MaterialSkin.MouseState.OUT;
            txtDNI.Multiline = false;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(180, 50);
            txtDNI.TabIndex = 5;
            txtDNI.Text = "";
            txtDNI.TrailingIcon = null;
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
            sltGenero.Location = new Point(435, 214);
            sltGenero.MaxDropDownItems = 4;
            sltGenero.MouseState = MaterialSkin.MouseState.OUT;
            sltGenero.Name = "sltGenero";
            sltGenero.Size = new Size(180, 49);
            sltGenero.StartIndex = 0;
            sltGenero.TabIndex = 7;
            // 
            // sltFechaNacimiento
            // 
            sltFechaNacimiento.CalendarMonthBackground = SystemColors.ScrollBar;
            sltFechaNacimiento.Format = DateTimePickerFormat.Short;
            sltFechaNacimiento.Location = new Point(13, 313);
            sltFechaNacimiento.MaxDate = new DateTime(2005, 12, 31, 0, 0, 0, 0);
            sltFechaNacimiento.MinDate = new DateTime(1920, 12, 31, 0, 0, 0, 0);
            sltFechaNacimiento.Name = "sltFechaNacimiento";
            sltFechaNacimiento.Size = new Size(200, 23);
            sltFechaNacimiento.TabIndex = 7;
            sltFechaNacimiento.Value = new DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Depth = 0;
            lblFecha.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFecha.Location = new Point(13, 278);
            lblFecha.MouseState = MaterialSkin.MouseState.HOVER;
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(148, 19);
            lblFecha.TabIndex = 14;
            lblFecha.Text = "Fecha de nacimiento";
            // 
            // btnRegistro
            // 
            btnRegistro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegistro.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegistro.Depth = 0;
            btnRegistro.HighEmphasis = true;
            btnRegistro.Icon = null;
            btnRegistro.Location = new Point(465, 405);
            btnRegistro.Margin = new Padding(4, 6, 4, 6);
            btnRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegistro.Name = "btnRegistro";
            btnRegistro.NoAccentTextColor = Color.Empty;
            btnRegistro.Size = new Size(99, 36);
            btnRegistro.TabIndex = 16;
            btnRegistro.Text = "Registrar";
            btnRegistro.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegistro.UseAccentColor = false;
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnVolver
            // 
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVolver.Depth = 0;
            btnVolver.HighEmphasis = true;
            btnVolver.Icon = null;
            btnVolver.Location = new Point(7, 405);
            btnVolver.Margin = new Padding(4, 6, 4, 6);
            btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            btnVolver.Name = "btnVolver";
            btnVolver.NoAccentTextColor = Color.Empty;
            btnVolver.Size = new Size(76, 36);
            btnVolver.TabIndex = 17;
            btnVolver.Text = "Volver";
            btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVolver.UseAccentColor = false;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtMail
            // 
            txtMail.AnimateReadOnly = false;
            txtMail.BorderStyle = BorderStyle.None;
            txtMail.Depth = 0;
            txtMail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMail.Hint = "Correo electronico";
            txtMail.LeadingIcon = null;
            txtMail.Location = new Point(264, 82);
            txtMail.MaxLength = 25;
            txtMail.MouseState = MaterialSkin.MouseState.OUT;
            txtMail.Multiline = false;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(264, 50);
            txtMail.TabIndex = 2;
            txtMail.Text = "";
            txtMail.TrailingIcon = null;
            // 
            // MenuProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 450);
            Controls.Add(txtMail);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistro);
            Controls.Add(lblFecha);
            Controls.Add(sltFechaNacimiento);
            Controls.Add(sltGenero);
            Controls.Add(txtDNI);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Name = "MenuProfesores";
            Text = "Registro de profesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtApellido;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtDireccion;
        private MaterialSkin.Controls.MaterialTextBox txtDNI;
        private MaterialSkin.Controls.MaterialComboBox sltGenero;
        private DateTimePicker sltFechaNacimiento;
        private MaterialSkin.Controls.MaterialLabel lblFecha;
        private MaterialSkin.Controls.MaterialButton btnRegistro;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialTextBox txtMail;
    }
}