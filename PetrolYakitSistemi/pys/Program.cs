using System;
using System.Windows.Forms;

namespace pys
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // İlk açılacak form burada belirleniyor
            Application.Run(new Form2());
        }
    }
}
