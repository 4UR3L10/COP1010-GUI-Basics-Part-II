using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondAssignment
{
    public partial class Form1 : Form
    {
        /*
         * I guess this is main 
         */
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * I dont know que pinga es esto.
         */
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /* 
         * This method creates a random number in order to determine which image to display (either head or tails)
         * If head is shown then show a message box with string heads or tail.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 3);

            if (randomNumber.Equals(1))
            {
                pictureBox1.Image = Properties.Resources.Head;
                MessageBox.Show("Heads!");
            }
            else
            {
                pictureBox1.Image = Properties.Resources.Tails;
                MessageBox.Show("Tails");
            }
        }

        /* 
         * This method clears the pictureBox.
         */
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
