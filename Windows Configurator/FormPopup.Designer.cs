namespace Windows_Configurator
{
    partial class FormPopup
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
            this.rtbPopup = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbPopup
            // 
            this.rtbPopup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPopup.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbPopup.Location = new System.Drawing.Point(12, 12);
            this.rtbPopup.Name = "rtbPopup";
            this.rtbPopup.ReadOnly = true;
            this.rtbPopup.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbPopup.Size = new System.Drawing.Size(360, 238);
            this.rtbPopup.TabIndex = 0;
            this.rtbPopup.Text = "12345678901234567890123456789012345678901234567890\n";
            // 
            // FormPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.rtbPopup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormPopup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPopup;
    }
}