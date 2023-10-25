namespace Whatsapp
{
    partial class FrmSendImage
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
			this.btnSendImage = new System.Windows.Forms.Button();
			this.rtfTextBox = new System.Windows.Forms.RichTextBox();
			this.btnSendText = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnUploadImage = new System.Windows.Forms.Button();
			this.btnSend = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSendImage
			// 
			this.btnSendImage.Location = new System.Drawing.Point(0, 0);
			this.btnSendImage.Name = "btnSendImage";
			this.btnSendImage.Size = new System.Drawing.Size(75, 23);
			this.btnSendImage.TabIndex = 0;
			// 
			// rtfTextBox
			// 
			this.rtfTextBox.Location = new System.Drawing.Point(12, 0);
			this.rtfTextBox.Name = "rtfTextBox";
			this.rtfTextBox.Size = new System.Drawing.Size(776, 253);
			this.rtfTextBox.TabIndex = 2;
			this.rtfTextBox.Text = "";
			// 
			// btnSendText
			// 
			this.btnSendText.Location = new System.Drawing.Point(92, 375);
			this.btnSendText.Name = "btnSendText";
			this.btnSendText.Size = new System.Drawing.Size(148, 46);
			this.btnSendText.TabIndex = 3;
			this.btnSendText.Text = "Send Text";
			this.btnSendText.UseVisualStyleBackColor = true;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 74);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(947, 289);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnUploadImage
			// 
			this.btnUploadImage.Location = new System.Drawing.Point(71, 385);
			this.btnUploadImage.Name = "btnUploadImage";
			this.btnUploadImage.Size = new System.Drawing.Size(145, 42);
			this.btnUploadImage.TabIndex = 1;
			this.btnUploadImage.Text = "Upload Image";
			this.btnUploadImage.UseVisualStyleBackColor = true;
			this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(222, 385);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(135, 42);
			this.btnSend.TabIndex = 2;
			this.btnSend.Text = "Send Image";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(269, 27);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 23);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(161, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Pin Code";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(381, 385);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(578, 32);
			this.progressBar1.TabIndex = 5;
			// 
			// FrmSendImage
			// 
			this.ClientSize = new System.Drawing.Size(988, 439);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.btnUploadImage);
			this.Controls.Add(this.pictureBox1);
			this.Name = "FrmSendImage";
			this.Load += new System.EventHandler(this.FrmSendImage_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Button btnSendImage;
        private RichTextBox rtfTextBox;
        private Button btnSendText;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnUploadImage;
        private Button btnSend;
        private ComboBox comboBox1;
        private Label label1;
		private ProgressBar progressBar1;
	}
}