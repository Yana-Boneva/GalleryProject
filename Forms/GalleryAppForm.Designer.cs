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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalleryAppForm));
            label1 = new Label();
            labelName = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            buttonLogin = new Button();
            buttonAdministration = new Button();
            buttonSearch = new Button();
            buttonPrev = new Button();
            buttonNext = new Button();
            buttonSettings = new Button();
            checkBoxFavorites = new CheckBox();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(226, 21);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(328, 64);
            label1.TabIndex = 0;
            label1.Text = "Hello, User!\r\nWelcome to the CHILL Zone... \r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(79, 4);
            labelName.Margin = new Padding(1, 0, 1, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 20);
            labelName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(48, 102);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(295, 102);
            pictureBox2.Margin = new Padding(1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(212, 220);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += PictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(542, 102);
            pictureBox3.Margin = new Padding(1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(212, 220);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += PictureBox3_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.OldLace;
            buttonLogin.BackgroundImage = (Image)resources.GetObject("buttonLogin.BackgroundImage");
            buttonLogin.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLogin.Location = new Point(732, 4);
            buttonLogin.Margin = new Padding(1);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(52, 38);
            buttonLogin.TabIndex = 6;
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += ButtonLogin_Click;
            // 
            // buttonAdministration
            // 
            buttonAdministration.BackColor = Color.OldLace;
            buttonAdministration.BackgroundImage = (Image)resources.GetObject("buttonAdministration.BackgroundImage");
            buttonAdministration.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdministration.Location = new Point(619, 4);
            buttonAdministration.Margin = new Padding(1);
            buttonAdministration.Name = "buttonAdministration";
            buttonAdministration.Size = new Size(47, 38);
            buttonAdministration.TabIndex = 7;
            buttonAdministration.UseVisualStyleBackColor = false;
            buttonAdministration.Visible = false;
            buttonAdministration.Click += ButtonAdministration_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.OldLace;
            buttonSearch.BackgroundImage = (Image)resources.GetObject("buttonSearch.BackgroundImage");
            buttonSearch.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSearch.Location = new Point(379, 352);
            buttonSearch.Margin = new Padding(1);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(52, 46);
            buttonSearch.TabIndex = 8;
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += ButtonSearch_Click;
            // 
            // buttonPrev
            // 
            buttonPrev.BackColor = Color.OldLace;
            buttonPrev.Location = new Point(4, 102);
            buttonPrev.Margin = new Padding(1);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(27, 220);
            buttonPrev.TabIndex = 9;
            buttonPrev.Text = "<";
            buttonPrev.UseVisualStyleBackColor = false;
            buttonPrev.Click += ButtonPrev_Click;
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.OldLace;
            buttonNext.Location = new Point(770, 102);
            buttonNext.Margin = new Padding(1);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(27, 220);
            buttonNext.TabIndex = 10;
            buttonNext.Text = ">";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += ButtonNext_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.OldLace;
            buttonSettings.BackgroundImage = (Image)resources.GetObject("buttonSettings.BackgroundImage");
            buttonSettings.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSettings.Location = new Point(679, 4);
            buttonSettings.Margin = new Padding(1);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(51, 38);
            buttonSettings.TabIndex = 11;
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += ButtonSettings_Click;
            // 
            // checkBoxFavorites
            // 
            checkBoxFavorites.AutoSize = true;
            checkBoxFavorites.BackColor = Color.OldLace;
            checkBoxFavorites.BackgroundImage = (Image)resources.GetObject("checkBoxFavorites.BackgroundImage");
            checkBoxFavorites.BackgroundImageLayout = ImageLayout.Stretch;
            checkBoxFavorites.CheckAlign = ContentAlignment.BottomRight;
            checkBoxFavorites.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxFavorites.ImageAlign = ContentAlignment.MiddleRight;
            checkBoxFavorites.Location = new Point(488, 355);
            checkBoxFavorites.Margin = new Padding(1);
            checkBoxFavorites.Name = "checkBoxFavorites";
            checkBoxFavorites.Size = new Size(42, 35);
            checkBoxFavorites.TabIndex = 12;
            checkBoxFavorites.Text = " ";
            checkBoxFavorites.UseVisualStyleBackColor = false;
            checkBoxFavorites.CheckedChanged += CheckBoxFavorites_CheckedChanged;
            // 
            // GalleryAppForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(803, 429);
            Controls.Add(checkBoxFavorites);
            Controls.Add(buttonSettings);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrev);
            Controls.Add(buttonSearch);
            Controls.Add(buttonAdministration);
            Controls.Add(buttonLogin);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelName);
            Controls.Add(label1);
            Margin = new Padding(1);
            Name = "GalleryAppForm";
            Text = "Gallery App";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelName;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button buttonLogin;
        private Button buttonAdministration;
        private Button buttonSearch;
        private Button buttonPrev;
        private Button buttonNext;
        private Button buttonSettings;
        private CheckBox checkBoxFavorites;
        private BindingSource bindingSource1;
    }
}