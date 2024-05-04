namespace GalleryProject
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonSignUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 97);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 41);
            label1.TabIndex = 0;
            label1.Text = "Name / email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 176);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 41);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(323, 88);
            textBoxName.Margin = new Padding(7, 8, 7, 8);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(400, 47);
            textBoxName.TabIndex = 2;
            textBoxName.Text = "admin@gmail.com";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(323, 168);
            textBoxPassword.Margin = new Padding(7, 8, 7, 8);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(400, 47);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.Text = "Alabala1!";
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(198, 328);
            buttonLogin.Margin = new Padding(7, 8, 7, 8);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(182, 63);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(395, 328);
            buttonSignUp.Margin = new Padding(7, 8, 7, 8);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(182, 63);
            buttonSignUp.TabIndex = 5;
            buttonSignUp.Text = "Sign up";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += ButtonSignUp_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 451);
            Controls.Add(buttonSignUp);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonSignUp;
    }
}
