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
    public partial class TTT1 : Form
    {
        bool againstComputer = false;
        bool turn = true;
        int count = 0;

        public TTT1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (P1.Text == string.Empty || p2.Text == string.Empty)
            {
               if( MessageBox.Show("First Enter Player Names","Tic Tac Toe", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    P1.Focus();
                }
            }
            else
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
                count++;
                turn = !turn;
                b.Enabled = false;
                checkForWinner();
            }
            if (!turn && againstComputer)
            {
                computerMove();
            }
        }

        private void computerMove()
        {
            //priority 1:  get tick tac toe
            //priority 2:  block x tic tac toe
            //priority 3:  go for corner space
            //priority 4:  pick open space
            if (count == 9)
                return;
            Button move = null;

            //look for tic tac toe opportunities
            move = look_for_win_or_block("O"); //look for win
            if (move == null)
            {
                move = look_for_win_or_block("X"); //look for block
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    }//end if
                }//end if
            }//end if

            move.PerformClick();
        }

        private Button look_for_open_space()
        {
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }//end if
            }//end if

            return null;
        }

        private Button look_for_corner()
        {
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;

            return null;
        }

        private Button look_for_win_or_block(string mark)
        {
            Console.WriteLine("Looking for win or block:  " + mark);
            //HORIZONTAL TESTS
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            //VERTICAL TESTS
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Design  By Trufanda", "Who made this thing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkForWinner()
        {
            bool aWinner = false;
            bool draw = false;

            if (count == 9)
                draw = true;
            if (A1.Text == A2.Text && A2.Text == A3.Text && A1.Enabled == false)
                aWinner = true;
            else if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Enabled == false)
                aWinner = true;
            else if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Enabled == false)
                aWinner = true;
            else if (A1.Text == B1.Text && B1.Text == C1.Text && A1.Enabled == false)
                aWinner = true;
            else if (A2.Text == B2.Text && B2.Text == C2.Text && A2.Enabled == false)
                aWinner = true;
            else if (A3.Text == B3.Text && B3.Text == C3.Text && A3.Enabled == false)
                aWinner = true;
            else if (A1.Text == B2.Text && B2.Text == C3.Text && A1.Enabled == false)
                aWinner = true;
            else if (A3.Text == B2.Text && B2.Text == C1.Text && A3.Enabled == false)
                aWinner = true;
            if (aWinner)
            {
                disableButton();
                string winner = string.Empty;
                if (turn)
                {
                    winner = p2.Text;
                    owc.Text = (int.Parse(owc.Text) + 1).ToString();
                }
                else
                {
                    winner = P1.Text;
                    xwc.Text = (int.Parse(xwc.Text) + 1).ToString();
                }
                if(MessageBox.Show(winner + " wins \n Do you want play again with same settings", "Tic Tac Toe", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (againstComputer)
                        againstComputerToolStripMenuItem.PerformClick();
                    else
                        againstHumanToolStripMenuItem.PerformClick();
                }
            }
            else if (draw)
            {
                dwc.Text = (int.Parse(dwc.Text) + 1).ToString();
                if (MessageBox.Show(" its a draw  Shame on both of you \n Do you want play again with same settings", "Tic Tac Toe", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (againstComputer)
                        againstComputerToolStripMenuItem.PerformClick();
                    else
                        againstHumanToolStripMenuItem.PerformClick();
                }
            }

        }

        private void disableButton()
        {
            foreach (Control c in Controls)
            {
                if (c is Button)
                    c.Enabled = false;
            }
        }

        private void againstHumanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                    c.Text = string.Empty;
                }
                count = 0;
                turn = true;
                

            }
            p2.Enabled = true;
            if(againstComputer)
                resetCounterToolStripMenuItem.PerformClick();
            againstComputer = false;

            
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
         
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void resetCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xwc.Text = "0";
            owc.Text = "0";
            dwc.Text = "0";
        }

        private void TTT1_Load(object sender, EventArgs e)
        {
            againstComputerToolStripMenuItem.PerformClick();
        }

        private void againstComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            againstComputer = true;
            p2.Text = "Computer";
            p2.Enabled = false;
            if (!againstComputer)
                resetCounterToolStripMenuItem.PerformClick();
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                    c.Text = string.Empty;
                }
                count = 0;
                turn = true;
            }
        }
    }
}
