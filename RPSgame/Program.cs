using System;
using System.Collections.Generic;
using System.Linq;

namespace RPSgame
{
    class Program
    {
        static string input;
        static string computer_ThrowItem;
        static string textPR = "Paper covers Rock";
        static string textSP = "Scissors cut Paper";
        static string textRS = "Rock breaks Scissors";
        static string textT = "It's a tie";
        static string textOut;
        static List<string> acceptableValues = new List<string> { "r", "p", "s", "e" };
        static void Main(string[] args)
        {
            PlayGame();
        }

        public static string RandomGenerator()
        {
            Random randomNumber = new Random();
            int outValue = randomNumber.Next(1, 4);
            string stringNumber = outValue.ToString();
            return stringNumber;
        }
        public static void SetUpThrow()
        {
            string throwNumber = RandomGenerator();
            switch (throwNumber)
            {
                case "1":
                    computer_ThrowItem = "Paper";
                    switch (input)
                    {
                        case "r":
                            textOut = textPR + ", you lose";
                            break;
                        case "p":
                            textOut = textT;
                            break;
                        case "s":
                            textOut = textSP + ", you win";
                            break;
                        default:
                            break;
                    }
                    break;
                case "2":
                    computer_ThrowItem = "Rock";
                    switch (input)
                    {
                        case "r":
                            textOut = textT;
                            break;
                        case "p":
                            textOut = textPR + ", you win";
                            break;
                        case "s":
                            textOut = textRS + ", you lose";
                            break;
                        default:
                            break;
                    }
                    break;
                case "3":
                    computer_ThrowItem = "Scissors";
                    switch (input)
                    {
                        case "r":
                            textOut = textRS + ", you win";
                            break;
                        case "p":
                            textOut = textSP + ", you lose";
                            break;
                        case "s":
                            textOut = textT;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            //return computer_ThrowItem;
        }
        public static void PlayGame()
        {
            do
            {
                do
                { 
                Console.WriteLine("r enter = Rock");
                Console.WriteLine("p enter = Paper");
                Console.WriteLine("s enter = Scissors");
                Console.WriteLine("e enter = Exit");
                input = Console.ReadLine();
                } while (!acceptableValues.Contains(input));
                SetUpThrow();
                Console.WriteLine("The computer chose " + computer_ThrowItem);
                Console.WriteLine(textOut);
                for (int index = 0; index < 3; index++)
                {
                    Console.WriteLine(" ");
                }
            } while (input != "e");
        }
    }
}