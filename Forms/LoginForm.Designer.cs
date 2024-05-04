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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonSignUp = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(111, 165);
            label1.Name = "label1";
            label1.Size = new Size(156, 26);
            label1.TabIndex = 0;
            label1.Text = "Name / Email: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(111, 204);
            label2.Name = "label2";
            label2.Size = new Size(106, 26);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.PaleVioletRed;
            textBoxName.Location = new Point(292, 164);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(190, 27);
            textBoxName.TabIndex = 2;
            textBoxName.Text = "admin@gmail.com";
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.PaleVioletRed;
            textBoxPassword.Location = new Point(292, 205);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(190, 27);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.Text = "Alabala1!";
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.PaleVioletRed;
            buttonLogin.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(139, 283);
            buttonLogin.Margin = new Padding(3, 4, 3, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(131, 42);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.PaleVioletRed;
            buttonSignUp.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSignUp.Location = new Point(381, 279);
            buttonSignUp.Margin = new Padding(3, 4, 3, 4);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(144, 46);
            buttonSignUp.TabIndex = 5;
            buttonSignUp.Text = "Sign up?";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += ButtonSignUp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LavenderBlush;
            label3.Location = new Point(154, 19);
            label3.Name = "label3";
            label3.Size = new Size(144, 26);
            label3.TabIndex = 6;
            label3.Text = "Welcome to...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PaleVioletRed;
            label4.Font = new Font("Ink Free", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LavenderBlush;
            label4.Location = new Point(154, 55);
            label4.Name = "label4";
            label4.Size = new Size(371, 34);
            label4.TabIndex = 7;
            label4.Text = "Petal and Palette Gallery   ";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(666, 376);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonSignUp);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(1);
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
        private Label label3;
        private Label label4;
    }
}
