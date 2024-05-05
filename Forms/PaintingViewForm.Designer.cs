namespace GalleryProject.Forms
{
    partial class PaintingViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintingViewForm));
            labelDate = new Label();
            label5 = new Label();
            textBoxNotes = new TextBox();
            pictureBox1 = new PictureBox();
            labelName = new Label();
            checkBoxFavorite = new CheckBox();
            linkLabelPainter = new LinkLabel();
            linkLabelStyle = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.BackColor = Color.Transparent;
            labelDate.Location = new Point(58, 411);
            labelDate.Margin = new Padding(1, 0, 1, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(401, 20);
            labelDate.TabIndex = 11;
            labelDate.Text = "Created";
            labelDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(6, 460);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 26);
            label5.TabIndex = 14;
            label5.Text = "Notes:";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(10, 502);
            textBoxNotes.Margin = new Padding(1);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.ScrollBars = ScrollBars.Both;
            textBoxNotes.Size = new Size(515, 119);
            textBoxNotes.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(119, 57);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 293);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelName.ForeColor = Color.Maroon;
            labelName.Location = new Point(58, 27);
            labelName.Margin = new Padding(1, 0, 1, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(401, 29);
            labelName.TabIndex = 21;
            labelName.Text = "Painting Name:";
            labelName.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkBoxFavorite
            // 
            checkBoxFavorite.AutoSize = true;
            checkBoxFavorite.BackColor = Color.Transparent;
            checkBoxFavorite.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxFavorite.ForeColor = Color.Maroon;
            checkBoxFavorite.Location = new Point(404, 328);
            checkBoxFavorite.Margin = new Padding(1);
            checkBoxFavorite.Name = "checkBoxFavorite";
            checkBoxFavorite.Size = new Size(105, 30);
            checkBoxFavorite.TabIndex = 15;
            checkBoxFavorite.Text = "Favorite";
            checkBoxFavorite.UseVisualStyleBackColor = false;
            checkBoxFavorite.CheckedChanged += CheckBoxFavorite_CheckedChanged;
            // 
            // linkLabelPainter
            // 
            linkLabelPainter.BackColor = Color.Transparent;
            linkLabelPainter.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabelPainter.Location = new Point(58, 370);
            linkLabelPainter.Margin = new Padding(1, 0, 1, 0);
            linkLabelPainter.Name = "linkLabelPainter";
            linkLabelPainter.Size = new Size(401, 29);
            linkLabelPainter.TabIndex = 23;
            linkLabelPainter.TabStop = true;
            linkLabelPainter.Text = "Painter";
            linkLabelPainter.TextAlign = ContentAlignment.MiddleCenter;
            linkLabelPainter.Click += LinkLabelPainter_Click;
            // 
            // linkLabelStyle
            // 
            linkLabelStyle.BackColor = Color.Transparent;
            linkLabelStyle.Location = new Point(58, 431);
            linkLabelStyle.Margin = new Padding(1, 0, 1, 0);
            linkLabelStyle.Name = "linkLabelStyle";
            linkLabelStyle.Size = new Size(401, 29);
            linkLabelStyle.TabIndex = 24;
            linkLabelStyle.TabStop = true;
            linkLabelStyle.Text = "Style";
            linkLabelStyle.TextAlign = ContentAlignment.MiddleCenter;
            linkLabelStyle.LinkClicked += linkLabelStyle_LinkClicked;
            // 
            // PaintingViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(553, 654);
            Controls.Add(linkLabelStyle);
            Controls.Add(linkLabelPainter);
            Controls.Add(checkBoxFavorite);
            Controls.Add(labelName);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxNotes);
            Controls.Add(label5);
            Controls.Add(labelDate);
            Margin = new Padding(1);
            Name = "PaintingViewForm";
            Text = "Painting Details";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPainter;
        private Label labelDate;
        private Label label5;
        private TextBox textBoxNotes;
        private PictureBox pictureBox1;
        private Label labelName;
        private CheckBox checkBoxFavorite;
        private LinkLabel linkLabelPainter;
        private LinkLabel linkLabelStyle;
    }
}