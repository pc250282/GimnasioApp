namespace Gimnasio.GUI.Pantallas
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            grpLogin = new GroupBox();
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            grpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // grpLogin
            // 
            grpLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpLogin.BackgroundImageLayout = ImageLayout.Stretch;
            grpLogin.Controls.Add(btnLogin);
            grpLogin.Controls.Add(txtPassword);
            grpLogin.Controls.Add(txtUsuario);
            grpLogin.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            grpLogin.Location = new Point(88, 112);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(424, 412);
            grpLogin.TabIndex = 2;
            grpLogin.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.Location = new Point(161, 291);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(91, 36);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Ingresar";
            btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += materialButton1_Click;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.Hint = "Contraseña";
            txtPassword.LeadingIcon = Properties.Resources.cslogin_104358;
            txtPassword.Location = new Point(111, 225);
            txtPassword.MaxLength = 50;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Password = true;
            txtPassword.Size = new Size(217, 36);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "";
            txtPassword.TrailingIcon = null;
            txtPassword.UseTallSize = false;
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsuario.Hint = "Usuario";
            txtUsuario.LeadingIcon = (Image)resources.GetObject("txtUsuario.LeadingIcon");
            txtUsuario.Location = new Point(111, 135);
            txtUsuario.MaxLength = 50;
            txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(217, 36);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "";
            txtUsuario.TrailingIcon = null;
            txtUsuario.UseTallSize = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoSistema;
            ClientSize = new Size(623, 575);
            Controls.Add(grpLogin);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLogin;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
    }
}