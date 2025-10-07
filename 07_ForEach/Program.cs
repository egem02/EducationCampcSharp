using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loop
            //string[] cities = { "milano", "roma", "Budapest", "ankara", "istanbul", "varsova" };

            //foreach (string city in cities) 
            //{ 
            //    Console.WriteLine(city);
            //}


            //int[] numbers = { 45, 78, 985, 635, 74,11,22,33,41,205,6578,10394 };

            //foreach (int number in numbers) 
            //{
            //    Console.WriteLine(number);

            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers) 
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }

            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;

            //foreach (int i in numbers) 
            //{ 
            //    total += i;

            //}
            //Console.WriteLine(total);

            //List<int> numbers  = new List<int>()
            //{
            //    1,2,3,4,5,8

            //};
            //foreach (int number in numbers) 
            //{
            //    Console.WriteLine(number);

            //}

            //string word = "Hello";

            //foreach (char c in word) 
            //{
            //    Console.WriteLine(c);

            //}

            #endregion
            #region Example for Exam System

           // Console.Write("***** C# Education Camp Exam Application *****");
           // Console.WriteLine();
           // Console.WriteLine();
           // Console.WriteLine();


           // //take the attendance 
           // Console.WriteLine("------------------------------");
           // Console.WriteLine("How many students do you have in your class: ");
           // int studentCount = int.Parse(Console.ReadLine());
           // Console.WriteLine("------------------------------");
            


           // //take the names of students and exam averages
           // string[] studentNames = new string[studentCount];
           // double [] studentExamAvg = new double[studentCount];

           // for (int i = 0; i < studentCount; i++)
           // {
           //     Console.Write($"Enter the {i+1}. name:  ");
           //     studentNames[i] = Console.ReadLine();

           //     double totalExamResult = 0;

           //     // take all students has a 3 exam.
           //     for (int j = 0; j < 3; j++) 
           //     {
           //         Console.Write($"Enter the {studentNames[i]}'s {j+1}. exam result: " );
           //         double value = double.Parse(Console.ReadLine());
           //         totalExamResult += value; //add all exam results
           //     }
           //     Console.WriteLine();
           //     studentExamAvg[i] = totalExamResult / 3;
           // }

           ////Exam Average

           // for (int i = 0; i < studentCount; i++)
           // {
           //     Console.WriteLine($"{studentNames[i]} 's Exam Average: {studentExamAvg[i]}") ;
           // //pass or fail
           //    if(studentExamAvg[i] >= 50)  
           //     { 
           //       Console.WriteLine($" {studentNames[i]} is pass the lesson.") ; 
           //     }
           //     else
           //     {
           //         Console.WriteLine($"{studentNames[i]} is fail the lesson.");

           //     }

           //    Console.WriteLine("*********************************************");
           // }
            
             
           


            #endregion

            Console.Read();
        }
    }
}
