namespace Gimnasio.GUI.Pantallas
{
    partial class FrmConsultaActividadesAbonos
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
            tablaActividades = new DataGridView();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
            sltIdActividad = new MaterialSkin.Controls.MaterialComboBox();
            btnEditActividad = new MaterialSkin.Controls.MaterialButton();
            btnCrearAbono = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            IdActividad = new DataGridViewTextBoxColumn();
            nombreActividad = new DataGridViewTextBoxColumn();
            cupoDisponible = new DataGridViewTextBoxColumn();
            horario = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            nombreAbono = new DataGridViewTextBoxColumn();
            valorCuotaPura = new DataGridViewTextBoxColumn();
            horasPorSemana = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tablaActividades).BeginInit();
            SuspendLayout();
            // 
            // tablaActividades
            // 
            tablaActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaActividades.Columns.AddRange(new DataGridViewColumn[] { IdActividad, nombreActividad, cupoDisponible, horario, nombre, nombreAbono, valorCuotaPura, horasPorSemana });
            tablaActividades.Location = new Point(7, 84);
            tablaActividades.Name = "tablaActividades";
            tablaActividades.RowTemplate.Height = 25;
            tablaActividades.Size = new Size(918, 284);
            tablaActividades.TabIndex = 0;
            tablaActividades.SelectionChanged += tablaActividades_SelectionChanged;
            // 
            // btnVolver
            // 
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVolver.Depth = 0;
            btnVolver.HighEmphasis = true;
            btnVolver.Icon = null;
            btnVolver.Location = new Point(26, 452);
            btnVolver.Margin = new Padding(4, 6, 4, 6);
            btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            btnVolver.Name = "btnVolver";
            btnVolver.NoAccentTextColor = Color.Empty;
            btnVolver.Size = new Size(76, 36);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "VOLVER";
            btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVolver.UseAccentColor = false;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // sltIdActividad
            // 
            sltIdActividad.AutoResize = false;
            sltIdActividad.BackColor = Color.FromArgb(255, 255, 255);
            sltIdActividad.Depth = 0;
            sltIdActividad.DrawMode = DrawMode.OwnerDrawVariable;
            sltIdActividad.DropDownHeight = 174;
            sltIdActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            sltIdActividad.DropDownWidth = 121;
            sltIdActividad.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sltIdActividad.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sltIdActividad.FormattingEnabled = true;
            sltIdActividad.Hint = "N° de actividad";
            sltIdActividad.IntegralHeight = false;
            sltIdActividad.ItemHeight = 43;
            sltIdActividad.Location = new Point(26, 377);
            sltIdActividad.MaxDropDownItems = 4;
            sltIdActividad.MouseState = MaterialSkin.MouseState.OUT;
            sltIdActividad.Name = "sltIdActividad";
            sltIdActividad.Size = new Size(209, 49);
            sltIdActividad.StartIndex = 0;
            sltIdActividad.TabIndex = 2;
            // 
            // btnEditActividad
            // 
            btnEditActividad.AutoSize = false;
            btnEditActividad.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditActividad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditActividad.Depth = 0;
            btnEditActividad.HighEmphasis = true;
            btnEditActividad.Icon = null;
            btnEditActividad.Location = new Point(376, 425);
            btnEditActividad.Margin = new Padding(4, 6, 4, 6);
            btnEditActividad.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditActividad.Name = "btnEditActividad";
            btnEditActividad.NoAccentTextColor = Color.Empty;
            btnEditActividad.Size = new Size(150, 36);
            btnEditActividad.TabIndex = 3;
            btnEditActividad.Text = "EDITAR ACTIVIDAD";
            btnEditActividad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditActividad.UseAccentColor = false;
            btnEditActividad.UseVisualStyleBackColor = true;
            btnEditActividad.Click += btnEditActividad_Click;
            // 
            // btnCrearAbono
            // 
            btnCrearAbono.AutoSize = false;
            btnCrearAbono.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCrearAbono.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCrearAbono.Depth = 0;
            btnCrearAbono.HighEmphasis = true;
            btnCrearAbono.Icon = null;
            btnCrearAbono.Location = new Point(376, 377);
            btnCrearAbono.Margin = new Padding(4, 6, 4, 6);
            btnCrearAbono.MouseState = MaterialSkin.MouseState.HOVER;
            btnCrearAbono.Name = "btnCrearAbono";
            btnCrearAbono.NoAccentTextColor = Color.Empty;
            btnCrearAbono.Size = new Size(150, 36);
            btnCrearAbono.TabIndex = 4;
            btnCrearAbono.Text = "CREAR UN ABONO ";
            btnCrearAbono.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCrearAbono.UseAccentColor = false;
            btnCrearAbono.UseVisualStyleBackColor = true;
            btnCrearAbono.Click += btnCrearAbono_Click;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(534, 400);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(186, 36);
            materialButton2.TabIndex = 5;
            materialButton2.Text = "ASIGNAR PROFESOR A LA ACTIVIDAD";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // IdActividad
            // 
            IdActividad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IdActividad.HeaderText = "N° Actividad";
            IdActividad.Name = "IdActividad";
            IdActividad.Width = 99;
            // 
            // nombreActividad
            // 
            nombreActividad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nombreActividad.HeaderText = "Nombre";
            nombreActividad.Name = "nombreActividad";
            nombreActividad.Width = 76;
            // 
            // cupoDisponible
            // 
            cupoDisponible.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cupoDisponible.HeaderText = "Cupo de alumnos";
            cupoDisponible.Name = "cupoDisponible";
            cupoDisponible.Width = 115;
            // 
            // horario
            // 
            horario.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            horario.HeaderText = "Horario";
            horario.Name = "horario";
            horario.Width = 72;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nombre.HeaderText = "Profesor";
            nombre.Name = "nombre";
            nombre.Width = 76;
            // 
            // nombreAbono
            // 
            nombreAbono.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nombreAbono.HeaderText = "Abono";
            nombreAbono.Name = "nombreAbono";
            nombreAbono.Width = 68;
            // 
            // valorCuotaPura
            // 
            valorCuotaPura.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            valorCuotaPura.HeaderText = "Valor";
            valorCuotaPura.Name = "valorCuotaPura";
            valorCuotaPura.Width = 58;
            // 
            // horasPorSemana
            // 
            horasPorSemana.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            horasPorSemana.HeaderText = "Horas semanales";
            horasPorSemana.Name = "horasPorSemana";
            horasPorSemana.Width = 111;
            // 
            // FrmConsultaActividadesAbonos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 508);
            Controls.Add(materialButton2);
            Controls.Add(btnCrearAbono);
            Controls.Add(btnEditActividad);
            Controls.Add(sltIdActividad);
            Controls.Add(btnVolver);
            Controls.Add(tablaActividades);
            Name = "FrmConsultaActividadesAbonos";
            Text = "Menu Actividades";
            ((System.ComponentModel.ISupportInitialize)tablaActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablaActividades;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialComboBox sltIdActividad;
        private MaterialSkin.Controls.MaterialButton btnEditActividad;
        private MaterialSkin.Controls.MaterialButton btnCrearAbono;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private DataGridViewTextBoxColumn IdActividad;
        private DataGridViewTextBoxColumn nombreActividad;
        private DataGridViewTextBoxColumn cupoDisponible;
        private DataGridViewTextBoxColumn horario;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn nombreAbono;
        private DataGridViewTextBoxColumn valorCuotaPura;
        private DataGridViewTextBoxColumn horasPorSemana;
    }
}