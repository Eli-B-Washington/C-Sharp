using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Bear
{
    public class Desk
    {
        public Desk() { 
        }

        public int width { get; set; }
        public int depth { get; set; }
        public int numDrawers { get; set; }
        public string surfaceMaterial { get; set; }

        //public int rush_order { get; set; }

        public const int MINWIDTH = 24;


    }


}
