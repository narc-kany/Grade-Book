using System;
using System.Collections.Generic;


namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=3.142, y=22.001; 
            var ans=0.00;
            ans = y/x;
            double result = 0.00;

            double[] num = new double[] {13.51, 6.43, 8.25, 90.0};
            foreach(double n in num) {
                result += n;
                System.Console.WriteLine($"The sum is {result}");
            }
            Console.WriteLine($"the value of the double {ans} \n");
            if (args.Length == 0) 
            {
                Console.WriteLine("No value is inside");
            }
            else 
            {
             Console.WriteLine($"Welcome {args[0]} !\n" + getSalutations(args[0]) + "\n");        
             
            }

            //List 
            List<double> grades = new List<double>() {13.51, 6.43, 8.25, 90.0};
            grades.Add(90.99);

            foreach(double grade in grades) {
                result += grade;
            }

            result /= grades.Count;
            System.Console.WriteLine($"The average range is {result:N2}");



            
        }

        public static String getSalutations(string username)
        {
            return "Sup" + username;
        }
    }
}
