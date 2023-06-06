namespace Gimnasio.GUI
{
    partial class FrmConsultaSociosYProfesores
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
            tablaSocios = new DataGridView();
            idSocio = new DataGridViewTextBoxColumn();
            nombreAbono = new DataGridViewTextBoxColumn();
            fechaDeInscripcion = new DataGridViewTextBoxColumn();
            fk_IdEstado = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            fechaUltimoPago = new DataGridViewTextBoxColumn();
            lblNumSocio = new MaterialSkin.Controls.MaterialLabel();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
            sltNumSocio = new MaterialSkin.Controls.MaterialComboBox();
            tbForm = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            btnRegistrarPago = new MaterialSkin.Controls.MaterialButton();
            tabPage2 = new TabPage();
            sltNumProfesor = new MaterialSkin.Controls.MaterialComboBox();
            btbAsignarActividad = new MaterialSkin.Controls.MaterialButton();
            sltActividades = new MaterialSkin.Controls.MaterialComboBox();
            tablaProfesores = new DataGridView();
            idProfesor = new DataGridViewTextBoxColumn();
            nombreEstado = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            nombreActividad = new DataGridViewTextBoxColumn();
            fechaContratacion = new DataGridViewTextBoxColumn();
            sueldo = new DataGridViewTextBoxColumn();
            TabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            ((System.ComponentModel.ISupportInitialize)tablaSocios).BeginInit();
            tbForm.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaProfesores).BeginInit();
            SuspendLayout();
            // 
            // tablaSocios
            // 
            tablaSocios.AllowUserToAddRows = false;
            tablaSocios.AllowUserToDeleteRows = false;
            tablaSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaSocios.Columns.AddRange(new DataGridViewColumn[] { idSocio, nombreAbono, fechaDeInscripcion, fk_IdEstado, nombre, apellido, telefono, fechaUltimoPago });
            tablaSocios.Location = new Point(23, 6);
            tablaSocios.Name = "tablaSocios";
            tablaSocios.ReadOnly = true;
            tablaSocios.RowTemplate.Height = 25;
            tablaSocios.Size = new Size(845, 246);
            tablaSocios.TabIndex = 0;
            // 
            // idSocio
            // 
            idSocio.HeaderText = "N° Socio";
            idSocio.Name = "idSocio";
            idSocio.ReadOnly = true;
            // 
            // nombreAbono
            // 
            nombreAbono.HeaderText = "Tipo de socio";
            nombreAbono.Name = "nombreAbono";
            nombreAbono.ReadOnly = true;
            // 
            // fechaDeInscripcion
            // 
            fechaDeInscripcion.HeaderText = "Socio desde:";
            fechaDeInscripcion.Name = "fechaDeInscripcion";
            fechaDeInscripcion.ReadOnly = true;
            // 
            // fk_IdEstado
            // 
            fk_IdEstado.HeaderText = "Estado del socio";
            fk_IdEstado.Name = "fk_IdEstado";
            fk_IdEstado.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // fechaUltimoPago
            // 
            fechaUltimoPago.DataPropertyName = "fechaUltimoPago";
            fechaUltimoPago.HeaderText = "Fecha ultimo pago";
            fechaUltimoPago.Name = "fechaUltimoPago";
            fechaUltimoPago.ReadOnly = true;
            // 
            // lblNumSocio
            // 
            lblNumSocio.AutoSize = true;
            lblNumSocio.Depth = 0;
            lblNumSocio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNumSocio.Location = new Point(23, 276);
            lblNumSocio.MouseState = MaterialSkin.MouseState.HOVER;
            lblNumSocio.Name = "lblNumSocio";
            lblNumSocio.Size = new Size(204, 19);
            lblNumSocio.TabIndex = 2;
            lblNumSocio.Text = "Seleccionar numero de socio";
            // 
            // btnVolver
            // 
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVolver.Depth = 0;
            btnVolver.HighEmphasis = true;
            btnVolver.Icon = null;
            btnVolver.Location = new Point(792, 328);
            btnVolver.Margin = new Padding(4, 6, 4, 6);
            btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            btnVolver.Name = "btnVolver";
            btnVolver.NoAccentTextColor = Color.Empty;
            btnVolver.Size = new Size(76, 36);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVolver.UseAccentColor = false;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // sltNumSocio
            // 
            sltNumSocio.AutoResize = false;
            sltNumSocio.BackColor = Color.FromArgb(255, 255, 255);
            sltNumSocio.Depth = 0;
            sltNumSocio.DrawMode = DrawMode.OwnerDrawVariable;
            sltNumSocio.DropDownHeight = 174;
            sltNumSocio.DropDownStyle = ComboBoxStyle.DropDownList;
            sltNumSocio.DropDownWidth = 121;
            sltNumSocio.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sltNumSocio.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sltNumSocio.FormattingEnabled = true;
            sltNumSocio.Hint = "N°Socio";
            sltNumSocio.IntegralHeight = false;
            sltNumSocio.ItemHeight = 43;
            sltNumSocio.Location = new Point(23, 315);
            sltNumSocio.MaxDropDownItems = 4;
            sltNumSocio.MouseState = MaterialSkin.MouseState.OUT;
            sltNumSocio.Name = "sltNumSocio";
            sltNumSocio.Size = new Size(204, 49);
            sltNumSocio.StartIndex = 0;
            sltNumSocio.TabIndex = 7;
            // 
            // tbForm
            // 
            tbForm.Controls.Add(tabPage1);
            tbForm.Controls.Add(tabPage2);
            tbForm.Depth = 0;
            tbForm.Location = new Point(6, 67);
            tbForm.MouseState = MaterialSkin.MouseState.HOVER;
            tbForm.Multiline = true;
            tbForm.Name = "tbForm";
            tbForm.SelectedIndex = 0;
            tbForm.Size = new Size(902, 415);
            tbForm.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRegistrarPago);
            tabPage1.Controls.Add(tablaSocios);
            tabPage1.Controls.Add(btnVolver);
            tabPage1.Controls.Add(lblNumSocio);
            tabPage1.Controls.Add(sltNumSocio);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(894, 387);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Datos Socios";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegistrarPago.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegistrarPago.Depth = 0;
            btnRegistrarPago.HighEmphasis = true;
            btnRegistrarPago.Icon = null;
            btnRegistrarPago.Location = new Point(253, 328);
            btnRegistrarPago.Margin = new Padding(4, 6, 4, 6);
            btnRegistrarPago.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.NoAccentTextColor = Color.Empty;
            btnRegistrarPago.Size = new Size(142, 36);
            btnRegistrarPago.TabIndex = 9;
            btnRegistrarPago.Text = "Registrar Pago";
            btnRegistrarPago.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegistrarPago.UseAccentColor = false;
            btnRegistrarPago.UseVisualStyleBackColor = true;
            btnRegistrarPago.Click += btnRegistrarPago_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(sltNumProfesor);
            tabPage2.Controls.Add(btbAsignarActividad);
            tabPage2.Controls.Add(sltActividades);
            tabPage2.Controls.Add(tablaProfesores);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(894, 455);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Datos Profesores";
            tabPage2.UseVisualStyleBackColor = true;
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
            sltNumProfesor.Location = new Point(25, 320);
            sltNumProfesor.MaxDropDownItems = 4;
            sltNumProfesor.MouseState = MaterialSkin.MouseState.OUT;
            sltNumProfesor.Name = "sltNumProfesor";
            sltNumProfesor.Size = new Size(189, 49);
            sltNumProfesor.StartIndex = 0;
            sltNumProfesor.TabIndex = 3;
            // 
            // btbAsignarActividad
            // 
            btbAsignarActividad.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btbAsignarActividad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btbAsignarActividad.Depth = 0;
            btbAsignarActividad.HighEmphasis = true;
            btbAsignarActividad.Icon = null;
            btbAsignarActividad.Location = new Point(25, 403);
            btbAsignarActividad.Margin = new Padding(4, 6, 4, 6);
            btbAsignarActividad.MouseState = MaterialSkin.MouseState.HOVER;
            btbAsignarActividad.Name = "btbAsignarActividad";
            btbAsignarActividad.NoAccentTextColor = Color.Empty;
            btbAsignarActividad.Size = new Size(83, 36);
            btbAsignarActividad.TabIndex = 2;
            btbAsignarActividad.Text = "Asignar";
            btbAsignarActividad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btbAsignarActividad.UseAccentColor = false;
            btbAsignarActividad.UseVisualStyleBackColor = true;
            btbAsignarActividad.Click += btbAsignarActividad_Click;
            // 
            // sltActividades
            // 
            sltActividades.AutoResize = false;
            sltActividades.BackColor = Color.FromArgb(255, 255, 255);
            sltActividades.Depth = 0;
            sltActividades.DrawMode = DrawMode.OwnerDrawVariable;
            sltActividades.DropDownHeight = 174;
            sltActividades.DropDownStyle = ComboBoxStyle.DropDownList;
            sltActividades.DropDownWidth = 121;
            sltActividades.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sltActividades.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sltActividades.FormattingEnabled = true;
            sltActividades.Hint = "Actividades";
            sltActividades.IntegralHeight = false;
            sltActividades.ItemHeight = 43;
            sltActividades.Location = new Point(239, 320);
            sltActividades.MaxDropDownItems = 4;
            sltActividades.MouseState = MaterialSkin.MouseState.OUT;
            sltActividades.Name = "sltActividades";
            sltActividades.Size = new Size(158, 49);
            sltActividades.StartIndex = 0;
            sltActividades.TabIndex = 1;
            // 
            // tablaProfesores
            // 
            tablaProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProfesores.Columns.AddRange(new DataGridViewColumn[] { idProfesor, nombreEstado, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, nombreActividad, fechaContratacion, sueldo });
            tablaProfesores.Location = new Point(25, 28);
            tablaProfesores.Name = "tablaProfesores";
            tablaProfesores.ReadOnly = true;
            tablaProfesores.RowTemplate.Height = 25;
            tablaProfesores.Size = new Size(746, 268);
            tablaProfesores.TabIndex = 0;
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
            // nombreActividad
            // 
            nombreActividad.DataPropertyName = "nombreActividad";
            nombreActividad.HeaderText = "Actividad Asignada";
            nombreActividad.Name = "nombreActividad";
            nombreActividad.ReadOnly = true;
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
            // TabSelector1
            // 
            TabSelector1.BaseTabControl = tbForm;
            TabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            TabSelector1.Depth = 0;
            TabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            TabSelector1.Location = new Point(357, 47);
            TabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            TabSelector1.Name = "TabSelector1";
            TabSelector1.Size = new Size(390, 27);
            TabSelector1.TabIndex = 9;
            TabSelector1.Text = "materialTabSelector1";
            // 
            // FrmConsultaSociosYProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 484);
            Controls.Add(TabSelector1);
            Controls.Add(tbForm);
            Name = "FrmConsultaSociosYProfesores";
            Text = "Ver Socios";
            ((System.ComponentModel.ISupportInitialize)tablaSocios).EndInit();
            tbForm.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaProfesores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tablaSocios;
        private MaterialSkin.Controls.MaterialLabel lblNumSocio;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialComboBox sltNumSocio;
        private MaterialSkin.Controls.MaterialTabControl tbForm;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector1;
        private DataGridView tablaProfesores;
        private DataGridViewTextBoxColumn idProfesor;
        private DataGridViewTextBoxColumn nombreEstado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nombreActividad;
        private DataGridViewTextBoxColumn fechaContratacion;
        private DataGridViewTextBoxColumn sueldo;
        private MaterialSkin.Controls.MaterialButton btnRegistrarPago;
        private MaterialSkin.Controls.MaterialComboBox sltNumProfesor;
        private MaterialSkin.Controls.MaterialButton btbAsignarActividad;
        private MaterialSkin.Controls.MaterialComboBox sltActividades;
        private DataGridViewTextBoxColumn idSocio;
        private DataGridViewTextBoxColumn nombreAbono;
        private DataGridViewTextBoxColumn fechaDeInscripcion;
        private DataGridViewTextBoxColumn fk_IdEstado;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn fechaUltimoPago;
    }
}