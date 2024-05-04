using GalleryProject.Entity;
using GalleryProject.General;

namespace GalleryProject.Forms
{
    public partial class PainterViewForm : Form
    {
        Painter? _painter;
        public PainterViewForm(int painterID)
        {
            InitializeComponent();
            _painter = DbManager.LoadPainter(painterID);
            SetDataDetails();
        }

        public void SetDataDetails()
        {
            labelFirstName.Text = _painter?.FirstName;
            labelLastName.Text = _painter?.LastName;
            labelDateOfBirth.Text = _painter?.DateOfBirth.ToShortDateString();
            labelDateOfDeath.Text = _painter?.DateOfDeath.HasValue ?? false
                ? _painter.DateOfDeath.Value.ToShortDateString() : "";
            textBoxNotes.Text = _painter?.Notes;
            pictureBox1.Image = DbManager.LoadPainterPicture(_painter?.ID ?? 0);
        }
    }
}
