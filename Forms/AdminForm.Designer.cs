namespace GalleryProject.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            buttonStyle = new Button();
            buttonPainter = new Button();
            buttonPainting = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonStyle
            // 
            buttonStyle.BackgroundImage = (Image)resources.GetObject("buttonStyle.BackgroundImage");
            buttonStyle.BackgroundImageLayout = ImageLayout.Stretch;
            buttonStyle.Location = new Point(10, 114);
            buttonStyle.Margin = new Padding(1, 1, 1, 1);
            buttonStyle.Name = "buttonStyle";
            buttonStyle.Size = new Size(214, 136);
            buttonStyle.TabIndex = 0;
            buttonStyle.UseVisualStyleBackColor = true;
            buttonStyle.Click += ButtonStyle_Click;
            // 
            // buttonPainter
            // 
            buttonPainter.BackgroundImage = (Image)resources.GetObject("buttonPainter.BackgroundImage");
            buttonPainter.BackgroundImageLayout = ImageLayout.Stretch;
            buttonPainter.Location = new Point(260, 100);
            buttonPainter.Margin = new Padding(1, 1, 1, 1);
            buttonPainter.Name = "buttonPainter";
            buttonPainter.Size = new Size(190, 169);
            buttonPainter.TabIndex = 1;
            buttonPainter.UseVisualStyleBackColor = true;
            buttonPainter.Click += ButtonPainter_Click;
            // 
            // buttonPainting
            // 
            buttonPainting.BackgroundImage = (Image)resources.GetObject("buttonPainting.BackgroundImage");
            buttonPainting.BackgroundImageLayout = ImageLayout.Stretch;
            buttonPainting.Location = new Point(488, 114);
            buttonPainting.Margin = new Padding(1, 1, 1, 1);
            buttonPainting.Name = "buttonPainting";
            buttonPainting.Size = new Size(218, 140);
            buttonPainting.TabIndex = 2;
            buttonPainting.UseVisualStyleBackColor = true;
            buttonPainting.Click += ButtonPainting_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(58, 289);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 3;
            label1.Text = "Art Styles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(304, 289);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 4;
            label2.Text = "Painters";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(565, 289);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 5;
            label3.Text = "Paintings";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(728, 390);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonPainting);
            Controls.Add(buttonPainter);
            Controls.Add(buttonStyle);
            Margin = new Padding(1, 1, 1, 1);
            Name = "AdminForm";
            Text = "Admin Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStyle;
        private Button buttonPainter;
        private Button buttonPainting;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}