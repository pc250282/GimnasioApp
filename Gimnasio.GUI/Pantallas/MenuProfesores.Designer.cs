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
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDNI = new MaterialSkin.Controls.MaterialTextBox();
            this.sltGenero = new MaterialSkin.Controls.MaterialComboBox();
            this.sltFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new MaterialSkin.Controls.MaterialLabel();
            this.sltActividad = new MaterialSkin.Controls.MaterialComboBox();
            this.btnRegistro = new MaterialSkin.Controls.MaterialButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.AnimateReadOnly = false;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Depth = 0;
            this.txtApellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellido.Hint = "Apellido";
            this.txtApellido.LeadingIcon = null;
            this.txtApellido.Location = new System.Drawing.Point(45, 149);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 50);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Text = "";
            this.txtApellido.TrailingIcon = null;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(45, 82);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 50);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.Hint = "Telefono";
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(269, 214);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 50);
            this.txtTelefono.TabIndex = 6;
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
            this.txtDireccion.Location = new System.Drawing.Point(269, 82);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(180, 50);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.Text = "";
            this.txtDireccion.TrailingIcon = null;
            // 
            // txtDNI
            // 
            this.txtDNI.AnimateReadOnly = false;
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNI.Depth = 0;
            this.txtDNI.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDNI.Hint = "N° Documento";
            this.txtDNI.LeadingIcon = null;
            this.txtDNI.Location = new System.Drawing.Point(45, 214);
            this.txtDNI.MaxLength = 50;
            this.txtDNI.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(180, 50);
            this.txtDNI.TabIndex = 3;
            this.txtDNI.Text = "";
            this.txtDNI.TrailingIcon = null;
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
            this.sltGenero.Location = new System.Drawing.Point(269, 148);
            this.sltGenero.MaxDropDownItems = 4;
            this.sltGenero.MouseState = MaterialSkin.MouseState.OUT;
            this.sltGenero.Name = "sltGenero";
            this.sltGenero.Size = new System.Drawing.Size(180, 49);
            this.sltGenero.StartIndex = 0;
            this.sltGenero.TabIndex = 5;
            // 
            // sltFechaNacimiento
            // 
            this.sltFechaNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.sltFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sltFechaNacimiento.Location = new System.Drawing.Point(45, 313);
            this.sltFechaNacimiento.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.sltFechaNacimiento.MinDate = new System.DateTime(1920, 12, 31, 0, 0, 0, 0);
            this.sltFechaNacimiento.Name = "sltFechaNacimiento";
            this.sltFechaNacimiento.Size = new System.Drawing.Size(200, 23);
            this.sltFechaNacimiento.TabIndex = 7;
            this.sltFechaNacimiento.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Depth = 0;
            this.lblFecha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFecha.Location = new System.Drawing.Point(45, 279);
            this.lblFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(148, 19);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha de nacimiento";
            // 
            // sltActividad
            // 
            this.sltActividad.AutoResize = false;
            this.sltActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sltActividad.Depth = 0;
            this.sltActividad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sltActividad.DropDownHeight = 174;
            this.sltActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltActividad.DropDownWidth = 121;
            this.sltActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sltActividad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sltActividad.FormattingEnabled = true;
            this.sltActividad.Hint = "Actividad";
            this.sltActividad.IntegralHeight = false;
            this.sltActividad.ItemHeight = 43;
            this.sltActividad.Location = new System.Drawing.Point(269, 287);
            this.sltActividad.MaxDropDownItems = 4;
            this.sltActividad.MouseState = MaterialSkin.MouseState.OUT;
            this.sltActividad.Name = "sltActividad";
            this.sltActividad.Size = new System.Drawing.Size(180, 49);
            this.sltActividad.StartIndex = 0;
            this.sltActividad.TabIndex = 8;
            // 
            // btnRegistro
            // 
            this.btnRegistro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistro.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistro.Depth = 0;
            this.btnRegistro.HighEmphasis = true;
            this.btnRegistro.Icon = null;
            this.btnRegistro.Location = new System.Drawing.Point(443, 405);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistro.Size = new System.Drawing.Size(99, 36);
            this.btnRegistro.TabIndex = 16;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistro.UseAccentColor = false;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVolver.Depth = 0;
            this.btnVolver.HighEmphasis = true;
            this.btnVolver.Icon = null;
            this.btnVolver.Location = new System.Drawing.Point(7, 405);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolver.Size = new System.Drawing.Size(76, 36);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolver.UseAccentColor = false;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // MenuProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.sltActividad);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.sltFechaNacimiento);
            this.Controls.Add(this.sltGenero);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Name = "MenuProfesores";
            this.Text = "Registro de profesor";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private MaterialSkin.Controls.MaterialComboBox sltActividad;
        private MaterialSkin.Controls.MaterialButton btnRegistro;
        private MaterialSkin.Controls.MaterialButton btnVolver;
    }
}