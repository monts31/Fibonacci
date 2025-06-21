using System.ComponentModel;

namespace LlamadasSeguras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var thread2 = new System.Threading.Thread(WriteTextUnsafe);
            //thread2.Start();
            //var threadParameters = new System.Threading.ThreadStart(delegate { WriteTextSafe("This text was set safely."); });
            //var thread2 = new System.Threading.Thread(threadParameters);
            //thread2.Start();
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        //private void WriteTextUnsafe() =>
        //textBox1.Text = "This text was set unsafely.";
        //public void WriteTextSafe(string text)
        //{
        //    if (textBox1.InvokeRequired)
        //    {
        //        // Call this same method but append THREAD2 to the text
        //        Action safeWrite = delegate { WriteTextSafe($"{text} (THREAD2)"); };
        //        textBox1.Invoke(safeWrite);
        //    }
        //    else
        //        textBox1.Text = text;
        //}

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int counter = 0;
            int max = 10;

            while (counter <= max)
            {
                backgroundWorker1.ReportProgress(0, counter.ToString());
                System.Threading.Thread.Sleep(1000);
                counter++;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) =>
            textBox1.Text = (string) e.UserState;
        

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
