using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class ComputerPlayer
    {
        private Board _board;
        private List<PossibleMove> _possibleMoves;        

        private class PossibleMove
        {
            public int Score { get; set; }
            public int Move { get; set; }
        }

        public ComputerPlayer(Board board)
        {
            _board = board;
        }

        public int RandomMove()
        {
            int[] validMoves = _board.GetValidMoves();

            Random random = new Random(DateTime.Now.Millisecond);
            int index = random.Next(0, validMoves.Length);

            return validMoves[index];
        }

        public int BestMove()
        {
            _possibleMoves = new List<PossibleMove>();

            int bestScore =  ChooseBestMove(Board.Player.Computer, 0);
            // i filter all posibles moves in order to obtain those who are the best
            _possibleMoves = _possibleMoves.FindAll(m => m.Score == bestScore);

            Random random = new Random();
            // i choose a random move from all best possibles moves
            int randomMove = random.Next(0, _possibleMoves.Count);

            return _possibleMoves[randomMove].Move;
        }

        // minimax implementation
        private int ChooseBestMove(Board.Player currentPlayer, int depth)
        {                        
            Board.Player winner = _board.GetWinner();

            if (winner == Board.Player.Computer)
                return 1;
            if (winner == Board.Player.Human)
                return -1;
            if (_board.IsFull())
                return 0;
            
            int bestScore = currentPlayer == Board.Player.Computer ? -1 : 1;

            foreach (int validMove in _board.GetValidMoves())
            {
                _board.Put(validMove, currentPlayer);
                int score = ChooseBestMove(currentPlayer == Board.Player.Computer ? Board.Player.Human : Board.Player.Computer, depth + 1);

                // i could use negamax to simplify this code
                if ((currentPlayer == Board.Player.Computer && score > bestScore) ||
                    (currentPlayer == Board.Player.Human && score < bestScore))
                {
                    bestScore = score;
                }

                _board.Remove(validMove);

                // if we are on the top of the tree, i save every possibly move in order to be able to choose one at random between the best moves
                if (depth == 0)
                {
                    _possibleMoves.Add(new PossibleMove(){Move = validMove, Score = score});
                }
            }

            return bestScore;
        }
    }
}
