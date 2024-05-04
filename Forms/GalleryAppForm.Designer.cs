namespace GalleryProject.Forms
{
    partial class GalleryAppForm
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
            labelName = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            buttonLogin = new Button();
            buttonAdministration = new Button();
            buttonSearch = new Button();
            buttonPrev = new Button();
            buttonNext = new Button();
            buttonSettings = new Button();
            checkBoxFavorites = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 41);
            label1.TabIndex = 0;
            label1.Text = "Wellcome";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(167, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 41);
            labelName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(103, 209);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(627, 209);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(450, 450);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += PictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(1152, 209);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(450, 450);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += PictureBox3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(766, 115);
            label2.Name = "label2";
            label2.Size = new Size(134, 54);
            label2.TabIndex = 5;
            label2.Text = "Galery";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(1506, 12);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(188, 58);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += ButtonLogin_Click;
            // 
            // buttonAdministration
            // 
            buttonAdministration.Location = new Point(1073, 12);
            buttonAdministration.Name = "buttonAdministration";
            buttonAdministration.Size = new Size(233, 58);
            buttonAdministration.TabIndex = 7;
            buttonAdministration.Text = "Administration";
            buttonAdministration.UseVisualStyleBackColor = true;
            buttonAdministration.Visible = false;
            buttonAdministration.Click += ButtonAdministration_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(627, 740);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(188, 58);
            buttonSearch.TabIndex = 8;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += ButtonSearch_Click;
            // 
            // buttonPrev
            // 
            buttonPrev.Location = new Point(9, 209);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(58, 450);
            buttonPrev.TabIndex = 9;
            buttonPrev.Text = "<";
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Click += ButtonPrev_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(1636, 209);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(58, 450);
            buttonNext.TabIndex = 10;
            buttonNext.Text = ">";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += ButtonNext_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Location = new Point(1312, 12);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(188, 58);
            buttonSettings.TabIndex = 11;
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += ButtonSettings_Click;
            // 
            // checkBoxFavorites
            // 
            checkBoxFavorites.AutoSize = true;
            checkBoxFavorites.Location = new Point(904, 748);
            checkBoxFavorites.Name = "checkBoxFavorites";
            checkBoxFavorites.Size = new Size(173, 45);
            checkBoxFavorites.TabIndex = 12;
            checkBoxFavorites.Text = "Favorites";
            checkBoxFavorites.UseVisualStyleBackColor = true;
            checkBoxFavorites.CheckedChanged += CheckBoxFavorites_CheckedChanged;
            // 
            // GalleryAppForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1706, 880);
            Controls.Add(checkBoxFavorites);
            Controls.Add(buttonSettings);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrev);
            Controls.Add(buttonSearch);
            Controls.Add(buttonAdministration);
            Controls.Add(buttonLogin);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelName);
            Controls.Add(label1);
            Name = "GalleryAppForm";
            Text = "Gallery App";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelName;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Button buttonLogin;
        private Button buttonAdministration;
        private Button buttonSearch;
        private Button buttonPrev;
        private Button buttonNext;
        private Button buttonSettings;
        private CheckBox checkBoxFavorites;
    }
}