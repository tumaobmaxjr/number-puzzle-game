using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Puzzle_Game_Project
{
    /* This is the structure of the game */
    public partial class Number_Puzzle_Game : Form
    {
        public Number_Puzzle_Game()
        {
            InitializeComponent();
        }

        //This is a function to check if the box is empty
        public void EmptyBoxChecker(Button Butt1, Button Butt2)
        {
            if(Butt2.Text == "")
            {
                Butt2.Text = Butt1.Text;
                Butt1.Text = "";
            }
        }

        int ctr;
        //Check if the puzzle be able to complete
        public void Checker()
        {
            if(button1.Text == "1" && button2.Text == "2" && button3.Text == "3" &&
               button4.Text == "4" && button5.Text == "5" && button6.Text == "6" &&
               button7.Text == "7" && button8.Text == "8" && button9.Text == "")
            {
                MessageBox.Show("Congratulations! You have successfully completed.", "Number Puzzle Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Add a feature to view the number of movements
            ctr = ctr + 1;
            textBox1.Text = "Moves: " + ctr;
        }
        
        //Shuffle the puzzle or button numbers
        public void toShuffle()
        {
            int[] bnum = new int[9];
            int i, j, rowcheck;
            Boolean flag = false;

            i = 1;
            do
            {
                Random rnd = new Random();
                rowcheck = Convert.ToInt32(rnd.Next(0, 8) + 1);

                for (j = 1; j <= i; j++)
                {
                    if (bnum[j] == rowcheck)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    bnum[i] = rowcheck;
                    i = i + 1;
                }
            }
            while (i <= 8);

            button1.Text = Convert.ToString(bnum[1]);
            button2.Text = Convert.ToString(bnum[2]);
            button3.Text = Convert.ToString(bnum[3]);
            button4.Text = Convert.ToString(bnum[4]);
            button5.Text = Convert.ToString(bnum[5]);
            button6.Text = Convert.ToString(bnum[6]);
            button7.Text = Convert.ToString(bnum[7]);
            button8.Text = Convert.ToString(bnum[8]);
            button9.Text = "";
        }

        //Game load...
        private void Number_Puzzle_Game_Load(object sender, EventArgs e)
        {
            toShuffle();
        }

        //Clicking button to shuffle the puzzle
        private void btn_shuffle_Click(object sender, EventArgs e)
        {
            toShuffle();
        }

        //It reset the entire game or puzzle
        private void btn_reset_Click(object sender, EventArgs e)
        {
            toShuffle();

            this.Refresh();
            this.Hide();
            Number_Puzzle_Game reset = new Number_Puzzle_Game();
            reset.Show();
        }

        //Clicking buttons to move the number tiles
        private void button1_Click_1(object sender, EventArgs e)
        {
            EmptyBoxChecker(button1, button2);
            EmptyBoxChecker(button1, button4);
            Checker();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EmptyBoxChecker(button2, button1);
            EmptyBoxChecker(button2, button3);
            EmptyBoxChecker(button2, button5);
            Checker();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            EmptyBoxChecker(button3, button2);
            EmptyBoxChecker(button3, button6);
            Checker();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmptyBoxChecker(button4, button1);
            EmptyBoxChecker(button4, button5);
            EmptyBoxChecker(button4, button7);
            Checker();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmptyBoxChecker(button5, button2);
            EmptyBoxChecker(button5, button4);
            EmptyBoxChecker(button5, button6);
            EmptyBoxChecker(button5, button8);
            Checker();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EmptyBoxChecker(button6, button3);
            EmptyBoxChecker(button6, button5);
            EmptyBoxChecker(button6, button9);
            Checker();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmptyBoxChecker(button7, button4);
            EmptyBoxChecker(button7, button8);
            Checker();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EmptyBoxChecker(button8, button5);
            EmptyBoxChecker(button8, button7);
            EmptyBoxChecker(button8, button9);
            Checker();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EmptyBoxChecker(button9, button6);
            EmptyBoxChecker(button9, button8);
            Checker();
        }

        //Asking the user to exit or cancel after clicking Close Button
        private void Number_Puzzle_Game_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Are you sure you want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
