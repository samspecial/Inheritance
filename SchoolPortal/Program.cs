using System;

namespace SchoolPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please provide your name here: \n");
            string name = Console.ReadLine();

            Console.Write("Please provide your registration number here: \n");
            string regNumber = Console.ReadLine();
            
            Console.WriteLine("Please enter your Department: ");
            string department = Console.ReadLine();
            
            Console.WriteLine("Please enter SCI or COM: ");
            string departmentCode = Console.ReadLine();

           
            double[] score = new double[3];
            for(int i = 0; i < 3; i++)
            {

            Console.Write($"Please enter score {i + 1}");
            score[i] = double.Parse(Console.ReadLine());
            }
            if(departmentCode == "SCI")
            {
                ScienceStudent science = new ScienceStudent(department, name, regNum);
            }else if(departmentCode == "COM"){
                CommercialStudent commercial = new CommercialStudent("");
            }else{
                Console.WriteLine($"{departmentCode} not recognized. Check and try again");
            }
           
        }
    }
}
