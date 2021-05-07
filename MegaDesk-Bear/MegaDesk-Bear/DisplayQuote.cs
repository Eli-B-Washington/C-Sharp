using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Bear
{
    public partial class DisplayQuote : Form
    {
        string name;
        int width;
        int depth;
        int numDrawers;
        int rush;
        string material;
        double total_area;
        int material_cost;
        double delivery_cost;
        double total;
        double drawer_cost;


        public DisplayQuote()
        {
            InitializeComponent();
        }

        public DisplayQuote(string name, int width, int depth, int numDrawers, string material, int rush, double total_area, int material_cost, double drawer_cost, double delivery_cost, double total) {
            InitializeComponent();
            this.name = name;
            this.width = width;
            this.depth = depth;
            this.numDrawers = numDrawers;
            this.rush = rush;
            this.material = material;
            this.total_area = total_area;
            this.material_cost = material_cost;
            this.delivery_cost = delivery_cost;
            this.drawer_cost = drawer_cost;
            this.total = total;
        


            name_label.Text = name;
            label2.Text = DateTime.Now.ToString();
            total_width.Text = width.ToString();
            total_depth.Text = depth.ToString();

            total_area_cost.Text = total_area.ToString();

            material_cost_total.Text = material_cost.ToString();

            drawer_count_total.Text = numDrawers.ToString();
            drawer_cost_total.Text = drawer_cost.ToString();
            material_total.Text = material;
            delivery_option_total.Text = rush.ToString();
            delivery_cost_total.Text = delivery_cost.ToString();
            total_total.Text = total.ToString();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote a = (AddQuote)Tag;
            a.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }



}
