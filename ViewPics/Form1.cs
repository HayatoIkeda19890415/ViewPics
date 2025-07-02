using System.Windows.Forms;
using System.IO;

namespace ViewPics
{
    public partial class Form1 : Form
    {
        private string[] imageFiles;
        private int currentPageIndex = 0;
        private int listCount = 0;
        private string listPath = Path.Combine(Application.StartupPath, "list.txt");
        private int favCount = 0;
        private string favPath = Path.Combine(Application.StartupPath, "fav.txt");
        private int currentListIndex = 0;


        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = true;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.PreviewKeyDown += Ctrl_PreviewKeyDown;
            }
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.Resize += new System.EventHandler(Form1_Resize);
            listCount = CountLines(listPath);
            favCount = CountLines(favPath);
        }

        private void readDir_Click(object sender, System.EventArgs e)
        {
            LoadImageFiles(folderpath.Text.ToString());
            DisplayCurrentImage();
        }

        private void randomDir_Click(object sender, System.EventArgs e)
        {
            int count = 0;
            string path = "";
            if (fav.Checked)
            {
                count = favCount;
                path = favPath;
            }
            else
            {
                count = listCount;
                path = listPath;
            }

            int targetIndex = new System.Random().Next(1, count + 1); // maxを含む
            while (currentListIndex == targetIndex)
            {
                targetIndex = new System.Random().Next(1, count + 1);
            }
            currentListIndex = targetIndex;

            using (var reader = new StreamReader(path, System.Text.Encoding.GetEncoding(932)))
            {
                string line;
                int readIndex = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (readIndex == targetIndex)
                    {
                        folderpath.Text = line;
                        break;
                    }
                    readIndex++;
                }
            }
            if (Directory.GetFiles(folderpath.Text).Length == 0)
            {
                randomDir_Click(sender, e);
            }
            else
            {
                currentPageIndex = 0;
                readDir_Click(sender, e);
            }
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
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.PageDown)
            {
                randomDir_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Up)
            {
                fav.Checked = !fav.Checked;
                randomDir_Click(sender, e);
            }
        }

        private void next_Click(object sender, System.EventArgs e)
        {
            if (imageFiles == null || imageFiles.Length == 0)
                return;

            currentPageIndex++;
            if (currentPageIndex >= imageFiles.Length)
                currentPageIndex = 0; // 最初に戻る（循環しないならこの行を削除）

            DisplayCurrentImage();
        }

        private void prev_Click(object sender, System.EventArgs e)
        {
            if (imageFiles == null || imageFiles.Length == 0)
                return;

            currentPageIndex--;
            if (currentPageIndex < 0)
                currentPageIndex = imageFiles.Length - 1; // 最後に移動

            DisplayCurrentImage();

        }

        private void LoadImageFiles(string folderPath)
        {
            imageFiles = Directory.GetFiles(folderPath);
            this.Text = folderPath;
        }

        private void DisplayCurrentImage()
        {
            if (imageFiles.Length > 0 && File.Exists(imageFiles[currentPageIndex]))
            {
                label1.Text = (currentPageIndex + 1).ToString() + " / " + imageFiles.Length.ToString();
                pictureBox1.ImageLocation = imageFiles[currentPageIndex];
            }
        }

        private void Ctrl_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left
                || e.KeyCode == Keys.Right
                || e.KeyCode == Keys.Up
                || e.KeyCode == Keys.Down
                || e.KeyCode == Keys.PageDown)
            {
                e.IsInputKey = true; // このキーはフォームに渡してほしい、と明示
            }
        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            int margin = 10;
            int topAreaHeight = 20;

            pictureBox1.Left = margin;
            pictureBox1.Top = topAreaHeight + margin;
            pictureBox1.Width = this.ClientSize.Width - 2 * margin;
            pictureBox1.Height = this.ClientSize.Height - topAreaHeight - 2 * margin;
        }

        private int CountLines(string filePath)
        {
            int count = 0;

            using (var reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
