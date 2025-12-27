using System;

namespace BridgeLabzTraining.scenrio_based_problem
{
    internal class SnakeAndLadder
    {
        // random call ke liye
        static Random random = new Random();

        static void Main(string[] args)
        {
            StartGame();
        }

        
        static void StartGame()
        {
            Console.WriteLine("Enter number of players (2 to 4):");
            int user = int.Parse(Console.ReadLine());

            // check the valid player number
            if (user < 2 || user > 4)
            {
                Console.WriteLine("Players are not sufficient");
                return; // if number of player is invalid
            }

            // player names array
            string[] player = new string[user];

            for (int i = 0; i < player.Length; i++)
            {
                Console.Write("Enter player name: ");
                player[i] = Console.ReadLine();
            }

            //   player ki position store karne ke liye and by defaut sare player ki position zero hogi
            int[] position = new int[user];

            //   while loop cotrol karne ke liye
            bool flag = false;

            // game will run until someone wins
            while (flag == false)
            {
                //  player chance ke liye
                for (int i = 0; i < player.Length; i++)
                {
                    Console.WriteLine("\n" + player[i] + " turn");

                    //  dice roll karne ke liye
                    int dice = RollDice();
                    Console.WriteLine("Dice value: " + dice);

                    //  old position ke liye
                    int oldPos = position[i];

                    // calculate new position
                    int newPos = MovePlayer(oldPos, dice);

                    // if position goes above 100 then skip turn
                    if (newPos > 100)
                    {
                        Console.WriteLine("Move skipped (above 100)");
                        continue;
                    }

                    // checking snake or ladder
                    newPos = ApplySnakeOrLadder(newPos);

                    // updating final position
                    position[i] = newPos;

                    // showing movement
                    Console.WriteLine(oldPos + " -> " + newPos);

                    // checking win condition
                    bool win = CheckWin(newPos);

                    // simple message using ternary operator
                    Console.WriteLine(win ? "Reached 100!" : "Game continues");

                    // if player wins then stop game
                    if (win)
                    {
                        Console.WriteLine("\n " + player[i] + " WINS THE GAME!");
                        flag = true;
                        break;
                    }
                }
            }
        }

        // method to roll dice (1 to 6)
        static int RollDice()
        {
            return random.Next(1, 7);
        }

        // method to move player position
        static int MovePlayer(int currentPos, int dice)
        {
            return currentPos + dice;
        }

        // method to check snake or ladder
        static int ApplySnakeOrLadder(int pos)
        {
            // using switch because positions are fixed
            switch (pos)
            {
                case 4:
                    Console.WriteLine("Ladder mila!");
                    return 14;

                case 17:
                    Console.WriteLine("Snake aa gaya!");
                    return 7;

                case 28:
                    Console.WriteLine("Ladder mila!");
                    return 84;

                case 54:
                    Console.WriteLine("Ladder mila!");
                    return 67;

                case 62:
                    Console.WriteLine("Snake aa gaya!");
                    return 19;

                case 99:
                    Console.WriteLine("Snake aa gaya!");
                    return 10;

                default:
                    return pos; // normal position
            }
        }

        // method to check winning condition
        static bool CheckWin(int pos)
        {
            // ternary operator used here
            return pos == 100 ? true : false;
        }
    }
}
