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
            this.tablaSocios = new System.Windows.Forms.DataGridView();
            this.idSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaUltimoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNumSocio = new MaterialSkin.Controls.MaterialLabel();
            this.lblApellido = new MaterialSkin.Controls.MaterialLabel();
            this.btnActualizarEstado = new MaterialSkin.Controls.MaterialButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.sltNumSocio = new MaterialSkin.Controls.MaterialComboBox();
            this.sltEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.tbForm = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRegistrarPago = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sltNumProfesor = new MaterialSkin.Controls.MaterialComboBox();
            this.btbAsignarActividad = new MaterialSkin.Controls.MaterialButton();
            this.sltActividades = new MaterialSkin.Controls.MaterialComboBox();
            this.tablaProfesores = new System.Windows.Forms.DataGridView();
            this.idProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaContratacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSocios)).BeginInit();
            this.tbForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaSocios
            // 
            this.tablaSocios.AllowUserToAddRows = false;
            this.tablaSocios.AllowUserToDeleteRows = false;
            this.tablaSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSocio,
            this.fechaDeInscripcion,
            this.fk_IdEstado,
            this.nombre,
            this.apellido,
            this.telefono,
            this.fechaUltimoPago});
            this.tablaSocios.Location = new System.Drawing.Point(23, 6);
            this.tablaSocios.Name = "tablaSocios";
            this.tablaSocios.ReadOnly = true;
            this.tablaSocios.RowTemplate.Height = 25;
            this.tablaSocios.Size = new System.Drawing.Size(743, 238);
            this.tablaSocios.TabIndex = 0;
            // 
            // idSocio
            // 
            this.idSocio.HeaderText = "N° Socio";
            this.idSocio.Name = "idSocio";
            this.idSocio.ReadOnly = true;
            // 
            // fechaDeInscripcion
            // 
            this.fechaDeInscripcion.HeaderText = "Socio desde:";
            this.fechaDeInscripcion.Name = "fechaDeInscripcion";
            this.fechaDeInscripcion.ReadOnly = true;
            // 
            // fk_IdEstado
            // 
            this.fk_IdEstado.HeaderText = "Estado del socio";
            this.fk_IdEstado.Name = "fk_IdEstado";
            this.fk_IdEstado.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // fechaUltimoPago
            // 
            this.fechaUltimoPago.DataPropertyName = "fechaUltimoPago";
            this.fechaUltimoPago.HeaderText = "Fecha ultimo pago";
            this.fechaUltimoPago.Name = "fechaUltimoPago";
            this.fechaUltimoPago.ReadOnly = true;
            // 
            // lblNumSocio
            // 
            this.lblNumSocio.AutoSize = true;
            this.lblNumSocio.Depth = 0;
            this.lblNumSocio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNumSocio.Location = new System.Drawing.Point(23, 255);
            this.lblNumSocio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumSocio.Name = "lblNumSocio";
            this.lblNumSocio.Size = new System.Drawing.Size(204, 19);
            this.lblNumSocio.TabIndex = 2;
            this.lblNumSocio.Text = "Seleccionar numero de socio";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Depth = 0;
            this.lblApellido.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblApellido.Location = new System.Drawing.Point(282, 255);
            this.lblApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(135, 19);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Seleccionar estado";
            // 
            // btnActualizarEstado
            // 
            this.btnActualizarEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarEstado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizarEstado.Depth = 0;
            this.btnActualizarEstado.HighEmphasis = true;
            this.btnActualizarEstado.Icon = null;
            this.btnActualizarEstado.Location = new System.Drawing.Point(282, 370);
            this.btnActualizarEstado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizarEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarEstado.Name = "btnActualizarEstado";
            this.btnActualizarEstado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizarEstado.Size = new System.Drawing.Size(109, 36);
            this.btnActualizarEstado.TabIndex = 5;
            this.btnActualizarEstado.Text = "Actualizar";
            this.btnActualizarEstado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizarEstado.UseAccentColor = false;
            this.btnActualizarEstado.UseVisualStyleBackColor = true;
            this.btnActualizarEstado.Click += new System.EventHandler(this.btnActualizarEstado_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVolver.Depth = 0;
            this.btnVolver.HighEmphasis = true;
            this.btnVolver.Icon = null;
            this.btnVolver.Location = new System.Drawing.Point(23, 370);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolver.Size = new System.Drawing.Size(76, 36);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolver.UseAccentColor = false;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // sltNumSocio
            // 
            this.sltNumSocio.AutoResize = false;
            this.sltNumSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sltNumSocio.Depth = 0;
            this.sltNumSocio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sltNumSocio.DropDownHeight = 174;
            this.sltNumSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltNumSocio.DropDownWidth = 121;
            this.sltNumSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sltNumSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sltNumSocio.FormattingEnabled = true;
            this.sltNumSocio.Hint = "N°Socio";
            this.sltNumSocio.IntegralHeight = false;
            this.sltNumSocio.ItemHeight = 43;
            this.sltNumSocio.Location = new System.Drawing.Point(23, 296);
            this.sltNumSocio.MaxDropDownItems = 4;
            this.sltNumSocio.MouseState = MaterialSkin.MouseState.OUT;
            this.sltNumSocio.Name = "sltNumSocio";
            this.sltNumSocio.Size = new System.Drawing.Size(204, 49);
            this.sltNumSocio.StartIndex = 0;
            this.sltNumSocio.TabIndex = 7;
            // 
            // sltEstado
            // 
            this.sltEstado.AutoResize = false;
            this.sltEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sltEstado.Depth = 0;
            this.sltEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sltEstado.DropDownHeight = 174;
            this.sltEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltEstado.DropDownWidth = 121;
            this.sltEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sltEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sltEstado.FormattingEnabled = true;
            this.sltEstado.Hint = "Estado";
            this.sltEstado.IntegralHeight = false;
            this.sltEstado.ItemHeight = 43;
            this.sltEstado.Location = new System.Drawing.Point(282, 296);
            this.sltEstado.MaxDropDownItems = 4;
            this.sltEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.sltEstado.Name = "sltEstado";
            this.sltEstado.Size = new System.Drawing.Size(204, 49);
            this.sltEstado.StartIndex = 0;
            this.sltEstado.TabIndex = 8;
            // 
            // tbForm
            // 
            this.tbForm.Controls.Add(this.tabPage1);
            this.tbForm.Controls.Add(this.tabPage2);
            this.tbForm.Depth = 0;
            this.tbForm.Location = new System.Drawing.Point(6, 67);
            this.tbForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbForm.Multiline = true;
            this.tbForm.Name = "tbForm";
            this.tbForm.SelectedIndex = 0;
            this.tbForm.Size = new System.Drawing.Size(809, 490);
            this.tbForm.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRegistrarPago);
            this.tabPage1.Controls.Add(this.tablaSocios);
            this.tabPage1.Controls.Add(this.btnVolver);
            this.tabPage1.Controls.Add(this.sltEstado);
            this.tabPage1.Controls.Add(this.btnActualizarEstado);
            this.tabPage1.Controls.Add(this.lblNumSocio);
            this.tabPage1.Controls.Add(this.sltNumSocio);
            this.tabPage1.Controls.Add(this.lblApellido);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Socios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrarPago.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrarPago.Depth = 0;
            this.btnRegistrarPago.HighEmphasis = true;
            this.btnRegistrarPago.Icon = null;
            this.btnRegistrarPago.Location = new System.Drawing.Point(612, 290);
            this.btnRegistrarPago.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrarPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrarPago.Size = new System.Drawing.Size(142, 36);
            this.btnRegistrarPago.TabIndex = 9;
            this.btnRegistrarPago.Text = "Registrar Pago";
            this.btnRegistrarPago.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrarPago.UseAccentColor = false;
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sltNumProfesor);
            this.tabPage2.Controls.Add(this.btbAsignarActividad);
            this.tabPage2.Controls.Add(this.sltActividades);
            this.tabPage2.Controls.Add(this.tablaProfesores);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(801, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Profesores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sltNumProfesor
            // 
            this.sltNumProfesor.AutoResize = false;
            this.sltNumProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sltNumProfesor.Depth = 0;
            this.sltNumProfesor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sltNumProfesor.DropDownHeight = 174;
            this.sltNumProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltNumProfesor.DropDownWidth = 121;
            this.sltNumProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sltNumProfesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sltNumProfesor.FormattingEnabled = true;
            this.sltNumProfesor.Hint = "Legajo Profesor";
            this.sltNumProfesor.IntegralHeight = false;
            this.sltNumProfesor.ItemHeight = 43;
            this.sltNumProfesor.Location = new System.Drawing.Point(25, 320);
            this.sltNumProfesor.MaxDropDownItems = 4;
            this.sltNumProfesor.MouseState = MaterialSkin.MouseState.OUT;
            this.sltNumProfesor.Name = "sltNumProfesor";
            this.sltNumProfesor.Size = new System.Drawing.Size(189, 49);
            this.sltNumProfesor.StartIndex = 0;
            this.sltNumProfesor.TabIndex = 3;
            // 
            // btbAsignarActividad
            // 
            this.btbAsignarActividad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btbAsignarActividad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btbAsignarActividad.Depth = 0;
            this.btbAsignarActividad.HighEmphasis = true;
            this.btbAsignarActividad.Icon = null;
            this.btbAsignarActividad.Location = new System.Drawing.Point(25, 403);
            this.btbAsignarActividad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btbAsignarActividad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btbAsignarActividad.Name = "btbAsignarActividad";
            this.btbAsignarActividad.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btbAsignarActividad.Size = new System.Drawing.Size(83, 36);
            this.btbAsignarActividad.TabIndex = 2;
            this.btbAsignarActividad.Text = "Asignar";
            this.btbAsignarActividad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btbAsignarActividad.UseAccentColor = false;
            this.btbAsignarActividad.UseVisualStyleBackColor = true;
            this.btbAsignarActividad.Click += new System.EventHandler(this.btbAsignarActividad_Click);
            // 
            // sltActividades
            // 
            this.sltActividades.AutoResize = false;
            this.sltActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sltActividades.Depth = 0;
            this.sltActividades.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sltActividades.DropDownHeight = 174;
            this.sltActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltActividades.DropDownWidth = 121;
            this.sltActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sltActividades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sltActividades.FormattingEnabled = true;
            this.sltActividades.Hint = "Actividades";
            this.sltActividades.IntegralHeight = false;
            this.sltActividades.ItemHeight = 43;
            this.sltActividades.Location = new System.Drawing.Point(239, 320);
            this.sltActividades.MaxDropDownItems = 4;
            this.sltActividades.MouseState = MaterialSkin.MouseState.OUT;
            this.sltActividades.Name = "sltActividades";
            this.sltActividades.Size = new System.Drawing.Size(158, 49);
            this.sltActividades.StartIndex = 0;
            this.sltActividades.TabIndex = 1;
            // 
            // tablaProfesores
            // 
            this.tablaProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProfesor,
            this.nombreEstado,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.nombreActividad,
            this.fechaContratacion,
            this.sueldo});
            this.tablaProfesores.Location = new System.Drawing.Point(25, 28);
            this.tablaProfesores.Name = "tablaProfesores";
            this.tablaProfesores.ReadOnly = true;
            this.tablaProfesores.RowTemplate.Height = 25;
            this.tablaProfesores.Size = new System.Drawing.Size(746, 268);
            this.tablaProfesores.TabIndex = 0;
            // 
            // idProfesor
            // 
            this.idProfesor.DataPropertyName = "idProfesor";
            this.idProfesor.HeaderText = "Legajo N°";
            this.idProfesor.Name = "idProfesor";
            this.idProfesor.ReadOnly = true;
            // 
            // nombreEstado
            // 
            this.nombreEstado.DataPropertyName = "nombreEstado";
            this.nombreEstado.HeaderText = "Estado";
            this.nombreEstado.Name = "nombreEstado";
            this.nombreEstado.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "apellido";
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nombreActividad
            // 
            this.nombreActividad.DataPropertyName = "nombreActividad";
            this.nombreActividad.HeaderText = "Actividad Asignada";
            this.nombreActividad.Name = "nombreActividad";
            this.nombreActividad.ReadOnly = true;
            // 
            // fechaContratacion
            // 
            this.fechaContratacion.DataPropertyName = "fechaContratacion";
            this.fechaContratacion.HeaderText = "F. Contratacion";
            this.fechaContratacion.Name = "fechaContratacion";
            this.fechaContratacion.ReadOnly = true;
            // 
            // sueldo
            // 
            this.sueldo.DataPropertyName = "sueldo";
            this.sueldo.HeaderText = "Sueldo";
            this.sueldo.Name = "sueldo";
            this.sueldo.ReadOnly = true;
            // 
            // TabSelector1
            // 
            this.TabSelector1.BaseTabControl = this.tbForm;
            this.TabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.TabSelector1.Depth = 0;
            this.TabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabSelector1.Location = new System.Drawing.Point(357, 47);
            this.TabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector1.Name = "TabSelector1";
            this.TabSelector1.Size = new System.Drawing.Size(390, 27);
            this.TabSelector1.TabIndex = 9;
            this.TabSelector1.Text = "materialTabSelector1";
            // 
            // FrmConsultaSociosYProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 578);
            this.Controls.Add(this.TabSelector1);
            this.Controls.Add(this.tbForm);
            this.Name = "FrmConsultaSociosYProfesores";
            this.Text = "Ver Socios";
            ((System.ComponentModel.ISupportInitialize)(this.tablaSocios)).EndInit();
            this.tbForm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfesores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView tablaSocios;
        private MaterialSkin.Controls.MaterialLabel lblNumSocio;
        private MaterialSkin.Controls.MaterialLabel lblApellido;
        private MaterialSkin.Controls.MaterialButton btnActualizarEstado;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialComboBox sltNumSocio;
        private MaterialSkin.Controls.MaterialComboBox sltEstado;
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
        private DataGridViewTextBoxColumn idSocio;
        private DataGridViewTextBoxColumn fechaDeInscripcion;
        private DataGridViewTextBoxColumn fk_IdEstado;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn fechaUltimoPago;
        private MaterialSkin.Controls.MaterialButton btnRegistrarPago;
        private MaterialSkin.Controls.MaterialComboBox sltNumProfesor;
        private MaterialSkin.Controls.MaterialButton btbAsignarActividad;
        private MaterialSkin.Controls.MaterialComboBox sltActividades;
    }
}