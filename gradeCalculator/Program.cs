namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HI! Please enter you full name: ");
            string nameEntered = Console.ReadLine();

            Console.WriteLine("Please enter your score:");
            string score = Console.ReadLine();
            int scoreEntered = Convert.ToInt32(score);

            char grade = 'F';

            if (scoreEntered < 40)
            {
                grade = 'F';
            }
            else if (scoreEntered >= 40 && scoreEntered <= 50)
            {
                grade = 'E';
            }
            else if (scoreEntered >= 51 && scoreEntered <= 60)
            {
                grade = 'D';
            }
            else if (scoreEntered >= 61 && scoreEntered <= 70)
            {
                grade = 'C';
            }
            else if (scoreEntered >= 71 && scoreEntered <= 80)
            {
                grade = 'B';
            }
            else if (scoreEntered >= 81 && scoreEntered <= 100)
            {
                grade = 'A';
            }
            else
            {
                Console.WriteLine("input a valid score!!!");
            }

            string gradeOutput = $"Dear {nameEntered}, your grade is {grade}";

            Console.WriteLine(gradeOutput);
            Console.ReadLine();

            //INT / LONG VARIABLE DECLARATION
            int age = 10;

            //DOUBLE / FLOAT DECLARATION
            double weight = 80.109;

            //char declaration
            char first = 'A';

            //string declaration

            string second = "Adeolu";

            //bool declaration
            bool score1;

            double result = age + weight;

            if (result < 90)
            {
                score1 = true;
            }
            else
            {
                score1 = false;
            }


        }

    }
}