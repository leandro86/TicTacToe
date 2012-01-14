using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class Board
    {
        public enum Player
        {
            None = '-',
            Human = 'X',
            Computer = 'O'
        };        
        
        private const int BoardSize = 9;
        private Player[] _board = new Player[BoardSize];

        public Board()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                _board[i] = Player.None;
            }
        }

        public void Put(int position, Player player)
        {
            _board[position] = player;
            //LastMove = position;
        }

        public void Remove(int position)
        {
            _board[position] = Player.None;
        }

        public bool IsFull()
        {
            return GetValidMoves().Length == 0;
        }

        public bool IsLegalMove(int position)
        {
            return _board[position] == Player.None;
        }

        public Player GetWinner()
        {
            int[] winnerPositions;
            return GetWinner(out winnerPositions);
        }

        public Player GetWinner(out int[]winnerPositions)
        {
            var winningPositions = new int[8, 3]
                                       {
                                           {0, 1, 2},
                                           {3, 4, 5},
                                           {6, 7, 8},
                                           {0, 3, 6},
                                           {1, 4, 7},
                                           {2, 5, 8},
                                           {0, 4, 8},
                                           {2, 4, 6}
                                       };

            for (int i = 0; i < 8; i++)
            {
                int index0 = winningPositions[i, 0];
                int index1 = winningPositions[i, 1];
                int index2 = winningPositions[i, 2];

                if (_board[index0] == _board[index1] && _board[index1] == _board[index2] && _board[index2] != Player.None)
                {
                    winnerPositions = new int[3] {index0, index1, index2};
                    return _board[index0];
                }
            }

            winnerPositions = null;
            return Player.None;            
        }

        public int[] GetValidMoves()
        {
            List<int> validMoves = new List<int>();
            
            for (int i = 0; i < BoardSize; i++)
            {
                if (_board[i] == Player.None)
                {
                    validMoves.Add(i);
                }
            }

            return validMoves.ToArray();
        }

        public void Clear()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                _board[i] = Player.None;
            }
        }

        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < BoardSize; i++)
            {
                if (i % 3 == 0)
                {
                    s += Environment.NewLine;
                }

                s += (char)_board[i];
            }

            return s;
        }
    }
}
