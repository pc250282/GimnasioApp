namespace Gimnasio.GUI
{
    partial class MenuPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            btnCrearSocio = new MaterialSkin.Controls.MaterialButton();
            btnCrearProfesor = new MaterialSkin.Controls.MaterialButton();
            btbBuscarSocio = new MaterialSkin.Controls.MaterialButton();
            btnVerActividades = new MaterialSkin.Controls.MaterialButton();
            btnCrearActividad = new MaterialSkin.Controls.MaterialButton();
            btnBuscarProfesores = new MaterialSkin.Controls.MaterialButton();
            btnAdminPagos = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            grpAdmin = new GroupBox();
            btnLogOff = new MaterialSkin.Controls.MaterialButton();
            btnCambiarRol = new MaterialSkin.Controls.MaterialButton();
            btnCrearEmpleado = new MaterialSkin.Controls.MaterialButton();
            grpGerencia = new GroupBox();
            lblFecha = new MaterialSkin.Controls.MaterialLabel();
            lblHora = new MaterialSkin.Controls.MaterialLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusUsuario = new ToolStripStatusLabel();
            toolStripStatusRol = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpAdmin.SuspendLayout();
            grpGerencia.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCrearSocio
            // 
            btnCrearSocio.AutoSize = false;
            btnCrearSocio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCrearSocio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCrearSocio.Depth = 0;
            btnCrearSocio.HighEmphasis = true;
            btnCrearSocio.Icon = null;
            btnCrearSocio.Location = new Point(32, 46);
            btnCrearSocio.Margin = new Padding(4, 6, 4, 6);
            btnCrearSocio.MouseState = MaterialSkin.MouseState.HOVER;
            btnCrearSocio.Name = "btnCrearSocio";
            btnCrearSocio.NoAccentTextColor = Color.Empty;
            btnCrearSocio.Size = new Size(148, 36);
            btnCrearSocio.TabIndex = 0;
            btnCrearSocio.Text = "Socio nuevo";
            btnCrearSocio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCrearSocio.UseAccentColor = false;
            btnCrearSocio.UseVisualStyleBackColor = true;
            btnCrearSocio.Click += btnCrearSocio_Click;
            // 
            // btnCrearProfesor
            // 
            btnCrearProfesor.AutoSize = false;
            btnCrearProfesor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCrearProfesor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCrearProfesor.Depth = 0;
            btnCrearProfesor.HighEmphasis = true;
            btnCrearProfesor.Icon = null;
            btnCrearProfesor.Location = new Point(40, 90);
            btnCrearProfesor.Margin = new Padding(4, 6, 4, 6);
            btnCrearProfesor.MouseState = MaterialSkin.MouseState.HOVER;
            btnCrearProfesor.Name = "btnCrearProfesor";
            btnCrearProfesor.NoAccentTextColor = Color.Empty;
            btnCrearProfesor.Size = new Size(195, 36);
            btnCrearProfesor.TabIndex = 1;
            btnCrearProfesor.Text = "Profesor nuevo";
            btnCrearProfesor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCrearProfesor.UseAccentColor = false;
            btnCrearProfesor.UseVisualStyleBackColor = true;
            btnCrearProfesor.Click += btnCrearProfesor_Click;
            // 
            // btbBuscarSocio
            // 
            btbBuscarSocio.AutoSize = false;
            btbBuscarSocio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btbBuscarSocio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btbBuscarSocio.Depth = 0;
            btbBuscarSocio.HighEmphasis = true;
            btbBuscarSocio.Icon = null;
            btbBuscarSocio.Location = new Point(7, 94);
            btbBuscarSocio.Margin = new Padding(4, 6, 4, 6);
            btbBuscarSocio.MouseState = MaterialSkin.MouseState.HOVER;
            btbBuscarSocio.Name = "btbBuscarSocio";
            btbBuscarSocio.NoAccentTextColor = Color.Empty;
            btbBuscarSocio.Size = new Size(195, 36);
            btbBuscarSocio.TabIndex = 2;
            btbBuscarSocio.Text = "GESTION DE SOCIOS";
            btbBuscarSocio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btbBuscarSocio.UseAccentColor = false;
            btbBuscarSocio.UseVisualStyleBackColor = true;
            btbBuscarSocio.Click += btbBuscarSocio_Click;
            // 
            // btnVerActividades
            // 
            btnVerActividades.AutoSize = false;
            btnVerActividades.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVerActividades.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVerActividades.Depth = 0;
            btnVerActividades.HighEmphasis = true;
            btnVerActividades.Icon = null;
            btnVerActividades.Location = new Point(7, 142);
            btnVerActividades.Margin = new Padding(4, 6, 4, 6);
            btnVerActividades.MouseState = MaterialSkin.MouseState.HOVER;
            btnVerActividades.Name = "btnVerActividades";
            btnVerActividades.NoAccentTextColor = Color.Empty;
            btnVerActividades.Size = new Size(195, 36);
            btnVerActividades.TabIndex = 5;
            btnVerActividades.Text = "MENU DE ACTIVIDADES";
            btnVerActividades.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVerActividades.UseAccentColor = false;
            btnVerActividades.UseVisualStyleBackColor = true;
            btnVerActividades.Click += btnVerActividades_Click;
            // 
            // btnCrearActividad
            // 
            btnCrearActividad.AutoSize = false;
            btnCrearActividad.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCrearActividad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCrearActividad.Depth = 0;
            btnCrearActividad.HighEmphasis = true;
            btnCrearActividad.Icon = null;
            btnCrearActividad.Location = new Point(40, 42);
            btnCrearActividad.Margin = new Padding(4, 6, 4, 6);
            btnCrearActividad.MouseState = MaterialSkin.MouseState.HOVER;
            btnCrearActividad.Name = "btnCrearActividad";
            btnCrearActividad.NoAccentTextColor = Color.Empty;
            btnCrearActividad.Size = new Size(195, 36);
            btnCrearActividad.TabIndex = 6;
            btnCrearActividad.Text = "Nueva Actividad";
            btnCrearActividad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCrearActividad.UseAccentColor = false;
            btnCrearActividad.UseVisualStyleBackColor = true;
            btnCrearActividad.Click += btnCrearActividad_Click;
            // 
            // btnBuscarProfesores
            // 
            btnBuscarProfesores.AutoSize = false;
            btnBuscarProfesores.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscarProfesores.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBuscarProfesores.Depth = 0;
            btnBuscarProfesores.HighEmphasis = true;
            btnBuscarProfesores.Icon = null;
            btnBuscarProfesores.Location = new Point(40, 138);
            btnBuscarProfesores.Margin = new Padding(4, 6, 4, 6);
            btnBuscarProfesores.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscarProfesores.Name = "btnBuscarProfesores";
            btnBuscarProfesores.NoAccentTextColor = Color.Empty;
            btnBuscarProfesores.Size = new Size(195, 36);
            btnBuscarProfesores.TabIndex = 7;
            btnBuscarProfesores.Text = "Administrar Profesores";
            btnBuscarProfesores.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBuscarProfesores.UseAccentColor = false;
            btnBuscarProfesores.UseVisualStyleBackColor = true;
            btnBuscarProfesores.Click += btnBuscarProfesores_Click;
            // 
            // btnAdminPagos
            // 
            btnAdminPagos.AutoSize = false;
            btnAdminPagos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdminPagos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdminPagos.Depth = 0;
            btnAdminPagos.HighEmphasis = true;
            btnAdminPagos.Icon = null;
            btnAdminPagos.Location = new Point(7, 190);
            btnAdminPagos.Margin = new Padding(4, 6, 4, 6);
            btnAdminPagos.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdminPagos.Name = "btnAdminPagos";
            btnAdminPagos.NoAccentTextColor = Color.Empty;
            btnAdminPagos.Size = new Size(195, 36);
            btnAdminPagos.TabIndex = 8;
            btnAdminPagos.Text = "ADMINISTRAR PAGOS";
            btnAdminPagos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdminPagos.UseAccentColor = false;
            btnAdminPagos.UseVisualStyleBackColor = true;
            btnAdminPagos.Click += btnAdminPagos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(231, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 326);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // grpAdmin
            // 
            grpAdmin.Controls.Add(btnAdminPagos);
            grpAdmin.Controls.Add(btbBuscarSocio);
            grpAdmin.Controls.Add(btnCrearSocio);
            grpAdmin.Controls.Add(btnVerActividades);
            grpAdmin.Location = new Point(3, 82);
            grpAdmin.Name = "grpAdmin";
            grpAdmin.Size = new Size(222, 330);
            grpAdmin.TabIndex = 10;
            grpAdmin.TabStop = false;
            // 
            // btnLogOff
            // 
            btnLogOff.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogOff.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogOff.Depth = 0;
            btnLogOff.HighEmphasis = true;
            btnLogOff.Icon = null;
            btnLogOff.Location = new Point(342, 440);
            btnLogOff.Margin = new Padding(4, 6, 4, 6);
            btnLogOff.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogOff.Name = "btnLogOff";
            btnLogOff.NoAccentTextColor = Color.Empty;
            btnLogOff.Size = new Size(131, 36);
            btnLogOff.TabIndex = 15;
            btnLogOff.Text = "cerrar sesión";
            btnLogOff.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogOff.UseAccentColor = false;
            btnLogOff.UseVisualStyleBackColor = true;
            btnLogOff.Click += btnLogOff_Click;
            // 
            // btnCambiarRol
            // 
            btnCambiarRol.AutoSize = false;
            btnCambiarRol.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCambiarRol.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCambiarRol.Depth = 0;
            btnCambiarRol.HighEmphasis = true;
            btnCambiarRol.Icon = null;
            btnCambiarRol.Location = new Point(40, 234);
            btnCambiarRol.Margin = new Padding(4, 6, 4, 6);
            btnCambiarRol.MouseState = MaterialSkin.MouseState.HOVER;
            btnCambiarRol.Name = "btnCambiarRol";
            btnCambiarRol.NoAccentTextColor = Color.Empty;
            btnCambiarRol.Size = new Size(195, 36);
            btnCambiarRol.TabIndex = 8;
            btnCambiarRol.Text = "EDICION DE EMPLEADO";
            btnCambiarRol.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCambiarRol.UseAccentColor = false;
            btnCambiarRol.UseVisualStyleBackColor = true;
            btnCambiarRol.Click += btnCambiarRol_Click;
            // 
            // btnCrearEmpleado
            // 
            btnCrearEmpleado.AutoSize = false;
            btnCrearEmpleado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCrearEmpleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCrearEmpleado.Depth = 0;
            btnCrearEmpleado.HighEmphasis = true;
            btnCrearEmpleado.Icon = null;
            btnCrearEmpleado.Location = new Point(40, 186);
            btnCrearEmpleado.Margin = new Padding(4, 6, 4, 6);
            btnCrearEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            btnCrearEmpleado.Name = "btnCrearEmpleado";
            btnCrearEmpleado.NoAccentTextColor = Color.Empty;
            btnCrearEmpleado.Size = new Size(195, 36);
            btnCrearEmpleado.TabIndex = 7;
            btnCrearEmpleado.Text = "CREAR EMPLEADO";
            btnCrearEmpleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCrearEmpleado.UseAccentColor = false;
            btnCrearEmpleado.UseVisualStyleBackColor = true;
            btnCrearEmpleado.Click += btnCrearEmpleado_Click;
            // 
            // grpGerencia
            // 
            grpGerencia.Controls.Add(btnCrearEmpleado);
            grpGerencia.Controls.Add(btnCambiarRol);
            grpGerencia.Controls.Add(btnBuscarProfesores);
            grpGerencia.Controls.Add(btnCrearProfesor);
            grpGerencia.Controls.Add(btnCrearActividad);
            grpGerencia.Location = new Point(590, 86);
            grpGerencia.Name = "grpGerencia";
            grpGerencia.Size = new Size(273, 326);
            grpGerencia.TabIndex = 11;
            grpGerencia.TabStop = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Depth = 0;
            lblFecha.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFecha.Location = new Point(3, 440);
            lblFecha.MouseState = MaterialSkin.MouseState.HOVER;
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(107, 19);
            lblFecha.TabIndex = 12;
            lblFecha.Text = "materialLabel1";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Depth = 0;
            lblHora.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblHora.Location = new Point(3, 473);
            lblHora.MouseState = MaterialSkin.MouseState.HOVER;
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(107, 19);
            lblHora.TabIndex = 13;
            lblHora.Text = "materialLabel2";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusUsuario, toolStripStatusRol });
            statusStrip1.Location = new Point(3, 502);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(871, 22);
            statusStrip1.TabIndex = 14;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusUsuario
            // 
            toolStripStatusUsuario.Name = "toolStripStatusUsuario";
            toolStripStatusUsuario.Size = new Size(118, 17);
            toolStripStatusUsuario.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusRol
            // 
            toolStripStatusRol.Name = "toolStripStatusRol";
            toolStripStatusRol.Size = new Size(118, 17);
            toolStripStatusRol.Text = "toolStripStatusLabel2";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 527);
            Controls.Add(btnLogOff);
            Controls.Add(statusStrip1);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(grpGerencia);
            Controls.Add(grpAdmin);
            Controls.Add(pictureBox1);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpAdmin.ResumeLayout(false);
            grpGerencia.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCrearSocio;
        private MaterialSkin.Controls.MaterialButton btnCrearProfesor;
        private MaterialSkin.Controls.MaterialButton btbBuscarSocio;
        private MaterialSkin.Controls.MaterialButton btnVerActividades;
        private MaterialSkin.Controls.MaterialButton btnCrearActividad;
        private MaterialSkin.Controls.MaterialButton btnBuscarProfesores;
        private MaterialSkin.Controls.MaterialButton btnAdminPagos;
        private PictureBox pictureBox1;
        private GroupBox grpAdmin;
        private GroupBox grpGerencia;
        private MaterialSkin.Controls.MaterialLabel lblFecha;
        private MaterialSkin.Controls.MaterialLabel lblHora;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusUsuario;
        private ToolStripStatusLabel toolStripStatusRol;
        private MaterialSkin.Controls.MaterialButton btnCambiarRol;
        private MaterialSkin.Controls.MaterialButton btnCrearEmpleado;
        private MaterialSkin.Controls.MaterialButton btnLogOff;
    }
}