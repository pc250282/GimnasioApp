namespace Gimnasio.GUI
{
    partial class FrmAsignarSueldo
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            lblNombre = new MaterialSkin.Controls.MaterialLabel();
            lblApellido = new MaterialSkin.Controls.MaterialLabel();
            lblLegajo = new MaterialSkin.Controls.MaterialLabel();
            tablaActividadesProfesor = new DataGridView();
            nombreActividad = new DataGridViewTextBoxColumn();
            valorCuotaPura = new DataGridViewTextBoxColumn();
            nombreAbono = new DataGridViewTextBoxColumn();
            porcentajeProfesor = new DataGridViewTextBoxColumn();
            horasPorSemana = new DataGridViewTextBoxColumn();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            lblSueldo = new MaterialSkin.Controls.MaterialLabel();
            btnConfirmarSueldo = new MaterialSkin.Controls.MaterialButton();
            checkBono = new MaterialSkin.Controls.MaterialCheckbox();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)tablaActividadesProfesor).BeginInit();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 78);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(131, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Datos del profesor";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Depth = 0;
            lblNombre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNombre.Location = new Point(7, 148);
            lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(74, 19);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "lblNombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Depth = 0;
            lblApellido.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblApellido.Location = new Point(6, 185);
            lblApellido.MouseState = MaterialSkin.MouseState.HOVER;
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(75, 19);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "lblApellido";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Depth = 0;
            lblLegajo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblLegajo.Location = new Point(6, 113);
            lblLegajo.MouseState = MaterialSkin.MouseState.HOVER;
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(66, 19);
            lblLegajo.TabIndex = 3;
            lblLegajo.Text = "lblLegajo";
            // 
            // tablaActividadesProfesor
            // 
            tablaActividadesProfesor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaActividadesProfesor.Columns.AddRange(new DataGridViewColumn[] { nombreActividad, valorCuotaPura, nombreAbono, porcentajeProfesor, horasPorSemana });
            tablaActividadesProfesor.Location = new Point(7, 217);
            tablaActividadesProfesor.Name = "tablaActividadesProfesor";
            tablaActividadesProfesor.RowTemplate.Height = 25;
            tablaActividadesProfesor.Size = new Size(545, 150);
            tablaActividadesProfesor.TabIndex = 5;
            // 
            // nombreActividad
            // 
            nombreActividad.HeaderText = "Actividad";
            nombreActividad.Name = "nombreActividad";
            // 
            // valorCuotaPura
            // 
            valorCuotaPura.HeaderText = "Valor";
            valorCuotaPura.Name = "valorCuotaPura";
            // 
            // nombreAbono
            // 
            nombreAbono.HeaderText = "Tipo de abono";
            nombreAbono.Name = "nombreAbono";
            // 
            // porcentajeProfesor
            // 
            porcentajeProfesor.HeaderText = "Porcentaje a pagar";
            porcentajeProfesor.Name = "porcentajeProfesor";
            // 
            // horasPorSemana
            // 
            horasPorSemana.HeaderText = "Horas";
            horasPorSemana.Name = "horasPorSemana";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(276, 78);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(119, 19);
            materialLabel2.TabIndex = 6;
            materialLabel2.Text = "Sueldo sugerido:";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Depth = 0;
            lblSueldo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSueldo.Location = new Point(401, 78);
            lblSueldo.MouseState = MaterialSkin.MouseState.HOVER;
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(62, 19);
            lblSueldo.TabIndex = 7;
            lblSueldo.Text = "$*****,**";
            // 
            // btnConfirmarSueldo
            // 
            btnConfirmarSueldo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmarSueldo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfirmarSueldo.Depth = 0;
            btnConfirmarSueldo.HighEmphasis = true;
            btnConfirmarSueldo.Icon = null;
            btnConfirmarSueldo.Location = new Point(276, 168);
            btnConfirmarSueldo.Margin = new Padding(4, 6, 4, 6);
            btnConfirmarSueldo.MouseState = MaterialSkin.MouseState.HOVER;
            btnConfirmarSueldo.Name = "btnConfirmarSueldo";
            btnConfirmarSueldo.NoAccentTextColor = Color.Empty;
            btnConfirmarSueldo.Size = new Size(164, 36);
            btnConfirmarSueldo.TabIndex = 8;
            btnConfirmarSueldo.Text = "Confirmar sueldo";
            btnConfirmarSueldo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfirmarSueldo.UseAccentColor = false;
            btnConfirmarSueldo.UseVisualStyleBackColor = true;
            btnConfirmarSueldo.Click += btnConfirmarSueldo_Click;
            // 
            // checkBono
            // 
            checkBono.AutoSize = true;
            checkBono.Depth = 0;
            checkBono.Location = new Point(276, 113);
            checkBono.Margin = new Padding(0);
            checkBono.MouseLocation = new Point(-1, -1);
            checkBono.MouseState = MaterialSkin.MouseState.HOVER;
            checkBono.Name = "checkBono";
            checkBono.ReadOnly = false;
            checkBono.Ripple = true;
            checkBono.Size = new Size(195, 37);
            checkBono.TabIndex = 9;
            checkBono.Text = "Aplicar bono por horas";
            checkBono.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVolver.Depth = 0;
            btnVolver.HighEmphasis = true;
            btnVolver.Icon = null;
            btnVolver.Location = new Point(7, 384);
            btnVolver.Margin = new Padding(4, 6, 4, 6);
            btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            btnVolver.Name = "btnVolver";
            btnVolver.NoAccentTextColor = Color.Empty;
            btnVolver.Size = new Size(76, 36);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "volver";
            btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVolver.UseAccentColor = false;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmAsignarSueldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 429);
            Controls.Add(btnVolver);
            Controls.Add(checkBono);
            Controls.Add(btnConfirmarSueldo);
            Controls.Add(lblSueldo);
            Controls.Add(materialLabel2);
            Controls.Add(tablaActividadesProfesor);
            Controls.Add(lblLegajo);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(materialLabel1);
            Name = "FrmAsignarSueldo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asignar sueldo ";
            ((System.ComponentModel.ISupportInitialize)tablaActividadesProfesor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblApellido;
        private MaterialSkin.Controls.MaterialLabel lblLegajo;
        private DataGridView tablaActividadesProfesor;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblSueldo;
        private MaterialSkin.Controls.MaterialButton btnConfirmarSueldo;
        private DataGridViewTextBoxColumn nombreActividad;
        private DataGridViewTextBoxColumn valorCuotaPura;
        private DataGridViewTextBoxColumn nombreAbono;
        private DataGridViewTextBoxColumn porcentajeProfesor;
        private DataGridViewTextBoxColumn horasPorSemana;
        private MaterialSkin.Controls.MaterialCheckbox checkBono;
        private MaterialSkin.Controls.MaterialButton btnVolver;
    }
}