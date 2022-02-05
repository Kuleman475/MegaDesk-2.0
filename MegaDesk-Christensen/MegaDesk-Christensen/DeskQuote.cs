using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;




namespace MegaDesk_Christensen
{
    public class DeskQuote
    {


        static string FName, LName;
        static int Rushnum;
        public string FirstName
        {
            get
            {
                return FName;
            }
            set
            {
                FName = value;
            }
        }
        public string LastName
        {
            get
            {
                return LName;

            }
            set
            {
                LName = value;
            }
        }
        public int RushOrder
        {
            get
            {
                return Rushnum;
            }
            set
            {
                Rushnum = value;
            }
        }

        public enum RushCombo
        {
            Three = 0,
            Five = 1,
            Seven = 2,
            Fourteen = 3
        }

        private RushCombo _rushCombo;

        public RushCombo CurrentRushCombo
        {
            get { return _rushCombo; }
            set { _rushCombo = value; }
        }


        public static string RushorderDays(int RushOrder)
        {
            if (RushOrder == 0)
            {
                return "3 Day Shipping";
            }
            else if (RushOrder == 1)
            {
                return "5 Day Shipping";
            }
            else if (RushOrder == 2)
            {
                return "7 Day Shipping";
            }

            return "14 Day Shipping";
        }
        public static string deskmatsNames(int DesktopMaterail)
        {
            if (DesktopMaterail == 0)
            {
                return "Oak";
            }
            else if (DesktopMaterail == 1)
            {
                return "Laminate";
            }
            else if (DesktopMaterail == 2)
            {
                return "Pine";
            }
            else if (DesktopMaterail == 3)
            {
                return "Rosewood";
            }
            else if (DesktopMaterail == 4)
            {
                return "Veneer";
            }
            return "";
        }

        public static int deskmatsTotal(int DesktopMaterail)
        {
            if (DesktopMaterail == 0)
            {
                return DesktopMaterail = 200;
            }
            else if (DesktopMaterail == 1)
            {
                return DesktopMaterail = 100;
            }
            else if (DesktopMaterail == 2)
            {
                return DesktopMaterail = 50;
            }
            else if (DesktopMaterail == 3)
            {
                return DesktopMaterail = 300;
            }
            else if (DesktopMaterail == 4)
            {
                return DesktopMaterail = 125;
            }
            return 5;
        }
        public static int rushNumdays(int rushNum)
        {
            if (rushNum == 0)
            {
                return rushNum = 3;
            }
            else if (rushNum == 1)
            {
                return rushNum = 5;
            }
            else if (rushNum == 2)
            {
                return rushNum = 7;
            }
            else
            {
                return rushNum = 14;
            }
        }
        public static int RushnumTotal(int rushNum, int Width, int Depth)
        {



            if (rushNum == 0)
            {
                if ((Width * Depth) < 1000)
                {
                    return rushNum = 60;
                }
                else if ((Width * Depth) >= 1000 && (Width * Depth) <= 2000)
                {
                    return rushNum = 70;
                }
                else
                {
                    return rushNum = 80;
                }

            }
            else if (rushNum == 1)
            {
                if ((Width * Depth) < 1000)
                {
                    return rushNum = 40;
                }
                else if ((Width * Depth) >= 1000 && (Width * Depth) <= 2000)
                {
                    return rushNum = 50;
                }
                else
                {
                    return rushNum = 60;
                }

            }
            else if (rushNum == 2)
            {
                if ((Width * Depth) < 1000)
                {
                    return rushNum = 30;
                }
                else if ((Width * Depth) >= 1000 && (Width * Depth) <= 2000)
                {
                    return rushNum = 35;
                }
                else
                {
                    return rushNum = 40;
                }

            }
            return 0;
        }

        public int Total(int rushNumber, int Width, int Depth, int Drawers, int DesktopMaterail)
        {
            int deskWidth = Convert.ToInt32(Desk.Width);
            int deskDepth = Convert.ToInt32(Desk.Depth);
            int deskDrawers = Convert.ToInt32(Desk.Drawers);
            //   int deskMats = Convert.ToInt32(Desk.DesktopMaterail);   

            //   int rushNumber = RushnumTotal(rushNum, Width, Depth);
            int deskmattts = deskmatsTotal(DesktopMaterail);


            int total = 200 + (deskWidth * deskDepth) + (deskDrawers * 50) + deskmattts + rushNumber;
            return total;

        }

        public static List<DeskQuote> Load(string filename)
        {
            List<DeskQuote> quoteList = null;
            quoteList = new List<DeskQuote>();

            if (File.Exists(filename))
            {

                StreamReader textIn = new StreamReader(filename);
                try
                {
                    string JSONList = textIn.ReadToEnd();

                    MessageBox.Show("Inside public static List<DeskQuote> Load");
                    MessageBox.Show($"{JSONList}");

                    quoteList = JsonConvert.DeserializeObject<List<DeskQuote>>(JSONList);


                    MessageBox.Show($"{quoteList}");

                }
                catch
                {
                    return null;
                }
                finally
                {
                    if (textIn != null) textIn.Close();
                }
                return quoteList;
            }
            else
            {
                return null;
            }
        }

        public DeskQuote(string FirstName, string LastName, int Width, int Depth, int Drawers, int DesktopMaterial, string Date, int rushNum)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Width = Width;
            this.Depth = Depth;
            this.Drawers = Drawers;
            this.DesktopMaterial = DesktopMaterial;
            this.Date = Date;
            this.Price = this.Total(Convert.ToInt32(DeskQuote.RushnumTotal(this.RushOrder, Convert.ToInt32(Desk.Width), Convert.ToInt32(Desk.Depth))), Convert.ToInt32(Desk.Width), Convert.ToInt32(Desk.Depth), Desk.Drawers, Desk.DesktopMaterail);
            this.rushNum = RushOrder;

        }
        
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public int DesktopMaterial { get; set; }
        public string Date { get; set; }
        public int Price { get; set; }
        public int rushNum { get; set; }

     


   


}
}
