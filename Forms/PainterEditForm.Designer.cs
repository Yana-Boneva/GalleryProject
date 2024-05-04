namespace GalleryProject.Forms
{
    partial class PainterEditForm
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
            textBoxFirstName = new TextBox();
            label1 = new Label();
            buttonInsert = new Button();
            comboBoxPainter = new ComboBox();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            label2 = new Label();
            textBoxLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimePickerBirth = new DateTimePicker();
            dateTimePickerDeath = new DateTimePicker();
            label5 = new Label();
            textBoxNotes = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(248, 111);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(450, 47);
            textBoxFirstName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(160, 41);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(12, 710);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(188, 58);
            buttonInsert.TabIndex = 4;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += ButtonInsert_Click;
            // 
            // comboBoxPainter
            // 
            comboBoxPainter.FormattingEnabled = true;
            comboBoxPainter.Location = new Point(248, 20);
            comboBoxPainter.Name = "comboBoxPainter";
            comboBoxPainter.Size = new Size(450, 49);
            comboBoxPainter.TabIndex = 5;
            comboBoxPainter.SelectedIndexChanged += ComboBoxPainter_SelectedIndexChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(525, 710);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(188, 58);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(282, 710);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(188, 58);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 178);
            label2.Name = "label2";
            label2.Size = new Size(157, 41);
            label2.TabIndex = 8;
            label2.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(248, 175);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(450, 47);
            textBoxLastName.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 245);
            label3.Name = "label3";
            label3.Size = new Size(185, 41);
            label3.TabIndex = 10;
            label3.Text = "Date of birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 306);
            label4.Name = "label4";
            label4.Size = new Size(199, 41);
            label4.TabIndex = 11;
            label4.Text = "Date of death";
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Format = DateTimePickerFormat.Short;
            dateTimePickerBirth.Location = new Point(248, 240);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(450, 47);
            dateTimePickerBirth.TabIndex = 12;
            // 
            // dateTimePickerDeath
            // 
            dateTimePickerDeath.Format = DateTimePickerFormat.Short;
            dateTimePickerDeath.Location = new Point(248, 306);
            dateTimePickerDeath.Name = "dateTimePickerDeath";
            dateTimePickerDeath.ShowCheckBox = true;
            dateTimePickerDeath.Size = new Size(450, 47);
            dateTimePickerDeath.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 363);
            label5.Name = "label5";
            label5.Size = new Size(97, 41);
            label5.TabIndex = 14;
            label5.Text = "Notes";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(12, 435);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.ScrollBars = ScrollBars.Both;
            textBoxNotes.Size = new Size(1089, 240);
            textBoxNotes.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 23);
            label6.Name = "label6";
            label6.Size = new Size(109, 41);
            label6.TabIndex = 16;
            label6.Text = "Painter";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(704, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += pictureBox1_DoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(845, 61);
            label7.Name = "label7";
            label7.Size = new Size(101, 41);
            label7.TabIndex = 18;
            label7.Text = "Image";
            // 
            // PainterEditForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 780);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(textBoxNotes);
            Controls.Add(label5);
            Controls.Add(dateTimePickerDeath);
            Controls.Add(dateTimePickerBirth);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxLastName);
            Controls.Add(label2);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(comboBoxPainter);
            Controls.Add(buttonInsert);
            Controls.Add(label1);
            Controls.Add(textBoxFirstName);
            Name = "PainterEditForm";
            Text = "Painter Edit Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstName;
        private Label label1;
        private Button buttonInsert;
        private ComboBox comboBoxPainter;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Label label2;
        private TextBox textBoxLastName;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePickerBirth;
        private DateTimePicker dateTimePickerDeath;
        private Label label5;
        private TextBox textBoxNotes;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
    }
}