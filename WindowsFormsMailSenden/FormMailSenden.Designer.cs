namespace WindowsFormsMailSenden
{
    partial class FormMailSenden
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
            this.labelMailAdresse = new System.Windows.Forms.Label();
            this.labelMailText = new System.Windows.Forms.Label();
            this.textBoxMailAdresse = new System.Windows.Forms.TextBox();
            this.textBoxMailText = new System.Windows.Forms.TextBox();
            this.buttonSenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMailAdresse
            // 
            this.labelMailAdresse.AutoSize = true;
            this.labelMailAdresse.Location = new System.Drawing.Point(16, 26);
            this.labelMailAdresse.Name = "labelMailAdresse";
            this.labelMailAdresse.Size = new System.Drawing.Size(70, 13);
            this.labelMailAdresse.TabIndex = 0;
            this.labelMailAdresse.Text = "Mail-Adresse:";
            // 
            // labelMailText
            // 
            this.labelMailText.AutoSize = true;
            this.labelMailText.Location = new System.Drawing.Point(16, 58);
            this.labelMailText.Name = "labelMailText";
            this.labelMailText.Size = new System.Drawing.Size(53, 13);
            this.labelMailText.TabIndex = 1;
            this.labelMailText.Text = "Mail-Text:";
            // 
            // textBoxMailAdresse
            // 
            this.textBoxMailAdresse.Location = new System.Drawing.Point(90, 23);
            this.textBoxMailAdresse.Name = "textBoxMailAdresse";
            this.textBoxMailAdresse.Size = new System.Drawing.Size(303, 20);
            this.textBoxMailAdresse.TabIndex = 2;
            // 
            // textBoxMailText
            // 
            this.textBoxMailText.Location = new System.Drawing.Point(89, 57);
            this.textBoxMailText.Multiline = true;
            this.textBoxMailText.Name = "textBoxMailText";
            this.textBoxMailText.Size = new System.Drawing.Size(304, 61);
            this.textBoxMailText.TabIndex = 3;
            // 
            // buttonSenden
            // 
            this.buttonSenden.Location = new System.Drawing.Point(413, 95);
            this.buttonSenden.Name = "buttonSenden";
            this.buttonSenden.Size = new System.Drawing.Size(75, 23);
            this.buttonSenden.TabIndex = 4;
            this.buttonSenden.Text = "Senden";
            this.buttonSenden.UseVisualStyleBackColor = true;
            this.buttonSenden.Click += new System.EventHandler(this.buttonSenden_Click);
            // 
            // FormMailSenden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 145);
            this.Controls.Add(this.buttonSenden);
            this.Controls.Add(this.textBoxMailText);
            this.Controls.Add(this.textBoxMailAdresse);
            this.Controls.Add(this.labelMailText);
            this.Controls.Add(this.labelMailAdresse);
            this.Name = "FormMailSenden";
            this.Text = "Mail senden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMailAdresse;
        private System.Windows.Forms.Label labelMailText;
        private System.Windows.Forms.TextBox textBoxMailAdresse;
        private System.Windows.Forms.TextBox textBoxMailText;
        private System.Windows.Forms.Button buttonSenden;
    }
}

