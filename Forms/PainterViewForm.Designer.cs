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
            label7.Location = new Point(845, 83);
            label7.Name = "label7";
            label7.Size = new Size(101, 41);
            label7.TabIndex = 30;
            label7.Text = "Image";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(704, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(12, 466);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.ReadOnly = true;
            textBoxNotes.ScrollBars = ScrollBars.Both;
            textBoxNotes.Size = new Size(1089, 240);
            textBoxNotes.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 385);
            label5.Name = "label5";
            label5.Size = new Size(97, 41);
            label5.TabIndex = 27;
            label5.Text = "Notes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 328);
            label4.Name = "label4";
            label4.Size = new Size(199, 41);
            label4.TabIndex = 24;
            label4.Text = "Date of death";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 267);
            label3.Name = "label3";
            label3.Size = new Size(185, 41);
            label3.TabIndex = 23;
            label3.Text = "Date of birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 200);
            label2.Name = "label2";
            label2.Size = new Size(157, 41);
            label2.TabIndex = 21;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 133);
            label1.Name = "label1";
            label1.Size = new Size(160, 41);
            label1.TabIndex = 20;
            label1.Text = "First Name";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(310, 133);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(160, 41);
            labelFirstName.TabIndex = 31;
            labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(310, 200);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(157, 41);
            labelLastName.TabIndex = 32;
            labelLastName.Text = "Last Name";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(310, 267);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(184, 41);
            labelDateOfBirth.TabIndex = 33;
            labelDateOfBirth.Text = "Date of Birth";
            // 
            // labelDateOfDeath
            // 
            labelDateOfDeath.AutoSize = true;
            labelDateOfDeath.Location = new Point(310, 328);
            labelDateOfDeath.Name = "labelDateOfDeath";
            labelDateOfDeath.Size = new Size(199, 41);
            labelDateOfDeath.TabIndex = 34;
            labelDateOfDeath.Text = "Date of death";
            // 
            // PainterViewForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 780);
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