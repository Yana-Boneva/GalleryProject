using GalleryProject.Entity;
using GalleryProject.General;
using System.Drawing.Imaging;

namespace GalleryProject.Forms
{
    public partial class PaintingEditForm : Form
    {
        Painting? lastSelectedItem = null;
        List<Painter> painters = new();
        List<Style> styles = new();

        public PaintingEditForm()
        {
            InitializeComponent();
            SetData();
        }

        private void SetData()
        {
            if (painters.Count == 0)
            {
                painters = DbManager.LoadPainters();
                comboBoxPainter.Items.Clear();
                comboBoxPainter.Items.AddRange(painters.ToArray());
                comboBoxPainter.ValueMember = "ID";
                comboBoxPainter.DisplayMember = "FullName";
            }

            if (styles.Count == 0)
            {
                styles = DbManager.LoadStyles();
                comboBoxStyle.Items.Clear();
                comboBoxStyle.Items.AddRange(styles.ToArray());
                comboBoxStyle.ValueMember = "ID";
                comboBoxStyle.DisplayMember = "Name";
            }

            List<Painting> paintings = DbManager.LoadPaintings();
            comboBoxPainting.Items.Clear();
            comboBoxPainting.Items.AddRange(paintings.ToArray());
            comboBoxPainting.ValueMember = "ID";
            comboBoxPainting.DisplayMember = "Name";

            Painting? painting = paintings.Find(item => item.ID == lastSelectedItem?.ID);
            if (painting != null)
            {
                comboBoxPainting.SelectedIndex = paintings.IndexOf(painting);
            }
            else
            {
                if (paintings.Count > 0)
                    comboBoxPainting.SelectedIndex = 0;
            }

        }

        private void SetDetailsData(Painting? painting = null)
        {
            textBoxName.Text = painting?.Name ?? string.Empty;
            textBoxNotes.Text = painting?.Notes ?? string.Empty;

            Painter? painter = painters.Find(item => item.ID == painting?.PainterID);
            comboBoxPainter.SelectedIndex = painter != null ? painters.IndexOf(painter) : -1;

            Style? style = styles.Find(item => item.ID == painting?.StyleID);
            comboBoxStyle.SelectedIndex = style != null ? styles.IndexOf(style) : -1;

            dateTimeDate.Checked = painting?.CreateDate != null;
            if (painting?.CreateDate != null)
                dateTimeDate.Value = painting.CreateDate.Value;
            pictureBox1.Image = painting != null ? DbManager.LoadPaintingPicture(painting.ID) : null;
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Last name can not be empty", "Error");
            }
            else
            {
                Painting painting = new();
                PopulateDataFromControls(ref painting);
                if (DbManager.InsertPainting(painting))
                {
                    MessageBox.Show($"{painting.Name} was inserted");
                    SetData();
                }
            }
        }

        void PopulateDataFromControls(ref Painting painting)
        {
            painting.Name = textBoxName.Text;
            painting.CreateDate = dateTimeDate.Checked ? dateTimeDate.Value : null;
            painting.Notes = textBoxNotes.Text;
            painting.PainterID = comboBoxPainter.SelectedIndex != -1 ? ((Painter)comboBoxPainter.SelectedItem).ID : null;
            painting.StyleID = comboBoxStyle.SelectedIndex != -1 ? ((Style)comboBoxStyle.SelectedItem).ID : null;
            if (pictureBox1.Image == null)
            {
                painting.Picture = null;
            }
            else
            {
                using MemoryStream stream = new();
                using Bitmap bitmapImage = new(pictureBox1.Image);
                bitmapImage.Save(stream, ImageFormat.Jpeg);
                painting.Picture = stream.GetBuffer();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxPainting.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing to delete", "Error");
            }
            else
            {
                Painting selectedItem = (Painting)comboBoxPainting.SelectedItem;
                if (DbManager.DeletePainting(selectedItem.ID))
                {
                    MessageBox.Show($"{selectedItem.Name} was deleted");
                    comboBoxPainter.Text = string.Empty;
                    lastSelectedItem = null;
                    SetData();
                }
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxPainting.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing to update", "Error");
            }
            else
            {
                Painting selectedItem = (Painting)comboBoxPainting.SelectedItem;
                PopulateDataFromControls(ref selectedItem);
                if (DbManager.UpdatePainting(selectedItem))
                {
                    MessageBox.Show($"{selectedItem.Name} was updated");
                    SetData();
                }
            }
        }

        private void PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void ComboBoxPainting_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDetailsData((Painting)comboBoxPainting.SelectedItem);
        }
    }
}
