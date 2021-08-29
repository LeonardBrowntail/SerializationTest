using System;

namespace Serialization
{
    [Serializable]
    public class Player
    {
        private string playerName;
        private string playerClass;
        private int playerScore;

        public string Name { get => playerName; set => playerName = value; }
        public string PlayerClass { get => playerClass; }
        public int Score { get => playerScore; }

        //switch player's class to another class
        public void SwitchClass(string playerClass)
        {
            this.playerClass = playerClass;
            Console.WriteLine("Successfully switched " + playerName + "\'s class to " + playerClass);
        }

        //Add player's score by one
        public void AddScore()
        {
            playerScore++;
        }
        //Add player's score by value
        public void AddScore(int score)
        {
            playerScore += score;
        }

        //set player's score to zero
        public void SetScore()
        {
            playerScore = 0;
        }

        //set player's score by value
        public void SetScore(int score)
        {
            playerScore = score;
            Console.WriteLine("Successfully set " + playerName + "\'s score to " + playerScore);
        }

        //constructors
        public Player()
        {
            playerName = "Anonymous";
            playerClass = "Civilian";
            playerScore = 0;
        }

        public Player(string name)
        {
            playerName = name;
            playerClass = "Civilian";
            playerScore = 0;
        }

        public Player(string name, string pClass)
        {
            playerName = name;
            playerClass = pClass;
            playerScore = 0;
        }
    }
}