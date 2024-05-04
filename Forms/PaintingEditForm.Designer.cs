namespace GalleryProject.Forms
{
    partial class PaintingEditForm
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
            textBoxName = new TextBox();
            label1 = new Label();
            buttonInsert = new Button();
            comboBoxPainter = new ComboBox();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            label4 = new Label();
            dateTimeDate = new DateTimePicker();
            label5 = new Label();
            textBoxNotes = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label2 = new Label();
            comboBoxStyle = new ComboBox();
            label3 = new Label();
            comboBoxPainting = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(248, 111);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(450, 47);
            textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 1;
            label1.Text = "Name";
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
            comboBoxPainter.Location = new Point(248, 181);
            comboBoxPainter.Name = "comboBoxPainter";
            comboBoxPainter.Size = new Size(450, 49);
            comboBoxPainter.TabIndex = 5;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 306);
            label4.Name = "label4";
            label4.Size = new Size(80, 41);
            label4.TabIndex = 11;
            label4.Text = "Date";
            // 
            // dateTimeDate
            // 
            dateTimeDate.Format = DateTimePickerFormat.Short;
            dateTimeDate.Location = new Point(248, 306);
            dateTimeDate.Name = "dateTimeDate";
            dateTimeDate.ShowCheckBox = true;
            dateTimeDate.Size = new Size(450, 47);
            dateTimeDate.TabIndex = 13;
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
            label6.Location = new Point(12, 184);
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
            pictureBox1.DoubleClick += PictureBox1_DoubleClick;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 250);
            label2.Name = "label2";
            label2.Size = new Size(81, 41);
            label2.TabIndex = 19;
            label2.Text = "Style";
            // 
            // comboBoxStyle
            // 
            comboBoxStyle.FormattingEnabled = true;
            comboBoxStyle.Location = new Point(248, 247);
            comboBoxStyle.Name = "comboBoxStyle";
            comboBoxStyle.Size = new Size(450, 49);
            comboBoxStyle.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 22);
            label3.Name = "label3";
            label3.Size = new Size(125, 41);
            label3.TabIndex = 21;
            label3.Text = "Painting";
            // 
            // comboBoxPainting
            // 
            comboBoxPainting.FormattingEnabled = true;
            comboBoxPainting.Location = new Point(248, 19);
            comboBoxPainting.Name = "comboBoxPainting";
            comboBoxPainting.Size = new Size(450, 49);
            comboBoxPainting.TabIndex = 22;
            comboBoxPainting.SelectedIndexChanged += ComboBoxPainting_SelectedIndexChanged;
            // 
            // PaintingEditForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 780);
            Controls.Add(comboBoxPainting);
            Controls.Add(label3);
            Controls.Add(comboBoxStyle);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(textBoxNotes);
            Controls.Add(label5);
            Controls.Add(dateTimeDate);
            Controls.Add(label4);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(comboBoxPainter);
            Controls.Add(buttonInsert);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Name = "PaintingEditForm";
            Text = "Painting Edit Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private Button buttonInsert;
        private ComboBox comboBoxPainter;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Label label4;
        private DateTimePicker dateTimeDate;
        private Label label5;
        private TextBox textBoxNotes;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label2;
        private ComboBox comboBoxStyle;
        private Label label3;
        private ComboBox comboBoxPainting;
    }
}