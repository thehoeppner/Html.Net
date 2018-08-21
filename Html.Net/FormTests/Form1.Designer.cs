namespace FormTests
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdGenerateHtml = new System.Windows.Forms.Button();
            this.txtHtml = new System.Windows.Forms.RichTextBox();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // cmdGenerateHtml
            // 
            this.cmdGenerateHtml.Location = new System.Drawing.Point(12, 339);
            this.cmdGenerateHtml.Name = "cmdGenerateHtml";
            this.cmdGenerateHtml.Size = new System.Drawing.Size(146, 23);
            this.cmdGenerateHtml.TabIndex = 0;
            this.cmdGenerateHtml.Text = "Generate Html";
            this.cmdGenerateHtml.UseVisualStyleBackColor = true;
            this.cmdGenerateHtml.Click += new System.EventHandler(this.cmdGenerateHtml_Click);
            // 
            // txtHtml
            // 
            this.txtHtml.Location = new System.Drawing.Point(12, 12);
            this.txtHtml.Name = "txtHtml";
            this.txtHtml.Size = new System.Drawing.Size(311, 321);
            this.txtHtml.TabIndex = 1;
            this.txtHtml.Text = "";
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(329, 12);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(250, 321);
            this.browser.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 374);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.txtHtml);
            this.Controls.Add(this.cmdGenerateHtml);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdGenerateHtml;
        private System.Windows.Forms.RichTextBox txtHtml;
        private System.Windows.Forms.WebBrowser browser;
    }
}

