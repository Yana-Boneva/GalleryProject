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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(513, 44);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 30;
            label7.Text = "Image";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(451, 78);
            pictureBox1.Margin = new Padding(1, 1, 1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(6, 227);
            textBoxNotes.Margin = new Padding(1, 1, 1, 1);
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
            label5.Location = new Point(6, 188);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 27;
            label5.Text = "Notes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 160);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 24;
            label4.Text = "Date of death";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 130);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 23;
            label3.Text = "Date of birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 98);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 21;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 65);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 20;
            label1.Text = "First Name";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(146, 65);
            labelFirstName.Margin = new Padding(1, 0, 1, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(80, 20);
            labelFirstName.TabIndex = 31;
            labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(146, 98);
            labelLastName.Margin = new Padding(1, 0, 1, 0);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(79, 20);
            labelLastName.TabIndex = 32;
            labelLastName.Text = "Last Name";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(146, 130);
            labelDateOfBirth.Margin = new Padding(1, 0, 1, 0);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(94, 20);
            labelDateOfBirth.TabIndex = 33;
            labelDateOfBirth.Text = "Date of Birth";
            // 
            // labelDateOfDeath
            // 
            labelDateOfDeath.AutoSize = true;
            labelDateOfDeath.Location = new Point(146, 160);
            labelDateOfDeath.Margin = new Padding(1, 0, 1, 0);
            labelDateOfDeath.Name = "labelDateOfDeath";
            labelDateOfDeath.Size = new Size(101, 20);
            labelDateOfDeath.TabIndex = 34;
            labelDateOfDeath.Text = "Date of death";
            // 
            // PainterViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 439);
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
            Margin = new Padding(1, 1, 1, 1);
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
    }
}