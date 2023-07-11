namespace Gimnasio.GUI.Pantallas
{
    partial class FrmAsignarMembresiaSocios
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
            lblNumSocio = new MaterialSkin.Controls.MaterialLabel();
            lblNombre = new MaterialSkin.Controls.MaterialLabel();
            lblEstado = new MaterialSkin.Controls.MaterialLabel();
            lblApellido = new MaterialSkin.Controls.MaterialLabel();
            sltAbono = new MaterialSkin.Controls.MaterialComboBox();
            sltValorAbono = new MaterialSkin.Controls.MaterialComboBox();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
            btnConfirmar = new MaterialSkin.Controls.MaterialButton();
            lblAbonoActual = new MaterialSkin.Controls.MaterialLabel();
            lblDiasDeAbonoPendiente = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // lblNumSocio
            // 
            lblNumSocio.AutoSize = true;
            lblNumSocio.Depth = 0;
            lblNumSocio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNumSocio.Location = new Point(45, 178);
            lblNumSocio.MouseState = MaterialSkin.MouseState.HOVER;
            lblNumSocio.Name = "lblNumSocio";
            lblNumSocio.Size = new Size(92, 19);
            lblNumSocio.TabIndex = 0;
            lblNumSocio.Text = "lblNumSocio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Depth = 0;
            lblNombre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNombre.Location = new Point(45, 86);
            lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(74, 19);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "lblNombre";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Depth = 0;
            lblEstado.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEstado.Location = new Point(245, 86);
            lblEstado.MouseState = MaterialSkin.MouseState.HOVER;
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(67, 19);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "lblEstado";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Depth = 0;
            lblApellido.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblApellido.Location = new Point(45, 133);
            lblApellido.MouseState = MaterialSkin.MouseState.HOVER;
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(75, 19);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "lblApellido";
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
            sltAbono.Location = new Point(35, 223);
            sltAbono.MaxDropDownItems = 4;
            sltAbono.MouseState = MaterialSkin.MouseState.OUT;
            sltAbono.Name = "sltAbono";
            sltAbono.Size = new Size(403, 49);
            sltAbono.StartIndex = 0;
            sltAbono.TabIndex = 4;
            // 
            // sltValorAbono
            // 
            sltValorAbono.AutoResize = false;
            sltValorAbono.BackColor = Color.FromArgb(255, 255, 255);
            sltValorAbono.Cursor = Cursors.No;
            sltValorAbono.Depth = 0;
            sltValorAbono.DrawMode = DrawMode.OwnerDrawVariable;
            sltValorAbono.DropDownHeight = 45;
            sltValorAbono.DropDownStyle = ComboBoxStyle.DropDownList;
            sltValorAbono.DropDownWidth = 121;
            sltValorAbono.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sltValorAbono.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sltValorAbono.FormattingEnabled = true;
            sltValorAbono.Hint = "Valor $";
            sltValorAbono.IntegralHeight = false;
            sltValorAbono.ItemHeight = 43;
            sltValorAbono.Location = new Point(35, 290);
            sltValorAbono.MaxDropDownItems = 1;
            sltValorAbono.MouseState = MaterialSkin.MouseState.OUT;
            sltValorAbono.Name = "sltValorAbono";
            sltValorAbono.Size = new Size(195, 49);
            sltValorAbono.StartIndex = 0;
            sltValorAbono.TabIndex = 7;
            // 
            // btnVolver
            // 
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVolver.Depth = 0;
            btnVolver.HighEmphasis = true;
            btnVolver.Icon = null;
            btnVolver.Location = new Point(78, 384);
            btnVolver.Margin = new Padding(4, 6, 4, 6);
            btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            btnVolver.Name = "btnVolver";
            btnVolver.NoAccentTextColor = Color.Empty;
            btnVolver.Size = new Size(76, 36);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "VOLVER";
            btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVolver.UseAccentColor = false;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfirmar.Depth = 0;
            btnConfirmar.HighEmphasis = true;
            btnConfirmar.Icon = null;
            btnConfirmar.Location = new Point(463, 384);
            btnConfirmar.Margin = new Padding(4, 6, 4, 6);
            btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.NoAccentTextColor = Color.Empty;
            btnConfirmar.Size = new Size(105, 36);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "CONFIRMAR ";
            btnConfirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfirmar.UseAccentColor = false;
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblAbonoActual
            // 
            lblAbonoActual.AutoSize = true;
            lblAbonoActual.Depth = 0;
            lblAbonoActual.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblAbonoActual.Location = new Point(245, 133);
            lblAbonoActual.MouseState = MaterialSkin.MouseState.HOVER;
            lblAbonoActual.Name = "lblAbonoActual";
            lblAbonoActual.Size = new Size(109, 19);
            lblAbonoActual.TabIndex = 10;
            lblAbonoActual.Text = "lblAbonoActual";
            // 
            // lblDiasDeAbonoPendiente
            // 
            lblDiasDeAbonoPendiente.AutoSize = true;
            lblDiasDeAbonoPendiente.Depth = 0;
            lblDiasDeAbonoPendiente.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDiasDeAbonoPendiente.Location = new Point(245, 178);
            lblDiasDeAbonoPendiente.MouseState = MaterialSkin.MouseState.HOVER;
            lblDiasDeAbonoPendiente.Name = "lblDiasDeAbonoPendiente";
            lblDiasDeAbonoPendiente.Size = new Size(185, 19);
            lblDiasDeAbonoPendiente.TabIndex = 11;
            lblDiasDeAbonoPendiente.Text = "lblDiasDeAbonoPendiente";
            // 
            // FrmAsignarMembresiaSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 514);
            Controls.Add(lblDiasDeAbonoPendiente);
            Controls.Add(lblAbonoActual);
            Controls.Add(btnConfirmar);
            Controls.Add(btnVolver);
            Controls.Add(sltValorAbono);
            Controls.Add(sltAbono);
            Controls.Add(lblApellido);
            Controls.Add(lblEstado);
            Controls.Add(lblNombre);
            Controls.Add(lblNumSocio);
            Name = "FrmAsignarMembresiaSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asignacion de abono";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblNumSocio;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblEstado;
        private MaterialSkin.Controls.MaterialLabel lblApellido;
        private MaterialSkin.Controls.MaterialComboBox sltAbono;
        private MaterialSkin.Controls.MaterialComboBox sltValorAbono;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialButton btnConfirmar;
        private MaterialSkin.Controls.MaterialLabel lblAbonoActual;
        private MaterialSkin.Controls.MaterialLabel lblDiasDeAbonoPendiente;
    }
}