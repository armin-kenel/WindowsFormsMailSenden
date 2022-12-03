using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMailSenden
{
    public partial class FormMailSenden : Form
    {
        private MailSenden mailSenden;
        public FormMailSenden()
        {
            InitializeComponent();
            mailSenden = new MailSenden();
        }

        private void buttonSenden_Click(object sender, EventArgs e)
        {
            String textMailAdresse = this.textBoxMailAdresse.Text;
            String textMail = this.textBoxMailText.Text;

            mailSenden.sendMail(textMailAdresse, textMail);
        }
    }
}
