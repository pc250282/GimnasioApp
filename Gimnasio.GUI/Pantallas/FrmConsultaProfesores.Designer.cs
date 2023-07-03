namespace Gimnasio.GUI.Pantallas
{
    partial class FrmConsultaProfesores
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
            tablaProfesores = new DataGridView();
            sltNumProfesor = new MaterialSkin.Controls.MaterialComboBox();
            btbAsignarSueldo = new MaterialSkin.Controls.MaterialButton();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
            idProfesor = new DataGridViewTextBoxColumn();
            nombreEstado = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            fechaContratacion = new DataGridViewTextBoxColumn();
            sueldo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tablaProfesores).BeginInit();
            SuspendLayout();
            // 
            // tablaProfesores
            // 
            tablaProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProfesores.Columns.AddRange(new DataGridViewColumn[] { idProfesor, nombreEstado, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, fechaContratacion, sueldo });
            tablaProfesores.Location = new Point(27, 91);
            tablaProfesores.Name = "tablaProfesores";
            tablaProfesores.ReadOnly = true;
            tablaProfesores.RowTemplate.Height = 25;
            tablaProfesores.Size = new Size(647, 268);
            tablaProfesores.TabIndex = 1;
            // 
            // sltNumProfesor
            // 
            sltNumProfesor.AutoResize = false;
            sltNumProfesor.BackColor = Color.FromArgb(255, 255, 255);
            sltNumProfesor.Depth = 0;
            sltNumProfesor.DrawMode = DrawMode.OwnerDrawVariable;
            sltNumProfesor.DropDownHeight = 174;
            sltNumProfesor.DropDownStyle = ComboBoxStyle.DropDownList;
            sltNumProfesor.DropDownWidth = 121;
            sltNumProfesor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sltNumProfesor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sltNumProfesor.FormattingEnabled = true;
            sltNumProfesor.Hint = "Legajo Profesor";
            sltNumProfesor.IntegralHeight = false;
            sltNumProfesor.ItemHeight = 43;
            sltNumProfesor.Location = new Point(27, 377);
            sltNumProfesor.MaxDropDownItems = 4;
            sltNumProfesor.MouseState = MaterialSkin.MouseState.OUT;
            sltNumProfesor.Name = "sltNumProfesor";
            sltNumProfesor.Size = new Size(189, 49);
            sltNumProfesor.StartIndex = 0;
            sltNumProfesor.TabIndex = 5;
            // 
            // btbAsignarSueldo
            // 
            btbAsignarSueldo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btbAsignarSueldo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btbAsignarSueldo.Depth = 0;
            btbAsignarSueldo.HighEmphasis = true;
            btbAsignarSueldo.Icon = null;
            btbAsignarSueldo.Location = new Point(253, 390);
            btbAsignarSueldo.Margin = new Padding(4, 6, 4, 6);
            btbAsignarSueldo.MouseState = MaterialSkin.MouseState.HOVER;
            btbAsignarSueldo.Name = "btbAsignarSueldo";
            btbAsignarSueldo.NoAccentTextColor = Color.Empty;
            btbAsignarSueldo.Size = new Size(142, 36);
            btbAsignarSueldo.TabIndex = 6;
            btbAsignarSueldo.Text = "Asignar sueldo";
            btbAsignarSueldo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btbAsignarSueldo.UseAccentColor = false;
            btbAsignarSueldo.UseVisualStyleBackColor = true;
            btbAsignarSueldo.Click += btbAsignarSueldo_Click;
            // 
            // btnVolver
            // 
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVolver.Depth = 0;
            btnVolver.HighEmphasis = true;
            btnVolver.Icon = null;
            btnVolver.Location = new Point(697, 390);
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
            // idProfesor
            // 
            idProfesor.DataPropertyName = "idProfesor";
            idProfesor.HeaderText = "Legajo N°";
            idProfesor.Name = "idProfesor";
            idProfesor.ReadOnly = true;
            // 
            // nombreEstado
            // 
            nombreEstado.DataPropertyName = "nombreEstado";
            nombreEstado.HeaderText = "Estado";
            nombreEstado.Name = "nombreEstado";
            nombreEstado.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "apellido";
            dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // fechaContratacion
            // 
            fechaContratacion.DataPropertyName = "fechaContratacion";
            fechaContratacion.HeaderText = "F. Contratacion";
            fechaContratacion.Name = "fechaContratacion";
            fechaContratacion.ReadOnly = true;
            // 
            // sueldo
            // 
            sueldo.DataPropertyName = "sueldo";
            sueldo.HeaderText = "Sueldo";
            sueldo.Name = "sueldo";
            sueldo.ReadOnly = true;
            // 
            // FrmConsultaProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btbAsignarSueldo);
            Controls.Add(sltNumProfesor);
            Controls.Add(tablaProfesores);
            Name = "FrmConsultaProfesores";
            Text = "Profesores:";
            ((System.ComponentModel.ISupportInitialize)tablaProfesores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablaProfesores;
        private MaterialSkin.Controls.MaterialComboBox sltNumProfesor;
        private MaterialSkin.Controls.MaterialComboBox sltActividades;
        private MaterialSkin.Controls.MaterialButton btbAsignarSueldo;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private DataGridViewTextBoxColumn idProfesor;
        private DataGridViewTextBoxColumn nombreEstado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn fechaContratacion;
        private DataGridViewTextBoxColumn sueldo;
    }
}