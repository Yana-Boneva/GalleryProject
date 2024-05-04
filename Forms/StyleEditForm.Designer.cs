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
            textBoxName.Location = new Point(248, 102);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(361, 47);
            textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 105);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 214);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ScrollBars = ScrollBars.Both;
            textBoxDescription.Size = new Size(972, 240);
            textBoxDescription.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 166);
            label2.Name = "label2";
            label2.Size = new Size(169, 41);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(141, 489);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(188, 58);
            buttonInsert.TabIndex = 4;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += ButtonInsert_Click;
            // 
            // comboBoxStyle
            // 
            comboBoxStyle.FormattingEnabled = true;
            comboBoxStyle.Location = new Point(248, 32);
            comboBoxStyle.Name = "comboBoxStyle";
            comboBoxStyle.Size = new Size(361, 49);
            comboBoxStyle.TabIndex = 5;
            comboBoxStyle.SelectedIndexChanged += ComboBoxStyle_SelectedIndexChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(626, 489);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(188, 58);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(379, 489);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(188, 58);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 35);
            label3.Name = "label3";
            label3.Size = new Size(81, 41);
            label3.TabIndex = 8;
            label3.Text = "Style";
            // 
            // StyleEditForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 566);
            Controls.Add(label3);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(comboBoxStyle);
            Controls.Add(buttonInsert);
            Controls.Add(label2);
            Controls.Add(textBoxDescription);
            Controls.Add(label1);
            Controls.Add(textBoxName);
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