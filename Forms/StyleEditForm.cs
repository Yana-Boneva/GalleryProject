using GalleryProject.Entity;
using GalleryProject.General;

namespace GalleryProject.Forms
{
    public partial class StyleEditForm : Form
    {
        Style? lastSelectedItem = null;
        public StyleEditForm()
        {
            InitializeComponent();
            SetData();
        }

        private void SetData()
        {
            textBoxName.Text = string.Empty;
            textBoxDescription.Text = string.Empty;

            List<Style> styles = DbManager.LoadStyles();
            comboBoxStyle.Items.Clear();
            comboBoxStyle.Items.AddRange(styles.ToArray());
            comboBoxStyle.ValueMember = "ID";
            comboBoxStyle.DisplayMember = "Name";

            if (styles.Find(item => item.ID == lastSelectedItem?.ID) != null)
            {
                comboBoxStyle.SelectedItem = lastSelectedItem;
            }
            else
            {
                if (styles.Count > 0)
                    comboBoxStyle.SelectedIndex = 0;
            }
        }

        private void SetDetailsData(Style? style = null)
        {
            textBoxName.Text = style?.Name ?? string.Empty;
            textBoxDescription.Text = style?.Description ?? string.Empty;
        }


        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Name can not be empty", "Error");
            }
            else
            {
                Style style = new()
                {
                    Name = textBoxName.Text,
                    Description = textBoxDescription.Text,
                };
                if (DbManager.InsertStyle(style))
                {
                    MessageBox.Show($"{style.Name} was inserted");
                    SetData();
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxStyle.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing to delete", "Error");
            }
            else
            {
                Style selectedItem = (Style)comboBoxStyle.SelectedItem;
                if (DbManager.DeleteStyle(selectedItem.ID))
                {
                    MessageBox.Show($"{selectedItem.Name} was deleted");
                    comboBoxStyle.Text = string.Empty;
                    lastSelectedItem = null;
                    SetData();
                }
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxStyle.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing to update", "Error");
            }
            else
            {
                Style selectedItem = (Style)comboBoxStyle.SelectedItem;
                selectedItem.Name = textBoxName.Text;
                selectedItem.Description = textBoxDescription.Text;
                if (DbManager.UpdateStyle(selectedItem))
                {
                    MessageBox.Show($"{selectedItem.Name} was updated");
                    SetData();
                }
            }
        }

        private void ComboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Style style = (Style)comboBoxStyle.SelectedItem;
            lastSelectedItem = style;
            SetDetailsData(style);
        }
    }
}
