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
    public partial class Number_Puzzle_Menu : Form
    {
        public Number_Puzzle_Menu()
        {
            InitializeComponent();
        }

        //Load game
        private void btn_play_Click(object sender, EventArgs e)
        {
            this.Refresh();
            this.Hide();
            Number_Puzzle_Game gameWindow = new Number_Puzzle_Game();
            gameWindow.Show();
        }

        //Display a MsgBox asking the user to exit or cancel
        private void btn_quit_Click(object sender, EventArgs e)
        {
            //Display a MsgBox asking the user to exit or cancel
            DialogResult iExit = MessageBox.Show("Are you sure you want to Quit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                //User Exit or Quit 
                Application.ExitThread();
            }
        }

        //Asking the user to exit or cancel after clicking Close Button
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Are you sure you want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
