using System;

namespace _3Questions
{
    class Program
    {
        static void Main()
        {
            // create variable for question numbers
            int questionNum = 0;


            while (questionNum != 1 && questionNum != 2 && questionNum != 3)
            {
                // ask user to pick a number
                Console.WriteLine("Choose your question (1-3): ->");
                string qChosen = Console.ReadLine();

                // convert answer to int
                questionNum = Int32.Parse(qChosen);

                // blanket if statement for number chosen
                if (questionNum == 1)
                {
                    string q1Answer = "black";
                    Console.WriteLine("You have 5 seconds to answer the following question:/n What is your favorite color?");
                    string q1Response = Console.ReadLine();
                    if (q1Answer == q1Response.ToLower())
                    {
                        Console.WriteLine("Well done! Play again?");
                        bool playAgain = false;
                        string playResponse = Console.ReadLine();
                        if (playResponse.ToLower() == "y" || playResponse.ToLower() == "yes")
                        {
                            playAgain = true;
                            questionNum = 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong! The answer is " + q1Answer);
                        Console.WriteLine("Play again? ->");
                        bool playAgain = false;
                        string playResponse = Console.ReadLine();
                        if (playResponse.ToLower() == "y" || playResponse.ToLower() == "yes")
                        {
                            playAgain = true;
                            questionNum = 0;
                        }
                    }

                }
                else if (questionNum == 2)
                {
                    Console.WriteLine("Question 2!");
                }
                else if (questionNum == 3)
                {
                    Console.WriteLine("Question 3!");
                }
                else
                {
                    Console.WriteLine("Please write a number between 1 and 3.");
                }
            }

        }
    }
}

