namespace GalleryProject.Forms
{
    partial class StyleEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StyleEditForm));
            textBoxName = new TextBox();
            label1 = new Label();
            textBoxDescription = new TextBox();
            label2 = new Label();
            buttonInsert = new Button();
            comboBoxStyle = new ComboBox();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(181, 121);
            textBoxName.Margin = new Padding(1);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(172, 27);
            textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 122);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 26);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(161, 174);
            textBoxDescription.Margin = new Padding(1);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ScrollBars = ScrollBars.Both;
            textBoxDescription.Size = new Size(460, 119);
            textBoxDescription.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 173);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 26);
            label2.TabIndex = 3;
            label2.Text = "Description:";
            // 
            // buttonInsert
            // 
            buttonInsert.BackgroundImage = (Image)resources.GetObject("buttonInsert.BackgroundImage");
            buttonInsert.BackgroundImageLayout = ImageLayout.Stretch;
            buttonInsert.Location = new Point(89, 309);
            buttonInsert.Margin = new Padding(1);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(53, 49);
            buttonInsert.TabIndex = 4;
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += ButtonInsert_Click;
            // 
            // comboBoxStyle
            // 
            comboBoxStyle.FormattingEnabled = true;
            comboBoxStyle.Location = new Point(181, 64);
            comboBoxStyle.Margin = new Padding(1);
            comboBoxStyle.Name = "comboBoxStyle";
            comboBoxStyle.Size = new Size(172, 28);
            comboBoxStyle.TabIndex = 5;
            comboBoxStyle.SelectedIndexChanged += ComboBoxStyle_SelectedIndexChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.BackgroundImage = (Image)resources.GetObject("buttonDelete.BackgroundImage");
            buttonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDelete.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(574, 309);
            buttonDelete.Margin = new Padding(1);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(47, 49);
            buttonDelete.TabIndex = 6;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackgroundImage = (Image)resources.GetObject("buttonUpdate.BackgroundImage");
            buttonUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            buttonUpdate.Location = new Point(327, 309);
            buttonUpdate.Margin = new Padding(1);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(51, 50);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 66);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 26);
            label3.TabIndex = 8;
            label3.Text = "Style:";
            // 
            // StyleEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(674, 360);
            Controls.Add(label3);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(comboBoxStyle);
            Controls.Add(buttonInsert);
            Controls.Add(label2);
            Controls.Add(textBoxDescription);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Margin = new Padding(1);
            Name = "StyleEditForm";
            Text = "Style Edit Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxDescription;
        private Label label2;
        private Button buttonInsert;
        private ComboBox comboBoxStyle;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Label label3;
    }
}