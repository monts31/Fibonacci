using System.ComponentModel;
using System.Numerics;
using System.Media;
using System.Windows.Forms;
namespace ClasesBackground
{

    public partial class Form1 : Form
    {
        private SoundPlayer player = new SoundPlayer();
        public void LoadSoundAsync(string filepath)
        {
            try
            {
                // Assign the selected file's path to 
                // the SoundPlayer object.  
                player.SoundLocation = this.textBox1.Text;

                // Load the .wav file.
                player.LoadAsync();
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }
        private void ReportStatus(string message)
        {
            MessageBox.Show("Estado: " + message);
        }
        private void LoadImageAsync(string url)
        {
            pictureBox1.WaitOnLoad = false;
            pictureBox1.LoadAsync(url);
        }
       
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void btnAsyncStart_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnCancelAsync_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 1; i <= 10; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    System.Threading.Thread.Sleep(500);
                    worker.ReportProgress(i * 10);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblResult.Text = (e.ProgressPercentage.ToString() + "%");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                lblResult.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                lblResult.Text = "Error: " + e.Error.Message;
            }
            else
            {
                lblResult.Text = "Done!";
            }
        }

        private void btnSonido_Click(object sender, EventArgs e)
        {

        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            LoadImageAsync("http://localhost/print.gif");
        }
    }
}
