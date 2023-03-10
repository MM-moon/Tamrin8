using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahyarMohammadi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student Name:Mahyar Mohammadi
            //professor name:Ali Hafezi


            Console.Write("Are you a student?(yes/no) ");
            string student = Console.ReadLine();
            switch (student)
            {

                case "yes":
                    Console.Write("Are you studying in a university?(yes/no) ");
                    string university = Console.ReadLine();
                    if (university == "yes")
                    {
                        Console.WriteLine("You are a university student and you will graduate with a bachelor's degree.");
                    }
                    else if (university == "no")
                    {
                        Console.WriteLine("You are an intermediate school or highschool student and you will graduate with a diploma.");
                    }
                    else
                    {
                        Console.WriteLine("You have entered the wrong answer.");
                    }
                    break;
                case "no":
                    Console.Write("Have you finished your military service?(yes/no) ");
                    string military = Console.ReadLine();
                    if (military == "yes")
                    {
                        Console.WriteLine("You are able to easily find a job.");
                    }
                    else if (military == "no")
                    {
                        Console.WriteLine("You must finish your military service and receive your card.");
                    }
                    else
                    {
                        Console.WriteLine("You have entered the wrong answer.");
                    }
                    break;


                  
            }
            Console.ReadKey();
            
        }
    }
}
