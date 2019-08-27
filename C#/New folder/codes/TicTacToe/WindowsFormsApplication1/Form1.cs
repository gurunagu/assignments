using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("press YES to play with AI or NO for 2 players", "Select Option", buttons);
            if (result == DialogResult.Yes)
            {
                ai = 1;
            }
            else if (result == DialogResult.No)
            {
                ai = 0;
            }
        }
        public int player = 2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;
        public int ai = 0;
        public int close = 0;
        public string S;

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (ai == 1)
            {
                if (button.Text == "")
                {

                    button.Text = "X";
                    player++;
                    turns++;
                    button.BackColor = Color.Cyan;
                    button.ForeColor = Color.Black;
                    if (CheckWinner() == true || CheckDraw() == true)
                    {
                        goto Label;
                    }
                    aiturn();
                }
            Label:
                decider(button);
            }
            else
            {
                if (button.Text == "")
                {
                    if (player % 2 == 0)
                    {
                        button.Text = "X";
                        button.BackColor = Color.Cyan;
                        button.ForeColor = Color.Black;
                        player++;
                        turns++;
                    }
                    else
                    {
                        button.Text = "O";
                        button.BackColor = Color.WhiteSmoke;
                        player++;
                        turns++;
                    }
                }
                decider(button);
            }

        }
        void decider(Button button)
        {
            if ((CheckDraw() == true) && (CheckWinner() == false))
            {
                MessageBox.Show("It's a Tie!!");
                sd++;
                Draws.Text = "Draws: " + sd;
                NewGame();
            }
            if (CheckWinner() == true)
            {
                if (S == "X")
                {
                    MessageBox.Show("X Won The Game!!");
                    s1++;
                    XWins.Text = "X: " + s1;
                    NewGame();
                }
                else
                {
                    MessageBox.Show("O Won The Game!!");
                    s2++;
                    OWins.Text = "O: " + s2;
                    NewGame();
                }

            }
        }
        private void aiturn()
        {
            //Attack
            //for A00 A20 A02 A22
            if ((((A01.Text == A02.Text) && (A01.Text == "O")) || ((A11.Text == A22.Text) && (A11.Text == "O")) || ((A10.Text == A20.Text) && (A10.Text == "O"))) && (A00.Text == ""))
            {
                A00.Text = "O";
            }
            else if ((((A00.Text == A10.Text) && (A10.Text == "O")) || ((A11.Text == A02.Text) && (A11.Text == "O")) || ((A21.Text == A22.Text) && (A21.Text == "O"))) && (A20.Text == ""))
            {
                A20.Text = "O";
            }
            else if ((((A01.Text == A00.Text) && (A01.Text == "O")) || ((A11.Text == A20.Text) && (A20.Text == "O")) || ((A12.Text == A22.Text) && (A12.Text == "O"))) && (A02.Text == ""))
            {
                A02.Text = "O";
            }
            else if ((((A02.Text == A12.Text) && (A02.Text == "O")) || ((A11.Text == A00.Text) && (A11.Text == "O")) || ((A20.Text == A21.Text) && (A20.Text == "O"))) && (A22.Text == ""))
            {
                A22.Text = "O";
            }
            //for A10 A01 A21 A12
            else if ((((A00.Text == A02.Text) && (A00.Text == "O")) || ((A11.Text == A21.Text) && (A21.Text == "O"))) && (A01.Text == ""))
            {
                A01.Text = "O";
            }
            else if ((((A20.Text == A22.Text) && (A20.Text == "O")) || ((A11.Text == A01.Text) && (A01.Text == "O"))) && (A21.Text == ""))
            {
                A21.Text = "O";
            }
            else if ((((A00.Text == A20.Text) && (A00.Text == "O")) || ((A11.Text == A12.Text) && (A11.Text == "O"))) && (A10.Text == ""))
            {
                A10.Text = "O";
            }
            else if ((((A02.Text == A22.Text) && (A02.Text == "O")) || ((A11.Text == A10.Text) && (A11.Text == "O"))) && (A12.Text == ""))
            {
                A12.Text = "O";
            }
            //for A11
            else if ((((A22.Text == A00.Text) && (A00.Text == "O")) || ((A02.Text == A20.Text) && (A02.Text == "O")) || ((A01.Text == A21.Text) && (A01.Text == "O")) || ((A12.Text == A10.Text) && (A10.Text == "O"))) && (A11.Text == "") && (A11.Text != "X"))
            {
                A11.Text = "O";
            }
            //Defend
            //for A00 A20 A02 A22
            else if ((((A01.Text == A02.Text) && (A01.Text != "")) || ((A11.Text == A22.Text) && (A11.Text != "")) || ((A10.Text == A20.Text) && (A10.Text != ""))) && (A00.Text == ""))
            {
                A00.Text = "O";
            }
            else if ((((A00.Text == A10.Text) && (A10.Text != "")) || ((A11.Text == A02.Text) && (A11.Text != "")) || ((A21.Text == A22.Text) && (A21.Text != ""))) && (A20.Text == ""))
            {
                A20.Text = "O";
            }
            else if ((((A01.Text == A00.Text) && (A01.Text != "")) || ((A11.Text == A20.Text) && (A20.Text != "")) || ((A12.Text == A22.Text) && (A12.Text != ""))) && (A02.Text == ""))
            {
                A02.Text = "O";
            }           
            else if ((((A02.Text == A12.Text) && (A02.Text != "")) || ((A11.Text == A00.Text) && (A11.Text != "")) || ((A20.Text == A21.Text) && (A20.Text != ""))) && (A22.Text == ""))
            {
                A22.Text = "O";
            }
            //for A10 A01 A21 A12
            else if ((((A00.Text == A02.Text) && (A00.Text != "")) || ((A11.Text == A21.Text) && (A21.Text != ""))) && (A01.Text == ""))
            {
                A01.Text = "O";
            }
            else if ((((A20.Text == A22.Text) && (A20.Text != "")) || ((A11.Text == A01.Text) && (A01.Text != ""))) && (A21.Text == ""))
            {
                A21.Text = "O";
            }
            else if ((((A00.Text == A20.Text) && (A00.Text != "")) || ((A11.Text == A12.Text) && (A11.Text != ""))) && (A10.Text == ""))
            {
                A10.Text = "O";
            }
            else if ((((A02.Text == A22.Text) && (A02.Text != "")) || ((A11.Text == A10.Text) && (A11.Text != ""))) && (A12.Text == ""))
            {
                A12.Text = "O";
            }
            //for A11
            else if ((((A22.Text == A00.Text) && (A00.Text != "")) || ((A02.Text == A20.Text) && (A02.Text != "")) || ((A01.Text == A21.Text) && (A01.Text != "")) || ((A12.Text == A10.Text) && (A10.Text != ""))) && (A11.Text == "") && (A11.Text != "X"))
            {
                A11.Text = "O";
            }
            //initalizer
            else if ((A11.Text == ""))
            {
                A11.Text = "O";
            }
            else if ((A01.Text == ""))
            {
                A01.Text = "O";
            }
            else if ((A21.Text == ""))
            {
                A21.Text = "O";
            }
            else if ((A12.Text == ""))
            {
                A12.Text = "O";
            }
            else if ((A10.Text == ""))
            {
                A10.Text = "O";
            }
            else if ((A22.Text == ""))
            {
                A22.Text = "O";
            }
            else if ((A20.Text == ""))
            {
                A20.Text = "O";
            }
            else if ((A00.Text == ""))
            {
                A00.Text = "O";
            }
            else if ((A02.Text == ""))
            {
                A02.Text = "O";
            }
            player++;
            turns++;
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            XWins.Text = "X: " + s1;
            OWins.Text = "O: " + s2;
            Draws.Text = "Draws: " + sd;
        }
        private void NewGame()
        {
            player = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            A00.BackColor = A01.BackColor = A02.BackColor = A10.BackColor = A11.BackColor = A12.BackColor = A20.BackColor = A21.BackColor = A22.BackColor = default(Color);           
        }

        private void NButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private bool CheckDraw()
        {
            if (turns == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckWinner()
        {
            //horizontal
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && A00.Text != "")
            {
                S = A00.Text;
                return true;
            }
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && A10.Text != "")
            {
                S = A10.Text;
                return true;
            }
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "")
            {
                S = A20.Text;
                return true;
            }
            //vertical
            else if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && A00.Text != "")
            {
                S = A00.Text;
                return true;
            }
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
            {
                S = A01.Text;
                return true;
            }
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
            {
                S = A02.Text;
                return true;
            }
            //diagonal
            else if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && A00.Text != "")
            {
                S = A00.Text;
                return true;
            }
            else if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && A02.Text != "")
            {
                S = A11.Text;
                return true;
            }
            else
                return false;
        }
        private void RButton_Click(object sender, EventArgs e)
        {
            NewGame();
            s1 = 0;
            s2 = 0;
            sd = 0;
            XWins.Text = "X: " + s1;
            OWins.Text = "O: " + s2;
            Draws.Text = "Draws: " + sd;
        }
    }
}
