using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            do
            {
                var result = MessageBox.Show("Ich lösch dich du Hurensohn 00000000000000000000000000000000000000000000000000000", "!!!!!!!VIRUS!!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Danke", "!!!!!!!VIRUS!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Hurensohn", "!!!!!!!VIRUS!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } while (true);
        }
    }
}
