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
            this.sltGenero = new MaterialSkin.Controls.MaterialComboBox();
            this.sltEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDNI = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.checkPago = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnConfirmaAlta = new MaterialSkin.Controls.MaterialButton();
            this.lblFecha = new MaterialSkin.Controls.MaterialLabel();
            this.sltFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtEdad = new MaterialSkin.Controls.MaterialTextBox();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // sltGenero
            // 
            this.sltGenero.AutoResize = false;
            this.sltGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sltGenero.Depth = 0;
            this.sltGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sltGenero.DropDownHeight = 174;
            this.sltGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltGenero.DropDownWidth = 121;
            this.sltGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sltGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sltGenero.FormattingEnabled = true;
            this.sltGenero.Hint = "Genero";
            this.sltGenero.IntegralHeight = false;
            this.sltGenero.ItemHeight = 43;
            this.sltGenero.Location = new System.Drawing.Point(271, 215);
            this.sltGenero.MaxDropDownItems = 4;
            this.sltGenero.MouseState = MaterialSkin.MouseState.OUT;
            this.sltGenero.Name = "sltGenero";
            this.sltGenero.Size = new System.Drawing.Size(205, 49);
            this.sltGenero.StartIndex = 0;
            this.sltGenero.TabIndex = 0;
            // 
            // sltEstado
            // 
            this.sltEstado.AutoResize = false;
            this.sltEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sltEstado.Depth = 0;
            this.sltEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sltEstado.DropDownHeight = 174;
            this.sltEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltEstado.DropDownWidth = 121;
            this.sltEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sltEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sltEstado.FormattingEnabled = true;
            this.sltEstado.Hint = "Estado del socio";
            this.sltEstado.IntegralHeight = false;
            this.sltEstado.ItemHeight = 43;
            this.sltEstado.Location = new System.Drawing.Point(271, 298);
            this.sltEstado.MaxDropDownItems = 4;
            this.sltEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.sltEstado.Name = "sltEstado";
            this.sltEstado.Size = new System.Drawing.Size(205, 49);
            this.sltEstado.StartIndex = 0;
            this.sltEstado.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(41, 79);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 50);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // txtApellido
            // 
            this.txtApellido.AnimateReadOnly = false;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Depth = 0;
            this.txtApellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellido.Hint = "Apellido";
            this.txtApellido.LeadingIcon = null;
            this.txtApellido.Location = new System.Drawing.Point(41, 145);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(205, 50);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.Text = "";
            this.txtApellido.TrailingIcon = null;
            // 
            // txtDNI
            // 
            this.txtDNI.AnimateReadOnly = false;
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNI.Depth = 0;
            this.txtDNI.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDNI.Hint = "N° Documento";
            this.txtDNI.LeadingIcon = null;
            this.txtDNI.Location = new System.Drawing.Point(41, 214);
            this.txtDNI.MaxLength = 50;
            this.txtDNI.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(205, 50);
            this.txtDNI.TabIndex = 4;
            this.txtDNI.Text = "";
            this.txtDNI.TrailingIcon = null;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.Hint = "Celular";
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(271, 145);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(205, 50);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.Text = "";
            this.txtTelefono.TrailingIcon = null;
            // 
            // txtDireccion
            // 
            this.txtDireccion.AnimateReadOnly = false;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion.Hint = "Direccion";
            this.txtDireccion.LeadingIcon = null;
            this.txtDireccion.Location = new System.Drawing.Point(271, 79);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(205, 50);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.Text = "";
            this.txtDireccion.TrailingIcon = null;
            // 
            // checkPago
            // 
            this.checkPago.AutoSize = true;
            this.checkPago.Depth = 0;
            this.checkPago.Location = new System.Drawing.Point(528, 102);
            this.checkPago.Margin = new System.Windows.Forms.Padding(0);
            this.checkPago.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkPago.Name = "checkPago";
            this.checkPago.ReadOnly = false;
            this.checkPago.Ripple = true;
            this.checkPago.Size = new System.Drawing.Size(137, 37);
            this.checkPago.TabIndex = 8;
            this.checkPago.Text = "Pago de cuota";
            this.checkPago.UseVisualStyleBackColor = true;
            // 
            // btnConfirmaAlta
            // 
            this.btnConfirmaAlta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmaAlta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirmaAlta.Depth = 0;
            this.btnConfirmaAlta.HighEmphasis = true;
            this.btnConfirmaAlta.Icon = null;
            this.btnConfirmaAlta.Location = new System.Drawing.Point(528, 215);
            this.btnConfirmaAlta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirmaAlta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmaAlta.Name = "btnConfirmaAlta";
            this.btnConfirmaAlta.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirmaAlta.Size = new System.Drawing.Size(111, 36);
            this.btnConfirmaAlta.TabIndex = 9;
            this.btnConfirmaAlta.Text = "Dar de alta";
            this.btnConfirmaAlta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirmaAlta.UseAccentColor = false;
            this.btnConfirmaAlta.UseVisualStyleBackColor = true;
            this.btnConfirmaAlta.Click += new System.EventHandler(this.btnConfirmaAlta_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Depth = 0;
            this.lblFecha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFecha.Location = new System.Drawing.Point(46, 298);
            this.lblFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(148, 19);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha de nacimiento";
            // 
            // sltFechaNacimiento
            // 
            this.sltFechaNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.sltFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sltFechaNacimiento.Location = new System.Drawing.Point(46, 324);
            this.sltFechaNacimiento.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.sltFechaNacimiento.MinDate = new System.DateTime(1920, 12, 31, 0, 0, 0, 0);
            this.sltFechaNacimiento.Name = "sltFechaNacimiento";
            this.sltFechaNacimiento.Size = new System.Drawing.Size(200, 23);
            this.sltFechaNacimiento.TabIndex = 12;
            this.sltFechaNacimiento.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.sltFechaNacimiento.MouseEnter += new System.EventHandler(this.sltFechaNacimiento_MouseEnter_1);
            // 
            // txtEdad
            // 
            this.txtEdad.AnimateReadOnly = false;
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdad.Depth = 0;
            this.txtEdad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEdad.LeadingIcon = null;
            this.txtEdad.Location = new System.Drawing.Point(46, 388);
            this.txtEdad.MaxLength = 50;
            this.txtEdad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEdad.Multiline = false;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(121, 50);
            this.txtEdad.TabIndex = 10;
            this.txtEdad.Text = "";
            this.txtEdad.TrailingIcon = null;
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVolver.Depth = 0;
            this.btnVolver.HighEmphasis = true;
            this.btnVolver.Icon = null;
            this.btnVolver.Location = new System.Drawing.Point(665, 388);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolver.Size = new System.Drawing.Size(76, 36);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolver.UseAccentColor = false;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(46, 366);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(37, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Edad";
            // 
            // MenuCargaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.sltFechaNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.btnConfirmaAlta);
            this.Controls.Add(this.checkPago);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.sltEstado);
            this.Controls.Add(this.sltGenero);
            this.Name = "MenuCargaSocio";
            this.Text = "Ingreso de socio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox sltGenero;
        private MaterialSkin.Controls.MaterialComboBox sltEstado;
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