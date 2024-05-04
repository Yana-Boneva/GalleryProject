namespace GalleryProject.Forms
{
    partial class SearchForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxPainter = new TextBox();
            textBoxPainting = new TextBox();
            comboBoxStyle = new ComboBox();
            buttonApply = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 54);
            label1.Name = "label1";
            label1.Size = new Size(191, 41);
            label1.TabIndex = 0;
            label1.Text = "Painter name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 166);
            label2.Name = "label2";
            label2.Size = new Size(207, 41);
            label2.TabIndex = 1;
            label2.Text = "Painting name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 274);
            label3.Name = "label3";
            label3.Size = new Size(81, 41);
            label3.TabIndex = 2;
            label3.Text = "Style";
            // 
            // textBoxPainter
            // 
            textBoxPainter.Location = new Point(320, 51);
            textBoxPainter.Name = "textBoxPainter";
            textBoxPainter.Size = new Size(437, 47);
            textBoxPainter.TabIndex = 3;
            // 
            // textBoxPainting
            // 
            textBoxPainting.Location = new Point(320, 163);
            textBoxPainting.Name = "textBoxPainting";
            textBoxPainting.Size = new Size(437, 47);
            textBoxPainting.TabIndex = 4;
            // 
            // comboBoxStyle
            // 
            comboBoxStyle.FormattingEnabled = true;
            comboBoxStyle.Location = new Point(320, 271);
            comboBoxStyle.Name = "comboBoxStyle";
            comboBoxStyle.Size = new Size(437, 49);
            comboBoxStyle.TabIndex = 5;
            // 
            // buttonApply
            // 
            buttonApply.Location = new Point(320, 364);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(188, 58);
            buttonApply.TabIndex = 6;
            buttonApply.Text = "Apply";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += ButtonApply_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonApply);
            Controls.Add(comboBoxStyle);
            Controls.Add(textBoxPainting);
            Controls.Add(textBoxPainter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SearchForm";
            Text = "Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxPainter;
        private TextBox textBoxPainting;
        private ComboBox comboBoxStyle;
        private Button buttonApply;
    }
}