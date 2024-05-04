using GalleryProject.Entity;
using GalleryProject.General;

namespace GalleryProject.Forms
{
    public partial class SearchForm : Form
    {
        public PaintingFilter _paintingFilter;
        public SearchForm(PaintingFilter paintingFilter)
        {
            InitializeComponent();
            _paintingFilter = paintingFilter;
            SetData();
            SetDetailsData();
        }

        private void SetData()
        {
            List<Style> styles = DbManager.LoadStyles();
            comboBoxStyle.Items.Clear();
            comboBoxStyle.Items.AddRange(styles.ToArray());
            comboBoxStyle.ValueMember = "ID";
            comboBoxStyle.DisplayMember = "Name";

            Style? style = styles.Find(item => item.ID == _paintingFilter.StyleID);
            if (style != null)
            {
                comboBoxStyle.SelectedItem = style;
            }
        }

        private void SetDetailsData()
        {
            textBoxPainter.Text = _paintingFilter.PainterName;
            textBoxPainting.Text = _paintingFilter.PaintingName;
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            _paintingFilter.PainterName = textBoxPainter.Text;
            _paintingFilter.PaintingName = textBoxPainting.Text;
            _paintingFilter.StyleID = ((Style)comboBoxStyle.SelectedItem)?.ID;
            Close();
        }
    }
}
