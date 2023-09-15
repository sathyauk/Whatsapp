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
            this.SuspendLayout();
            // 
            // btnSendImage
            // 
            this.btnSendImage.Location = new System.Drawing.Point(294, 375);
            this.btnSendImage.Name = "btnSendImage";
            this.btnSendImage.Size = new System.Drawing.Size(135, 45);
            this.btnSendImage.TabIndex = 1;
            this.btnSendImage.Text = "Send Image";
            this.btnSendImage.UseVisualStyleBackColor = true;
            this.btnSendImage.Click += new System.EventHandler(this.button1_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSendText);
            this.Controls.Add(this.rtfTextBox);
            this.Controls.Add(this.btnSendImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnSendImage;
        private RichTextBox rtfTextBox;
        private Button btnSendText;
        private OpenFileDialog openFileDialog1;
    }
}