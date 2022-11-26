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
            this.tablaActividades = new System.Windows.Forms.DataGridView();
            this.nombreActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_idAbono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablaActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaActividades
            // 
            this.tablaActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreActividad,
            this.horario,
            this.nombreProfesor,
            this.fk_idAbono,
            this.cupo,
            this.cupoTotal});
            this.tablaActividades.Location = new System.Drawing.Point(53, 108);
            this.tablaActividades.Name = "tablaActividades";
            this.tablaActividades.RowTemplate.Height = 25;
            this.tablaActividades.Size = new System.Drawing.Size(653, 215);
            this.tablaActividades.TabIndex = 0;
            // 
            // nombreActividad
            // 
            this.nombreActividad.HeaderText = "Actividad";
            this.nombreActividad.Name = "nombreActividad";
            // 
            // horario
            // 
            this.horario.HeaderText = "Horario";
            this.horario.Name = "horario";
            // 
            // nombreProfesor
            // 
            this.nombreProfesor.HeaderText = "Profesor";
            this.nombreProfesor.Name = "nombreProfesor";
            // 
            // fk_idAbono
            // 
            this.fk_idAbono.HeaderText = "Abono";
            this.fk_idAbono.Name = "fk_idAbono";
            // 
            // cupo
            // 
            this.cupo.HeaderText = "Cupo disponible";
            this.cupo.Name = "cupo";
            // 
            // cupoTotal
            // 
            this.cupoTotal.HeaderText = "Cupo Total";
            this.cupoTotal.Name = "cupoTotal";
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVolver.Depth = 0;
            this.btnVolver.HighEmphasis = true;
            this.btnVolver.Icon = null;
            this.btnVolver.Location = new System.Drawing.Point(7, 405);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolver.Size = new System.Drawing.Size(158, 36);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolver.UseAccentColor = false;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmConsultaActividadesAbonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tablaActividades);
            this.Name = "FrmConsultaActividadesAbonos";
            this.Text = "FrmConsultaActividadesAbonos";
            ((System.ComponentModel.ISupportInitialize)(this.tablaActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tablaActividades;
        private DataGridViewTextBoxColumn nombreActividad;
        private DataGridViewTextBoxColumn horario;
        private DataGridViewTextBoxColumn nombreProfesor;
        private DataGridViewTextBoxColumn fk_idAbono;
        private DataGridViewTextBoxColumn cupo;
        private DataGridViewTextBoxColumn cupoTotal;
        private MaterialSkin.Controls.MaterialButton btnVolver;
    }
}