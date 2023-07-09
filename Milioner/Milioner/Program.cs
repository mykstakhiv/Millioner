using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milioner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> QuestionsAnswers = new Dictionary<string, string>();

            QuestionsAnswers.Add("When First World War started\n A)1915\n B)1918\n C)1910\n D)1914", "d");
            QuestionsAnswers.Add("Who did write Romeo and Juliet\n A)Shakespeare\n B)Venus\n C)Adonis\n D)Shevchenko", "a");

            int questionNumber = 1;
            int score = 0;

            

                foreach (KeyValuePair<string, string> question in QuestionsAnswers)
                {
                    Console.WriteLine("Question {0}: {1}", questionNumber, question.Key);
                    Console.Write("Your answer: ");
                    string answer = Console.ReadLine();

                    if (answer.ToLower() == question.Value.ToLower())
                    {
                        Console.WriteLine("Correct!");
                        score += 1000;
                        Console.WriteLine("You scored {0} points.", score);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, the correct answer is {0}.", question.Value);
                        Console.WriteLine("You scored {0} points.", score);
                        Console.WriteLine("Game over.");
                        Console.ReadLine();
                        return;
                    }

                    Console.Write("Do you want to continue? (Y/N): ");
                    string continueAnswer = Console.ReadLine().ToLower();

                    if (continueAnswer == "n")
                    {
                        Console.WriteLine("You scored {0} points.", score);
                        Console.WriteLine("Thanks for playing!");
                        Console.ReadLine();
                        return;
                    }

                    questionNumber++;
                }

                Console.WriteLine("You scored {0} points!", score);
                Console.WriteLine("Thanks for playing!");
                Console.ReadLine();

            }
        }
    }

