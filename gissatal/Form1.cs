using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gissatal
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        int nummer;
        int guesses =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text=nummer.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess =int .Parse(textBox1.Text);
            guesses = guesses + 1;

            if (guess == nummer)
            {
                nummer = rng.Next(1,20);
                MessageBox.Show("Du gisssade rätt efter " + guesses.ToString() + "försök!");
                guesses = 0;
            }
            else if (guess > nummer)
            {
                MessageBox.Show("Du gissade för högt!");    
            }
            else if (guess<nummer)
            {
                MessageBox.Show("Du gissde för lågt!");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            nummer = rng.Next(1,20) ;
           
        }
    }
}

