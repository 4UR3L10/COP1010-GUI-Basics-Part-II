using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlipper
{
    public partial class CoinFlipper : Form
    {
        public CoinFlipper()
        {
            InitializeComponent();
        }

        /**
         * Method for the Toss button of the program.
         * Generates a random number
         * Compares the value obtained in random and displays head or tails
         */
        private void TossButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int value = random.Next(1, 3);
            if (value == 1)
            {
                MessageBox.Show("HEAD");
                pictureBox1.Image = global::CoinFlipper.Properties.Resources.Head;
            }
            else
            {
                MessageBox.Show("TAIL");
                pictureBox1.Image = global::CoinFlipper.Properties.Resources.Tails;
            }
        }

        /**
         * Method for the clear button
         * The image equals null
         * 
         */
        private void ClearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
