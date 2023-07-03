namespace Gimnasio.GUI
{
    partial class FrmConsultaSocios
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
            sltEstado = new MaterialSkin.Controls.MaterialComboBox();
            btnActualizarEstado = new MaterialSkin.Controls.MaterialButton();
            btnUpdateAbono = new MaterialSkin.Controls.MaterialButton();
            btnAbono = new MaterialSkin.Controls.MaterialButton();
            btnRegistrarPago = new MaterialSkin.Controls.MaterialButton();
            tablaSocios = new DataGridView();
            idSocio = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            nombreAbono = new DataGridViewTextBoxColumn();
            fechaDeInscripcion = new DataGridViewTextBoxColumn();
            fk_IdEstado = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            mail = new DataGridViewTextBoxColumn();
            fechaUltimoPago = new DataGridViewTextBoxColumn();
            lblNumSocio = new MaterialSkin.Controls.MaterialLabel();
            sltNumSocio = new MaterialSkin.Controls.MaterialComboBox();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
            btnEditarDatos = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)tablaSocios).BeginInit();
            SuspendLayout();
            // 
            // sltEstado
            // 
            sltEstado.AutoResize = false;
            sltEstado.BackColor = Color.FromArgb(255, 255, 255);
            sltEstado.Depth = 0;
            sltEstado.DrawMode = DrawMode.OwnerDrawVariable;
            sltEstado.DropDownHeight = 174;
            sltEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            sltEstado.DropDownWidth = 121;
            sltEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sltEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sltEstado.FormattingEnabled = true;
            sltEstado.Hint = "Estados";
            sltEstado.IntegralHeight = false;
            sltEstado.ItemHeight = 43;
            sltEstado.Location = new Point(680, 445);
            sltEstado.MaxDropDownItems = 4;
            sltEstado.MouseState = MaterialSkin.MouseState.OUT;
            sltEstado.Name = "sltEstado";
            sltEstado.Size = new Size(204, 49);
            sltEstado.StartIndex = 0;
            sltEstado.TabIndex = 13;
            // 
            // btnActualizarEstado
            // 
            btnActualizarEstado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnActualizarEstado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnActualizarEstado.Depth = 0;
            btnActualizarEstado.HighEmphasis = true;
            btnActualizarEstado.Icon = null;
            btnActualizarEstado.Location = new Point(680, 528);
            btnActualizarEstado.Margin = new Padding(4, 6, 4, 6);
            btnActualizarEstado.MouseState = MaterialSkin.MouseState.HOVER;
            btnActualizarEstado.Name = "btnActualizarEstado";
            btnActualizarEstado.NoAccentTextColor = Color.Empty;
            btnActualizarEstado.Size = new Size(168, 36);
            btnActualizarEstado.TabIndex = 12;
            btnActualizarEstado.Text = "actualizar estado";
            btnActualizarEstado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnActualizarEstado.UseAccentColor = false;
            btnActualizarEstado.UseVisualStyleBackColor = true;
            btnActualizarEstado.Click += btnActualizarEstado_Click_1;
            // 
            // btnUpdateAbono
            // 
            btnUpdateAbono.AutoSize = false;
            btnUpdateAbono.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateAbono.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateAbono.Depth = 0;
            btnUpdateAbono.HighEmphasis = true;
            btnUpdateAbono.Icon = null;
            btnUpdateAbono.Location = new Point(449, 493);
            btnUpdateAbono.Margin = new Padding(4, 6, 4, 6);
            btnUpdateAbono.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateAbono.Name = "btnUpdateAbono";
            btnUpdateAbono.NoAccentTextColor = Color.Empty;
            btnUpdateAbono.Size = new Size(173, 36);
            btnUpdateAbono.TabIndex = 11;
            btnUpdateAbono.Text = "cambiar membresia";
            btnUpdateAbono.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateAbono.UseAccentColor = false;
            btnUpdateAbono.UseVisualStyleBackColor = true;
            btnUpdateAbono.Click += btnUpdateAbono_Click;
            // 
            // btnAbono
            // 
            btnAbono.AutoSize = false;
            btnAbono.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAbono.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAbono.Depth = 0;
            btnAbono.HighEmphasis = true;
            btnAbono.Icon = null;
            btnAbono.Location = new Point(261, 445);
            btnAbono.Margin = new Padding(4, 6, 4, 6);
            btnAbono.MouseState = MaterialSkin.MouseState.HOVER;
            btnAbono.Name = "btnAbono";
            btnAbono.NoAccentTextColor = Color.Empty;
            btnAbono.Size = new Size(180, 36);
            btnAbono.TabIndex = 10;
            btnAbono.Text = "Asignar membrersia";
            btnAbono.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAbono.UseAccentColor = false;
            btnAbono.UseVisualStyleBackColor = true;
            btnAbono.Click += btnAbono_Click;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.AutoSize = false;
            btnRegistrarPago.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegistrarPago.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegistrarPago.Depth = 0;
            btnRegistrarPago.HighEmphasis = true;
            btnRegistrarPago.Icon = null;
            btnRegistrarPago.Location = new Point(261, 493);
            btnRegistrarPago.Margin = new Padding(4, 6, 4, 6);
            btnRegistrarPago.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.NoAccentTextColor = Color.Empty;
            btnRegistrarPago.Size = new Size(180, 36);
            btnRegistrarPago.TabIndex = 9;
            btnRegistrarPago.Text = "Registrar Pago";
            btnRegistrarPago.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegistrarPago.UseAccentColor = false;
            btnRegistrarPago.UseVisualStyleBackColor = true;
            btnRegistrarPago.Click += btnRegistrarPago_Click;
            // 
            // tablaSocios
            // 
            tablaSocios.AllowUserToAddRows = false;
            tablaSocios.AllowUserToDeleteRows = false;
            tablaSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaSocios.Columns.AddRange(new DataGridViewColumn[] { idSocio, dni, nombreAbono, fechaDeInscripcion, fk_IdEstado, nombre, apellido, telefono, mail, fechaUltimoPago });
            tablaSocios.Location = new Point(6, 80);
            tablaSocios.Name = "tablaSocios";
            tablaSocios.ReadOnly = true;
            tablaSocios.RowTemplate.Height = 25;
            tablaSocios.Size = new Size(1379, 301);
            tablaSocios.TabIndex = 0;
            tablaSocios.SelectionChanged += tablaSocios_SelectionChanged;
            // 
            // idSocio
            // 
            idSocio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idSocio.HeaderText = "N° Socio";
            idSocio.Name = "idSocio";
            idSocio.ReadOnly = true;
            idSocio.Width = 72;
            // 
            // dni
            // 
            dni.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dni.HeaderText = "N° Documento";
            dni.Name = "dni";
            dni.ReadOnly = true;
            dni.Width = 103;
            // 
            // nombreAbono
            // 
            nombreAbono.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nombreAbono.HeaderText = "Tipo de socio";
            nombreAbono.Name = "nombreAbono";
            nombreAbono.ReadOnly = true;
            nombreAbono.Width = 94;
            // 
            // fechaDeInscripcion
            // 
            fechaDeInscripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fechaDeInscripcion.HeaderText = "Socio desde";
            fechaDeInscripcion.Name = "fechaDeInscripcion";
            fechaDeInscripcion.ReadOnly = true;
            fechaDeInscripcion.Width = 88;
            // 
            // fk_IdEstado
            // 
            fk_IdEstado.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fk_IdEstado.HeaderText = "Estado del socio";
            fk_IdEstado.Name = "fk_IdEstado";
            fk_IdEstado.ReadOnly = true;
            fk_IdEstado.Width = 82;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 76;
            // 
            // apellido
            // 
            apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            apellido.Width = 76;
            // 
            // telefono
            // 
            telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            telefono.HeaderText = "Telefono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            telefono.Width = 77;
            // 
            // mail
            // 
            mail.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            mail.HeaderText = "E-mail";
            mail.Name = "mail";
            mail.ReadOnly = true;
            mail.Width = 66;
            // 
            // fechaUltimoPago
            // 
            fechaUltimoPago.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fechaUltimoPago.DataPropertyName = "fechaUltimoPago";
            fechaUltimoPago.HeaderText = "Fecha ultimo pago";
            fechaUltimoPago.Name = "fechaUltimoPago";
            fechaUltimoPago.ReadOnly = true;
            fechaUltimoPago.Width = 120;
            // 
            // lblNumSocio
            // 
            lblNumSocio.AutoSize = true;
            lblNumSocio.Depth = 0;
            lblNumSocio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNumSocio.Location = new Point(27, 406);
            lblNumSocio.MouseState = MaterialSkin.MouseState.HOVER;
            lblNumSocio.Name = "lblNumSocio";
            lblNumSocio.Size = new Size(204, 19);
            lblNumSocio.TabIndex = 2;
            lblNumSocio.Text = "Seleccionar numero de socio";
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
            sltNumSocio.Location = new Point(27, 445);
            sltNumSocio.MaxDropDownItems = 4;
            sltNumSocio.MouseState = MaterialSkin.MouseState.OUT;
            sltNumSocio.Name = "sltNumSocio";
            sltNumSocio.Size = new Size(204, 49);
            sltNumSocio.StartIndex = 0;
            sltNumSocio.TabIndex = 7;
            // 
            // btnVolver
            // 
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVolver.Depth = 0;
            btnVolver.HighEmphasis = true;
            btnVolver.Icon = null;
            btnVolver.Location = new Point(7, 609);
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
            // btnEditarDatos
            // 
            btnEditarDatos.AutoSize = false;
            btnEditarDatos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarDatos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarDatos.Depth = 0;
            btnEditarDatos.HighEmphasis = true;
            btnEditarDatos.Icon = null;
            btnEditarDatos.Location = new Point(449, 445);
            btnEditarDatos.Margin = new Padding(4, 6, 4, 6);
            btnEditarDatos.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditarDatos.Name = "btnEditarDatos";
            btnEditarDatos.NoAccentTextColor = Color.Empty;
            btnEditarDatos.Size = new Size(173, 36);
            btnEditarDatos.TabIndex = 14;
            btnEditarDatos.Text = "Editar datos";
            btnEditarDatos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditarDatos.UseAccentColor = false;
            btnEditarDatos.UseVisualStyleBackColor = true;
            btnEditarDatos.Click += btnEditarDatos_Click;
            // 
            // FrmConsultaSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 654);
            Controls.Add(btnEditarDatos);
            Controls.Add(btnVolver);
            Controls.Add(btnAbono);
            Controls.Add(sltEstado);
            Controls.Add(tablaSocios);
            Controls.Add(btnActualizarEstado);
            Controls.Add(lblNumSocio);
            Controls.Add(btnUpdateAbono);
            Controls.Add(btnRegistrarPago);
            Controls.Add(sltNumSocio);
            Name = "FrmConsultaSocios";
            Sizable = false;
            Text = "Socios";
            ((System.ComponentModel.ISupportInitialize)tablaSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialComboBox sltNumProfesor;
        private MaterialSkin.Controls.MaterialButton btbAsignarActividad;
        private MaterialSkin.Controls.MaterialComboBox sltActividades;
        private DataGridView tablaProfesores;
        private DataGridViewTextBoxColumn idProfesor;
        private DataGridViewTextBoxColumn nombreEstado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nombreActividad;
        private DataGridViewTextBoxColumn fechaContratacion;
        private DataGridViewTextBoxColumn sueldo;
        private MaterialSkin.Controls.MaterialButton btnRegistrarPago;
        private DataGridView tablaSocios;
        private MaterialSkin.Controls.MaterialLabel lblNumSocio;
        private MaterialSkin.Controls.MaterialComboBox sltNumSocio;
        private System.CodeDom.CodeTypeReference btnAsignarAbono;
        private MaterialSkin.Controls.MaterialButton btnAbono;
        private MaterialSkin.Controls.MaterialButton btnUpdateAbono;
        private MaterialSkin.Controls.MaterialComboBox sltEstado;
        private MaterialSkin.Controls.MaterialButton btnActualizarEstado;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private DataGridViewTextBoxColumn idSocio;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombreAbono;
        private DataGridViewTextBoxColumn fechaDeInscripcion;
        private DataGridViewTextBoxColumn fk_IdEstado;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn mail;
        private DataGridViewTextBoxColumn fechaUltimoPago;
        private MaterialSkin.Controls.MaterialButton btnEditarDatos;
    }
}