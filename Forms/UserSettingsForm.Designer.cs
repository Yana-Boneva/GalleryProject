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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettingsForm));
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
            textBoxEmail.Location = new Point(186, 145);
            textBoxEmail.Margin = new Padding(1, 1, 1, 1);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(190, 27);
            textBoxEmail.TabIndex = 13;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(186, 232);
            textBoxConfirmPassword.Margin = new Padding(1, 1, 1, 1);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(190, 27);
            textBoxConfirmPassword.TabIndex = 17;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 232);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(174, 26);
            label4.TabIndex = 15;
            label4.Text = "Confirm password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 146);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 26);
            label3.TabIndex = 14;
            label3.Text = "Email:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(186, 187);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(190, 27);
            textBoxPassword.TabIndex = 16;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(186, 104);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(190, 27);
            textBoxName.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 188);
            label2.Name = "label2";
            label2.Size = new Size(97, 26);
            label2.TabIndex = 11;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 105);
            label1.Name = "label1";
            label1.Size = new Size(69, 26);
            label1.TabIndex = 10;
            label1.Text = "Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(445, 96);
            pictureBox1.Margin = new Padding(1, 1, 1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.DoubleClick += PictureBox1_DoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(493, 53);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 26);
            label7.TabIndex = 19;
            label7.Text = "Image";
            // 
            // buttonSave
            // 
            buttonSave.BackgroundImage = (Image)resources.GetObject("buttonSave.BackgroundImage");
            buttonSave.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSave.Location = new Point(492, 301);
            buttonSave.Margin = new Padding(1, 1, 1, 1);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(68, 56);
            buttonSave.TabIndex = 20;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // UserSettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(663, 395);
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
            Margin = new Padding(1, 1, 1, 1);
            Name = "UserSettingsForm";
            Text = "User Settings";
            Load += UserSettingsForm_Load;
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