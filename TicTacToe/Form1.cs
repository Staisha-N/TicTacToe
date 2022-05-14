using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool whosturn = true; //Who's turn is it? T = X turn, F = O turn
        int numTurns = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (whosturn)
                b.Text = "X";
            else
                b.Text = "O";

            whosturn = !whosturn;
            b.Enabled = false;
            numTurns++;

            checkForWon();
        }

        private void checkForWon()
        {
            bool game_won = false;

            //check horizontal lines

            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
                game_won = true;
            if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
                game_won = true;
            if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
                game_won = true;

            //check vertical lines

            if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
                game_won = true;
            if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
                game_won = true;
            if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
                game_won = true;

            //diagonal check lines

            if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
                game_won = true;
            if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button2.Enabled))
                game_won = true;


            if (game_won)
            {
                //disableAll ();
                String declare_winner = "";
                if (whosturn)
                    declare_winner = "O";
                else
                    declare_winner = "X";

                MessageBox.Show(declare_winner + " wins!", "Great Job!");
            }
            else
            {
                if (numTurns ==9)
                    MessageBox.Show("Draw!", "Better luck next time!");
            }

            //private void disableAll()
            //{
                //foreach(Control c in Controls)
                //{
                    //Button b = (Button)c;
                    //b.Enabled=false;
                //}
            //}

        }
    }
}
