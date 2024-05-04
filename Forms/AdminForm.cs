namespace GalleryProject.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void ButtonStyle_Click(object sender, EventArgs e)
        {
            StyleEditForm modalForm = new();
            modalForm.ShowDialog();
        }

        private void ButtonPainter_Click(object sender, EventArgs e)
        {
            PainterEditForm modalForm = new();
            modalForm.ShowDialog();
        }

        private void ButtonPainting_Click(object sender, EventArgs e)
        {
            PaintingEditForm modalForm = new();
            modalForm.ShowDialog();
        }
    }
}
