namespace GalleryProject.Forms
{
    partial class UserSettingsForm
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
            textBoxEmail = new TextBox();
            textBoxConfirmPassword = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBoxPassword = new TextBox();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(43, 172);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(400, 47);
            textBoxEmail.TabIndex = 13;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(43, 370);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(400, 47);
            textBoxConfirmPassword.TabIndex = 17;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 326);
            label4.Name = "label4";
            label4.Size = new Size(259, 41);
            label4.TabIndex = 15;
            label4.Text = "Confirm password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 128);
            label3.Name = "label3";
            label3.Size = new Size(89, 41);
            label3.TabIndex = 14;
            label3.Text = "email";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(43, 271);
            textBoxPassword.Margin = new Padding(7, 8, 7, 8);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(400, 47);
            textBoxPassword.TabIndex = 16;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(43, 73);
            textBoxName.Margin = new Padding(7, 8, 7, 8);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(400, 47);
            textBoxName.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 222);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 41);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 24);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(504, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += PictureBox1_DoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(574, 24);
            label7.Name = "label7";
            label7.Size = new Size(101, 41);
            label7.TabIndex = 19;
            label7.Text = "Image";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(528, 359);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(188, 58);
            buttonSave.TabIndex = 20;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // UserSettingsForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserSettingsForm";
            Text = "User Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmail;
        private TextBox textBoxConfirmPassword;
        private Label label4;
        private Label label3;
        private TextBox textBoxPassword;
        private TextBox textBoxName;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label7;
        private Button buttonSave;
    }
}