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
            tabPage2 = new TabPage();
            btnEditar = new MaterialSkin.Controls.MaterialButton();
            btnEliminar = new MaterialSkin.Controls.MaterialButton();
            groupBox1 = new GroupBox();
            lblImp = new Label();
            lblValorTotal = new Label();
            lblNombre = new Label();
            btnBuscar = new MaterialSkin.Controls.MaterialButton();
            txtIdAbono = new MaterialSkin.Controls.MaterialTextBox2();
            tabPage1 = new TabPage();
            txtNombreMembresia = new MaterialSkin.Controls.MaterialTextBox();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
            btnCrear = new MaterialSkin.Controls.MaterialButton();
            txtValor = new MaterialSkin.Controls.MaterialTextBox();
            gpDatos = new GroupBox();
            lblIVA = new Label();
            lblValorFinal = new Label();
            lblNombreMembresia = new Label();
            sltTipoIva = new MaterialSkin.Controls.MaterialComboBox();
            tabControl1 = new TabControl();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage1.SuspendLayout();
            gpDatos.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnEditar);
            tabPage2.Controls.Add(btnEliminar);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(btnBuscar);
            tabPage2.Controls.Add(txtIdAbono);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(677, 372);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar abono";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.AutoSize = false;
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.Location = new Point(167, 303);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(121, 36);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Visible = false;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSize = false;
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminar.Depth = 0;
            btnEliminar.HighEmphasis = true;
            btnEliminar.Icon = null;
            btnEliminar.Location = new Point(18, 303);
            btnEliminar.Margin = new Padding(4, 6, 4, 6);
            btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.NoAccentTextColor = Color.Empty;
            btnEliminar.Size = new Size(121, 36);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminar.UseAccentColor = false;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Visible = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.fondoMembresia;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(lblImp);
            groupBox1.Controls.Add(lblValorTotal);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Location = new Point(318, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 345);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // lblImp
            // 
            lblImp.AutoSize = true;
            lblImp.Location = new Point(72, 149);
            lblImp.Name = "lblImp";
            lblImp.Size = new Size(43, 15);
            lblImp.TabIndex = 2;
            lblImp.Text = "............";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Location = new Point(72, 179);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(31, 15);
            lblValorTotal.TabIndex = 1;
            lblValorTotal.Text = "........";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(72, 116);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(43, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "............";
            // 
            // btnBuscar
            // 
            btnBuscar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBuscar.Depth = 0;
            btnBuscar.HighEmphasis = true;
            btnBuscar.Icon = null;
            btnBuscar.Location = new Point(18, 189);
            btnBuscar.Margin = new Padding(4, 6, 4, 6);
            btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscar.Name = "btnBuscar";
            btnBuscar.NoAccentTextColor = Color.Empty;
            btnBuscar.Size = new Size(77, 36);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBuscar.UseAccentColor = false;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += materialButton1_Click;
            // 
            // txtIdAbono
            // 
            txtIdAbono.AnimateReadOnly = false;
            txtIdAbono.BackgroundImageLayout = ImageLayout.None;
            txtIdAbono.CharacterCasing = CharacterCasing.Normal;
            txtIdAbono.Depth = 0;
            txtIdAbono.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIdAbono.HideSelection = true;
            txtIdAbono.Hint = "N° de membresia";
            txtIdAbono.LeadingIcon = null;
            txtIdAbono.Location = new Point(18, 89);
            txtIdAbono.MaxLength = 32767;
            txtIdAbono.MouseState = MaterialSkin.MouseState.OUT;
            txtIdAbono.Name = "txtIdAbono";
            txtIdAbono.PasswordChar = '\0';
            txtIdAbono.PrefixSuffixText = null;
            txtIdAbono.ReadOnly = false;
            txtIdAbono.RightToLeft = RightToLeft.No;
            txtIdAbono.SelectedText = "";
            txtIdAbono.SelectionLength = 0;
            txtIdAbono.SelectionStart = 0;
            txtIdAbono.ShortcutsEnabled = true;
            txtIdAbono.Size = new Size(158, 48);
            txtIdAbono.TabIndex = 9;
            txtIdAbono.TabStop = false;
            txtIdAbono.TextAlign = HorizontalAlignment.Left;
            txtIdAbono.TrailingIcon = null;
            txtIdAbono.UseSystemPasswordChar = false;
            txtIdAbono.KeyPress += txtIdAbono_KeyPress;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtNombreMembresia);
            tabPage1.Controls.Add(btnVolver);
            tabPage1.Controls.Add(btnCrear);
            tabPage1.Controls.Add(txtValor);
            tabPage1.Controls.Add(gpDatos);
            tabPage1.Controls.Add(sltTipoIva);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(677, 372);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Nueva abono";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtNombreMembresia
            // 
            txtNombreMembresia.AnimateReadOnly = false;
            txtNombreMembresia.BorderStyle = BorderStyle.None;
            txtNombreMembresia.Depth = 0;
            txtNombreMembresia.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreMembresia.Hint = "Nombre";
            txtNombreMembresia.LeadingIcon = null;
            txtNombreMembresia.Location = new Point(8, 19);
            txtNombreMembresia.MaxLength = 50;
            txtNombreMembresia.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreMembresia.Multiline = false;
            txtNombreMembresia.Name = "txtNombreMembresia";
            txtNombreMembresia.Size = new Size(271, 50);
            txtNombreMembresia.TabIndex = 2;
            txtNombreMembresia.Text = "";
            txtNombreMembresia.TrailingIcon = null;
            // 
            // btnVolver
            // 
            btnVolver.AutoSize = false;
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVolver.Depth = 0;
            btnVolver.HighEmphasis = true;
            btnVolver.Icon = null;
            btnVolver.Location = new Point(213, 289);
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
            btnCrear.Location = new Point(18, 289);
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
            // txtValor
            // 
            txtValor.AnimateReadOnly = false;
            txtValor.BorderStyle = BorderStyle.None;
            txtValor.Depth = 0;
            txtValor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValor.Hint = "Valor neto";
            txtValor.LeadingIcon = null;
            txtValor.Location = new Point(8, 100);
            txtValor.MaxLength = 50;
            txtValor.MouseState = MaterialSkin.MouseState.OUT;
            txtValor.Multiline = false;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(192, 50);
            txtValor.TabIndex = 3;
            txtValor.Text = "";
            txtValor.TrailingIcon = null;
            txtValor.SelectionChanged += txtValor_SelectionChanged;
            // 
            // gpDatos
            // 
            gpDatos.BackgroundImage = Properties.Resources.fondoMembresia;
            gpDatos.BackgroundImageLayout = ImageLayout.Stretch;
            gpDatos.Controls.Add(lblIVA);
            gpDatos.Controls.Add(lblValorFinal);
            gpDatos.Controls.Add(lblNombreMembresia);
            gpDatos.Location = new Point(339, 19);
            gpDatos.Name = "gpDatos";
            gpDatos.Size = new Size(332, 345);
            gpDatos.TabIndex = 7;
            gpDatos.TabStop = false;
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Location = new Point(72, 149);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(43, 15);
            lblIVA.TabIndex = 2;
            lblIVA.Text = "............";
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Location = new Point(72, 179);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(31, 15);
            lblValorFinal.TabIndex = 1;
            lblValorFinal.Text = "........";
            // 
            // lblNombreMembresia
            // 
            lblNombreMembresia.AutoSize = true;
            lblNombreMembresia.Location = new Point(72, 116);
            lblNombreMembresia.Name = "lblNombreMembresia";
            lblNombreMembresia.Size = new Size(43, 15);
            lblNombreMembresia.TabIndex = 0;
            lblNombreMembresia.Text = "............";
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
            sltTipoIva.Location = new Point(6, 193);
            sltTipoIva.MaxDropDownItems = 4;
            sltTipoIva.MouseState = MaterialSkin.MouseState.OUT;
            sltTipoIva.Name = "sltTipoIva";
            sltTipoIva.Size = new Size(192, 49);
            sltTipoIva.StartIndex = 0;
            sltTipoIva.TabIndex = 4;
            sltTipoIva.SelectedValueChanged += sltTipoIva_SelectedValueChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(6, 67);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(685, 400);
            tabControl1.TabIndex = 8;
            // 
            // FrmMembresiasEstablecimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 473);
            Controls.Add(tabControl1);
            Name = "FrmMembresiasEstablecimiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Membresia";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            gpDatos.ResumeLayout(false);
            gpDatos.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private GroupBox groupBox1;
        private Label lblImp;
        private Label lblValorTotal;
        private Label lblNombre;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdAbono;
        private TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTextBox txtNombreMembresia;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialButton btnCrear;
        private MaterialSkin.Controls.MaterialTextBox txtValor;
        private GroupBox gpDatos;
        private Label lblIVA;
        private Label lblValorFinal;
        private Label lblNombreMembresia;
        private MaterialSkin.Controls.MaterialComboBox sltTipoIva;
        private TabControl tabControl1;
    }
}