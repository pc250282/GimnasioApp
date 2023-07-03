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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblFecha = new MaterialSkin.Controls.MaterialLabel();
            lblHora = new MaterialSkin.Controls.MaterialLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            btnCrearSocio.Location = new Point(7, 36);
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
            btnCrearProfesor.Location = new Point(8, 94);
            btnCrearProfesor.Margin = new Padding(4, 6, 4, 6);
            btnCrearProfesor.MouseState = MaterialSkin.MouseState.HOVER;
            btnCrearProfesor.Name = "btnCrearProfesor";
            btnCrearProfesor.NoAccentTextColor = Color.Empty;
            btnCrearProfesor.Size = new Size(147, 36);
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
            btbBuscarSocio.Location = new Point(7, 36);
            btbBuscarSocio.Margin = new Padding(4, 6, 4, 6);
            btbBuscarSocio.MouseState = MaterialSkin.MouseState.HOVER;
            btbBuscarSocio.Name = "btbBuscarSocio";
            btbBuscarSocio.NoAccentTextColor = Color.Empty;
            btbBuscarSocio.Size = new Size(195, 36);
            btbBuscarSocio.TabIndex = 2;
            btbBuscarSocio.Text = "Administrar socios";
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
            btnVerActividades.Location = new Point(7, 155);
            btnVerActividades.Margin = new Padding(4, 6, 4, 6);
            btnVerActividades.MouseState = MaterialSkin.MouseState.HOVER;
            btnVerActividades.Name = "btnVerActividades";
            btnVerActividades.NoAccentTextColor = Color.Empty;
            btnVerActividades.Size = new Size(195, 36);
            btnVerActividades.TabIndex = 5;
            btnVerActividades.Text = "Administrar Actividades";
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
            btnCrearActividad.Location = new Point(7, 155);
            btnCrearActividad.Margin = new Padding(4, 6, 4, 6);
            btnCrearActividad.MouseState = MaterialSkin.MouseState.HOVER;
            btnCrearActividad.Name = "btnCrearActividad";
            btnCrearActividad.NoAccentTextColor = Color.Empty;
            btnCrearActividad.Size = new Size(148, 36);
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
            btnBuscarProfesores.Location = new Point(7, 94);
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
            btnAdminPagos.Location = new Point(7, 214);
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
            pictureBox1.Location = new Point(195, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 326);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCrearActividad);
            groupBox1.Controls.Add(btnCrearProfesor);
            groupBox1.Controls.Add(btnCrearSocio);
            groupBox1.Location = new Point(6, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(183, 316);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAdminPagos);
            groupBox2.Controls.Add(btnBuscarProfesores);
            groupBox2.Controls.Add(btbBuscarSocio);
            groupBox2.Controls.Add(btnVerActividades);
            groupBox2.Location = new Point(554, 82);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(220, 300);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Administracion";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Depth = 0;
            lblFecha.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFecha.Location = new Point(195, 64);
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
            lblHora.Location = new Point(413, 64);
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
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 450);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "MenuPrincipal";
            Text = "Menu principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel lblFecha;
        private MaterialSkin.Controls.MaterialLabel lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}