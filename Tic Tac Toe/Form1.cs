using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Methods -
        //after making move, check win status
        //change label of player


        public void MakeAMove(Button DummyButton)
        {
            if (ShowPlayerNumber.Text == "Move: Black")
                DummyButton.BackColor = Color.Black;
            else if (ShowPlayerNumber.Text == "Move: Green")
                DummyButton.BackColor = Color.Green;
        }
        public void ChangePlayer()
        {
            if (ShowPlayerNumber.Text == "Move: Black")
                ShowPlayerNumber.Text = "Move: Green";
            else if (ShowPlayerNumber.Text == "Move: Green")
                ShowPlayerNumber.Text ="Move: Black";
        }

        public void ResetBoard()
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
        }

        public void CheckWinStatus()
        {
            if ((button1.BackColor == Color.Black && button2.BackColor == Color.Black && button3.BackColor == Color.Black)
                || (button4.BackColor == Color.Black && button5.BackColor == Color.Black && button6.BackColor == Color.Black)
                || (button7.BackColor == Color.Black && button8.BackColor == Color.Black && button9.BackColor == Color.Black)
                || (button1.BackColor == Color.Black && button4.BackColor == Color.Black && button7.BackColor == Color.Black)
                || (button2.BackColor == Color.Black && button5.BackColor == Color.Black && button8.BackColor == Color.Black)
                || (button3.BackColor == Color.Black && button6.BackColor == Color.Black && button9.BackColor == Color.Black)
                || (button1.BackColor == Color.Black && button5.BackColor == Color.Black && button9.BackColor == Color.Black)
                || (button3.BackColor == Color.Black && button5.BackColor == Color.Black && button7.BackColor == Color.Black))
            {
                MessageBox.Show("Winner: Black!");
                ResetBoard();
                ScoreBoardPlayer1Score.Text =Convert.ToString(Convert.ToInt32(ScoreBoardPlayer1Score.Text) + 1);
            }
            //OR PLAYER 2
             else if ((button1.BackColor == Color.Green && button2.BackColor == Color.Green && button3.BackColor == Color.Green)
             || (button4.BackColor == Color.Green && button5.BackColor == Color.Green && button6.BackColor == Color.Green)
             || (button7.BackColor == Color.Green && button8.BackColor == Color.Green && button9.BackColor == Color.Green)
             || (button1.BackColor == Color.Green && button4.BackColor == Color.Green && button7.BackColor == Color.Green)
             || (button2.BackColor == Color.Green && button5.BackColor == Color.Green && button8.BackColor == Color.Green)
             || (button3.BackColor == Color.Green && button6.BackColor == Color.Green && button9.BackColor == Color.Green)
             || (button1.BackColor == Color.Green && button5.BackColor == Color.Green && button9.BackColor == Color.Green)
             || (button3.BackColor == Color.Green && button5.BackColor == Color.Green && button7.BackColor == Color.Green))
            {
                MessageBox.Show("Winner: Green!");
                ResetBoard();
                ScoreBoardPlayer2Score.Text =Convert.ToString(Convert.ToInt32(ScoreBoardPlayer2Score.Text) + 1);
            }

            else if((button1.BackColor == Color.Black || button1.BackColor == Color.Green)
                && (button2.BackColor == Color.Black || button2.BackColor == Color.Green)
                && (button3.BackColor == Color.Black || button3.BackColor == Color.Green)
                && (button4.BackColor == Color.Black || button4.BackColor == Color.Green)
                && (button5.BackColor == Color.Black || button5.BackColor == Color.Green)
                && (button6.BackColor == Color.Black || button6.BackColor == Color.Green)
                && (button7.BackColor == Color.Black || button7.BackColor == Color.Green)
                && (button8.BackColor == Color.Black || button8.BackColor == Color.Green)
                && (button9.BackColor == Color.Black || button9.BackColor == Color.Green))
            {
                MessageBox.Show("Draw!");
                ResetBoard();
            }


        }



        private void button1ClickEvent(object sender, EventArgs e)
        {
            if(button1.BackColor == Color.Black || button1.BackColor == Color.Green)
            {
                return;
            }
               
            MakeAMove(button1);
            ChangePlayer();
            CheckWinStatus();

        }

        private void button2ClickEvent(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Black || button2.BackColor == Color.Green)
            {
                return;
            }
            MakeAMove(button2);
            ChangePlayer();
            CheckWinStatus();
        }

        private void button3ClickEvent(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Black || button3.BackColor == Color.Green)
            {
                return;
            }
            MakeAMove(button3);
            ChangePlayer();
            CheckWinStatus();
        }

        private void button4ClickEvent(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Black || button4.BackColor == Color.Green)
            {
                return;
            }
            MakeAMove(button4);
            ChangePlayer();
            CheckWinStatus();
        }

        private void button5ClickEvent(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Black || button5.BackColor == Color.Green)
            {
                return;
            }
            MakeAMove(button5);
            ChangePlayer();
            CheckWinStatus();
        }

        private void button6ClickEvent(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.Black || button6.BackColor == Color.Green)
            {
                return;
            }
            MakeAMove(button6);
            ChangePlayer();
            CheckWinStatus();
        }

        private void button7ClickEvent(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.Black || button7.BackColor == Color.Green)
            {
                return;
            }
            MakeAMove(button7);
            ChangePlayer();
            CheckWinStatus();
        }

        private void button8ClickEvent(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.Black || button8.BackColor == Color.Green)
            {
                return;
            }
            MakeAMove(button8);
            ChangePlayer();
            CheckWinStatus();
        }

        private void button9ClickEvent(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.Black || button9.BackColor == Color.Green)
            {
                return;
            }
            MakeAMove(button9);
            ChangePlayer();
            CheckWinStatus();
        }

        
        public bool CheckIfEmpty(Button DummyButton)
        {
            if (DummyButton.BackColor == Color.White)
                return true;
            else
                return false;
        }

        

        private void BotPlayerSelect_CheckedChanged(object sender, EventArgs e)
        {
            ResetBoard();
            ScoreBoardPlayer1Score.Text = "0";
            ScoreBoardPlayer2Score.Text = "0";
        }

    }
}
