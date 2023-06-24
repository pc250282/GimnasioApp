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
            txtNombreActividad = new MaterialSkin.Controls.MaterialTextBox2();
            txtHorario = new MaterialSkin.Controls.MaterialTextBox2();
            txtCupo = new MaterialSkin.Controls.MaterialTextBox2();
            seleccionAbono = new MaterialSkin.Controls.MaterialComboBox();
            txtCrearAbono = new MaterialSkin.Controls.MaterialButton();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
            sltAbono = new MaterialSkin.Controls.MaterialComboBox();
            btnCreaActividad = new MaterialSkin.Controls.MaterialButton();
            sltProfesor = new MaterialSkin.Controls.MaterialComboBox();
            lblAbonoActual = new MaterialSkin.Controls.MaterialLabel();
            lblProfesorActual = new MaterialSkin.Controls.MaterialLabel();
            lblValorActual = new MaterialSkin.Controls.MaterialLabel();
            lblDatos = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // txtNombreActividad
            // 
            txtNombreActividad.AnimateReadOnly = false;
            txtNombreActividad.BackgroundImageLayout = ImageLayout.None;
            txtNombreActividad.CharacterCasing = CharacterCasing.Normal;
            txtNombreActividad.Depth = 0;
            txtNombreActividad.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreActividad.HideSelection = true;
            txtNombreActividad.Hint = "Nombre de la actividad";
            txtNombreActividad.LeadingIcon = null;
            txtNombreActividad.Location = new Point(21, 96);
            txtNombreActividad.MaxLength = 32767;
            txtNombreActividad.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreActividad.Name = "txtNombreActividad";
            txtNombreActividad.PasswordChar = '\0';
            txtNombreActividad.PrefixSuffixText = null;
            txtNombreActividad.ReadOnly = false;
            txtNombreActividad.RightToLeft = RightToLeft.No;
            txtNombreActividad.SelectedText = "";
            txtNombreActividad.SelectionLength = 0;
            txtNombreActividad.SelectionStart = 0;
            txtNombreActividad.ShortcutsEnabled = true;
            txtNombreActividad.Size = new Size(250, 48);
            txtNombreActividad.TabIndex = 0;
            txtNombreActividad.TabStop = false;
            txtNombreActividad.TextAlign = HorizontalAlignment.Left;
            txtNombreActividad.TrailingIcon = null;
            txtNombreActividad.UseSystemPasswordChar = false;
            // 
            // txtHorario
            // 
            txtHorario.AnimateReadOnly = false;
            txtHorario.BackgroundImageLayout = ImageLayout.None;
            txtHorario.CharacterCasing = CharacterCasing.Normal;
            txtHorario.Depth = 0;
            txtHorario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHorario.HelperText = "Ej: L y Ma 19:30 a 21:30";
            txtHorario.HideSelection = true;
            txtHorario.Hint = "Horario de la actividad";
            txtHorario.LeadingIcon = null;
            txtHorario.Location = new Point(21, 169);
            txtHorario.MaxLength = 32767;
            txtHorario.MouseState = MaterialSkin.MouseState.OUT;
            txtHorario.Name = "txtHorario";
            txtHorario.PasswordChar = '\0';
            txtHorario.PrefixSuffixText = null;
            txtHorario.ReadOnly = false;
            txtHorario.RightToLeft = RightToLeft.No;
            txtHorario.SelectedText = "";
            txtHorario.SelectionLength = 0;
            txtHorario.SelectionStart = 0;
            txtHorario.ShortcutsEnabled = true;
            txtHorario.Size = new Size(250, 48);
            txtHorario.TabIndex = 1;
            txtHorario.TabStop = false;
            txtHorario.TextAlign = HorizontalAlignment.Left;
            txtHorario.TrailingIcon = null;
            txtHorario.UseSystemPasswordChar = false;
            // 
            // txtCupo
            // 
            txtCupo.AnimateReadOnly = false;
            txtCupo.BackgroundImageLayout = ImageLayout.None;
            txtCupo.CharacterCasing = CharacterCasing.Normal;
            txtCupo.Depth = 0;
            txtCupo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCupo.HideSelection = true;
            txtCupo.Hint = "Cupo de alumnos";
            txtCupo.LeadingIcon = null;
            txtCupo.Location = new Point(21, 250);
            txtCupo.MaxLength = 100;
            txtCupo.MouseState = MaterialSkin.MouseState.OUT;
            txtCupo.Name = "txtCupo";
            txtCupo.PasswordChar = '\0';
            txtCupo.PrefixSuffixText = null;
            txtCupo.ReadOnly = false;
            txtCupo.RightToLeft = RightToLeft.No;
            txtCupo.SelectedText = "";
            txtCupo.SelectionLength = 0;
            txtCupo.SelectionStart = 0;
            txtCupo.ShortcutsEnabled = true;
            txtCupo.Size = new Size(250, 48);
            txtCupo.TabIndex = 2;
            txtCupo.TabStop = false;
            txtCupo.TextAlign = HorizontalAlignment.Left;
            txtCupo.TrailingIcon = null;
            txtCupo.UseSystemPasswordChar = false;
            // 
            // seleccionAbono
            // 
            seleccionAbono.AutoResize = false;
            seleccionAbono.BackColor = Color.FromArgb(255, 255, 255);
            seleccionAbono.Depth = 0;
            seleccionAbono.DrawMode = DrawMode.OwnerDrawVariable;
            seleccionAbono.DropDownHeight = 174;
            seleccionAbono.DropDownStyle = ComboBoxStyle.DropDownList;
            seleccionAbono.DropDownWidth = 121;
            seleccionAbono.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            seleccionAbono.ForeColor = Color.FromArgb(222, 0, 0, 0);
            seleccionAbono.FormattingEnabled = true;
            seleccionAbono.Hint = "Seleccione abono";
            seleccionAbono.IntegralHeight = false;
            seleccionAbono.ItemHeight = 43;
            seleccionAbono.Location = new Point(301, 96);
            seleccionAbono.MaxDropDownItems = 4;
            seleccionAbono.MouseState = MaterialSkin.MouseState.OUT;
            seleccionAbono.Name = "seleccionAbono";
            seleccionAbono.Size = new Size(250, 49);
            seleccionAbono.StartIndex = 0;
            seleccionAbono.TabIndex = 1;
            // 
            // txtCrearAbono
            // 
            txtCrearAbono.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtCrearAbono.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            txtCrearAbono.Depth = 0;
            txtCrearAbono.HighEmphasis = true;
            txtCrearAbono.Icon = null;
            txtCrearAbono.Location = new Point(378, 343);
            txtCrearAbono.Margin = new Padding(4, 6, 4, 6);
            txtCrearAbono.MouseState = MaterialSkin.MouseState.HOVER;
            txtCrearAbono.Name = "txtCrearAbono";
            txtCrearAbono.NoAccentTextColor = Color.Empty;
            txtCrearAbono.Size = new Size(173, 36);
            txtCrearAbono.TabIndex = 4;
            txtCrearAbono.Text = "CREAR NUEVO ABONO";
            txtCrearAbono.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            txtCrearAbono.UseAccentColor = false;
            txtCrearAbono.UseVisualStyleBackColor = true;
            txtCrearAbono.Click += txtCrearAbono_Click;
            // 
            // btnVolver
            // 
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVolver.Depth = 0;
            btnVolver.HighEmphasis = true;
            btnVolver.Icon = null;
            btnVolver.Location = new Point(252, 343);
            btnVolver.Margin = new Padding(4, 6, 4, 6);
            btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            btnVolver.Name = "btnVolver";
            btnVolver.NoAccentTextColor = Color.Empty;
            btnVolver.Size = new Size(76, 36);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "VOLVER";
            btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVolver.UseAccentColor = false;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // sltAbono
            // 
            sltAbono.AutoResize = false;
            sltAbono.BackColor = Color.FromArgb(255, 255, 255);
            sltAbono.Cursor = Cursors.No;
            sltAbono.Depth = 0;
            sltAbono.DrawMode = DrawMode.OwnerDrawVariable;
            sltAbono.DropDownHeight = 45;
            sltAbono.DropDownStyle = ComboBoxStyle.DropDownList;
            sltAbono.DropDownWidth = 121;
            sltAbono.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sltAbono.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sltAbono.FormattingEnabled = true;
            sltAbono.Hint = "Valor $";
            sltAbono.IntegralHeight = false;
            sltAbono.ItemHeight = 43;
            sltAbono.Location = new Point(301, 169);
            sltAbono.MaxDropDownItems = 1;
            sltAbono.MouseState = MaterialSkin.MouseState.OUT;
            sltAbono.Name = "sltAbono";
            sltAbono.Size = new Size(250, 49);
            sltAbono.StartIndex = 0;
            sltAbono.TabIndex = 6;
            // 
            // btnCreaActividad
            // 
            btnCreaActividad.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCreaActividad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCreaActividad.Depth = 0;
            btnCreaActividad.HighEmphasis = true;
            btnCreaActividad.Icon = null;
            btnCreaActividad.Location = new Point(21, 343);
            btnCreaActividad.Margin = new Padding(4, 6, 4, 6);
            btnCreaActividad.MouseState = MaterialSkin.MouseState.HOVER;
            btnCreaActividad.Name = "btnCreaActividad";
            btnCreaActividad.NoAccentTextColor = Color.Empty;
            btnCreaActividad.Size = new Size(167, 36);
            btnCreaActividad.TabIndex = 7;
            btnCreaActividad.Text = "GUARDAR ACTIVIDAD";
            btnCreaActividad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCreaActividad.UseAccentColor = false;
            btnCreaActividad.UseVisualStyleBackColor = true;
            btnCreaActividad.Click += btnCreaActividad_Click;
            // 
            // sltProfesor
            // 
            sltProfesor.AutoResize = false;
            sltProfesor.BackColor = Color.FromArgb(255, 255, 255);
            sltProfesor.Depth = 0;
            sltProfesor.DrawMode = DrawMode.OwnerDrawVariable;
            sltProfesor.DropDownHeight = 174;
            sltProfesor.DropDownStyle = ComboBoxStyle.DropDownList;
            sltProfesor.DropDownWidth = 121;
            sltProfesor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sltProfesor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sltProfesor.FormattingEnabled = true;
            sltProfesor.Hint = "Seleccione Profesor";
            sltProfesor.IntegralHeight = false;
            sltProfesor.ItemHeight = 43;
            sltProfesor.Location = new Point(301, 249);
            sltProfesor.MaxDropDownItems = 4;
            sltProfesor.MouseState = MaterialSkin.MouseState.OUT;
            sltProfesor.Name = "sltProfesor";
            sltProfesor.Size = new Size(250, 49);
            sltProfesor.StartIndex = 0;
            sltProfesor.TabIndex = 8;
            // 
            // lblAbonoActual
            // 
            lblAbonoActual.AutoSize = true;
            lblAbonoActual.Depth = 0;
            lblAbonoActual.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblAbonoActual.Location = new Point(566, 125);
            lblAbonoActual.MouseState = MaterialSkin.MouseState.HOVER;
            lblAbonoActual.Name = "lblAbonoActual";
            lblAbonoActual.Size = new Size(109, 19);
            lblAbonoActual.TabIndex = 9;
            lblAbonoActual.Text = "lblAbonoActual";
            // 
            // lblProfesorActual
            // 
            lblProfesorActual.AutoSize = true;
            lblProfesorActual.Depth = 0;
            lblProfesorActual.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblProfesorActual.Location = new Point(566, 279);
            lblProfesorActual.MouseState = MaterialSkin.MouseState.HOVER;
            lblProfesorActual.Name = "lblProfesorActual";
            lblProfesorActual.Size = new Size(123, 19);
            lblProfesorActual.TabIndex = 10;
            lblProfesorActual.Text = "lblProfesorActual";
            // 
            // lblValorActual
            // 
            lblValorActual.AutoSize = true;
            lblValorActual.Depth = 0;
            lblValorActual.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblValorActual.Location = new Point(566, 198);
            lblValorActual.MouseState = MaterialSkin.MouseState.HOVER;
            lblValorActual.Name = "lblValorActual";
            lblValorActual.Size = new Size(100, 19);
            lblValorActual.TabIndex = 11;
            lblValorActual.Text = "lblValorActual";
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Depth = 0;
            lblDatos.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblDatos.Location = new Point(566, 74);
            lblDatos.MouseState = MaterialSkin.MouseState.HOVER;
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(122, 19);
            lblDatos.TabIndex = 12;
            lblDatos.Text = "Valores actuales:";
            // 
            // FrmActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDatos);
            Controls.Add(lblValorActual);
            Controls.Add(lblProfesorActual);
            Controls.Add(lblAbonoActual);
            Controls.Add(sltProfesor);
            Controls.Add(btnCreaActividad);
            Controls.Add(sltAbono);
            Controls.Add(btnVolver);
            Controls.Add(txtCrearAbono);
            Controls.Add(seleccionAbono);
            Controls.Add(txtCupo);
            Controls.Add(txtHorario);
            Controls.Add(txtNombreActividad);
            Name = "FrmActividades";
            Text = "Administrar actividades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtNombreActividad;
        private MaterialSkin.Controls.MaterialTextBox2 txtHorario;
        private MaterialSkin.Controls.MaterialTextBox2 txtCupo;
        private MaterialSkin.Controls.MaterialComboBox seleccionAbono;
        private MaterialSkin.Controls.MaterialButton txtCrearAbono;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialComboBox sltAbono;
        private MaterialSkin.Controls.MaterialButton btnCreaActividad;
        private MaterialSkin.Controls.MaterialComboBox sltProfesor;
        private MaterialSkin.Controls.MaterialLabel lblAbonoActual;
        private MaterialSkin.Controls.MaterialLabel lblProfesorActual;
        private MaterialSkin.Controls.MaterialLabel lblValorActual;
        private MaterialSkin.Controls.MaterialLabel lblDatos;
    }
}