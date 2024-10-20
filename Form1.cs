using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RestartGame();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;
           
        }

        public enum Player
        {
            X, O
        }

        Player activePlayer;
        List<Button> buttons;
        private int playerXWins = 0;
        private int playerOWins = 0;

        private void PlayerClick(object sender, EventArgs e)
        {
            var button = (Button)sender;

            // Set the text and color based on the active player
            if (activePlayer == Player.X)
            {
                button.Text = Player.X.ToString(); // Set button text to X
                button.BackColor = Color.Brown;      // Set button color to Brown
                activePlayer = Player.O;           // Switch to Player O
            }
            else
            {
                button.Text = Player.O.ToString(); // Set button text to O
                button.BackColor = ColorTranslator.FromHtml("#C4A484");   // Set button color 
                activePlayer = Player.X;           // Switch to Player X
            }

            button.Enabled = false; // Disable the button after it's clicked

            CheckGame(); // Checking for win or draw after the move
        }

        private void CheckGame()
        {
            // Checking rows for a win
            if ((button1.Text == button2.Text && button2.Text == button3.Text) && !string.IsNullOrEmpty(button1.Text))
            {
                EndGame(button1.Text); // Player X or O wins
                return;
            }
            if ((button4.Text == button5.Text && button5.Text == button6.Text) && !string.IsNullOrEmpty(button4.Text))
            {
                EndGame(button4.Text);
                return;
            }
            if ((button7.Text == button8.Text && button8.Text == button9.Text) && !string.IsNullOrEmpty(button7.Text))
            {
                EndGame(button7.Text);
                return;
            }

            // Checking columns for a win
            if ((button1.Text == button4.Text && button4.Text == button7.Text) && !string.IsNullOrEmpty(button1.Text))
            {
                EndGame(button1.Text);
                return;
            }
            if ((button2.Text == button5.Text && button5.Text == button8.Text) && !string.IsNullOrEmpty(button2.Text))
            {
                EndGame(button2.Text);
                return;
            }
            if ((button3.Text == button6.Text && button6.Text == button9.Text) && !string.IsNullOrEmpty(button3.Text))
            {
                EndGame(button3.Text);
                return;
            }

            // Checking diagonals for a win
            if ((button1.Text == button5.Text && button5.Text == button9.Text) && !string.IsNullOrEmpty(button1.Text))
            {
                EndGame(button1.Text);
                return;
            }
            if ((button3.Text == button5.Text && button5.Text == button7.Text) && !string.IsNullOrEmpty(button3.Text))
            {
                EndGame(button3.Text);
                return;
            }

            // Checking for a draw (all buttons clicked but no winner)
            if (buttons.All(b => !b.Enabled))
            {
                MessageBox.Show("It's a draw!", "Game Over");
                RestartGame(); // Restart the game after a draw
            }
        }

        // Method to handle the end of the game
        private void EndGame(string winner)
        {
            MessageBox.Show($"{winner} wins!", "Game Over");
            if (winner == Player.X.ToString())
            {
                playerXWins++; // Increment Player X's score
            }
            else
            {
                playerOWins++; // Increment Player O's score
            }

            RestartGame();  // Restart the game for a new round
        }

        // Restart the game for a new round
        public void RestartGame()
        {
            // Initialize buttons list
            buttons = new List<Button>() { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button space in buttons)
            {
                space.Enabled = true;  // Re-enable the buttons
                space.Text = "";       // Clear button text
                space.BackColor = ColorTranslator.FromHtml("#ded1b6");  // Reset color
                space.Height = space.Width;     // Ensure square buttons
            }
            lblXwins.Text = $"Player X Wins : {playerXWins}";
            lblOWins.Text = $"Player O Wins : {playerOWins} ";

            activePlayer = Player.X; // Player X starts first
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
            playerOWins = 0;
            playerXWins = 0;// Restart the game when the restart button is clicked
        }

       
    }
}
