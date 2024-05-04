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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            labelName = new Label();
            labelPassword = new Label();
            textBoxName = new TextBox();
            textBoxPassword = new TextBox();
            buttonCreateUser = new Button();
            labelEmail = new Label();
            label4 = new Label();
            textBoxConfirmPassword = new TextBox();
            textBoxEmail = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Cursor = Cursors.Hand;
            labelName.FlatStyle = FlatStyle.Popup;
            labelName.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(402, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(69, 26);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            labelName.Click += labelName_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(402, 149);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(97, 26);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Password:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(413, 45);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(190, 27);
            textBoxName.TabIndex = 2;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(413, 179);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(190, 27);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.BackgroundImage = (Image)resources.GetObject("buttonCreateUser.BackgroundImage");
            buttonCreateUser.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCreateUser.Font = new Font("Trebuchet MS", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonCreateUser.Location = new Point(481, 296);
            buttonCreateUser.Margin = new Padding(3, 4, 3, 4);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(47, 41);
            buttonCreateUser.TabIndex = 10;
            buttonCreateUser.UseVisualStyleBackColor = true;
            buttonCreateUser.Click += ButtonCreateUser_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(402, 76);
            labelEmail.Margin = new Padding(1, 0, 1, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(69, 26);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(402, 223);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(174, 26);
            label4.TabIndex = 7;
            label4.Text = "Confirm password:";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(413, 259);
            textBoxConfirmPassword.Margin = new Padding(1);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(190, 27);
            textBoxConfirmPassword.TabIndex = 9;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(413, 112);
            textBoxEmail.Margin = new Padding(1);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(190, 27);
            textBoxEmail.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 263);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LavenderBlush;
            label1.Font = new Font("Ink Free", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(53, 259);
            label1.Name = "label1";
            label1.Size = new Size(254, 25);
            label1.TabIndex = 12;
            label1.Text = "Petal and Palette Gallery";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(667, 364);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(label4);
            Controls.Add(labelEmail);
            Controls.Add(buttonCreateUser);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Controls.Add(labelPassword);
            Controls.Add(labelName);
            ForeColor = Color.Black;
            Margin = new Padding(1);
            Name = "SignUpForm";
            Text = "Sign up";
            Load += SignUpForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelPassword;
        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private Button buttonCreateUser;
        private Label labelEmail;
        private Label label4;
        private TextBox textBoxConfirmPassword;
        private TextBox textBoxEmail;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
