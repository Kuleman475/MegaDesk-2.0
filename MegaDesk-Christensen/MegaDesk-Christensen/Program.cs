using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Christensen
{
    internal static class Program
    {
        public static List<DeskQuote> deskQuoteList;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            deskQuoteList = DeskQuote.Load("desk_quote_list.json");

            //MessageBox.Show($"{deskQuoteList}");

            if (deskQuoteList == null)
            {
                deskQuoteList = new List<DeskQuote>();
            }

            Application.Run(new MainMenu());
        }
    }
}
