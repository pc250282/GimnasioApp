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
            grpBievenido = new GroupBox();
            btnGerencia = new MaterialSkin.Controls.MaterialButton();
            btnAdmin = new MaterialSkin.Controls.MaterialButton();
            grpLogin = new GroupBox();
            lblMessage = new Label();
            btnVolver = new MaterialSkin.Controls.MaterialFloatingActionButton();
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            grpBievenido.SuspendLayout();
            grpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // grpBievenido
            // 
            grpBievenido.BackgroundImage = Properties.Resources.fondoSistema;
            grpBievenido.BackgroundImageLayout = ImageLayout.Stretch;
            grpBievenido.Controls.Add(btnGerencia);
            grpBievenido.Controls.Add(btnAdmin);
            grpBievenido.Location = new Point(35, 68);
            grpBievenido.Name = "grpBievenido";
            grpBievenido.Size = new Size(548, 501);
            grpBievenido.TabIndex = 0;
            grpBievenido.TabStop = false;
            // 
            // btnGerencia
            // 
            btnGerencia.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGerencia.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGerencia.Depth = 0;
            btnGerencia.HighEmphasis = true;
            btnGerencia.Icon = null;
            btnGerencia.Location = new Point(203, 370);
            btnGerencia.Margin = new Padding(4, 6, 4, 6);
            btnGerencia.MouseState = MaterialSkin.MouseState.HOVER;
            btnGerencia.Name = "btnGerencia";
            btnGerencia.NoAccentTextColor = Color.Empty;
            btnGerencia.Size = new Size(138, 36);
            btnGerencia.TabIndex = 1;
            btnGerencia.Text = "LOGIN GERENCIA";
            btnGerencia.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGerencia.UseAccentColor = false;
            btnGerencia.UseVisualStyleBackColor = true;
            btnGerencia.Click += btnGerencia_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.AutoSize = false;
            btnAdmin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdmin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdmin.Depth = 0;
            btnAdmin.HighEmphasis = true;
            btnAdmin.Icon = null;
            btnAdmin.Location = new Point(203, 322);
            btnAdmin.Margin = new Padding(4, 6, 4, 6);
            btnAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdmin.Name = "btnAdmin";
            btnAdmin.NoAccentTextColor = Color.Empty;
            btnAdmin.Size = new Size(138, 36);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "LOGIN ADMIN";
            btnAdmin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdmin.UseAccentColor = false;
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // grpLogin
            // 
            grpLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpLogin.Controls.Add(lblMessage);
            grpLogin.Controls.Add(btnVolver);
            grpLogin.Controls.Add(btnLogin);
            grpLogin.Controls.Add(txtPassword);
            grpLogin.Controls.Add(txtUsuario);
            grpLogin.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            grpLogin.Location = new Point(6, 68);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(611, 502);
            grpLogin.TabIndex = 2;
            grpLogin.TabStop = false;
            grpLogin.Visible = false;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(127, 35);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(52, 17);
            lblMessage.TabIndex = 6;
            lblMessage.Text = "label1";
            // 
            // btnVolver
            // 
            btnVolver.Depth = 0;
            btnVolver.Icon = Properties.Resources.btnBack;
            btnVolver.Location = new Point(119, 95);
            btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(60, 60);
            btnVolver.TabIndex = 4;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnLogin
            // 
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.Location = new Point(261, 321);
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
            txtPassword.Location = new Point(203, 248);
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
            txtUsuario.Location = new Point(203, 185);
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
            Controls.Add(grpBievenido);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            grpBievenido.ResumeLayout(false);
            grpBievenido.PerformLayout();
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBievenido;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialButton btnGerencia;
        private MaterialSkin.Controls.MaterialButton btnAdmin;
        private GroupBox grpLogin;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnVolver;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private Label lblMessage;
    }
}