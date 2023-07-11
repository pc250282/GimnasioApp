namespace Gimnasio.GUI
{
    partial class FrmCrearUsuario
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
            sltRoles = new MaterialSkin.Controls.MaterialComboBox();
            txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            grpDatosEmpleado = new GroupBox();
            txtPassword2 = new MaterialSkin.Controls.MaterialTextBox();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            btnConfirmar = new MaterialSkin.Controls.MaterialButton();
            btnVolver = new MaterialSkin.Controls.MaterialButton();
            lblNombreUser = new MaterialSkin.Controls.MaterialLabel();
            grpDatosEmpleado.SuspendLayout();
            SuspendLayout();
            // 
            // sltRoles
            // 
            sltRoles.AutoResize = false;
            sltRoles.BackColor = Color.FromArgb(255, 255, 255);
            sltRoles.Depth = 0;
            sltRoles.DrawMode = DrawMode.OwnerDrawVariable;
            sltRoles.DropDownHeight = 174;
            sltRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            sltRoles.DropDownWidth = 121;
            sltRoles.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sltRoles.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sltRoles.FormattingEnabled = true;
            sltRoles.Hint = "Rol del empleado";
            sltRoles.IntegralHeight = false;
            sltRoles.ItemHeight = 43;
            sltRoles.Location = new Point(20, 225);
            sltRoles.MaxDropDownItems = 4;
            sltRoles.MouseState = MaterialSkin.MouseState.OUT;
            sltRoles.Name = "sltRoles";
            sltRoles.Size = new Size(214, 49);
            sltRoles.StartIndex = 0;
            sltRoles.TabIndex = 7;
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsuario.Hint = "Usuario";
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(20, 22);
            txtUsuario.MaxLength = 50;
            txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(214, 50);
            txtUsuario.TabIndex = 17;
            txtUsuario.Text = "";
            txtUsuario.TrailingIcon = null;
            // 
            // grpDatosEmpleado
            // 
            grpDatosEmpleado.Controls.Add(lblNombreUser);
            grpDatosEmpleado.Controls.Add(txtPassword2);
            grpDatosEmpleado.Controls.Add(txtPassword);
            grpDatosEmpleado.Controls.Add(txtUsuario);
            grpDatosEmpleado.Controls.Add(sltRoles);
            grpDatosEmpleado.Location = new Point(47, 92);
            grpDatosEmpleado.Name = "grpDatosEmpleado";
            grpDatosEmpleado.Size = new Size(255, 295);
            grpDatosEmpleado.TabIndex = 18;
            grpDatosEmpleado.TabStop = false;
            // 
            // txtPassword2
            // 
            txtPassword2.AnimateReadOnly = false;
            txtPassword2.BorderStyle = BorderStyle.None;
            txtPassword2.Depth = 0;
            txtPassword2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword2.Hint = "Repetir contraseña";
            txtPassword2.LeadingIcon = null;
            txtPassword2.Location = new Point(20, 155);
            txtPassword2.MaxLength = 50;
            txtPassword2.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword2.Multiline = false;
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Password = true;
            txtPassword2.Size = new Size(214, 50);
            txtPassword2.TabIndex = 20;
            txtPassword2.Text = "";
            txtPassword2.TrailingIcon = null;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.Hint = "Contraseña";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(20, 86);
            txtPassword.MaxLength = 50;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Password = true;
            txtPassword.Size = new Size(214, 50);
            txtPassword.TabIndex = 18;
            txtPassword.Text = "";
            txtPassword.TrailingIcon = null;
            // 
            // btnConfirmar
            // 
            btnConfirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfirmar.Depth = 0;
            btnConfirmar.HighEmphasis = true;
            btnConfirmar.Icon = null;
            btnConfirmar.Location = new Point(146, 433);
            btnConfirmar.Margin = new Padding(4, 6, 4, 6);
            btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.NoAccentTextColor = Color.Empty;
            btnConfirmar.Size = new Size(178, 36);
            btnConfirmar.TabIndex = 19;
            btnConfirmar.Text = "CONFIRMAR REGISTRO";
            btnConfirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfirmar.UseAccentColor = false;
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnVolver
            // 
            btnVolver.AutoSize = false;
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVolver.Depth = 0;
            btnVolver.HighEmphasis = true;
            btnVolver.Icon = null;
            btnVolver.Location = new Point(7, 433);
            btnVolver.Margin = new Padding(4, 6, 4, 6);
            btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            btnVolver.Name = "btnVolver";
            btnVolver.NoAccentTextColor = Color.Empty;
            btnVolver.Size = new Size(82, 36);
            btnVolver.TabIndex = 20;
            btnVolver.Text = "volver";
            btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVolver.UseAccentColor = false;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblNombreUser
            // 
            lblNombreUser.AutoSize = true;
            lblNombreUser.Depth = 0;
            lblNombreUser.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNombreUser.Location = new Point(61, 36);
            lblNombreUser.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombreUser.Name = "lblNombreUser";
            lblNombreUser.Size = new Size(1, 0);
            lblNombreUser.TabIndex = 21;
            // 
            // FrmCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 521);
            Controls.Add(btnVolver);
            Controls.Add(btnConfirmar);
            Controls.Add(grpDatosEmpleado);
            Name = "FrmCrearUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de empleado";
            grpDatosEmpleado.ResumeLayout(false);
            grpDatosEmpleado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox sltRoles;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private GroupBox grpDatosEmpleado;
        private MaterialSkin.Controls.MaterialTextBox txtPassword2;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialButton btnConfirmar;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialLabel lblNombreUser;
    }
}