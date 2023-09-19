namespace Whatsapp
{
    partial class FrmWhatsapp
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
            this.btnText = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(98, 149);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(229, 108);
            this.btnText.TabIndex = 0;
            this.btnText.Text = "Send Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(347, 149);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(298, 108);
            this.btnImage.TabIndex = 1;
            this.btnImage.Text = "Send Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // FrmWhatsapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnText);
            this.Name = "FrmWhatsapp";
            this.Text = "FrmWhatsapp";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnText;
        private Button btnImage;
    }
}