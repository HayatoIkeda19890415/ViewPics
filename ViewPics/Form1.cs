using System.Windows.Forms;
using System.IO;

namespace ViewPics
{
    public partial class Form1 : Form
    {
        private string[] imageFiles;
        private int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void readDir_Click(object sender, System.EventArgs e)
        {
            LoadImageFiles(folderpath.Text.ToString());
            DisplayCurrentImage();
        }

        private void randomDir_Click(object sender, System.EventArgs e)
        {

        }

        private void prev_Click(object sender, System.EventArgs e)
        {

        }

        private void next_Click(object sender, System.EventArgs e)
        {

        }
        private void LoadImageFiles(string folderPath)
        {
            imageFiles = Directory.GetFiles(folderPath);
        }
        private void DisplayCurrentImage()
        {
            if (imageFiles.Length > 0 && File.Exists(imageFiles[currentIndex]))
            {
                pictureBox1.ImageLocation = imageFiles[currentIndex];
            }
        }
    }
}
