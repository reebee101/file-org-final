using System.Globalization;
using System.IO.Compression;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Visible = false;
            LocationsBox.Visible = false;
            monthCalendar1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        FileStream file;
        StreamReader reader;
        StreamWriter writer;
        string filename;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.Cancel) { return; }
            filename = ofd.FileName;
            if (filename == null) { MessageBox.Show("invalid file"); }
            else
            {
                using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    using (ZipArchive archive = new ZipArchive(file, ZipArchiveMode.Read))
                    {
                        foreach (ZipArchiveEntry entry in archive.Entries)
                        {
                            if (!entry.FullName.EndsWith("/")) // Directory entries end with "/"
                            {
                                if (IsImageFile(entry.FullName))
                                {
                                    using (Stream zipStream = entry.Open())
                                    {
                                        Image img = Image.FromStream(zipStream);

                                        PictureBox pictureBox = new PictureBox();
                                        pictureBox.Image = img;
                                        pictureBox.Size = new Size(400, 500);

                                        // Add picture box to the flow layout panel
                                        photoFlowLayout.Controls.Add(pictureBox);
                                    }
                                }
                            }
                        }
                    }
                    button1.Visible = false;
                    checkedListBox1.Visible = true;
                    button2.Visible = true;
                    label1.Visible = true;
                    photoFlowLayout.HorizontalScroll.Visible = true;
                    photoFlowLayout.VerticalScroll.Visible = true;
                }
            }
        }

        private bool IsImageFile(string fileName)
        {
            string ext = Path.GetExtension(fileName).ToLower();
            return ext == ".jpg" || ext == ".jpeg" || ext == ".png";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                string check = itemChecked.ToString();
                if (check == "date")
                {
                    button3.Visible = true;
                    monthCalendar1.Visible = true;

                }
                else if (check == "location")
                {
                    label2.Visible = true;
                    LocationsBox.Visible = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedDate = monthCalendar1.SelectionStart.Date.ToString();
            string formattedDate = selectedDate.Replace("/", "");

            photoFlowLayout.Controls.Clear();

            using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                using (ZipArchive archive = new ZipArchive(file, ZipArchiveMode.Read))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        if (!entry.FullName.EndsWith("/"))
                        {
                            if (IsImageFile(entry.FullName))
                            {
                                string creationDate = GetCreationDate(entry);

                                if (formattedDate == creationDate)
                                {
                                    using (Stream zipstream = entry.Open())
                                    {
                                        Image img = Image.FromStream(zipstream);

                                        PictureBox pictureBox = new PictureBox();
                                        pictureBox.Image = img;
                                        pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

                                        photoFlowLayout.Controls.Add(pictureBox);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void LocationsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLocation = LocationsBox.SelectedItem.ToString();

            photoFlowLayout.Controls.Clear();

            using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                using (ZipArchive archive = new ZipArchive(file, ZipArchiveMode.Read))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        if (!entry.FullName.EndsWith("/")) // Directory entries end with "/"
                        {
                            if (IsImageFile(entry.FullName))
                            {
                                // Get the location of the image
                                string imageLocation = GetLocation(entry);

                                // Check if the image location matches the selected location
                                if (imageLocation == selectedLocation)
                                {
                                    using (Stream zipStream = entry.Open())
                                    {
                                        Image imgg = Image.FromStream(zipStream);

                                        PictureBox pictureBox = new PictureBox();
                                        pictureBox.Image = imgg;
                                        pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

                                        // Add picture box to the flow layout panel
                                        photoFlowLayout.Controls.Add(pictureBox);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private string GetCreationDate(ZipArchiveEntry entry)
        {
            string[] parts = entry.FullName.Split('-');
            if (parts.Length >= 2)
            {
                return parts[1] + " 00:00:00";
            }
            else
            {
                return "unknown";
            }
        }

        private string GetLocation(ZipArchiveEntry entry)
        {
            string[] parts = entry.FullName.Split('-');
            if (parts.Length >= 1)
            {
                return parts[0];
            }
            else
            {
                return "Unknown";
            }
        }       
    }
}
