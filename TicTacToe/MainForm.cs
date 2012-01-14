using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        private Board _board = new Board();
        private ComputerPlayer _computerPlayer;
        private Panel[] _panels = new Panel[9];
        private bool _chooseBestMove;
        private GameState _gameState;
        private enum GameState
        {
            Playing,
            GameOver
        }

        public MainForm()
        {
            InitializeComponent();

            _chooseBestMove = invencibleDifficultyRadioButton.Checked;

            // i save in an array the references to the 9 panels
            foreach (Panel panel in backgroundPanel.Controls)
            {
                int panelNumber = int.Parse(panel.Name[panel.Name.Length - 1].ToString());
                _panels[panelNumber] = panel;
            }

            _computerPlayer = new ComputerPlayer(_board);
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            if (_gameState != GameState.Playing)
            {
                _board.Clear();

                foreach (Panel panel in _panels)
                {
                    panel.BackColor = Color.White;
                    panel.BackgroundImage = null;
                }

                _gameState = GameState.Playing;

                return;                
            }                        

            Panel clickedPanel = sender as Panel;
            int indexToBoard = int.Parse(clickedPanel.Name[clickedPanel.Name.Length - 1].ToString());

            if (!_board.IsLegalMove(indexToBoard))
            {
                return;
            }

            _board.Put(indexToBoard, Board.Player.Human);
            clickedPanel.BackgroundImage = Properties.Resources.XPiece;

            if (_board.IsFull() || _board.GetWinner() != Board.Player.None)
            {
                GameOver();
            }
            else
            {
                DoComputerMove();
            }
        }

        private void GameOver()
        {
            int[] winnerPositions;
            Board.Player winner = _board.GetWinner(out winnerPositions);

            if (winner != Board.Player.None)
            {
                foreach (int winnerPosition in winnerPositions)
                {
                    _panels[winnerPosition].BackColor = Color.Yellow;
                }

                if (winner == Board.Player.Human)
                {
                    humanScoreLabel.Text = (int.Parse(humanScoreLabel.Text) + 1).ToString();
                }
                else
                {
                    computerScoreLabel.Text = (int.Parse(computerScoreLabel.Text) + 1).ToString();
                }
            }

            _gameState = GameState.GameOver;
        }

        private void DoComputerMove()
        {
            int computerMove = _chooseBestMove ? _computerPlayer.BestMove() : _computerPlayer.RandomMove();
            _board.Put(computerMove, Board.Player.Computer);
            _panels[computerMove].BackgroundImage = Properties.Resources.OPiece;

            if (_board.IsFull() || _board.GetWinner() != Board.Player.None)
            {
                GameOver();
            }
        }

        private void resetScoresButton_Click(object sender, EventArgs e)
        {
            humanScoreLabel.Text = "0";
            computerScoreLabel.Text = "0";
        }

        private void dumbDifficultyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _chooseBestMove = false;
        }

        private void invencibleDifficultyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _chooseBestMove = true;
        }
    }
}
