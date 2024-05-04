using GalleryProject.Entity;
using GalleryProject.General;
using System.Text.RegularExpressions;

namespace GalleryProject
{
    public partial class SignUpForm : Form
    {
        public User? CreatedUser { get; internal set; }

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void ButtonCreateUser_Click(object sender, EventArgs e)
        {
            string passwordPattern = "^(?=.*\\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[^\\w\\d\\s:])([^\\s]){8,16}$";
            string emailPattern = @"^((((([a-zA-Z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-zA-Z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-zA-Z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-zA-Z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-zA-Z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-zA-Z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-zA-Z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-zA-Z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-zA-Z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-zA-Z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?)[;]?)+$";

            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Username can not be empty");
                return;
            }

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email");
                return;
            }

            if (!Regex.IsMatch(password, passwordPattern))
            {
                MessageBox.Show("Invalid password");
                return;
            }

            if (!password.Equals(textBoxConfirmPassword.Text))
            {
                MessageBox.Show("Password did not match confirm password");
                return;
            }

            try
            {
                if (DbManager.IsUserExists(textBoxName.Text))
                {
                    MessageBox.Show("This username is already exists. Change it or use forget password link");
                    return;
                }

                if (DbManager.IsEmailExists(email))
                {
                    MessageBox.Show("Your email has been signed up. Use forget password link");
                    return;
                }

                string date = DateTime.Now.ToString();
                DbManager.CreateUser(textBoxName.Text, email, date, Tools.HashPassword($"{password}{date}"));

                CreatedUser = DbManager.LoadUser(email);
                MessageBox.Show("You were signed up");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB error occurred. Please try again." + ex.Message, "Error");
            }

        }
    }
}
