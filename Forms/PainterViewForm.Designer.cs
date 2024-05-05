namespace GalleryProject.Forms
{
    partial class PainterViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainterViewForm));
            label7 = new Label();
            pictureBox1 = new PictureBox();
            textBoxNotes = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelDateOfBirth = new Label();
            labelDateOfDeath = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(504, 69);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 26);
            label7.TabIndex = 30;
            label7.Text = "Image:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(438, 111);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(84, 259);
            textBoxNotes.Margin = new Padding(1);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.ReadOnly = true;
            textBoxNotes.ScrollBars = ScrollBars.Both;
            textBoxNotes.Size = new Size(515, 119);
            textBoxNotes.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 259);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 26);
            label5.TabIndex = 27;
            label5.Text = "Notes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 196);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 26);
            label4.TabIndex = 24;
            label4.Text = "Date of death:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 170);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 26);
            label3.TabIndex = 23;
            label3.Text = "Date of birth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 144);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 26);
            label2.TabIndex = 21;
            label2.Text = "Last name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 117);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 26);
            label1.TabIndex = 20;
            label1.Text = "First name:";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.Transparent;
            labelFirstName.Location = new Point(161, 121);
            labelFirstName.Margin = new Padding(1, 0, 1, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(80, 20);
            labelFirstName.TabIndex = 31;
            labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.BackColor = Color.Transparent;
            labelLastName.Location = new Point(161, 148);
            labelLastName.Margin = new Padding(1, 0, 1, 0);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(79, 20);
            labelLastName.TabIndex = 32;
            labelLastName.Text = "Last Name";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.BackColor = Color.Transparent;
            labelDateOfBirth.Location = new Point(161, 176);
            labelDateOfBirth.Margin = new Padding(1, 0, 1, 0);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(94, 20);
            labelDateOfBirth.TabIndex = 33;
            labelDateOfBirth.Text = "Date of Birth";
            // 
            // labelDateOfDeath
            // 
            labelDateOfDeath.AutoSize = true;
            labelDateOfDeath.BackColor = Color.Transparent;
            labelDateOfDeath.Location = new Point(161, 200);
            labelDateOfDeath.Margin = new Padding(1, 0, 1, 0);
            labelDateOfDeath.Name = "labelDateOfDeath";
            labelDateOfDeath.Size = new Size(101, 20);
            labelDateOfDeath.TabIndex = 34;
            labelDateOfDeath.Text = "Date of death";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(132, 9);
            label6.Name = "label6";
            label6.Size = new Size(368, 70);
            label6.TabIndex = 35;
            label6.Text = "Curious about a certain painter? \r\nHere you can find some basic info...";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PainterViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(703, 439);
            Controls.Add(label6);
            Controls.Add(labelDateOfDeath);
            Controls.Add(labelDateOfBirth);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxNotes);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(1);
            Name = "PainterViewForm";
            Text = "Painter Info";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private PictureBox pictureBox1;
        private TextBox textBoxNotes;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelDateOfBirth;
        private Label labelDateOfDeath;
        private Label label6;
    }
}