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
        public ViewAllQuotes()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MM = new MainMenu();
            MM.ShowDialog();
            this.Close();
        }
    }
}
