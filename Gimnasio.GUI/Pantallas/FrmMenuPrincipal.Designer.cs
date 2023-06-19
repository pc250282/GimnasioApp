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
            btnCrearSocio = new MaterialSkin.Controls.MaterialButton();
            btnCrearProfesor = new MaterialSkin.Controls.MaterialButton();
            btbBuscarSocio = new MaterialSkin.Controls.MaterialButton();
            btnVerActividades = new MaterialSkin.Controls.MaterialButton();
            btnCrearActividad = new MaterialSkin.Controls.MaterialButton();
            btnBuscarProfesores = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // btnCrearSocio
            // 
            btnCrearSocio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCrearSocio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCrearSocio.Depth = 0;
            btnCrearSocio.HighEmphasis = true;
            btnCrearSocio.Icon = null;
            btnCrearSocio.Location = new Point(7, 93);
            btnCrearSocio.Margin = new Padding(4, 6, 4, 6);
            btnCrearSocio.MouseState = MaterialSkin.MouseState.HOVER;
            btnCrearSocio.Name = "btnCrearSocio";
            btnCrearSocio.NoAccentTextColor = Color.Empty;
            btnCrearSocio.Size = new Size(116, 36);
            btnCrearSocio.TabIndex = 0;
            btnCrearSocio.Text = "Socio nuevo";
            btnCrearSocio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCrearSocio.UseAccentColor = false;
            btnCrearSocio.UseVisualStyleBackColor = true;
            btnCrearSocio.Click += btnCrearSocio_Click;
            // 
            // btnCrearProfesor
            // 
            btnCrearProfesor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCrearProfesor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCrearProfesor.Depth = 0;
            btnCrearProfesor.HighEmphasis = true;
            btnCrearProfesor.Icon = null;
            btnCrearProfesor.Location = new Point(136, 93);
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
            btbBuscarSocio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btbBuscarSocio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btbBuscarSocio.Depth = 0;
            btbBuscarSocio.HighEmphasis = true;
            btbBuscarSocio.Icon = null;
            btbBuscarSocio.Location = new Point(7, 214);
            btbBuscarSocio.Margin = new Padding(4, 6, 4, 6);
            btbBuscarSocio.MouseState = MaterialSkin.MouseState.HOVER;
            btbBuscarSocio.Name = "btbBuscarSocio";
            btbBuscarSocio.NoAccentTextColor = Color.Empty;
            btbBuscarSocio.Size = new Size(174, 36);
            btbBuscarSocio.TabIndex = 2;
            btbBuscarSocio.Text = "Administrar socios";
            btbBuscarSocio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btbBuscarSocio.UseAccentColor = false;
            btbBuscarSocio.UseVisualStyleBackColor = true;
            btbBuscarSocio.Click += btbBuscarSocio_Click;
            // 
            // btnVerActividades
            // 
            btnVerActividades.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVerActividades.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVerActividades.Depth = 0;
            btnVerActividades.HighEmphasis = true;
            btnVerActividades.Icon = null;
            btnVerActividades.Location = new Point(7, 348);
            btnVerActividades.Margin = new Padding(4, 6, 4, 6);
            btnVerActividades.MouseState = MaterialSkin.MouseState.HOVER;
            btnVerActividades.Name = "btnVerActividades";
            btnVerActividades.NoAccentTextColor = Color.Empty;
            btnVerActividades.Size = new Size(214, 36);
            btnVerActividades.TabIndex = 5;
            btnVerActividades.Text = "Administrar Actividades";
            btnVerActividades.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVerActividades.UseAccentColor = false;
            btnVerActividades.UseVisualStyleBackColor = true;
            btnVerActividades.Click += btnVerActividades_Click;
            // 
            // btnCrearActividad
            // 
            btnCrearActividad.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCrearActividad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCrearActividad.Depth = 0;
            btnCrearActividad.HighEmphasis = true;
            btnCrearActividad.Icon = null;
            btnCrearActividad.Location = new Point(294, 93);
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
            btnBuscarProfesores.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscarProfesores.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBuscarProfesores.Depth = 0;
            btnBuscarProfesores.HighEmphasis = true;
            btnBuscarProfesores.Icon = null;
            btnBuscarProfesores.Location = new Point(7, 279);
            btnBuscarProfesores.Margin = new Padding(4, 6, 4, 6);
            btnBuscarProfesores.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscarProfesores.Name = "btnBuscarProfesores";
            btnBuscarProfesores.NoAccentTextColor = Color.Empty;
            btnBuscarProfesores.Size = new Size(213, 36);
            btnBuscarProfesores.TabIndex = 7;
            btnBuscarProfesores.Text = "Administrar Profesores";
            btnBuscarProfesores.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBuscarProfesores.UseAccentColor = false;
            btnBuscarProfesores.UseVisualStyleBackColor = true;
            btnBuscarProfesores.Click += btnBuscarProfesores_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 450);
            Controls.Add(btnBuscarProfesores);
            Controls.Add(btnCrearActividad);
            Controls.Add(btnVerActividades);
            Controls.Add(btbBuscarSocio);
            Controls.Add(btnCrearProfesor);
            Controls.Add(btnCrearSocio);
            Name = "MenuPrincipal";
            Text = "Bienvenido al sistema";
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
    }
}