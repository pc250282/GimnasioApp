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
            this.btnCrearSocio = new MaterialSkin.Controls.MaterialButton();
            this.btnCrearProfesor = new MaterialSkin.Controls.MaterialButton();
            this.btbBuscarSocio = new MaterialSkin.Controls.MaterialButton();
            this.btnVerActividades = new MaterialSkin.Controls.MaterialButton();
            this.btnCrearActividad = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnCrearSocio
            // 
            this.btnCrearSocio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearSocio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCrearSocio.Depth = 0;
            this.btnCrearSocio.HighEmphasis = true;
            this.btnCrearSocio.Icon = null;
            this.btnCrearSocio.Location = new System.Drawing.Point(146, 100);
            this.btnCrearSocio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCrearSocio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearSocio.Name = "btnCrearSocio";
            this.btnCrearSocio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCrearSocio.Size = new System.Drawing.Size(116, 36);
            this.btnCrearSocio.TabIndex = 0;
            this.btnCrearSocio.Text = "Socio nuevo";
            this.btnCrearSocio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCrearSocio.UseAccentColor = false;
            this.btnCrearSocio.UseVisualStyleBackColor = true;
            this.btnCrearSocio.Click += new System.EventHandler(this.btnCrearSocio_Click);
            // 
            // btnCrearProfesor
            // 
            this.btnCrearProfesor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearProfesor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCrearProfesor.Depth = 0;
            this.btnCrearProfesor.HighEmphasis = true;
            this.btnCrearProfesor.Icon = null;
            this.btnCrearProfesor.Location = new System.Drawing.Point(232, 325);
            this.btnCrearProfesor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCrearProfesor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearProfesor.Name = "btnCrearProfesor";
            this.btnCrearProfesor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCrearProfesor.Size = new System.Drawing.Size(147, 36);
            this.btnCrearProfesor.TabIndex = 1;
            this.btnCrearProfesor.Text = "Profesor nuevo";
            this.btnCrearProfesor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCrearProfesor.UseAccentColor = false;
            this.btnCrearProfesor.UseVisualStyleBackColor = true;
            this.btnCrearProfesor.Click += new System.EventHandler(this.btnCrearProfesor_Click);
            // 
            // btbBuscarSocio
            // 
            this.btbBuscarSocio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btbBuscarSocio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btbBuscarSocio.Depth = 0;
            this.btbBuscarSocio.HighEmphasis = true;
            this.btbBuscarSocio.Icon = null;
            this.btbBuscarSocio.Location = new System.Drawing.Point(121, 216);
            this.btbBuscarSocio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btbBuscarSocio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btbBuscarSocio.Name = "btbBuscarSocio";
            this.btbBuscarSocio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btbBuscarSocio.Size = new System.Drawing.Size(174, 36);
            this.btbBuscarSocio.TabIndex = 2;
            this.btbBuscarSocio.Text = "Administrar socios";
            this.btbBuscarSocio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btbBuscarSocio.UseAccentColor = false;
            this.btbBuscarSocio.UseVisualStyleBackColor = true;
            this.btbBuscarSocio.Click += new System.EventHandler(this.btbBuscarSocio_Click);
            // 
            // btnVerActividades
            // 
            this.btnVerActividades.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerActividades.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerActividades.Depth = 0;
            this.btnVerActividades.HighEmphasis = true;
            this.btnVerActividades.Icon = null;
            this.btnVerActividades.Location = new System.Drawing.Point(136, 158);
            this.btnVerActividades.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerActividades.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerActividades.Name = "btnVerActividades";
            this.btnVerActividades.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVerActividades.Size = new System.Drawing.Size(145, 36);
            this.btnVerActividades.TabIndex = 5;
            this.btnVerActividades.Text = "Ver Actividades";
            this.btnVerActividades.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerActividades.UseAccentColor = false;
            this.btnVerActividades.UseVisualStyleBackColor = true;
            this.btnVerActividades.Click += new System.EventHandler(this.btnVerActividades_Click);
            // 
            // btnCrearActividad
            // 
            this.btnCrearActividad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearActividad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCrearActividad.Depth = 0;
            this.btnCrearActividad.HighEmphasis = true;
            this.btnCrearActividad.Icon = null;
            this.btnCrearActividad.Location = new System.Drawing.Point(76, 325);
            this.btnCrearActividad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCrearActividad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearActividad.Name = "btnCrearActividad";
            this.btnCrearActividad.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCrearActividad.Size = new System.Drawing.Size(148, 36);
            this.btnCrearActividad.TabIndex = 6;
            this.btnCrearActividad.Text = "Nueva Actividad";
            this.btnCrearActividad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCrearActividad.UseAccentColor = false;
            this.btnCrearActividad.UseVisualStyleBackColor = true;
            this.btnCrearActividad.Click += new System.EventHandler(this.btnCrearActividad_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.btnCrearActividad);
            this.Controls.Add(this.btnVerActividades);
            this.Controls.Add(this.btbBuscarSocio);
            this.Controls.Add(this.btnCrearProfesor);
            this.Controls.Add(this.btnCrearSocio);
            this.Name = "MenuPrincipal";
            this.Text = "Bienvenido al sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCrearSocio;
        private MaterialSkin.Controls.MaterialButton btnCrearProfesor;
        private MaterialSkin.Controls.MaterialButton btbBuscarSocio;
        private MaterialSkin.Controls.MaterialButton btnVerActividades;
        private MaterialSkin.Controls.MaterialButton btnCrearActividad;
    }
}