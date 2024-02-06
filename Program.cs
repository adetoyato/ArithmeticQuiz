using System;

public static class ArithmeticQuiz
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Loading Arithmetic Quiz...");
        Thread.Sleep(1000);
        startQuiz();
    }

    static void startQuiz()
    {

        Random random = new Random();
        int questionsAvailable = random.Next(5, 16); //Randomizes how many questions are to be answered

        Console.Clear();
        Console.WriteLine($"Questions to answer: {questionsAvailable}"); //Displays how many questions are to be expected
        Console.WriteLine();
        //comment this out to avoid confusion if you wish to try the method above!

        int yourScore = 0;

        for (int i = 0; i < questionsAvailable; i++)
        {
            int num1 = random.Next(1, 100); //Randomizes numbers 1
            int num2 = random.Next(1, 100); //Randomizes numbers 2
            int yourAnswer;

            switch (random.Next(1, 5))
            {
                case 1: //Addition
                    Console.Write($"Question {i + 1}: What is {num1} + {num2}?\nYour Answer: ");
                    yourAnswer = num1 + num2;
                    break;
                case 2: //Subtraction
                    Console.Write($"Question {i + 1}: What is {num1} - {num2}?\nYour Answer: ");
                    yourAnswer = num1 - num2;
                    break;
                case 3: //Multiplication
                    Console.WriteLine($"Question {i + 1}: What is {num1} * {num2}?\nYour Answer: ");
                    yourAnswer = num1 * num2;
                    break;
                case 4: //Division
                    Console.Write($"Question {i + 1}: What is {num1} / {num2}?\nYour Answer: ");
                    yourAnswer = num1 / num2;
                    break;
                default:
                    yourAnswer = 0;
                    break;
            }
            int answerHere;
            while (!int.TryParse(Console.ReadLine(), out answerHere)) //Ensures that the input are only valid numbers
            {
                Console.WriteLine("Answer is invalid. Please only use numbers.");
            }
            if (answerHere == yourAnswer)
            {
                Console.WriteLine("Your answer is correct!");
                Console.WriteLine();
                yourScore++;
            }
            else
            {
                Console.WriteLine($"Your answer is incorrect. The answer should be {yourAnswer}");
            }
        }
        double answerPercentage = (double)yourScore / questionsAvailable * 100; //Computes the percentage of correct answers
        Console.WriteLine($"The quiz has ended. Your score is {yourScore} out of {questionsAvailable}");
        Console.WriteLine($"You answered {answerPercentage}% of the questions correctly.");
        Console.WriteLine();

        bool inputTrue = false;
        do
        {
            Console.WriteLine("Would you like to take the quiz again? Y = Yes/N = No"); //Asks if you'd like to take the quiz again
            String booleanInput = Console.ReadLine();
            Console.WriteLine();

            if (booleanInput.Equals("yes", StringComparison.OrdinalIgnoreCase) || booleanInput.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                startQuiz();
            }
            else if (booleanInput.Equals("no", StringComparison.OrdinalIgnoreCase) || booleanInput.Equals("n", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("See you next time.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please use only Y or N in your input.");
            }
        } while (!inputTrue);
    }
}
