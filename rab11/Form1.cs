using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace rab11
{
    public partial class Form1 : Form
    {
        Bitmap image; 
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true; 
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                image = newImage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void яРКОСТЬToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BrightFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void бИНАРИЗАЦИЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BinarizationFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void оТТЕНКИСЕРОГОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayscaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }

}
