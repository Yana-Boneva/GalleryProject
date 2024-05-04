using GalleryProject.Entity;
using GalleryProject.General;

namespace GalleryProject.Forms
{
    public partial class PaintingViewForm : Form
    {
        readonly Painting? _painting;
        readonly int? _userID;
        Style? _style;
        public PaintingViewForm(int paintingID, int? userID)
        {
            InitializeComponent();
            _painting = DbManager.LoadPainting(paintingID);
            _userID = userID;
            checkBoxFavorite.Visible = userID.HasValue;
            SetData();
        }

        private void SetData()
        {
            SetDetailsData(_painting);
        }

        private void SetDetailsData(Painting? painting = null)
        {
            labelName.Text = painting?.Name ?? string.Empty;
            Painter? painter = null;
            if (painting?.PainterID.HasValue ?? false)
            {
                painter = DbManager.LoadPainters().Find(item => item.ID == painting.PainterID);
            }
            linkLabelPainter.Text = painter?.FullName ?? string.Empty;

            if (painting?.StyleID.HasValue ?? false)
            {
                _style = DbManager.LoadStyles().Find(item => item.ID == painting.StyleID);
            }
            linkLabelStyle.Text = _style?.Name ?? string.Empty;

            textBoxNotes.Text = painting?.Notes ?? string.Empty;

            labelDate.Visible = painting?.CreateDate != null;
            if (painting?.CreateDate != null)
                labelDate.Text = painting.CreateDate.Value.ToShortDateString();
            pictureBox1.Image = painting != null ? DbManager.LoadPaintingPicture(painting.ID) : null;

            checkBoxFavorite.Checked = _userID.HasValue && DbManager.GetFavorite(_userID.Value, _painting.ID);
        }

        private void CheckBoxFavorite_CheckedChanged(object sender, EventArgs e)
        {
            if (_userID.HasValue)
            {
                DbManager.SetFavorite(_userID.Value, _painting.ID, checkBoxFavorite.Checked);
            }
        }

        private void LinkLabelPainter_Click(object sender, EventArgs e)
        {
            if (_painting != null && _painting.PainterID.HasValue)
            {
                PainterViewForm form = new PainterViewForm(_painting.PainterID.Value);
                form.ShowDialog();
            }
        }
        private void linkLabelStyle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            MessageBox.Show(_style.Description, "Info");
        }
    }
}
