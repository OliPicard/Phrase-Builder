using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phrase_Builder
{
    public partial class phraseBuilder : Form
    {
        public phraseBuilder()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] NameListOne = new string[] { "Cosmic Panda", "Pizza Delivery Boy", "Boom Goes the Dinimatie","why is the rum gone?","Grumpy Cat","Serious Octopus","Alt+ F4","Tasty Pickle","NoNoNoNo Cat","Oh Long Johnson","Chocolate Rain","Charlie Sheen"};
            Random pepperpig = new Random(); //create a new random.
            int length = NameListOne.Length; //get the length of the string
            int rand1 = (int)(pepperpig.Next(0,12)); //provide pepperpig(random) guidence.
            label2.Text = (NameListOne[rand1]);//issue command to list said item.
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crafted with love by OliPicard");
        }
    }
}
