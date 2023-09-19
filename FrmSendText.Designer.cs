namespace Whatsapp
{
    partial class FrmSendText
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtfMessage = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSendText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPinCode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rtfMessage
            // 
            this.rtfMessage.Location = new System.Drawing.Point(5, 12);
            this.rtfMessage.Name = "rtfMessage";
            this.rtfMessage.Size = new System.Drawing.Size(1096, 556);
            this.rtfMessage.TabIndex = 0;
            this.rtfMessage.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(0, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(952, 336);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnSendText
            // 
            this.btnSendText.Location = new System.Drawing.Point(326, 425);
            this.btnSendText.Name = "btnSendText";
            this.btnSendText.Size = new System.Drawing.Size(144, 56);
            this.btnSendText.TabIndex = 0;
            this.btnSendText.Text = "Send Whatsapp Text";
            this.btnSendText.Click += new System.EventHandler(this.btnSendText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pin Code";
            // 
            // cmbPinCode
            // 
            this.cmbPinCode.FormattingEnabled = true;
            this.cmbPinCode.Location = new System.Drawing.Point(140, 18);
            this.cmbPinCode.Name = "cmbPinCode";
            this.cmbPinCode.Size = new System.Drawing.Size(121, 23);
            this.cmbPinCode.TabIndex = 2;
            this.cmbPinCode.SelectedIndexChanged += new System.EventHandler(this.cmbPinCode_SelectedIndexChanged);
            // 
            // FrmSendText
            // 
            this.ClientSize = new System.Drawing.Size(987, 493);
            this.Controls.Add(this.cmbPinCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendText);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FrmSendText";
            this.Load += new System.EventHandler(this.FrmSendText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtfMessage;
        private Button btnSend;
        private RichTextBox richTextBox1;
        private Button btnSendText;
        private Label label1;
        private ComboBox cmbPinCode;
    }
}