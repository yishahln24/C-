using System;

    public class GradeCalculator
    {
        static void Main(String[] args)
        {
            Console.WriteLine("====Welcome to Grade Calculator!====");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your Prelim Grade: ");
            double prelim = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your MidTerm Grade: ");
            double midterm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your Final Grade: ");
            double final = Convert.ToDouble(Console.ReadLine());

            int average = Convert.ToInt16(prelim + midterm + final)/3;
            Console.WriteLine("====RESULTS====");
            Console.WriteLine($"Name: {name} \nGrade: {average}");
            if(average >= 75)
             { 
                Console.WriteLine("Status: PASSED");
             }
            else
             {
                Console.WriteLine("Status: FAILED");
             }
        }
    }
