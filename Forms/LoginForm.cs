using GalleryProject.Entity;
using GalleryProject.General;

namespace GalleryProject
{
    public partial class LoginForm : Form
    {
        public User? LoggedUser { get; internal set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
            if (signUpForm.CreatedUser != null)
            {
                LoggedUser = signUpForm.CreatedUser;
                Close();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User? user = DbManager.LoadUser(textBoxName.Text);
            if (user != null)
            {
                string password = textBoxPassword.Text;
                string signupdate = user.CreateDate;
                string passwordHash = user.Password;
                if (Tools.HashPassword($"{password}{signupdate}").Equals(passwordHash))
                {
                    MessageBox.Show($"Logged in as {user}");
                    LoggedUser = user;
                    Close();
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }
            }
            else
            {
                MessageBox.Show("Username or Email not found");
            }

        }


    }
}
