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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        



             this.Load += new EventHandler(DataGridView_Load);
    }

    private void DataGridView_Load(System.Object sender, System.EventArgs e)
    {
        DataGridView.DataSource = Program.deskQuoteList;

    }
    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Desk.DesktopMaterial));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MM = new MainMenu();
            MM.ShowDialog();
            this.Close();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

     
    }
}
