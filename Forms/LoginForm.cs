using GalleryProject.Entity;
using GalleryProject.General;
using System.Media;

namespace GalleryProject
{
    public partial class LoginForm : Form
    {
        private SoundPlayer player;
        private bool isMusicPlaying = false;
        public User? LoggedUser { get; internal set; }
        public LoginForm()
        {
            InitializeComponent();
           player = new SoundPlayer(@"C:\Art Gallery project\9 Minutes of Jazz Music for Focusing and Calm.wav");
            StartPlayingMusic();
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

        private void sound_Click(object sender, EventArgs e)
        {
            ToggleMusicPlayback();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            StartPlayingMusic();
        }
        private void StartPlayingMusic()
        {
            player.Play();
            isMusicPlaying = true;
        }
        private void PauseMusic()
        {
            player.Stop();
            isMusicPlaying = false;
        }

        private void ToggleMusicPlayback()
        {
            if (isMusicPlaying)
            {
                PauseMusic();
            }
            else
            {
                StartPlayingMusic();
            }
        }
    }
}
