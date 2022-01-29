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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddQuote_Click(object sender, EventArgs e)
        {


            this.Hide();
            AddQuote AQ = new AddQuote();
            AQ.ShowDialog();
            this.Close();
        }

        private void Exit_Leave(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAllQuotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllQuotes VAQ = new ViewAllQuotes();
            VAQ.ShowDialog();
            this.Close();
        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchQuotes SQ = new SearchQuotes();
            SQ.ShowDialog();
            this.Close();
        }
    }
}
