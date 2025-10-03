using System;

namespace _03_MakingDecison
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region If-Else
            //Console.Write("Please enter your password: ");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd")
            //{
            //    Console.WriteLine("The password is correct");
            //}
            //else {
            //    Console.WriteLine("The password isnt correct.");
            //}
            //string capital;
            //string country;
            //Console.Write("Please enter your capital: ");
            //capital = Console.ReadLine();
            //Console.Write("Please enter your country: ");
            //country = Console.ReadLine();

            //if(capital == "ankara" & country == "turkiye")
            //{
            //    Console.Write("The datas are corrected");
            //}
            //else
            //{
            //    Console.Write("The datas are not correct.");
            //}
            //int number;
            //Console.Write("Please enter number");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("The number is correct.");
            //}
            //else {
            //    Console.WriteLine("The number isnt correct.");
            //}
            //int exam1, exam2, exam3 ,average;
            //string result = "Error";
            //Console.Write("First exam: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Second exam: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Third exam: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2+ exam3) / 3;
            //Console.WriteLine("The average of exams: " + average);

            //if(average > 0 & average <= 50)
            //{
            //    result = "You failed.";
            //}

            //if(average > 50 & average <= 69)
            //{
            //    result = "You passed.";
            //}
            //if(average > 69 & average <= 84)
            //{
            //    result = "You good.";
            //}
            //if(average > 84 & average <= 100)
            //{
            //    result = "You success.";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Please enter the city name: ");
            //city = Console.ReadLine();
            //if (city == "antalya" | city == "ankara")
            //{
            //    Console.WriteLine("The city is include.");
            //}
            //else
            //{
            //    Console.WriteLine("The city isnt include.");
            //}


            //Console.Write("Please enter your username: ");
            //string  username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("This username couldnt access");
            //}
            //else {
            //    Console.Write("Welcome.");
            //}
            //Console.Read();
            #endregion
            #region Mod 

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Enter your first number: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter your second number: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = (number1 % number2);

            //Console.Write("Its left First number divided by second number: " + result );


            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.Write("The number is even");
            //}
            //else
            //{
            //    Console.Write("The number is odd");
            //}

            #endregion
            #region Char Variables to decided
            //char team;
            //Console.Write("Please enter the team symbol: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'g'| team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f'| team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b'| team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion
            #region Project Applying

            //Console.WriteLine("***** C# Education Camp Restorant *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("1- Main Dishes");
            //Console.WriteLine("2- Soups");
            //Console.WriteLine("3- Pizzas");
            //Console.WriteLine("4- Drinks");
            //Console.WriteLine("5- Deserts");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();
            //string menuItem;
            //Console.Write("Menu choice for taking details: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------Main Dishes------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kori with Chicken");
            //    Console.WriteLine("2-Fish and chips");
            //    Console.WriteLine("3-Apperatifs");
            //    Console.WriteLine("4- Beans with rice");
            //    Console.WriteLine("5- Salmon");
            //    Console.WriteLine("-------Main Dishes------");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------Soups------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Tomato Soup");
            //    Console.WriteLine("2- Ezogelin soup");
            //    Console.WriteLine("-------Soups------");

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------Pizzas------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Chicken Pizza");
            //    Console.WriteLine("2-Tuna Pizza");
            //    Console.WriteLine("3-Pizza with Anchuez");
            //    Console.WriteLine("4- Peperroni pizza");

            //    Console.WriteLine("-------Pizzas------");
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------Drinks------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Beer");
            //    Console.WriteLine("2-Champagne");
            //    Console.WriteLine("3-Red / white / Rose Wine");
            //    Console.WriteLine("4- Coke");

            //    Console.WriteLine("-------Drinks------");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------Desserts------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kazandibi");
            //    Console.WriteLine("2- Sütlaç");
            //    Console.WriteLine("3- Baklava ");
            //    Console.WriteLine("4- Trileçe");

            //    Console.WriteLine("-------Drinks------");
            //}
            #endregion
            #region Switch-Case

            //Console.Write("Please enter a month: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber) 
            //{
            //    case 1: Console.Write("January"); 
            //    break;            
            //    case 2: Console.Write("Feburary"); 
            //    break;            
            //    case 3: Console.Write("March"); 
            //    break;            
            //    case 4: Console.Write("April"); 
            //    break;            
            //    case 5: Console.Write("May"); 
            //    break;            
            //    case 6: Console.Write("June"); 
            //    break;            
            //    case 7: Console.Write("July"); 
            //    break;            
            //    case 8: Console.Write("August"); 
            //    break;            
            //    case 9: Console.Write("September"); 
            //    break;            
            //    case 10: Console.Write("October"); 
            //    break;            
            //    case 11: Console.Write("November"); 
            //    break;            
            //    case 12: Console.Write("December"); 
            //    break;
            //    default: Console.WriteLine("Invalid option.");
            //    break;



            //}

            #endregion
            #region Switch Case Calculator
            //int number1, number2, result;
            //char symbol;
            //Console.Write("Enter the first number: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Please choice your operation: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch(symbol)
            //{
            //    case '+':
            //        result = number2 + number1;
            //        Console.WriteLine("Total: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Total: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Total: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Total: " + result);
            //        break;
            //    default: Console.WriteLine("Invalid option");
            //    break;
            //}
              
            #endregion
           // Console.Read();
        }
    }
}
