using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slump_Tal_Grafiskt_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int AntalGissningar = 0;
        int slumptal;

        private void Form1_Load(object sender, EventArgs e)
        {
            Random tal = new Random();
            slumptal = tal.Next(1, 101);
        }

        private void ButtonRätta_Click(object sender, EventArgs e)
        {
            int gissning = Convert.ToInt32(TextBoxInmatning.Text);
            AntalGissningar++;
            LabelAntalGissningar.Text = ("Antal gissningar: " + AntalGissningar);
            if (gissning == slumptal)
            {
                Label.Text = "rätt gissat";
            }
            else if (gissning > slumptal)
            {
                Label.Text = "fel gissat, talet är mindre. gissa igen.";
            }
            else if (gissning < slumptal)
            {
                Label.Text = "fel gissat, talet är större. gissa igen.";
            }
        }

        

    }
}
