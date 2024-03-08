using System;

namespace RPS
{
        class Program
    {
        static void Main(string[] args)
        {
            GameItem player1Choice = ParseGameItem(args[0]);
            GameItem player2Choice = ParseGameItem(args[1]);

            GameStatus result = RockPaperScissors(player1Choice, player2Choice);

            switch (result)
            {
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static GameItem ParseGameItem(string input)
        {
            return Enum.Parse<GameItem>(input);
        }

        private static GameStatus RockPaperScissors(GameItem player1, GameItem player2)
        {
            if (player1 == player2)
            {
                return GameStatus.Draw;
            }

            bool player1Wins = (player1 == GameItem.Rock && player2 == GameItem.Scissors) ||
                            (player1 == GameItem.Scissors && player2 == GameItem.Paper) ||
                            (player1 == GameItem.Paper && player2 == GameItem.Rock);

            return player1Wins ? GameStatus.Player1Wins : GameStatus.Player2Wins;
        }
    }
}
