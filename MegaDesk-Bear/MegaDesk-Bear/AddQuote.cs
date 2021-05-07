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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void depth_label_Click(object sender, EventArgs e)
        {

        }


        private void rush_order_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void num_drawers_1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click_1(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(desk_width_1.Text, "VALID FORM!");


                string name = customer_name_value.Text;
                int width = int.Parse(desk_width_1.Text);
                int depth = int.Parse(desk_depth_1.Text);
                int numDrawers = (int)num_drawers_1.Value;
                string material = desktop_material.GetItemText(desktop_material.SelectedItem);
                string rush1 = (rush_order.GetItemText(rush_order.SelectedItem));
                //Console.WriteLine(item_selected_1);
                int rush = int.Parse(rush1);
                DeskQuote deskquote = new DeskQuote(name, width, depth, numDrawers, material, rush);
                double desk_size = width * depth;

                int material_cost = deskquote.calculateSurfaceMaterialCost(material);
                double drawer_cost = deskquote.calculateDrawerCost(numDrawers);
                double delivery_cost = deskquote.rushOrderCost(desk_size, rush);
                double total_area = deskquote.calculateSurfaceAreaCost(width, depth);
                double total = deskquote.CalculateCost();
                deskquote.CalculateCost();


                DisplayQuote display = new DisplayQuote(name, width, depth, numDrawers, material, rush, total_area, material_cost, drawer_cost, delivery_cost, total);
                display.Tag = this;
                display.Show(this);
                Hide();
            }
            

        }

        private void desk_width_1_Validating(object sender, EventArgs e)
        {


            int f = int.Parse(desk_width_1.Text);
            

            if (f < 24 || f > 96)
            {
                desk_width_1.Focus();
                System.Windows.Forms.MessageBox.Show("Please Enter a Value From 24 to 96");

            }
            
        }

        private void desk_width_1_Validating(object sender, CancelEventArgs e)
        {
            int y = 0;
            if (string.IsNullOrWhiteSpace(desk_width_1.Text) == false){
                y = int.Parse((desk_width_1.Text));
            }

            if (string.IsNullOrWhiteSpace(desk_width_1.Text) || y < 24 || y > 96)
            {
                e.Cancel = true;
                desk_width_1.Focus();
                errorProvider1.SetError(desk_width_1, "Enter a number from 24 to 96");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(desk_width_1, "");
            }
        }

        private void desk_depth_1_Validating(object sender, CancelEventArgs e)
        {
            int y = 0;
            if (string.IsNullOrWhiteSpace(desk_depth_1.Text) == false)
            {
                y = int.Parse((desk_depth_1.Text));
            }

            if (string.IsNullOrWhiteSpace(desk_depth_1.Text) || y < 12 || y > 48)
            {
                e.Cancel = true;
                desk_width_1.Focus();
                errorProvider1.SetError(desk_depth_1, "Enter a number from 12 to 48");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(desk_depth_1, "");
            }
        }

        private void customer_name_value_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(customer_name_value.Text))
            {
                e.Cancel = true;
                desk_width_1.Focus();
                errorProvider1.SetError(customer_name_value, "Empty Value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(customer_name_value, "");
            }
        }

        private void return1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
