using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMailSenden
{
    internal class MailSenden
    {
        public MailSenden() { }
        public void sendMail(String mailAdresse, String mailText)
        {
            MessageBox.Show(mailAdresse + "\n" + mailText, "Information");
        }
    }
}
