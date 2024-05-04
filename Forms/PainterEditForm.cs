using GalleryProject.Entity;
using GalleryProject.General;
using System.Drawing.Imaging;

namespace GalleryProject.Forms
{
    public partial class PainterEditForm : Form
    {
        Painter? lastSelectedItem = null;
        public PainterEditForm(int? painterID = null)
        {
            InitializeComponent();
            if (painterID.HasValue)
                lastSelectedItem = new Painter { ID = painterID.Value };
            SetData();
        }

        private void SetData()
        {
            List<Painter> painters = DbManager.LoadPainters();
            comboBoxPainter.Items.Clear();
            comboBoxPainter.Items.AddRange(painters.ToArray());
            comboBoxPainter.ValueMember = "ID";
            comboBoxPainter.DisplayMember = "FullName";

            Painter? painter = painters.Find(item => item.ID == lastSelectedItem?.ID);
            if (painter != null)
            {
                comboBoxPainter.SelectedIndex = painters.IndexOf(painter);
            }
            else
            {
                if (painters.Count > 0)
                    comboBoxPainter.SelectedIndex = 0;
            }
        }

        private void SetDetailsData(Painter? painter = null)
        {
            textBoxFirstName.Text = painter?.FirstName ?? string.Empty;
            textBoxLastName.Text = painter?.LastName ?? string.Empty;
            dateTimePickerBirth.Value = painter?.DateOfBirth ?? DateTime.Today;
            dateTimePickerDeath.Checked = painter?.DateOfDeath != null;
            if (painter?.DateOfDeath != null)
                dateTimePickerDeath.Value = painter.DateOfDeath.Value;
            textBoxNotes.Text = painter?.Notes ?? string.Empty;
            pictureBox1.Image = painter != null ? DbManager.LoadPainterPicture(painter.ID) : null;
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show("Last name can not be empty", "Error");
            }
            else
            {
                Painter painter = new()
                {
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    DateOfBirth = dateTimePickerBirth.Value,
                    DateOfDeath = dateTimePickerDeath.Checked ? dateTimePickerDeath.Value : null,
                    Notes = textBoxNotes.Text,
                };
                if (pictureBox1.Image == null)
                {
                    painter.Picture = null;
                }
                else
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        Bitmap bitmapImage = new Bitmap(pictureBox1.Image);
                        bitmapImage.Save(stream, ImageFormat.Jpeg);
                        painter.Picture = stream.GetBuffer();
                    }
                }
                if (DbManager.InsertPainter(painter))
                {
                    MessageBox.Show($"{painter.FullName} was inserted");
                    SetData();
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxPainter.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing to delete", "Error");
            }
            else
            {
                Painter selectedItem = (Painter)comboBoxPainter.SelectedItem;
                if (DbManager.DeletePainter(selectedItem.ID))
                {
                    MessageBox.Show($"{selectedItem.FullName} was deleted");
                    comboBoxPainter.Text = string.Empty;
                    lastSelectedItem = null;
                    SetData();
                }
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxPainter.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing to update", "Error");
            }
            else
            {
                Painter selectedItem = (Painter)comboBoxPainter.SelectedItem;
                selectedItem.FirstName = textBoxFirstName.Text;
                selectedItem.LastName = textBoxLastName.Text;
                selectedItem.DateOfBirth = dateTimePickerBirth.Value;
                selectedItem.DateOfDeath = dateTimePickerDeath.Checked ? dateTimePickerDeath.Value : null;
                selectedItem.Notes = textBoxNotes.Text;
                if (pictureBox1.Image == null)
                {
                    selectedItem.Picture = null;
                }
                else
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        Bitmap bitmapImage = new Bitmap(pictureBox1.Image);
                        bitmapImage.Save(stream, ImageFormat.Jpeg);
                        selectedItem.Picture = stream.GetBuffer();
                    }
                }
                if (DbManager.UpdatePainter(selectedItem))
                {
                    MessageBox.Show($"{selectedItem.FullName} was updated");
                    SetData();
                }
            }
        }

        private void ComboBoxPainter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Painter painter = (Painter)comboBoxPainter.SelectedItem;
            lastSelectedItem = painter;
            SetDetailsData(painter);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
