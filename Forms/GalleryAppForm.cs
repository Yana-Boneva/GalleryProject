using GalleryProject.Entity;
using GalleryProject.General;
using System.Media;

namespace GalleryProject.Forms
{
    public partial class GalleryAppForm : Form
    {
        private SoundPlayer player;
        User? _loggedUser = null;
        PaintingFilter _paintingFilter = new();
        List<int> _paintingsIDs;

        public GalleryAppForm()
        {
            InitializeComponent();
            player = new SoundPlayer();
            if (_loggedUser == null)
            {
                Login();
            }
            _paintingsIDs = LoadPaintings();
            SetPaintings(_paintingsIDs);
        }

        private static List<int> LoadPaintings(PaintingFilter? paintingFilter = null)
        {
            return DbManager.LoadPaintings(paintingFilter).Select(item => item.ID).ToList();
        }

        private void SetPaintings(List<int> paintingsIDs)
        {
            if (paintingsIDs.Count > 0)
                pictureBox1.Image = DbManager.LoadPaintingPicture(paintingsIDs[0]);
            else
                pictureBox1.Image = null;
            if (paintingsIDs.Count > 1)
                pictureBox2.Image = DbManager.LoadPaintingPicture(paintingsIDs[1]);
            else
                pictureBox2.Image = null;
            if (paintingsIDs.Count > 2)
                pictureBox3.Image = DbManager.LoadPaintingPicture(paintingsIDs[2]);
            else
                pictureBox3.Image = null;
        }

        private void SetAuthenticatedControls()
        {
            labelName.Text = _loggedUser?.Username ?? "Guest";
            buttonLogin.Text = _loggedUser == null ? "Login" : "Logout";

            buttonSettings.Visible = _loggedUser != null;
            checkBoxFavorites.Visible = _loggedUser != null;

            buttonAdministration.Visible = _loggedUser?.IsAdmin ?? false;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (_loggedUser == null)
            {
                Login();
            }
            else
            {
                _loggedUser = null;
                SetAuthenticatedControls();
            }
        }

        private void Login()
        {
            LoginForm loginForm = new();
            loginForm.ShowDialog();
            _loggedUser = loginForm.LoggedUser;
            SetAuthenticatedControls();
        }

        private void ButtonAdministration_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new();
            adminForm.ShowDialog();

            ReloadPaintings();
        }

        void ReloadPaintings()
        {
            _paintingsIDs = LoadPaintings(_paintingFilter);
            SetPaintings(_paintingsIDs);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new(_paintingFilter);
            searchForm.ShowDialog();
            _paintingFilter = searchForm._paintingFilter;
            ReloadPaintings();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                PaintingViewForm paintingView = new(_paintingsIDs[0], _loggedUser?.ID);
                paintingView.ShowDialog();
                ReloadPaintings();
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                PaintingViewForm paintingView = new(_paintingsIDs[1], _loggedUser?.ID);
                paintingView.ShowDialog();
                ReloadPaintings();
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image != null)
            {
                PaintingViewForm paintingView = new(_paintingsIDs[2], _loggedUser?.ID);
                paintingView.ShowDialog();
                ReloadPaintings();
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (_paintingsIDs.Count > 0)
            {
                int firstID = _paintingsIDs[0];
                _paintingsIDs.RemoveAt(0);
                _paintingsIDs.Add(firstID);
                SetPaintings(_paintingsIDs);
            }
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            if (_paintingsIDs.Count > 0)
            {
                int lastID = _paintingsIDs[_paintingsIDs.Count - 1];
                _paintingsIDs.RemoveAt(_paintingsIDs.Count - 1);
                _paintingsIDs.Insert(0, lastID);
                SetPaintings(_paintingsIDs);
            }
        }

        private void CheckBoxFavorites_CheckedChanged(object sender, EventArgs e)
        {
            _paintingFilter.UserID = checkBoxFavorites.Checked ? _loggedUser?.ID : null;
            ReloadPaintings();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            if (_loggedUser != null)
            {
                UserSettingsForm userSettingsForm = new(_loggedUser);
                userSettingsForm.ShowDialog();
            }
        }

        private void GalleryAppForm_Load(object sender, EventArgs e)
        {
            string audioFilePath = @"C:\Users\Elitza\Downloads\9 Minutes of Jazz Music for Focusing and Calm.wav";
            player.SoundLocation = audioFilePath;
            player.Load();
            player.Play();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Stop(); // Stop the music when the form is closing
            player.Dispose(); // Dispose the SoundPlayer object to release resources
        }
    }
}
