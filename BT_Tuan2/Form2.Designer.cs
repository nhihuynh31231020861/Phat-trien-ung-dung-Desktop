namespace BT_Tuan2
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private ErrorProvider errorProvider1;
        private ToolTip toolTip1;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(50, 37);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(153, 27);
            txtUsername.TabIndex = 0;
            toolTip1.SetToolTip(txtUsername, "Tài khoản mặc định: admin");
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(50, 70);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(153, 27);
            txtPassword.TabIndex = 1;
            toolTip1.SetToolTip(txtPassword, "Mật khẩu mặc định: 123");
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(89, 103);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormLogin
            // 
            ClientSize = new Size(263, 187);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Name = "FormLogin";
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>


        #endregion
    }
}