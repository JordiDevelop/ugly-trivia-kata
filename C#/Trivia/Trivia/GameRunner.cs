using System;

namespace Trivia
{
    public abstract class GameRunner
    {
        private static bool _notAWinner;

        public static void Main(string[] args)
        {
            var aGame = new Game();

            aGame.Add("Chet");
            aGame.Add("Pat");
            aGame.Add("Sue");

            var rand = new Random();

            do
            {
                aGame.Roll(rand.Next(5) + 1);

                _notAWinner = WasCorrectlyAnswered(rand, aGame);
                
            } while (_notAWinner);
        }

        private static bool WasCorrectlyAnswered(Random rand, Game aGame)
        {
            return rand.Next(9) == 7 ? aGame.WrongAnswer() : aGame.WasCorrectlyAnswered();
        }
    }
}