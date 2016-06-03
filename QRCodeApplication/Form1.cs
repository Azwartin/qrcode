using System;
using System.Windows.Forms;
using System.Drawing;
using ZXing;
using ZXing.QrCode;
using AForge.Video;
using AForge.Video.DirectShow;

namespace QRCodeApplication
{
    public partial class Form1 : Form
    {
        private QrCodeEncodingOptions options;
        private bool fromCamera = false;
        private FilterInfoCollection devices;
        private VideoCaptureDevice video;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 250,
                Height = 250
            };

            devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in devices)
            {
                cmbBoxDevices.Items.Add(device.Name);
            }

            cmbBoxDevices.SelectedIndex = 0;
            video = new VideoCaptureDevice();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var qr = new BarcodeWriter();
            qr.Options = options;
            qr.Format = ZXing.BarcodeFormat.QR_CODE;
            var text = this.textQr.Text.Trim();
            if (text.Length > 0)
            {
                var result = new Bitmap(qr.Write(text));
                image.Image = result;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.image.Image == null)
            {
                return;
            }

            try
            {
                Bitmap bitmap = new Bitmap(this.image.Image);
                BarcodeReader reader = new BarcodeReader { AutoRotate = true };
                Result result = reader.Decode(bitmap);
                if (result != null)
                {
                    string decoded = result.ToString().Trim();
                    this.textQr.Text = decoded;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Открыть QR код из файла";
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = "Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            openFileDialog.ShowHelp = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image.Image = new Bitmap(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image" + ex.Message);
                }
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (image.Image != null) 
            {
                saveFileDialog.Title = "Сохранить картинку как...";
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.Filter = "Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                saveFileDialog.ShowHelp = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        image.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fromCamera)
            {
                button1.Text = "Запустить камеру";
                video.NewFrame -= Video_NewFrame;
                Graphics g = image.CreateGraphics();
                g.Clear(Color.White);
                video.Stop();
                this.btnGenerate.Enabled = true;
                this.btnLoadFile.Enabled = true;
                this.btnSaveToFile.Enabled = true;
            }
            else
            {
                button1.Text = "Остановить камеру";
                video = new VideoCaptureDevice(devices[cmbBoxDevices.SelectedIndex].MonikerString);
                video.NewFrame += new NewFrameEventHandler(Video_NewFrame);
                video.Start();
                this.btnGenerate.Enabled = false;
                this.btnLoadFile.Enabled = false;
                this.btnSaveToFile.Enabled = false;

            }

            fromCamera = !fromCamera;
        }

        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            image.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnGetImage_Click(object sender, EventArgs e)
        {
           
        }
    }
}
