﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool turn = true; // true  = X turn; false = Y turn;
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkForWinner();
        }

        private void checkForWinner()
        {
            bool winner = false;

            //horizontal
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled)) { winner = true; }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled)) { winner = true; }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled)) { winner = true; }
            //vertical
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled)) { winner = true; }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled)) { winner = true; }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled)) { winner = true; }
            //diagonal
            else if((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled)) { winner = true; }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled)) { winner = true; }

            if (winner)
            {
                disableButtons();
                String winnerIs = "";
                if (turn)
                {
                    winnerIs = "O";
                } else
                {
                    winnerIs = "X";
                }
                MessageBox.Show("Winner is " + winnerIs);
            }
            else
            {
                if(turn_count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
        }

        private void disableButtons()
        {
            foreach(Control c in Controls)
            {
                if(c.GetType() == typeof(Button))
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
        }
        
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just a normal Tic Tac Toe game. The winner gets candy.");
        }
    }
}
