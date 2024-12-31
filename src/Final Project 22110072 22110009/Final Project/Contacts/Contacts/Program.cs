using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contacts
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Random random = new Random();
            string filePath = "contacts.txt";

            if (!File.Exists(filePath))
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    for (int i = 0; i < 200; i++)
                    {
                        int contactID = random.Next(1000, 10000);
                        writer.WriteLine(contactID);
                    }
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ContactApp());
        }
    }
}
