/*
 Author: Akeem Brown
 Date: 07/22/2024
 Purpose: The class below will be incharge of the changing of UI
          elements that will appear on the form.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_Game
{
    public partial class Hangman_Visuals : Form
    {
        /*
        We are instatiating the Functionality class in order to use the
        "Utility" functions
        */
        Functionality func = new Functionality();

        string newWord;
        string wordScoreKey;

        ArrayList hiddenWord;
        ArrayList arrayedWord;
        ArrayList correctGuesses = new ArrayList();
        ArrayList wrongGuesses = new ArrayList();

        SortedList<string, int> wordScore = new SortedList<string, int>();

        int maxGuesses = 10;

        // We are initializing the immediate, necessary, UI elements.
        public Hangman_Visuals()
        {
            InitializeComponent();

            foreach (var elem in func.fruits)
            {
                wordScore.Add(elem, 0);
            }

            foreach (var elem in wordScore)
            {
                scoreBoard.Items.Add($"{elem.Key} = {elem.Value}");
            }
        }

        // This button will start a new game every click.
        private void startNewGameButton_Click(object sender, EventArgs e)
        {
            // As soon as the game is (re)started we clear and re-wrrite all UI elements
            incorrectWords.Text = "";
            wrongGuesses.Clear();
            correctGuesses.Clear();
            quitGameButton.Visible = false;
            startNewGameButton.Visible = false;
            newWord = func.WordSelect();
            wordScoreKey = newWord;
            maxGuesses = 10;
            scoreBoard.Visible = false;

            arrayedWord = func.ConvertToArray(newWord);
            hiddenWord = func.MakeHidden(arrayedWord);

            // Displaying the word as "hidden"(Underscores - '_').
            newHiddenWord.Text = "";

            foreach (var elem in hiddenWord)
            {
                newHiddenWord.Text += elem;
            }

            lives.Text = maxGuesses.ToString();

            playAgainText.Visible = false;
        }

        // As long as this button is visible it can be clicked to quit the program.
        private void quitGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // The keypress in charge of comparing keys with the associated "word's" letters.
        private void startNewGameButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool doesContains = arrayedWord.Contains(e.KeyChar);
            /*
                Check if the letter is within the word and replace every instance with said letter.
                else just decrease the lives.
            */
            if (doesContains)
            {
                Console.WriteLine("Does contain " + e.KeyChar.ToString());
                // Check if the correct letter has already been guessed else warn player you already made that guess.
                if (!correctGuesses.Contains(e.KeyChar.ToString()))
                {
                    correctGuesses.Add(e.KeyChar.ToString());
                }
                else
                {
                    Console.WriteLine("You already guessed " + e.KeyChar.ToString());
                }
                for(int i = 0; i < arrayedWord.Count; i++)
                {
                    if (arrayedWord[i].ToString() == e.KeyChar.ToString())
                    {
                        hiddenWord[i] = e.KeyChar;
                    }
                }

                // We than update said hidden word
                newHiddenWord.Text = "";
                foreach (var elem in hiddenWord)
                {
                    newHiddenWord.Text += elem;
                }

                bool isEqaul = func.AreTheySame(arrayedWord, hiddenWord);
                // Check if player has won as well as change update word scores along with the UI.
                if (isEqaul)
                {
                    playAgainText.Visible = true;
                    playAgainText.Text = "You win \n Play Again?";
                    playAgainText.Focus();
                    scoreBoard.Visible = true;
                    wordScore[wordScoreKey]++;

                    scoreBoard.Items.Clear();
                    foreach (var elem in wordScore)
                    {
                        scoreBoard.Items.Add($"{elem.Key} = {elem.Value}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Does not contain " + e.KeyChar.ToString());
                //  Check if the incorrect letter has already been guessed else warn player you already made that guess.
                if (!wrongGuesses.Contains(e.KeyChar.ToString()))
                {
                    wrongGuesses.Add(e.KeyChar.ToString());
                }
                else
                {
                    Console.WriteLine("You've already guessed " + e.KeyChar.ToString());
                }
                wrongGuesses.Sort();
                maxGuesses--;
                lives.Text = maxGuesses.ToString();

                incorrectWords.Text = "";
                foreach(var elem in wrongGuesses)
                {
                    incorrectWords.Text += elem;
                }

                // Check if player has lost
                if(maxGuesses == 0)
                {
                    playAgainText.Visible = true;
                    playAgainText.Text = "You lose \n Play Again?";
                    playAgainText.Focus();
                    scoreBoard.Visible = true;
                }
            }
        }

        // Determine wether or not the player with play again after winning or losing.
        private void playAgainText_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("You Lose");
            startNewGameButton.Visible = true;
            quitGameButton.Visible = true;
        }
    }
}
