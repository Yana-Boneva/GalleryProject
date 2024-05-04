using GalleryProject.Entity;
using GalleryProject.General;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace GalleryProject.Forms
{
    public partial class UserSettingsForm : Form
    {
        User _loggedUser;
        public UserSettingsForm(User loggedUser)
        {
            InitializeComponent();
            _loggedUser = loggedUser;
            SetDataDetails();
        }

        private void SetDataDetails()
        {
            textBoxName.Text = _loggedUser.Username;
            textBoxEmail.Text = _loggedUser.Email;
            pictureBox1.Image = DbManager.LoadUserPicture(_loggedUser.ID);
        }

        private void PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (PopulateDataFromControls(ref _loggedUser))
            {
                DbManager.UpdateUser(_loggedUser);

                User? updatedUser = DbManager.LoadUser(_loggedUser.Email);
                if (updatedUser != null)
                {
                    _loggedUser = updatedUser;
                    MessageBox.Show("Your settings was updated");
                    SetDataDetails();
                }
                else
                {
                    MessageBox.Show("Your settings was not updated. Please try again.", "Error");
                }
            }
        }

        private bool PopulateDataFromControls(ref User loggedUser)
        {
            string passwordPattern = "^(?=.*\\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[^\\w\\d\\s:])([^\\s]){8,16}$";
            string emailPattern = @"^((((([a-zA-Z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-zA-Z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-zA-Z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-zA-Z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-zA-Z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-zA-Z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-zA-Z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-zA-Z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-zA-Z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-zA-Z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?)[;]?)+$";

            string username = textBoxName.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;

            if (pictureBox1.Image == null)
            {
                loggedUser.Picture = null;
            }
            else
            {
                using MemoryStream stream = new();
                using Bitmap bitmapImage = new(pictureBox1.Image);
                bitmapImage.Save(stream, ImageFormat.Jpeg);
                loggedUser.Picture = stream.GetBuffer();
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username can not be empty");
                return false;
            }

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(password) || !string.IsNullOrWhiteSpace(confirmPassword))
            {
                if (!Regex.IsMatch(password, passwordPattern))
                {
                    MessageBox.Show("Invalid password");
                    return false;
                }

                if (!password.Equals(confirmPassword))
                {
                    MessageBox.Show("Password did not match confirm password");
                    return false;
                }

                _loggedUser.Password = password;
            }


            try
            {
                if (DbManager.IsUserExists(username, _loggedUser.ID))
                {
                    MessageBox.Show("This username is already exists. Change username");
                    return false;
                }

                if (DbManager.IsEmailExists(email, _loggedUser.ID))
                {
                    MessageBox.Show("This email has been signed up. Change email");
                    return false;
                }

                _loggedUser.Username = username;
                _loggedUser.Email = email;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB error occurred. Please try again." + ex.Message, "Error");
                return false;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserSettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
