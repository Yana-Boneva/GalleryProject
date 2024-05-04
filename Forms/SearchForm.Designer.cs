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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(73, 65);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 26);
            label1.TabIndex = 0;
            label1.Text = "Painter name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 122);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 26);
            label2.TabIndex = 1;
            label2.Text = "Painting name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(73, 169);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 26);
            label3.TabIndex = 2;
            label3.Text = "Style:";
            // 
            // textBoxPainter
            // 
            textBoxPainter.Location = new Point(268, 58);
            textBoxPainter.Margin = new Padding(1, 1, 1, 1);
            textBoxPainter.Name = "textBoxPainter";
            textBoxPainter.Size = new Size(208, 27);
            textBoxPainter.TabIndex = 3;
            // 
            // textBoxPainting
            // 
            textBoxPainting.Location = new Point(268, 115);
            textBoxPainting.Margin = new Padding(1, 1, 1, 1);
            textBoxPainting.Name = "textBoxPainting";
            textBoxPainting.Size = new Size(208, 27);
            textBoxPainting.TabIndex = 4;
            // 
            // comboBoxStyle
            // 
            comboBoxStyle.FormattingEnabled = true;
            comboBoxStyle.Location = new Point(268, 167);
            comboBoxStyle.Margin = new Padding(1, 1, 1, 1);
            comboBoxStyle.Name = "comboBoxStyle";
            comboBoxStyle.Size = new Size(208, 28);
            comboBoxStyle.TabIndex = 5;
            // 
            // buttonApply
            // 
            buttonApply.BackgroundImage = (Image)resources.GetObject("buttonApply.BackgroundImage");
            buttonApply.BackgroundImageLayout = ImageLayout.Stretch;
            buttonApply.Location = new Point(237, 222);
            buttonApply.Margin = new Padding(1, 1, 1, 1);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(63, 52);
            buttonApply.TabIndex = 6;
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += ButtonApply_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(519, 284);
            Controls.Add(buttonApply);
            Controls.Add(comboBoxStyle);
            Controls.Add(textBoxPainting);
            Controls.Add(textBoxPainter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(1, 1, 1, 1);
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