using System;

    public class Grade
    {
        static void main(String[] args)
        {
            Console.WriteLine("Welcome to Grade Calculator!\n");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your Prelim Grade: ");
            double prelim = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your MidTerm Grade: ");
            double midterm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your Final Grade: ");
            double final = Convert.ToDouble(Console.ReadLine());

            double average = (prelim + midterm + final)/3;
            Console.WriteLine("RESULTS");
            Console.WriteLine($"Name: {name} \n Grade: {average}");
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
