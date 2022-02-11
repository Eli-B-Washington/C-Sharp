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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            addQuote.Tag = this;
            addQuote.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAllQuotes view = new ViewAllQuotes();
            view.Tag = this;
            view.Show(this);
            Hide();

        }

        private void search_quotes_Click(object sender, EventArgs e)
        {
            SearchQuotes search = new SearchQuotes();
            search.Tag = this;
            search.Show(this);
            Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
