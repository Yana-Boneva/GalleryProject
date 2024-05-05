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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintingEditForm));
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
            textBoxName.Location = new Point(130, 88);
            textBoxName.Margin = new Padding(1);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(214, 27);
            textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 89);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 26);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // buttonInsert
            // 
            buttonInsert.BackgroundImage = (Image)resources.GetObject("buttonInsert.BackgroundImage");
            buttonInsert.BackgroundImageLayout = ImageLayout.Stretch;
            buttonInsert.Location = new Point(695, 208);
            buttonInsert.Margin = new Padding(1);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(47, 48);
            buttonInsert.TabIndex = 4;
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += ButtonInsert_Click;
            // 
            // comboBoxPainter
            // 
            comboBoxPainter.FormattingEnabled = true;
            comboBoxPainter.Location = new Point(130, 127);
            comboBoxPainter.Margin = new Padding(1);
            comboBoxPainter.Name = "comboBoxPainter";
            comboBoxPainter.Size = new Size(214, 28);
            comboBoxPainter.TabIndex = 5;
            // 
            // buttonDelete
            // 
            buttonDelete.BackgroundImage = (Image)resources.GetObject("buttonDelete.BackgroundImage");
            buttonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDelete.Location = new Point(697, 329);
            buttonDelete.Margin = new Padding(1);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(45, 44);
            buttonDelete.TabIndex = 6;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackgroundImage = (Image)resources.GetObject("buttonUpdate.BackgroundImage");
            buttonUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            buttonUpdate.Location = new Point(697, 268);
            buttonUpdate.Margin = new Padding(1);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(45, 44);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 210);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 26);
            label4.TabIndex = 11;
            label4.Text = "Date:";
            // 
            // dateTimeDate
            // 
            dateTimeDate.Format = DateTimePickerFormat.Short;
            dateTimeDate.Location = new Point(130, 210);
            dateTimeDate.Margin = new Padding(1);
            dateTimeDate.Name = "dateTimeDate";
            dateTimeDate.ShowCheckBox = true;
            dateTimeDate.Size = new Size(214, 27);
            dateTimeDate.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 255);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 26);
            label5.TabIndex = 14;
            label5.Text = "Notes:";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(130, 256);
            textBoxNotes.Margin = new Padding(1);
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
            label6.Location = new Point(16, 129);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 26);
            label6.TabIndex = 16;
            label6.Text = "Painter:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(465, 75);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += PictureBox1_DoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(465, 31);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 26);
            label7.TabIndex = 18;
            label7.Text = "Image:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 168);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 26);
            label2.TabIndex = 19;
            label2.Text = "Style:";
            // 
            // comboBoxStyle
            // 
            comboBoxStyle.FormattingEnabled = true;
            comboBoxStyle.Location = new Point(130, 168);
            comboBoxStyle.Margin = new Padding(1);
            comboBoxStyle.Name = "comboBoxStyle";
            comboBoxStyle.Size = new Size(214, 28);
            comboBoxStyle.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 41);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 26);
            label3.TabIndex = 21;
            label3.Text = "Painting:";
            // 
            // comboBoxPainting
            // 
            comboBoxPainting.FormattingEnabled = true;
            comboBoxPainting.Location = new Point(130, 42);
            comboBoxPainting.Margin = new Padding(1);
            comboBoxPainting.Name = "comboBoxPainting";
            comboBoxPainting.Size = new Size(214, 28);
            comboBoxPainting.TabIndex = 22;
            comboBoxPainting.SelectedIndexChanged += ComboBoxPainting_SelectedIndexChanged;
            // 
            // PaintingEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(773, 391);
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
            Margin = new Padding(1);
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