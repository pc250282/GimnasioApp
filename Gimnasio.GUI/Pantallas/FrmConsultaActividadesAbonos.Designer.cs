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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_idAbono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreActividad,
            this.horario,
            this.nombreProfesor,
            this.fk_idAbono,
            this.cupo,
            this.cupoTotal});
            this.dataGridView1.Location = new System.Drawing.Point(53, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(653, 215);
            this.dataGridView1.TabIndex = 0;
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
            // FrmConsultaActividadesAbonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmConsultaActividadesAbonos";
            this.Text = "FrmConsultaActividadesAbonos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombreActividad;
        private DataGridViewTextBoxColumn horario;
        private DataGridViewTextBoxColumn nombreProfesor;
        private DataGridViewTextBoxColumn fk_idAbono;
        private DataGridViewTextBoxColumn cupo;
        private DataGridViewTextBoxColumn cupoTotal;
    }
}