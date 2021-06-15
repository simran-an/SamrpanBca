using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamrpanBca
{
    class Program
    {
        static void Main1(string[] args)
        {
            int symbol_no; 
            //initializing 3 subjects
            double Dotnet, mis, cn;
            double percentage;
            int total = 300;
            string s_name, division;

            Console.WriteLine("Calculate the total, percentage and division to take marks of three subjects:\n");

            Console.Write("Input the Roll Number of the student :");
            symbol_no = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Name of the student :");
            s_name = Console.ReadLine().ToUpper().ToString();

            Console.Write("Input the marks of dotnet :");
            Dotnet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the marks of mis ");
            mis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the marks of cn ");
            cn = Convert.ToInt32(Console.ReadLine());

            /*double marks_obtained = Dotnet + mis + cn;

            //percentage = (marks_obtaines/ total marks )* 100
            percentage = (marks_obtained / total) * 100;
            //create object of class */

            StdMarksCal stdmarkscal = new StdMarksCal();
            double percentagecalculation = stdmarkscal.Calculatepercentage(Dotnet, mis, cn);


            Console.WriteLine("your percentage using custom class: " +percentagecalculation);
            Console.WriteLine("Percentage Obtained by: {0}, RollNo : {1} is {2}%", s_name, symbol_no, +percentagecalculation);

            Console.ReadKey(true);
        }
    


    }
}

