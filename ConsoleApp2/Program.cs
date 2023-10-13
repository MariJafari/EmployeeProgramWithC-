using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static string[] ids = new string[100];
        static string[] names = new string[100];
        static double[] incomes = new double[100];


        static void Main(string[] args)
        {

            bool toContinue = true;
            for (; toContinue;)
            {

                Console.WriteLine("Welcome to the HR Program");
                Console.WriteLine("Please Choose one  of the following options");

                Console.WriteLine("\n\n1 - Add Employee");
                Console.WriteLine("2 - Display Employee");
                Console.WriteLine("3 - Exit");

                Console.Write("\n\nSelection....: ");
                int selection = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (selection)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        DisplayEmployee();
                        break;
                    case 3:
                        Console.WriteLine("You choose to Exit");
                        toContinue = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid number");
                        break;

                }

            }
        }
        static void AddEmployee()
        {

            bool ReturnToMainMenu = false;
            while (!ReturnToMainMenu)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Employee Add Section");
                Console.WriteLine("Please Choose Type of Employee");
                Console.WriteLine("\n\n1- Commission Employee");
                Console.WriteLine("2- Salaried Employee");
                Console.WriteLine("3- Hourly Employee");
                Console.WriteLine("4- Return to Main Menu");

                Console.Write("\nSelection....: ");
                int selection2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (selection2)
                {
                    case 1:
                        AddCommissionEmployee();
                        break;
                    case 2:
                        AddSalariedEmployee();
                        break;
                    case 3:
                        AddHourlyEmployee();
                        break;
                    case 4:
                        Console.WriteLine("Return to Main Menu");
                        ReturnToMainMenu = true;
                        break;
                    default:
                        Console.WriteLine("Please select a valid number");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void AddCommissionEmployee()
        {
            Console.WriteLine("You selected to Add [Commission Employee]");
            Console.Write("Please enter total sales value....: ");
            double salesValue = double.Parse(Console.ReadLine());
            Console.Write("Please enter commission sales..: ");
            double commission = double.Parse(Console.ReadLine());
            double totalEarning = (commission * salesValue) / 100;
            Console.WriteLine($"Total Earning is....: {totalEarning}  ");
        }



        static void AddSalariedEmployee()
        {
            Console.WriteLine("You selected to Add [Salaried Employee]");
            Console.Write("Please enter Salary....: ");
            double salary = double.Parse(Console.ReadLine());
            double bones;
            if (salary <= 50000)
                bones = 0.3;

            else if (salary > 50000 && salary < 250000)
                bones = 0.2;
            else
                bones = 0.1;

            double totalEarning = salary + (salary * bones);
            Console.WriteLine($"Total earning is...:  {totalEarning}");


        }
        static void AddHourlyEmployee()
        {
            Console.WriteLine("You selected to Add [Hourly Employee]");
            Console.Write("Please Enter hourly rate.....:");
            double hourlyRate = double.Parse(Console.ReadLine());
            Console.Write("Please Enter total weekly hours....:");
            double weeklyHours = double.Parse(Console.ReadLine());
            double totalEarning;

            if (weeklyHours <= 40)
                 totalEarning = weeklyHours * hourlyRate;

            else
                totalEarning = (hourlyRate * 40) + (hourlyRate * 0.5 + hourlyRate) * (weeklyHours - 40);

            Console.WriteLine($"Total earning is...:  {totalEarning}");


        }

        static void DisplayEmployee()
        {
            bool ReturnToMainMenu = false;
            while (!ReturnToMainMenu)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Employee Display");
                Console.WriteLine("Please Choose one of the following options");

                Console.WriteLine("\n\n1- Display Information of All Employees");
                Console.WriteLine("2- Display information of one Employee");
                Console.WriteLine("3- Return to Main Menu");

                Console.Write("\nSelection....:");
                int selection3 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (selection3)
                {
                    case 1:
                        DisplayAll();
                        break;
                    case 2:
                        DisplayOne();
                        break;
                    case 3:
                        Console.WriteLine("Return to Main Menu");
                        ReturnToMainMenu = true;
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid number");
                        break;
                }
                

            }
            
            Console.Clear();
        }


        static void DisplayAll()
        {
            Console.Write("Enter the number of employee you want to add: ");
            int numNames = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            for (int counter = 0; counter < numNames; counter++)
            {
                Console.Write($"Enter name{counter + 1}: ");
                names[counter] = Console.ReadLine();
                Console.Write($"Employee ID{counter + 1}: ");
                ids[counter] = Console.ReadLine();
                Console.Write($"Employee's Income{counter + 1}:  ");
                incomes[counter] = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n");
            }
            Console.WriteLine("\nPress any key to Display all Employee");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("{0,-20} | {1,-20} |{2,-20}", "Name", "ID", "Income");
            Console.WriteLine("{0,-20} | {1,-20} |{2,-20}", "----", "--", "------");


            for (int counter = 0; counter < numNames; counter++)
            {
                Console.WriteLine("{0,-20} | {1,-20} |{2,-20}", names[counter], ids[counter], incomes[counter]);
            }

            Console.ReadKey();
            Console.Clear();

        }
        static void DisplayOne()
        {

            Console.WriteLine("Please Enter Name of the Employee");
            string searchName = Console.ReadLine();
            string nameUpper = searchName.ToUpper();


            bool found = false;
            for (int counter = 0; counter < names.Length; counter++)
            {
                if (names[counter] == searchName)

                {

                    Console.WriteLine("{0,-20} | {1,-20} |{2,-20}", "Name", "ID", "Income");
                    Console.WriteLine("{0,-20} | {1,-20} |{2,-20}", "----", "--", "------");
                    Console.WriteLine("{0,-20} | {1,-20} |{2,-20}", names[counter], ids[counter], incomes[counter]);
                    found = true;
                    Console.ReadKey();
                    break;

                }

            }
            if (!found)
            {
                Console.WriteLine("{0} is not found.", searchName);


                Console.ReadKey();
            }

        }




    }

}





