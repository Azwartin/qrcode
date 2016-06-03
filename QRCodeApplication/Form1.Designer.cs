namespace QRCodeApplication
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.textQr = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbBoxDevices = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(645, 270);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(99, 38);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Создать QR";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Считать QR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.White;
            this.image.Location = new System.Drawing.Point(12, 13);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(400, 250);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 3;
            this.image.TabStop = false;
            // 
            // textQr
            // 
            this.textQr.Location = new System.Drawing.Point(438, 13);
            this.textQr.Multiline = true;
            this.textQr.Name = "textQr";
            this.textQr.Size = new System.Drawing.Size(306, 250);
            this.textQr.TabIndex = 4;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(12, 359);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(98, 42);
            this.btnLoadFile.TabIndex = 5;
            this.btnLoadFile.Text = "Из файла";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(142, 359);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(99, 42);
            this.btnSaveToFile.TabIndex = 6;
            this.btnSaveToFile.Text = "Сохранить в файл";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Запуcтить камеру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbBoxDevices
            // 
            this.cmbBoxDevices.FormattingEnabled = true;
            this.cmbBoxDevices.Location = new System.Drawing.Point(13, 270);
            this.cmbBoxDevices.Name = "cmbBoxDevices";
            this.cmbBoxDevices.Size = new System.Drawing.Size(399, 21);
            this.cmbBoxDevices.TabIndex = 8;
            this.cmbBoxDevices.Text = "Выбор камеры";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 446);
            this.Controls.Add(this.cmbBoxDevices);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.textQr);
            this.Controls.Add(this.image);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "QRCode";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.TextBox textQr;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbBoxDevices;
    }
}

