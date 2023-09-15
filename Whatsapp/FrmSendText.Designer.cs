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
            this.btnSend.Location = new System.Drawing.Point(381, 630);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(191, 75);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send Text";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
      
           
        }

        #endregion

        private RichTextBox rtfMessage;
        private Button btnSend;
    }
}