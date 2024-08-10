namespace Hangman_Game
{
    partial class Hangman_Visuals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newHiddenWord = new System.Windows.Forms.Label();
            this.startNewGameButton = new System.Windows.Forms.Button();
            this.quitGameButton = new System.Windows.Forms.Button();
            this.lives = new System.Windows.Forms.Label();
            this.playAgainText = new System.Windows.Forms.Label();
            this.incorrectWords = new System.Windows.Forms.Label();
            this.scoreBoard = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // newHiddenWord
            // 
            this.newHiddenWord.AutoSize = true;
            this.newHiddenWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newHiddenWord.Location = new System.Drawing.Point(36, 40);
            this.newHiddenWord.Name = "newHiddenWord";
            this.newHiddenWord.Size = new System.Drawing.Size(305, 55);
            this.newHiddenWord.TabIndex = 1;
            this.newHiddenWord.Text = "Hidden Word";
            // 
            // startNewGameButton
            // 
            this.startNewGameButton.Location = new System.Drawing.Point(149, 577);
            this.startNewGameButton.Name = "startNewGameButton";
            this.startNewGameButton.Size = new System.Drawing.Size(360, 124);
            this.startNewGameButton.TabIndex = 4;
            this.startNewGameButton.Text = "Start New";
            this.startNewGameButton.UseVisualStyleBackColor = true;
            this.startNewGameButton.Click += new System.EventHandler(this.startNewGameButton_Click);
            this.startNewGameButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startNewGameButton_KeyPress);
            // 
            // quitGameButton
            // 
            this.quitGameButton.Location = new System.Drawing.Point(636, 577);
            this.quitGameButton.Name = "quitGameButton";
            this.quitGameButton.Size = new System.Drawing.Size(360, 124);
            this.quitGameButton.TabIndex = 5;
            this.quitGameButton.Text = "Quit";
            this.quitGameButton.UseVisualStyleBackColor = true;
            this.quitGameButton.Click += new System.EventHandler(this.quitGameButton_Click);
            // 
            // lives
            // 
            this.lives.AutoSize = true;
            this.lives.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lives.Location = new System.Drawing.Point(777, 40);
            this.lives.Name = "lives";
            this.lives.Size = new System.Drawing.Size(384, 55);
            this.lives.TabIndex = 6;
            this.lives.Text = "Number Of Lives";
            // 
            // playAgainText
            // 
            this.playAgainText.AutoSize = true;
            this.playAgainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainText.Location = new System.Drawing.Point(438, 396);
            this.playAgainText.Name = "playAgainText";
            this.playAgainText.Size = new System.Drawing.Size(288, 55);
            this.playAgainText.TabIndex = 7;
            this.playAgainText.Text = "Play Game?";
            this.playAgainText.Enter += new System.EventHandler(this.playAgainText_Enter);
            // 
            // incorrectWords
            // 
            this.incorrectWords.AutoSize = true;
            this.incorrectWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectWords.Location = new System.Drawing.Point(405, 211);
            this.incorrectWords.Name = "incorrectWords";
            this.incorrectWords.Size = new System.Drawing.Size(363, 55);
            this.incorrectWords.TabIndex = 8;
            this.incorrectWords.Text = "Incorrect Words";
            // 
            // scoreBoard
            // 
            this.scoreBoard.CausesValidation = false;
            this.scoreBoard.Enabled = false;
            this.scoreBoard.FormattingEnabled = true;
            this.scoreBoard.ItemHeight = 25;
            this.scoreBoard.Location = new System.Drawing.Point(1167, 42);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.Size = new System.Drawing.Size(705, 679);
            this.scoreBoard.TabIndex = 9;
            // 
            // Hangman_Visuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1978, 797);
            this.Controls.Add(this.scoreBoard);
            this.Controls.Add(this.incorrectWords);
            this.Controls.Add(this.playAgainText);
            this.Controls.Add(this.lives);
            this.Controls.Add(this.quitGameButton);
            this.Controls.Add(this.startNewGameButton);
            this.Controls.Add(this.newHiddenWord);
            this.Name = "Hangman_Visuals";
            this.Text = "Hangman Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label newHiddenWord;
        private System.Windows.Forms.Button startNewGameButton;
        private System.Windows.Forms.Button quitGameButton;
        private System.Windows.Forms.Label lives;
        private System.Windows.Forms.Label playAgainText;
        private System.Windows.Forms.Label incorrectWords;
        private System.Windows.Forms.ListBox scoreBoard;
    }
}