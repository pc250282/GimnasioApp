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
            tabPage1 = new TabPage();
            btnAbono = new MaterialSkin.Controls.MaterialButton();
            btnRegistrarPago = new MaterialSkin.Controls.MaterialButton();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
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
            sltNumSocio = new MaterialSkin.Controls.MaterialComboBox();
            tbForm = new MaterialSkin.Controls.MaterialTabControl();
            btnUpdateAbono = new MaterialSkin.Controls.MaterialButton();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaSocios).BeginInit();
            tbForm.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnUpdateAbono);
            tabPage1.Controls.Add(btnAbono);
            tabPage1.Controls.Add(btnRegistrarPago);
            tabPage1.Controls.Add(btnVolver);
            tabPage1.Controls.Add(tablaSocios);
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
            // btnAbono
            // 
            btnAbono.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAbono.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAbono.Depth = 0;
            btnAbono.HighEmphasis = true;
            btnAbono.Icon = null;
            btnAbono.Location = new Point(253, 280);
            btnAbono.Margin = new Padding(4, 6, 4, 6);
            btnAbono.MouseState = MaterialSkin.MouseState.HOVER;
            btnAbono.Name = "btnAbono";
            btnAbono.NoAccentTextColor = Color.Empty;
            btnAbono.Size = new Size(137, 36);
            btnAbono.TabIndex = 10;
            btnAbono.Text = "Asignar Abono";
            btnAbono.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAbono.UseAccentColor = false;
            btnAbono.UseVisualStyleBackColor = true;
            btnAbono.Click += btnAbono_Click;
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
            tbForm.Depth = 0;
            tbForm.Location = new Point(6, 67);
            tbForm.MouseState = MaterialSkin.MouseState.HOVER;
            tbForm.Multiline = true;
            tbForm.Name = "tbForm";
            tbForm.SelectedIndex = 0;
            tbForm.Size = new Size(902, 415);
            tbForm.TabIndex = 9;
            // 
            // btnUpdateAbono
            // 
            btnUpdateAbono.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateAbono.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateAbono.Depth = 0;
            btnUpdateAbono.HighEmphasis = true;
            btnUpdateAbono.Icon = null;
            btnUpdateAbono.Location = new Point(434, 280);
            btnUpdateAbono.Margin = new Padding(4, 6, 4, 6);
            btnUpdateAbono.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateAbono.Name = "btnUpdateAbono";
            btnUpdateAbono.NoAccentTextColor = Color.Empty;
            btnUpdateAbono.Size = new Size(149, 36);
            btnUpdateAbono.TabIndex = 11;
            btnUpdateAbono.Text = "cambiar abono";
            btnUpdateAbono.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateAbono.UseAccentColor = false;
            btnUpdateAbono.UseVisualStyleBackColor = true;
            btnUpdateAbono.Click += btnUpdateAbono_Click;
            // 
            // FrmConsultaSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 484);
            Controls.Add(tbForm);
            Name = "FrmConsultaSocios";
            Text = "Socios";
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaSocios).EndInit();
            tbForm.ResumeLayout(false);
            ResumeLayout(false);
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
        private TabPage tabPage1;
        private MaterialSkin.Controls.MaterialButton btnRegistrarPago;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private DataGridView tablaSocios;
        private DataGridViewTextBoxColumn idSocio;
        private DataGridViewTextBoxColumn nombreAbono;
        private DataGridViewTextBoxColumn fechaDeInscripcion;
        private DataGridViewTextBoxColumn fk_IdEstado;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn fechaUltimoPago;
        private MaterialSkin.Controls.MaterialLabel lblNumSocio;
        private MaterialSkin.Controls.MaterialComboBox sltNumSocio;
        private MaterialSkin.Controls.MaterialTabControl tbForm;
        private System.CodeDom.CodeTypeReference btnAsignarAbono;
        private MaterialSkin.Controls.MaterialButton btnAbono;
        private MaterialSkin.Controls.MaterialButton btnUpdateAbono;
    }
}