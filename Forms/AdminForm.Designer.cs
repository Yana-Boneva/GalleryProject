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
            buttonStyle = new Button();
            buttonPainter = new Button();
            buttonPainting = new Button();
            SuspendLayout();
            // 
            // buttonStyle
            // 
            buttonStyle.Location = new Point(39, 110);
            buttonStyle.Name = "buttonStyle";
            buttonStyle.Size = new Size(188, 58);
            buttonStyle.TabIndex = 0;
            buttonStyle.Text = "Styles";
            buttonStyle.UseVisualStyleBackColor = true;
            buttonStyle.Click += ButtonStyle_Click;
            // 
            // buttonPainter
            // 
            buttonPainter.Location = new Point(304, 110);
            buttonPainter.Name = "buttonPainter";
            buttonPainter.Size = new Size(188, 58);
            buttonPainter.TabIndex = 1;
            buttonPainter.Text = "Painters";
            buttonPainter.UseVisualStyleBackColor = true;
            buttonPainter.Click += ButtonPainter_Click;
            // 
            // buttonPainting
            // 
            buttonPainting.Location = new Point(577, 110);
            buttonPainting.Name = "buttonPainting";
            buttonPainting.Size = new Size(188, 58);
            buttonPainting.TabIndex = 2;
            buttonPainting.Text = "Paintings";
            buttonPainting.UseVisualStyleBackColor = true;
            buttonPainting.Click += ButtonPainting_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPainting);
            Controls.Add(buttonPainter);
            Controls.Add(buttonStyle);
            Name = "AdminForm";
            Text = "Admin Form";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStyle;
        private Button buttonPainter;
        private Button buttonPainting;
    }
}