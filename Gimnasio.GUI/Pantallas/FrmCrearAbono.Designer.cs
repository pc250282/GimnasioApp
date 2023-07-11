namespace Gimnasio.GUI.Pantallas
{
    partial class FrmCrearAbono
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
            txtNombreAbono = new MaterialSkin.Controls.MaterialTextBox();
            txtPorcentajeEstablecimiento = new MaterialSkin.Controls.MaterialTextBox();
            txtValorAbono = new MaterialSkin.Controls.MaterialTextBox();
            lblMuestraPorcentajeProfesor = new MaterialSkin.Controls.MaterialLabel();
            lblMuestraGanancia = new MaterialSkin.Controls.MaterialLabel();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
            txtPorcentajeProfesor = new MaterialSkin.Controls.MaterialTextBox2();
            SuspendLayout();
            // 
            // txtNombreAbono
            // 
            txtNombreAbono.AnimateReadOnly = false;
            txtNombreAbono.BorderStyle = BorderStyle.None;
            txtNombreAbono.Depth = 0;
            txtNombreAbono.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreAbono.Hint = "Nombre del Abono";
            txtNombreAbono.LeadingIcon = null;
            txtNombreAbono.Location = new Point(21, 108);
            txtNombreAbono.MaxLength = 50;
            txtNombreAbono.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreAbono.Multiline = false;
            txtNombreAbono.Name = "txtNombreAbono";
            txtNombreAbono.Size = new Size(241, 50);
            txtNombreAbono.TabIndex = 0;
            txtNombreAbono.Text = "";
            txtNombreAbono.TrailingIcon = null;
            // 
            // txtPorcentajeEstablecimiento
            // 
            txtPorcentajeEstablecimiento.AnimateReadOnly = false;
            txtPorcentajeEstablecimiento.BorderStyle = BorderStyle.None;
            txtPorcentajeEstablecimiento.Depth = 0;
            txtPorcentajeEstablecimiento.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPorcentajeEstablecimiento.Hint = "Porcentaje ganancia";
            txtPorcentajeEstablecimiento.LeadingIcon = null;
            txtPorcentajeEstablecimiento.Location = new Point(21, 180);
            txtPorcentajeEstablecimiento.MaxLength = 50;
            txtPorcentajeEstablecimiento.MouseState = MaterialSkin.MouseState.OUT;
            txtPorcentajeEstablecimiento.Multiline = false;
            txtPorcentajeEstablecimiento.Name = "txtPorcentajeEstablecimiento";
            txtPorcentajeEstablecimiento.Size = new Size(144, 50);
            txtPorcentajeEstablecimiento.TabIndex = 3;
            txtPorcentajeEstablecimiento.Text = "0";
            txtPorcentajeEstablecimiento.TrailingIcon = null;
            txtPorcentajeEstablecimiento.TextChanged += txtPorcentajeEstablecimiento_TextChanged;
            txtPorcentajeEstablecimiento.KeyPress += txtPorcentajeEstablecimiento_KeyPress;
            // 
            // txtValorAbono
            // 
            txtValorAbono.AnimateReadOnly = false;
            txtValorAbono.BorderStyle = BorderStyle.None;
            txtValorAbono.Depth = 0;
            txtValorAbono.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorAbono.Hint = "Valor del abono";
            txtValorAbono.LeadingIcon = null;
            txtValorAbono.Location = new Point(297, 107);
            txtValorAbono.MaxLength = 50;
            txtValorAbono.MouseState = MaterialSkin.MouseState.OUT;
            txtValorAbono.Multiline = false;
            txtValorAbono.Name = "txtValorAbono";
            txtValorAbono.Size = new Size(151, 50);
            txtValorAbono.TabIndex = 2;
            txtValorAbono.Text = "0";
            txtValorAbono.TrailingIcon = null;
            // 
            // lblMuestraPorcentajeProfesor
            // 
            lblMuestraPorcentajeProfesor.AutoSize = true;
            lblMuestraPorcentajeProfesor.Depth = 0;
            lblMuestraPorcentajeProfesor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMuestraPorcentajeProfesor.Location = new Point(21, 288);
            lblMuestraPorcentajeProfesor.MouseState = MaterialSkin.MouseState.HOVER;
            lblMuestraPorcentajeProfesor.Name = "lblMuestraPorcentajeProfesor";
            lblMuestraPorcentajeProfesor.Size = new Size(38, 19);
            lblMuestraPorcentajeProfesor.TabIndex = 4;
            lblMuestraPorcentajeProfesor.Text = "Valor";
            // 
            // lblMuestraGanancia
            // 
            lblMuestraGanancia.AutoSize = true;
            lblMuestraGanancia.Depth = 0;
            lblMuestraGanancia.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMuestraGanancia.Location = new Point(21, 251);
            lblMuestraGanancia.MouseState = MaterialSkin.MouseState.HOVER;
            lblMuestraGanancia.Name = "lblMuestraGanancia";
            lblMuestraGanancia.Size = new Size(38, 19);
            lblMuestraGanancia.TabIndex = 5;
            lblMuestraGanancia.Text = "Valor";
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.Location = new Point(297, 334);
            btnGuardar.Margin = new Padding(4, 6, 4, 6);
            btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(121, 36);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Crear abono";
            btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVolver.Depth = 0;
            btnVolver.HighEmphasis = true;
            btnVolver.Icon = null;
            btnVolver.Location = new Point(105, 334);
            btnVolver.Margin = new Padding(4, 6, 4, 6);
            btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            btnVolver.Name = "btnVolver";
            btnVolver.NoAccentTextColor = Color.Empty;
            btnVolver.Size = new Size(76, 36);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVolver.UseAccentColor = false;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtPorcentajeProfesor
            // 
            txtPorcentajeProfesor.AnimateReadOnly = false;
            txtPorcentajeProfesor.BackgroundImageLayout = ImageLayout.None;
            txtPorcentajeProfesor.CharacterCasing = CharacterCasing.Normal;
            txtPorcentajeProfesor.Depth = 0;
            txtPorcentajeProfesor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPorcentajeProfesor.HelperText = "Porcentaje profesor";
            txtPorcentajeProfesor.HideSelection = true;
            txtPorcentajeProfesor.LeadingIcon = null;
            txtPorcentajeProfesor.Location = new Point(253, 180);
            txtPorcentajeProfesor.MaxLength = 32767;
            txtPorcentajeProfesor.MouseState = MaterialSkin.MouseState.OUT;
            txtPorcentajeProfesor.Name = "txtPorcentajeProfesor";
            txtPorcentajeProfesor.PasswordChar = '\0';
            txtPorcentajeProfesor.PrefixSuffixText = null;
            txtPorcentajeProfesor.ReadOnly = true;
            txtPorcentajeProfesor.RightToLeft = RightToLeft.No;
            txtPorcentajeProfesor.SelectedText = "";
            txtPorcentajeProfesor.SelectionLength = 0;
            txtPorcentajeProfesor.SelectionStart = 0;
            txtPorcentajeProfesor.ShortcutsEnabled = true;
            txtPorcentajeProfesor.Size = new Size(195, 48);
            txtPorcentajeProfesor.TabIndex = 8;
            txtPorcentajeProfesor.TabStop = false;
            txtPorcentajeProfesor.TextAlign = HorizontalAlignment.Left;
            txtPorcentajeProfesor.TrailingIcon = null;
            txtPorcentajeProfesor.UseSystemPasswordChar = false;
            // 
            // FrmCrearAbono
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 460);
            Controls.Add(txtPorcentajeProfesor);
            Controls.Add(btnVolver);
            Controls.Add(btnGuardar);
            Controls.Add(lblMuestraGanancia);
            Controls.Add(lblMuestraPorcentajeProfesor);
            Controls.Add(txtValorAbono);
            Controls.Add(txtPorcentajeEstablecimiento);
            Controls.Add(txtNombreAbono);
            Name = "FrmCrearAbono";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Abono";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtNombreAbono;
        private MaterialSkin.Controls.MaterialTextBox txtPorcentajeEstablecimiento;
        private MaterialSkin.Controls.MaterialTextBox txtValorAbono;
        private MaterialSkin.Controls.MaterialLabel lblMuestraPorcentajeProfesor;
        private MaterialSkin.Controls.MaterialLabel lblMuestraGanancia;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialTextBox2 txtPorcentajeProfesor;
    }
}