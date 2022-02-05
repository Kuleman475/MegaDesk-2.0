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
        List<DeskQuote> ListDeskQuotes;

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

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ListDeskQuotes = new List<DeskQuote>();
            foreach (DeskQuote deskQuote in Program.deskQuoteList)
            {
                if (deskQuote.DesktopMaterial == comboBox1.SelectedIndex)
                {
                    ListDeskQuotes.Add(deskQuote);
                }

            }
            DataGridView.DataSource = ListDeskQuotes;
        }

        private void bindingSource2_CurrentItemChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
              
                
            }
            else if (comboBox1.SelectedIndex == 1)
            {

            }
            else if (comboBox1.SelectedIndex == 2)
            {

            }
            else if (comboBox1.SelectedIndex == 3)
            {

            }
            else if (comboBox1.SelectedIndex == 4)
            {

            }
        }
    }
}
