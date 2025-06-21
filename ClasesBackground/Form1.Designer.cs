namespace ClasesBackground
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAsyncStart = new Button();
            btnCancelAsync = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblResult = new Label();
            btnSonido = new Button();
            btnImg = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAsyncStart
            // 
            btnAsyncStart.Location = new Point(46, 118);
            btnAsyncStart.Name = "btnAsyncStart";
            btnAsyncStart.Size = new Size(75, 23);
            btnAsyncStart.TabIndex = 0;
            btnAsyncStart.Text = "Start";
            btnAsyncStart.UseVisualStyleBackColor = true;
            btnAsyncStart.Click += btnAsyncStart_Click;
            // 
            // btnCancelAsync
            // 
            btnCancelAsync.Location = new Point(175, 118);
            btnCancelAsync.Name = "btnCancelAsync";
            btnCancelAsync.Size = new Size(75, 23);
            btnCancelAsync.TabIndex = 1;
            btnCancelAsync.Text = "Cancel";
            btnCancelAsync.UseVisualStyleBackColor = true;
            btnCancelAsync.Click += btnCancelAsync_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(120, 53);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(38, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "label1";
            // 
            // btnSonido
            // 
            btnSonido.Location = new Point(383, 118);
            btnSonido.Name = "btnSonido";
            btnSonido.Size = new Size(107, 23);
            btnSonido.TabIndex = 3;
            btnSonido.Text = "Cargar sonido";
            btnSonido.UseVisualStyleBackColor = true;
            btnSonido.Click += btnSonido_Click;
            // 
            // btnImg
            // 
            btnImg.Location = new Point(614, 118);
            btnImg.Name = "btnImg";
            btnImg.Size = new Size(102, 23);
            btnImg.TabIndex = 4;
            btnImg.Text = "Cargar imagen";
            btnImg.UseVisualStyleBackColor = true;
            btnImg.Click += btnImg_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(330, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(604, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 252);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(btnImg);
            Controls.Add(btnSonido);
            Controls.Add(lblResult);
            Controls.Add(btnCancelAsync);
            Controls.Add(btnAsyncStart);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAsyncStart;
        private Button btnCancelAsync;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblResult;
        private Button btnSonido;
        private Button btnImg;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}
