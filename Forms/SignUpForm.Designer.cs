namespace GalleryProject
{
    partial class SignUpForm
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
            buttonCreateUser = new Button();
            label3 = new Label();
            label4 = new Label();
            textBoxConfirmPassword = new TextBox();
            textBoxEmail = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 25);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 197);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 41);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(344, 22);
            textBoxName.Margin = new Padding(7, 8, 7, 8);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(400, 47);
            textBoxName.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(344, 194);
            textBoxPassword.Margin = new Padding(7, 8, 7, 8);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(400, 47);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.Location = new Point(562, 361);
            buttonCreateUser.Margin = new Padding(7, 8, 7, 8);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(182, 63);
            buttonCreateUser.TabIndex = 10;
            buttonCreateUser.Text = "Create User";
            buttonCreateUser.UseVisualStyleBackColor = true;
            buttonCreateUser.Click += ButtonCreateUser_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 104);
            label3.Name = "label3";
            label3.Size = new Size(89, 41);
            label3.TabIndex = 6;
            label3.Text = "email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 278);
            label4.Name = "label4";
            label4.Size = new Size(259, 41);
            label4.TabIndex = 7;
            label4.Text = "Confirm password";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(344, 275);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(400, 47);
            textBoxConfirmPassword.TabIndex = 9;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(344, 101);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(400, 47);
            textBoxEmail.TabIndex = 3;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 451);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonCreateUser);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "SignUpForm";
            Text = "Sign up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private Button buttonCreateUser;
        private Label label3;
        private Label label4;
        private TextBox textBoxConfirmPassword;
        private TextBox textBoxEmail;
    }
}
