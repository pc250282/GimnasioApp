namespace Gimnasio.GUI.Pantallas
{
    partial class FrmMembresiasEstablecimiento
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
            txtNombreMembresia = new MaterialSkin.Controls.MaterialTextBox();
            txtValor = new MaterialSkin.Controls.MaterialTextBox();
            sltTipoIva = new MaterialSkin.Controls.MaterialComboBox();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
            btnCrear = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtNombreMembresia
            // 
            txtNombreMembresia.AnimateReadOnly = false;
            txtNombreMembresia.BorderStyle = BorderStyle.None;
            txtNombreMembresia.Depth = 0;
            txtNombreMembresia.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreMembresia.Hint = "Nombre";
            txtNombreMembresia.LeadingIcon = null;
            txtNombreMembresia.Location = new Point(40, 101);
            txtNombreMembresia.MaxLength = 50;
            txtNombreMembresia.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreMembresia.Multiline = false;
            txtNombreMembresia.Name = "txtNombreMembresia";
            txtNombreMembresia.Size = new Size(271, 50);
            txtNombreMembresia.TabIndex = 2;
            txtNombreMembresia.Text = "";
            txtNombreMembresia.TrailingIcon = null;
            // 
            // txtValor
            // 
            txtValor.AnimateReadOnly = false;
            txtValor.BorderStyle = BorderStyle.None;
            txtValor.Depth = 0;
            txtValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValor.Hint = "Valor neto";
            txtValor.LeadingIcon = null;
            txtValor.Location = new Point(40, 187);
            txtValor.MaxLength = 50;
            txtValor.MouseState = MaterialSkin.MouseState.OUT;
            txtValor.Multiline = false;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(192, 50);
            txtValor.TabIndex = 3;
            txtValor.Text = "";
            txtValor.TrailingIcon = null;
            // 
            // sltTipoIva
            // 
            sltTipoIva.AutoResize = false;
            sltTipoIva.BackColor = Color.FromArgb(255, 255, 255);
            sltTipoIva.Depth = 0;
            sltTipoIva.DrawMode = DrawMode.OwnerDrawVariable;
            sltTipoIva.DropDownHeight = 174;
            sltTipoIva.DropDownStyle = ComboBoxStyle.DropDownList;
            sltTipoIva.DropDownWidth = 121;
            sltTipoIva.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sltTipoIva.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sltTipoIva.FormattingEnabled = true;
            sltTipoIva.Hint = "% IVA";
            sltTipoIva.IntegralHeight = false;
            sltTipoIva.ItemHeight = 43;
            sltTipoIva.Location = new Point(40, 273);
            sltTipoIva.MaxDropDownItems = 4;
            sltTipoIva.MouseState = MaterialSkin.MouseState.OUT;
            sltTipoIva.Name = "sltTipoIva";
            sltTipoIva.Size = new Size(192, 49);
            sltTipoIva.StartIndex = 0;
            sltTipoIva.TabIndex = 4;
            // 
            // btnVolver
            // 
            btnVolver.AutoSize = false;
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVolver.Depth = 0;
            btnVolver.HighEmphasis = true;
            btnVolver.Icon = null;
            btnVolver.Location = new Point(236, 357);
            btnVolver.Margin = new Padding(4, 6, 4, 6);
            btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            btnVolver.Name = "btnVolver";
            btnVolver.NoAccentTextColor = Color.Empty;
            btnVolver.Size = new Size(75, 36);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "VOLVER";
            btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVolver.UseAccentColor = false;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCrear
            // 
            btnCrear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCrear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCrear.Depth = 0;
            btnCrear.HighEmphasis = true;
            btnCrear.Icon = null;
            btnCrear.Location = new Point(40, 357);
            btnCrear.Margin = new Padding(4, 6, 4, 6);
            btnCrear.MouseState = MaterialSkin.MouseState.HOVER;
            btnCrear.Name = "btnCrear";
            btnCrear.NoAccentTextColor = Color.Empty;
            btnCrear.Size = new Size(88, 36);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "GUARDAR";
            btnCrear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCrear.UseAccentColor = false;
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // FrmMembresiasEstablecimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 450);
            Controls.Add(btnCrear);
            Controls.Add(btnVolver);
            Controls.Add(sltTipoIva);
            Controls.Add(txtValor);
            Controls.Add(txtNombreMembresia);
            Name = "FrmMembresiasEstablecimiento";
            Text = "Crear Membresia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtNombreMembresia;
        private MaterialSkin.Controls.MaterialTextBox txtValor;
        private MaterialSkin.Controls.MaterialComboBox sltTipoIva;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialButton btnCrear;
    }
}