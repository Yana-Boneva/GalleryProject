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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainterEditForm));
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
            textBoxFirstName.Location = new Point(225, 64);
            textBoxFirstName.Margin = new Padding(1, 1, 1, 1);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(214, 27);
            textBoxFirstName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 64);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 26);
            label1.TabIndex = 1;
            label1.Text = "First Name:";
            // 
            // buttonInsert
            // 
            buttonInsert.BackColor = Color.Thistle;
            buttonInsert.BackgroundImage = (Image)resources.GetObject("buttonInsert.BackgroundImage");
            buttonInsert.BackgroundImageLayout = ImageLayout.Stretch;
            buttonInsert.Location = new Point(65, 370);
            buttonInsert.Margin = new Padding(1, 1, 1, 1);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(54, 49);
            buttonInsert.TabIndex = 4;
            buttonInsert.UseVisualStyleBackColor = false;
            buttonInsert.Click += ButtonInsert_Click;
            // 
            // comboBoxPainter
            // 
            comboBoxPainter.FormattingEnabled = true;
            comboBoxPainter.Location = new Point(225, 26);
            comboBoxPainter.Margin = new Padding(1, 1, 1, 1);
            comboBoxPainter.Name = "comboBoxPainter";
            comboBoxPainter.Size = new Size(214, 28);
            comboBoxPainter.TabIndex = 5;
            comboBoxPainter.SelectedIndexChanged += ComboBoxPainter_SelectedIndexChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.BackgroundImage = (Image)resources.GetObject("buttonDelete.BackgroundImage");
            buttonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDelete.Location = new Point(662, 370);
            buttonDelete.Margin = new Padding(1, 1, 1, 1);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(54, 49);
            buttonDelete.TabIndex = 6;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackgroundImage = (Image)resources.GetObject("buttonUpdate.BackgroundImage");
            buttonUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            buttonUpdate.Location = new Point(368, 370);
            buttonUpdate.Margin = new Padding(1, 1, 1, 1);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(49, 49);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 101);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 26);
            label2.TabIndex = 8;
            label2.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(225, 102);
            textBoxLastName.Margin = new Padding(1, 1, 1, 1);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(214, 27);
            textBoxLastName.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 142);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 26);
            label3.TabIndex = 10;
            label3.Text = "Date of birth:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 182);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 26);
            label4.TabIndex = 11;
            label4.Text = "Date of death:";
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Format = DateTimePickerFormat.Short;
            dateTimePickerBirth.Location = new Point(225, 142);
            dateTimePickerBirth.Margin = new Padding(1, 1, 1, 1);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(214, 27);
            dateTimePickerBirth.TabIndex = 12;
            // 
            // dateTimePickerDeath
            // 
            dateTimePickerDeath.Format = DateTimePickerFormat.Short;
            dateTimePickerDeath.Location = new Point(225, 182);
            dateTimePickerDeath.Margin = new Padding(1, 1, 1, 1);
            dateTimePickerDeath.Name = "dateTimePickerDeath";
            dateTimePickerDeath.ShowCheckBox = true;
            dateTimePickerDeath.Size = new Size(214, 27);
            dateTimePickerDeath.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(38, 234);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 26);
            label5.TabIndex = 14;
            label5.Text = "Notes:";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(135, 234);
            textBoxNotes.Margin = new Padding(1, 1, 1, 1);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.ScrollBars = ScrollBars.Both;
            textBoxNotes.Size = new Size(515, 119);
            textBoxNotes.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(38, 26);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 26);
            label6.TabIndex = 16;
            label6.Text = "Painter:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(528, 75);
            pictureBox1.Margin = new Padding(1, 1, 1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += pictureBox1_DoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(578, 26);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 26);
            label7.TabIndex = 18;
            label7.Text = "Image:";
            // 
            // PainterEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(788, 429);
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
            Margin = new Padding(1, 1, 1, 1);
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