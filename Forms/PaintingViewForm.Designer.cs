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
            labelDate.Location = new Point(123, 818);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(852, 41);
            labelDate.TabIndex = 11;
            labelDate.Text = "Created";
            labelDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 944);
            label5.Name = "label5";
            label5.Size = new Size(104, 41);
            label5.TabIndex = 14;
            label5.Text = "Notes:";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(12, 1006);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.ScrollBars = ScrollBars.Both;
            textBoxNotes.Size = new Size(1089, 240);
            textBoxNotes.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(252, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(123, 25);
            labelName.Name = "labelName";
            labelName.Size = new Size(852, 60);
            labelName.TabIndex = 21;
            labelName.Text = "Painting Name";
            labelName.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkBoxFavorite
            // 
            checkBoxFavorite.AutoSize = true;
            checkBoxFavorite.Location = new Point(858, 672);
            checkBoxFavorite.Name = "checkBoxFavorite";
            checkBoxFavorite.Size = new Size(160, 45);
            checkBoxFavorite.TabIndex = 15;
            checkBoxFavorite.Text = "Favorite";
            checkBoxFavorite.UseVisualStyleBackColor = true;
            checkBoxFavorite.CheckedChanged += CheckBoxFavorite_CheckedChanged;
            // 
            // linkLabelPainter
            // 
            linkLabelPainter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelPainter.Location = new Point(123, 731);
            linkLabelPainter.Name = "linkLabelPainter";
            linkLabelPainter.Size = new Size(852, 60);
            linkLabelPainter.TabIndex = 23;
            linkLabelPainter.TabStop = true;
            linkLabelPainter.Text = "Painter";
            linkLabelPainter.TextAlign = ContentAlignment.MiddleCenter;
            linkLabelPainter.Click += LinkLabelPainter_Click;
            // 
            // linkLabelStyle
            // 
            linkLabelStyle.Location = new Point(123, 859);
            linkLabelStyle.Name = "linkLabelStyle";
            linkLabelStyle.Size = new Size(852, 60);
            linkLabelStyle.TabIndex = 24;
            linkLabelStyle.TabStop = true;
            linkLabelStyle.Text = "Style";
            linkLabelStyle.TextAlign = ContentAlignment.MiddleCenter;
            linkLabelStyle.LinkClicked += linkLabelStyle_LinkClicked;
            // 
            // PaintingViewForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 1258);
            Controls.Add(linkLabelStyle);
            Controls.Add(linkLabelPainter);
            Controls.Add(checkBoxFavorite);
            Controls.Add(labelName);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxNotes);
            Controls.Add(label5);
            Controls.Add(labelDate);
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