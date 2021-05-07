using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Bear
{
    public class DeskQuote
    {
        int deskQuoteId;
        double deskQuote;
        int basePrice = 200;
        string name;
        int width;
        int depth;
        int numDrawers;
        int rush;
        string material;

        public DeskQuote()
        {
  
        }

        public DeskQuote(string name, int width, int depth, int numDrawers, string material, int rush)
        {
            this.name = name;
            this.width = width;
            this.depth = depth;
            this.numDrawers = numDrawers;
            this.rush = rush;
            this.material = material;
        }



        public int rushOrderCost(double desk_size, int rush_order)
        {
            if (desk_size < 1000 && rush_order == 3)
            {
                return 60;
            }
            else if (desk_size < 1000 && rush_order == 5)
            {
                return 40;
            }
            else if (desk_size < 1000 && rush_order == 7)
            {
                return 30;
            }
            else if (desk_size < 2000 && rush_order == 3)
            {
                return 70;
            }
            else if (desk_size < 2000 && rush_order == 5)
            {
                return 50;
            }
            else if (desk_size < 2000 && rush_order == 7)
            {
                return 35;
            }
            else if (desk_size > 2000 && rush_order == 3)
            {
                return 80;
            }
            else if (desk_size > 2000 && rush_order == 5)
            {
                return 60;
            }
            else if (desk_size > 2000 && rush_order == 7)
            {
                return 40;
            }
            else {
                return 0;
                    }
        }

        public int calculateSurfaceMaterialCost(string y) {
            int x;
            switch (y)
            {
                case "Laminate":
                    x = 100;
                    break;
                case "Oak":
                    x = 200;
                    break;
                case "Rosewood":
                    x = 300;
                    break;
                case "Veneer":
                    x = 125;
                    break;
                case "Pine":
                    x = 50;
                    break;
                default:
                    x = 0;
                    break;
            }
            return x;
        }


        public double calculateSurfaceAreaCost(double x, double y)
        {
            return x * y;
        }

        public double calculateDrawerCost(double x) {
            return x * 50;
        }


        public double calculateTotal(double a, double b, int c, int d) {
            return a + b + c + d + basePrice;
        }
 public double CalculateCost()
        {

            //deskquote.fullName = desk_width_1.Text;
            //desk.width = Convert.ToDouble(desk_width_1.Text);
            
            Desk desk = new Desk();
            
            desk.depth = depth;
            desk.width = width;
            desk.numDrawers = numDrawers;
            desk.surfaceMaterial = material;


            double drawer_cost = calculateDrawerCost(desk.numDrawers);
            double surface_area = calculateSurfaceAreaCost(desk.depth, desk.width);
            int surface_material = calculateSurfaceMaterialCost(desk.surfaceMaterial);
            int rush_cost = rushOrderCost(surface_area , rush);



            


            double total = calculateTotal(drawer_cost, surface_area, surface_material, rush_cost);
            return total;
        }
    }
}
