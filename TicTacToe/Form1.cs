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
        bool turn = true;
        int count = 0;

        public TTT1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            count++;
            turn = !turn;
            b.Enabled = false;
            checkForWinner();

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
                    winner = "O";
                    owc.Text = (int.Parse(owc.Text) + 1).ToString();
                }
                else
                {
                    winner = "X";
                    xwc.Text = (int.Parse(xwc.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " wins", "congrats");
            }
            if (draw)
            {
                MessageBox.Show("its a draw", caption: "Shame on both of you");
                dwc.Text = (int.Parse(dwc.Text) + 1).ToString();
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
    }
}
