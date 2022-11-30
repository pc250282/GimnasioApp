namespace Gimnasio.GUI.Pantallas
{
    partial class FrmActividades
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
            this.txtNombreActividad = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtHorario = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCupo = new MaterialSkin.Controls.MaterialTextBox2();
            this.seleccionAbono = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCrearAbono = new MaterialSkin.Controls.MaterialButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtNombreActividad
            // 
            this.txtNombreActividad.AnimateReadOnly = false;
            this.txtNombreActividad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreActividad.Depth = 0;
            this.txtNombreActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreActividad.HideSelection = true;
            this.txtNombreActividad.Hint = "Nombre de la actividad";
            this.txtNombreActividad.LeadingIcon = null;
            this.txtNombreActividad.Location = new System.Drawing.Point(21, 96);
            this.txtNombreActividad.MaxLength = 32767;
            this.txtNombreActividad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreActividad.Name = "txtNombreActividad";
            this.txtNombreActividad.PasswordChar = '\0';
            this.txtNombreActividad.PrefixSuffixText = null;
            this.txtNombreActividad.ReadOnly = false;
            this.txtNombreActividad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreActividad.SelectedText = "";
            this.txtNombreActividad.SelectionLength = 0;
            this.txtNombreActividad.SelectionStart = 0;
            this.txtNombreActividad.ShortcutsEnabled = true;
            this.txtNombreActividad.Size = new System.Drawing.Size(250, 48);
            this.txtNombreActividad.TabIndex = 0;
            this.txtNombreActividad.TabStop = false;
            this.txtNombreActividad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreActividad.TrailingIcon = null;
            this.txtNombreActividad.UseSystemPasswordChar = false;
            // 
            // txtHorario
            // 
            this.txtHorario.AnimateReadOnly = false;
            this.txtHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtHorario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHorario.Depth = 0;
            this.txtHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHorario.HelperText = "Ej: L y Ma 19:30 a 21:30";
            this.txtHorario.HideSelection = true;
            this.txtHorario.Hint = "Horario de la actividad";
            this.txtHorario.LeadingIcon = null;
            this.txtHorario.Location = new System.Drawing.Point(21, 169);
            this.txtHorario.MaxLength = 32767;
            this.txtHorario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.PasswordChar = '\0';
            this.txtHorario.PrefixSuffixText = null;
            this.txtHorario.ReadOnly = false;
            this.txtHorario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHorario.SelectedText = "";
            this.txtHorario.SelectionLength = 0;
            this.txtHorario.SelectionStart = 0;
            this.txtHorario.ShortcutsEnabled = true;
            this.txtHorario.Size = new System.Drawing.Size(250, 48);
            this.txtHorario.TabIndex = 1;
            this.txtHorario.TabStop = false;
            this.txtHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHorario.TrailingIcon = null;
            this.txtHorario.UseSystemPasswordChar = false;
            // 
            // txtCupo
            // 
            this.txtCupo.AnimateReadOnly = false;
            this.txtCupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCupo.Depth = 0;
            this.txtCupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCupo.HideSelection = true;
            this.txtCupo.Hint = "Cupo de alumnos";
            this.txtCupo.LeadingIcon = null;
            this.txtCupo.Location = new System.Drawing.Point(21, 250);
            this.txtCupo.MaxLength = 32767;
            this.txtCupo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.PasswordChar = '\0';
            this.txtCupo.PrefixSuffixText = null;
            this.txtCupo.ReadOnly = false;
            this.txtCupo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCupo.SelectedText = "";
            this.txtCupo.SelectionLength = 0;
            this.txtCupo.SelectionStart = 0;
            this.txtCupo.ShortcutsEnabled = true;
            this.txtCupo.Size = new System.Drawing.Size(250, 48);
            this.txtCupo.TabIndex = 2;
            this.txtCupo.TabStop = false;
            this.txtCupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCupo.TrailingIcon = null;
            this.txtCupo.UseSystemPasswordChar = false;
            // 
            // seleccionAbono
            // 
            this.seleccionAbono.AutoResize = false;
            this.seleccionAbono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.seleccionAbono.Depth = 0;
            this.seleccionAbono.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.seleccionAbono.DropDownHeight = 174;
            this.seleccionAbono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionAbono.DropDownWidth = 121;
            this.seleccionAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.seleccionAbono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seleccionAbono.FormattingEnabled = true;
            this.seleccionAbono.Hint = "Seleccione abono";
            this.seleccionAbono.IntegralHeight = false;
            this.seleccionAbono.ItemHeight = 43;
            this.seleccionAbono.Location = new System.Drawing.Point(21, 330);
            this.seleccionAbono.MaxDropDownItems = 4;
            this.seleccionAbono.MouseState = MaterialSkin.MouseState.OUT;
            this.seleccionAbono.Name = "seleccionAbono";
            this.seleccionAbono.Size = new System.Drawing.Size(250, 49);
            this.seleccionAbono.StartIndex = 0;
            this.seleccionAbono.TabIndex = 1;
            // 
            // txtCrearAbono
            // 
            this.txtCrearAbono.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtCrearAbono.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.txtCrearAbono.Depth = 0;
            this.txtCrearAbono.HighEmphasis = true;
            this.txtCrearAbono.Icon = null;
            this.txtCrearAbono.Location = new System.Drawing.Point(316, 343);
            this.txtCrearAbono.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCrearAbono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCrearAbono.Name = "txtCrearAbono";
            this.txtCrearAbono.NoAccentTextColor = System.Drawing.Color.Empty;
            this.txtCrearAbono.Size = new System.Drawing.Size(173, 36);
            this.txtCrearAbono.TabIndex = 4;
            this.txtCrearAbono.Text = "CREAR NUEVO ABONO";
            this.txtCrearAbono.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.txtCrearAbono.UseAccentColor = false;
            this.txtCrearAbono.UseVisualStyleBackColor = true;
            this.txtCrearAbono.Click += new System.EventHandler(this.txtCrearAbono_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVolver.Depth = 0;
            this.btnVolver.HighEmphasis = true;
            this.btnVolver.Icon = null;
            this.btnVolver.Location = new System.Drawing.Point(577, 343);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolver.Size = new System.Drawing.Size(76, 36);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolver.UseAccentColor = false;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtCrearAbono);
            this.Controls.Add(this.seleccionAbono);
            this.Controls.Add(this.txtCupo);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtNombreActividad);
            this.Name = "FrmActividades";
            this.Text = "Administrar actividades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtNombreActividad;
        private MaterialSkin.Controls.MaterialTextBox2 txtHorario;
        private MaterialSkin.Controls.MaterialTextBox2 txtCupo;
        private MaterialSkin.Controls.MaterialComboBox seleccionAbono;
        private MaterialSkin.Controls.MaterialButton txtCrearAbono;
        private MaterialSkin.Controls.MaterialButton btnVolver;
    }
}