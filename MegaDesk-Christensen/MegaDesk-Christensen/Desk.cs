using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Christensen
{
    internal class Desk
    {

        static string widthnum, dephtNum;
        static int drawersnum, deskMatNum;
       
        public static string Width
        {
            get
            {
                return widthnum;
            }
            set
            {
                widthnum = value;
            }
        }
        public static string Depth
        {
            get
            {
                return dephtNum;

            }
            set
            {
                dephtNum = value;
            }
        }

        public static int Drawers
        {
            get
            {
                return drawersnum;
            }
            set
            {
                drawersnum = value;
            }
        }

        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;



        public const int MAXDEPTH = 48;
        public const int MINDEPTH = 11;

    
        public static string ValidteWidth(string WidthString)
        {

            int WidthVal = Convert.ToInt32(WidthString);

            if (WidthVal >= Desk.MINWIDTH && WidthVal <= Desk.MAXWIDTH)
            {
               
                return WidthString;
            }
            return "p";
        }
        public static string ValidteDepth(string DepthString)
        {
            
            int DepthVal = Convert.ToInt32(DepthString);

            if (DepthVal > Desk.MINDEPTH && DepthVal <= Desk.MAXDEPTH)
            {

                return DepthString;
            }
            return "p";
        }
        public static int GetArea(int Depth, int Width)
        {

            return Depth * Width;
        }


        public static int getdeskMat(int selectedIndex)
        {

            return selectedIndex;
        }

        public static int DesktopMaterail
        {
            get
            {
                return deskMatNum;
            }
            set
            {
                deskMatNum = value;
            }
        }

        public enum DesktopMaterial
        {
            Oak = 0,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }

        private DesktopMaterial _desktopMaterial;

        public DesktopMaterial CurrentDesktopMaterial
        {
            get { return _desktopMaterial; }
            set { _desktopMaterial = value; }
        }




        /*
        public Account(string inName, string inAddress,
 decimal inBalance)
        {
            name = inName;
            address = inAddress;
            balance = inBalance;
        }
    }

    const int MAX_CUST = 100;
        deskquoteArray[] deskArray = new deskquoteArray[MAX_CUST];//(DeskQuote.FirstName, DeskQuote.LastName, Desk.Width, Desk.Depth, Desk.Drawers.ToString(), Desk.DesktopMaterail.ToString());

        deskArray[0] = new deskquoteArray(DeskQuote.FirstName, DeskQuote.LastName, Desk.Width, Desk.Depth, Desk.Drawers.ToString(), Desk.DesktopMaterail.ToString());
        /*
         * const int MAX_CUST = 100;
                        Account[] Accounts = new Account[MAX_CUST];
                        Accounts[0] = new Account("Rob", "Robs House",
                        1000000);
                        Accounts[1] = new Account("Jim", "Jims House");
                        Accounts[2] = new Account("Fred");





        const int MAX_CUST = 100;
 Account[] Bank = new Account[MAX_CUST];
 Bank[0].Name = "Rob";
 Bank[0].State = AccountState.Active;
 Bank[0].Balance = 1000000;
 Bank[1].Name = "Jim";
 Bank[1].State = AccountState.Frozen;
 Bank[1].Balance = 0;

        */

        /*
                const int MAX_CUST = 100;
                Desk[] Bank = new Desk[MAX_CUST];
                Bank[0].Firstname = DeskQuote.FirstName;
         Bank[0].State = AccountState.Active;
         Bank[0].Balance = 1000000;
         Bank[1].Name = "Jim";
         Bank[1].State = AccountState.Frozen;
         Bank[1].Balance = 0;
        */
        /*
        struct Account
        {
           // public AccountState State;
            public string Name;
            public string Address;
            public int AccountNumber;
            public int Balance;
            public int Overdraft;
        }

        const int MAX_CUST = 100;

        AccountState[] states = new AccountState[MAX_CUST];
        string[] Name = new string[MAX_CUST];
        

        int[] Width = new int[MAX_CUST];
        int[] Depth = new int[MAX_CUST];
        int[] Drawers = new int[MAX_CUST];



        Desk.Account RobsAccount;

        Desk[] Desks = new Desk[MAX_CUST];
        Desk[0] Width = Desk.Width.ToString();
                Desk[0].Depth = Desk.Depth;
                Desk[0].Drawers = Convert.ToInt32(DrawerDrop.Value);
                Desks[0].CurrentDesktopMaterial = (Desk.DesktopMaterial) comboBox1.SelectedItem;

        DeskQuote[] deskQuotes = new DeskQuote[MAX_CUST];
        deskQuotes[0].Name = DeskQuote.FirstName + DeskQuote.LastName;
               */
            


    }


}
