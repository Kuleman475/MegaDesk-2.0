using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Christensen
{
    public partial class ViewAllQuotes : Form
    {
      // private List<DeskQuote> DeskQuotes();
        public ViewAllQuotes()
        {
            InitializeComponent();

           this.Load += new EventHandler(ViewAllQuotes_Load);
        }

        private void ViewAllQuotes_Load(System.Object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = Program.deskQuoteList;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MM = new MainMenu();
            MM.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        
        }


    }
}
