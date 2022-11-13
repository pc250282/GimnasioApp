namespace GimnasioDesktop
{
    partial class MenuCargaSocio
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
            this.sltGenero = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // sltGenero
            // 
            this.sltGenero.AutoResize = false;
            this.sltGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sltGenero.Depth = 0;
            this.sltGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sltGenero.DropDownHeight = 174;
            this.sltGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltGenero.DropDownWidth = 121;
            this.sltGenero.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sltGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sltGenero.FormattingEnabled = true;
            this.sltGenero.IntegralHeight = false;
            this.sltGenero.ItemHeight = 43;
            this.sltGenero.Location = new System.Drawing.Point(59, 92);
            this.sltGenero.MaxDropDownItems = 4;
            this.sltGenero.MouseState = MaterialSkin.MouseState.OUT;
            this.sltGenero.Name = "sltGenero";
            this.sltGenero.Size = new System.Drawing.Size(158, 49);
            this.sltGenero.StartIndex = 0;
            this.sltGenero.TabIndex = 0;
            // 
            // MenuCargaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sltGenero);
            this.Name = "MenuCargaSocio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox sltGenero;
    }
}

