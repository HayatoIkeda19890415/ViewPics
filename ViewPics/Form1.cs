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
            this.KeyPreview = true;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.PreviewKeyDown += Ctrl_PreviewKeyDown;
            }
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void readDir_Click(object sender, System.EventArgs e)
        {
            LoadImageFiles(folderpath.Text.ToString());
            DisplayCurrentImage();
            this.ActiveControl = null;
        }

        private void randomDir_Click(object sender, System.EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                next_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Left)
            {
                prev_Click(sender, e);
            }
        }

        private void next_Click(object sender, System.EventArgs e)
        {
            if (imageFiles == null || imageFiles.Length == 0)
                return;

            currentIndex++;
            if (currentIndex >= imageFiles.Length)
                currentIndex = 0; // 最初に戻る（循環しないならこの行を削除）

            DisplayCurrentImage();
        }

        private void prev_Click(object sender, System.EventArgs e)
        {
            if (imageFiles == null || imageFiles.Length == 0)
                return;

            currentIndex--;
            if (currentIndex < 0)
                currentIndex = imageFiles.Length - 1; // 最後に移動

            DisplayCurrentImage();

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

        private void Ctrl_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true; // このキーはフォームに渡してほしい、と明示
            }
        }
    }
}
