using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeAI
    {
        TicTacToeDifficulty Difficulty;

        public TicTacToeAI(TicTacToeDifficulty difficulty)
        {
            Difficulty = difficulty;
        }

        public int ComputeNextMove(TicTacToeCell[] board)
        {
            Random rnd = new Random();

            if (Difficulty != TicTacToeDifficulty.Easy)
            {
                int empty = 0;

                foreach (TicTacToeCell c in board)
                {
                    if (c == TicTacToeCell.None) empty++;
                }

                // Check if board is empty
                if (empty == 9)
                {
                    // Always start with a corner
                    return rnd.Next(4) switch
                    {
                        0 => 0,
                        1 => 2,
                        2 => 6,
                        _ => 8
                    };
                }

                // Check if AI can win this round

                List<int> AIWinOptions = ComputeWinOptions(TicTacToeCell.AI, board);

                if (AIWinOptions.Count > 0 && (Difficulty == TicTacToeDifficulty.Difficult || rnd.Next(100) > 70)) return AIWinOptions[0];

                // Check if user can win this round

                List<int> UserWinOptions = ComputeWinOptions(TicTacToeCell.User, board);

                if (UserWinOptions.Count == 1 && (Difficulty == TicTacToeDifficulty.Difficult || rnd.Next(100) > 75)) return UserWinOptions[0];
                else if (UserWinOptions.Count > 1) return UserWinOptions[rnd.Next(UserWinOptions.Count)]; // If this happens, we have lost. Closing only one path for user victory.


                // If not occupied, choose center (4)

                if (board[4] == TicTacToeCell.None && (Difficulty == TicTacToeDifficulty.Difficult || rnd.Next(100) > 75)) return 4;
            }
            

            // If we have come this far, we will select a random cell

            int selectedcell = rnd.Next(9);

            while (board[selectedcell] != TicTacToeCell.None)
            {
                selectedcell = rnd.Next(9);
            }

            return selectedcell;
        }

        List<int> ComputeWinOptions(TicTacToeCell winner, TicTacToeCell[] board)
        {
            // Check how many cells are occpied by the requested player
            int totaloftype = 0;
            foreach (TicTacToeCell c in board)
            {
                if (c == winner) totaloftype++;
            }

            // No way of winning if less than 2
            if (totaloftype < 2) return new List<int>();

            List<int> winlist = new List<int>();

            /*
             * Possible winning combinations as follows
             * 012
             * 345
             * 678
             * 036
             * 147
             * 258
             * 048
             * 246
             */

            // Check all winning combinations, and add cells that will make player win this round to list

            List<List<int>> combinations = new List<List<int>>
            {
                new List<int> {0,1,2},
                new List<int> {3, 4, 5},
                new List<int> {6,7,8},
                new List<int> {0,3,6},
                new List<int> {1,4,7},
                new List<int> {2,5,8},
                new List<int> {0,4,8},
                new List<int> {2,4,6}
            };

            foreach (List<int> c in combinations)
            {
                int? r = CheckMissingForWinOnCombination(board, winner, c);
                if (r != null && winlist.IndexOf((int)r) < 0) winlist.Add((int)r);
            }

            return winlist;
        }

        public int? CheckMissingForWinOnCombination(TicTacToeCell[] board, TicTacToeCell winner, List<int> comb)
        {
            // Find opponent
            TicTacToeCell opponent = winner switch
            {
                TicTacToeCell.AI => TicTacToeCell.User,
                TicTacToeCell.User => TicTacToeCell.AI,
                _ => throw new ArgumentOutOfRangeException()
            };

            List<int> has = new List<int>();
            List<int> opponents = new List<int>();
            List<int> missing = new List<int>();
            foreach (int i in comb)
            {
                if (board[i] == winner) has.Add(i);
                else if (board[i] == opponent) opponents.Add(i);
                else if (board[i] == TicTacToeCell.None) missing.Add(i);
            }

            if (opponents.Count == 0 && has.Count == 2) return missing[0];
            else return null;
        }
    }
}
