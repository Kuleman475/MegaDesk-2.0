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
     
    
    public partial class AddQuote : Form
    {
      
        public AddQuote()
        { 
            InitializeComponent();
        }
            private DeskQuote _displayQuote = new DeskQuote();
        private void Submit_Click(object sender, EventArgs e)
        {

            string WidthString = Width.Text;
            string DepthString = Depth.Text;
            int selectedIndex = comboBox1.SelectedIndex + 1;
            int selectedRush = RushCombo.SelectedIndex + 1;

            string WidthCheck = Desk.ValidteWidth(WidthString);
            string DepthCheck = Desk.ValidteDepth(DepthString);

            int deskMats = Desk.getdeskMat(selectedIndex);
            int RushOrder = Desk.getdeskMat(selectedRush);

              int DepthVal = Convert.ToInt32(Depth.Text);
            int WidthVal = Convert.ToInt32(Width.Text);
            int result = Desk.GetArea(DepthVal, WidthVal);

            if (String.IsNullOrEmpty(FirstName.Text)) 
            {
                MessageBox.Show("Please put in your first name");
            }
            else if (String.IsNullOrEmpty(LastName.Text))
            {
                MessageBox.Show("Please put in your last name");
            }

            else if (WidthCheck == "p" || WidthCheck == "")
            {
                MessageBox.Show("Width must be between 24 and 96");
            }
            else if (DepthCheck == "p" || DepthCheck == "")
            {
                MessageBox.Show("Depth must be between 12 and 48");
            }
            else if (deskMats == 0)
            {
                MessageBox.Show("Please Choose a material");
            }
            else if (RushOrder == 0)
            {
                MessageBox.Show("Please Choose a material");
            }
            
            else
            {



                Desk myDeskMaterial = new Desk();
       myDeskMaterial.CurrentDesktopMaterial = (Desk.DesktopMaterial)comboBox1.SelectedIndex;

       DeskQuote myDesk = new DeskQuote();
       myDesk.CurrentRushCombo = (DeskQuote.RushCombo)RushCombo.SelectedIndex;

     


                DeskQuote.FirstName = FirstName.Text;
                DeskQuote.LastName = LastName.Text;

                Desk.Width = Width.Text;
                Desk.Depth = Depth.Text;
                Desk.Drawers = Convert.ToInt32(DrawerDrop.Value);
                Desk.DesktopMaterail = Convert.ToInt32((Desk.DesktopMaterial)comboBox1.SelectedIndex);
        
                DeskQuote.RushOrder = Convert.ToInt32((DeskQuote.RushCombo)RushCombo.SelectedIndex);

                this.Hide();
                DisplayQuote DQ = new DisplayQuote();
                DQ.ShowDialog();
               this.Close();

            }

        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MM = new MainMenu();
            MM.ShowDialog();
            this.Close();
        }

       

        private void Width_Validating(object sender, CancelEventArgs e)

        {
            /*
            int Widths;
            string WidthString = Width.Text;
            try
            {
                Widths = int.Parse(WidthString);
                MessageBox.Show("Thank you");
               
            }
            catch
            {
                MessageBox.Show("enter a number"); 
                Width.Text = "";
            }

            */

            string WidthString = Width.Text;

        

            for (int i = 0; i < WidthString.Length; i++)
            {

                if (char.IsNumber(WidthString[i]))
                {
             string WidthCheck = Desk.ValidteWidth(WidthString);

                    if (WidthCheck == "p" || WidthCheck == "")
                    {
                        Width.BackColor = Color.Red;
                    }
                    else
                    {
                        Width.BackColor = Color.White;
                    }


                }

                else
                {
                    
                    MessageBox.Show("Please enter a valid number");
                    Width.Text = "";
                    Width.BackColor = Color.Red;
                    Width.Select();
                }
             
            }
String WidthChecks = Desk.ValidteWidth(WidthString);
            if (WidthChecks == "p" || WidthChecks == "")
                {
                    Width.BackColor = Color.Red;
                MessageBox.Show("Width mst be between 24 and 96");
                Width.Text = "";
                }




        }

        private void Width_TextChanged(object sender, EventArgs e)
        {

        }

        private void Depth_TextChanged(object sender, EventArgs e)
        {

        }


        public static bool nonNumberEntered = false;
        private void Depth_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
                MessageBox.Show("Must Enter a number");
                Depth.BackColor = Color.Red;
                Depth.Select();

            }
            



        }

        private void Depth_KeyDown(object sender, KeyEventArgs e)

        {
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void Drawers_TextChanged(object sender, EventArgs e)
        {


        }

        private void DrawerDrop_ValueChanged(object sender, EventArgs e)
        {
            int Max = 7;
            if (DrawerDrop.Value <= Max)
            {


            }
            else
            {
                MessageBox.Show("Please Enter a number between 0 and 7");
                DrawerDrop.Value = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex + 1;
            Object selectedItem = comboBox1.SelectedItem;

        }

        private void Depth_Leave(object sender, EventArgs e)
        {
       
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Desk.DesktopMaterial));

            
        }

        private void RushCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRush = RushCombo.SelectedIndex;
            Object selectedItem = RushCombo.SelectedItem;
        }

        private void RushCombo_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void RushCombo_DropDown(object sender, EventArgs e)
        {
            RushCombo.DataSource = Enum.GetValues(typeof(DeskQuote.RushCombo));
        }

        private void Depth_Validating(object sender, CancelEventArgs e)
        {
            string DepthString = Depth.Text;
            string DepthCheck = Desk.ValidteDepth(DepthString);
            if (DepthCheck == "p" || DepthCheck == "")
            {
                MessageBox.Show("Depth must be between 12 and 48");
                Depth.BackColor = Color.Red;
                Depth.Text = "0";
                Depth.Select();
            }
            else
            {
                Depth.BackColor = Color.White;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

