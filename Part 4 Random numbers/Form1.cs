using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4_Random_numbers
{
    public partial class RandomNumbers : Form
    {
        Random generator = new Random();
        public RandomNumbers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numbermin = Convert.ToInt32(txtmin.Text);
            int numbermax = Convert.ToInt32(txtmax.Text);
            int numbertotal = generator.Next(numbermin, numbermax);
            lblnumbers.Text = numbertotal + "";
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numbermin = Convert.ToInt32(txtmin.Text);
            int numbermax = Convert.ToInt32(txtmax.Text);
            lblnumbers.Text = (generator.Next(numbermin, numbermax)  +generator.NextDouble()) + "";
        }
    }
}
