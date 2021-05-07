using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Bear
{
    public class Desk
    {
        public const int MAXWIDTH = 24;
        public const int MINWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        public Desk() { 
        }

        public int width { get; set; }
        public int depth { get; set; }
        public int numDrawers { get; set; }
        public string surfaceMaterial { get; set; }

        //public int rush_order { get; set; }

        public enum DesktopMaterial {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
        }

    }


}
