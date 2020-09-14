using System;


namespace guess_game
{
    class Program
    {
        static void Main()
        {
            string choise;
            do
            {
                bool youwon = false;
                Random random = new Random();
                int randomnumber = random.Next(1, 100);
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("guess the number");
                    int guess = int.Parse(Console.ReadLine());
                    if (guess == randomnumber)
                    {
                        Console.WriteLine("you won");
                        youwon = true;
                        break;
                    }
                    else if (guess < randomnumber)
                        Console.WriteLine("your number is less than mine");
                    else
                        Console.WriteLine("your number is greater than mine");
                }
                if (!youwon)
                    Console.WriteLine("you have lost sorry");
                Console.WriteLine($"correct number is {randomnumber}");
            
            Console.WriteLine("do you want to try again(Y/N)");
            choise =Console.ReadLine().ToLower();
            } while (choise == "y");


        }
    }
}
