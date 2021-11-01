using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Game Tokens
        public string X_TOKEN = "X";
        public string O_TOKEN = "O";
        //Current Turn
        public string turn = "X";
        //Player Scores
        public int x_score = 0;
        public int o_score = 0;

        //Buttons
        private void board_btn1_Click(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            button.Text = turn;
            button.Enabled = false;
            //Set text of button to current turn
            //Check if player wins
            //Switch Turns
            turn = switch_turn(turn);
            update_label();
            //Disable Button
        }

        //Checks if either player has won
        private string check_win()
        {
            string winner = "X_TOKEN";
            return winner;
        }

        //Switches turn to other player
        private string switch_turn(string turn)
        {
            if (turn == X_TOKEN)
            {
                return O_TOKEN;
            }
            else
            {
                return X_TOKEN;
            }
        }

        //Updates the score labels
        private void update_scores()
        {

        }

        //Updates the hud label
        private void update_label()
        {
            turn_lbl.Text = "Player Turn: "+turn;
        }

        //Resets Game
        private void reset_btn_Click(object sender, EventArgs e)
        {
            board_btn1.Text = "";
            board_btn2.Text = "";
            board_btn3.Text = "";
            board_btn4.Text = "";
            board_btn5.Text = "";
            board_btn6.Text = "";
            board_btn7.Text = "";
            board_btn8.Text = "";
            board_btn9.Text = "";
            board_btn1.Enabled = true;
            board_btn2.Enabled = true;
            board_btn3.Enabled = true;
            board_btn4.Enabled = true;
            board_btn5.Enabled = true;
            board_btn6.Enabled = true;
            board_btn7.Enabled = true;
            board_btn8.Enabled = true;
            board_btn9.Enabled = true;
        }
    }
}
