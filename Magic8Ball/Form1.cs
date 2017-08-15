using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The Magic for the ball is done all in this button.
        private void askButton_Click(object sender, EventArgs e)
        {
            //Call the random class
            Random rnd = new Random();

            //Create a variable that holds a random number from 1-15
            int num = rnd.Next(1, 15);

            //Assign the Image source to the resource folder with 8 ball images labeled _1 - _15
            pictureBox1.Image = Properties.Resources._1;

            //Switch the image based on the number that shows up
            switch(num)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._6;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._7;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources._8;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources._9;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources._10;
                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources._11;
                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources._12;
                    break;
                case 13:
                    pictureBox1.Image = Properties.Resources._13;
                    break;
                case 14:
                    pictureBox1.Image = Properties.Resources._14;
                    break;
                case 15:
                    pictureBox1.Image = Properties.Resources._15;
                    break;
            }
        }
    }
}
