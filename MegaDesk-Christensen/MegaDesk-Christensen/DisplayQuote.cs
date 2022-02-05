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
    
    public partial class DisplayQuote : Form
    {
        //        private DeskQuote _displayQuote;
        private readonly DeskQuote myDesk;
        
        public DisplayQuote(DeskQuote myDesk)
        {  
            this.myDesk = myDesk;
          
            InitializeComponent();
        }  
      /*  public static void DisplayQuote(AddQuote displayQuot)
        {
          
            MessageBox.Show(displayQuot.FirstName);
            displayQuot.LastName = DeskQuote.LastName;
            string date = DateTime.Today.ToString("dd MMMM yyy");
            MessageBox.Show(date.ToString());
       
        }
  
*/
        private void label14_Click(object sender, EventArgs e)
        {
            
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MM = new MainMenu();
            MM.ShowDialog();
            this.Close();

        }

        private void nameLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
       //     myDesk.FirstName = DeskQuote.FirstName;

            MessageBox.Show(Program.deskQuoteList.Count().ToString());
          // int adddias = Convert.ToInt32(myDesk.rushNum);
            nameLabel.Text = myDesk.FirstName;
            WidthLabel.Text = myDesk.Width + " Inches";
            DepthLabel.Text = myDesk.Depth + " Inches";
            DrawersLabel.Text = myDesk.Drawers.ToString();
            MaterialsLabel.Text = myDesk.DesktopMaterial.ToString(); //DeskQuote.deskmatsNames(Desk.DesktopMaterail);
            OrderLabel.Text = myDesk.RushOrder.ToString(); //DeskQuote.RushorderDays(DeskQuote.RushOrder);
            TotalLabel.Text = "$ " + myDesk.Total(Convert.ToInt32(DeskQuote.RushnumTotal(myDesk.RushOrder, Convert.ToInt32(Desk.Width), Convert.ToInt32(Desk.Depth))), Convert.ToInt32(Desk.Width), Convert.ToInt32(Desk.Depth), Desk.Drawers, Desk.DesktopMaterail).ToString();
          // DateLabel.Text = DateTime.Today.AddDays(adddias).ToString("dd MMMM yyy");
            TodaysDAte.Text = DateTime.Today.ToString("dd MMMM yyyy");

            
        }

        private void TodaysDAte_Click(object sender, EventArgs e)
        {

        }
    }
}
