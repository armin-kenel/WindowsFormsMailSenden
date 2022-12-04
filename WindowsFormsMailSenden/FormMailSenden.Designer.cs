using System.Windows.Forms;

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
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.buttonSenden = new System.Windows.Forms.Button();
            this.labelPasswort = new System.Windows.Forms.Label();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
            this.labelTitel = new System.Windows.Forms.Label();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(16, 26);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(48, 13);
            this.labelAdresse.TabIndex = 1;
            this.labelAdresse.Text = "Adresse:";
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Location = new System.Drawing.Point(16, 52);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(30, 13);
            this.labelTitel.TabIndex = 2;
            this.labelTitel.Text = "Titel:";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(16, 77);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(31, 13);
            this.labelText.TabIndex = 3;
            this.labelText.Text = "Text:";
            // 
            // labelPasswort
            // 
            this.labelPasswort.AutoSize = true;
            this.labelPasswort.Location = new System.Drawing.Point(19, 150);
            this.labelPasswort.Name = "labelPasswort";
            this.labelPasswort.Size = new System.Drawing.Size(53, 13);
            this.labelPasswort.TabIndex = 4;
            this.labelPasswort.Text = "Passwort:";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(90, 23);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(303, 20);
            this.textBoxAdresse.TabIndex = 5;
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Location = new System.Drawing.Point(90, 48);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(303, 20);
            this.textBoxTitel.TabIndex = 6;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(89, 76);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(304, 61);
            this.textBoxText.TabIndex = 7;
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.Location = new System.Drawing.Point(90, 147);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.PasswordChar = '*';
            this.textBoxPasswort.Size = new System.Drawing.Size(303, 20);
            this.textBoxPasswort.TabIndex = 8;
            // 
            // buttonSenden
            // 
            this.buttonSenden.Location = new System.Drawing.Point(401, 147);
            this.buttonSenden.Name = "buttonSenden";
            this.buttonSenden.Size = new System.Drawing.Size(75, 23);
            this.buttonSenden.TabIndex = 9;
            this.buttonSenden.Text = "Senden";
            this.buttonSenden.UseVisualStyleBackColor = true;
            this.buttonSenden.Click += new System.EventHandler(this.buttonSenden_Click);
            // 
            // FormMailSenden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 187);
            this.Controls.Add(this.textBoxTitel);
            this.Controls.Add(this.labelTitel);
            this.Controls.Add(this.textBoxPasswort);
            this.Controls.Add(this.labelPasswort);
            this.Controls.Add(this.buttonSenden);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelAdresse);
            this.Name = "FormMailSenden";
            this.Text = "Mail senden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAdresse;
        private Label labelTitel;
        private Label labelText;
        private Label labelPasswort;
        public TextBox textBoxAdresse;
        public TextBox textBoxTitel;
        public TextBox textBoxText;
        public TextBox textBoxPasswort;
        public Button buttonSenden;
    }
}