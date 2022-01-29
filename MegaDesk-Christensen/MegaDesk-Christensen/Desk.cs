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

    }
    

}
