using System;

namespace Assa_calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            bool keepAlive = true;
            while (keepAlive)
            {



                try
                {


                    Console.Write(" Enter number  (or 9 to exit)\nSecect: ");
                    int selectionNumber = int.Parse(Console.ReadLine() ?? "");

                    if (selectionNumber == 9)
                    {
                        keepAlive = false;
                        continue;
                    }

                    double firstNum;
                    Double secondNum;
                    string operation;
                    Double answer;

                    Console.WriteLine("Your are welcome to calculate  x, / , +, -!");

                    firstNum = AskUserForNumber();

                    Console.WriteLine("Enter your operation (x , / , + , - ) ");
                    operation = Console.ReadLine();

                    secondNum = AskUserForNumber();

                    if (operation == "*")
                    {
                        answer = Multi(firstNum, secondNum);

                        Console.WriteLine($" {firstNum} {operation} {secondNum}  =  {answer} ");

                    }

                    else if (operation == "/")
                    {
                        if (secondNum == 0)
                        {
                             Console.WriteLine("can not divide by zero ");

                        }
                        else
                        {
                            answer = Divide(firstNum, secondNum);

                            Console.WriteLine($" {firstNum} {operation} {secondNum}  =  {answer} ");
                        }

                    }
                    else if (operation == "+")
                    {
                        answer = Add(firstNum, secondNum);

                        Console.WriteLine($" {firstNum} {operation} {secondNum}  =  {answer} ");

                    }
                    else if (operation == "-")
                    {
                        answer = Subtract(firstNum, secondNum);
                        Console.WriteLine($" {firstNum} {operation} {secondNum}  =  {answer} ");

                    }
                    else
                    {
                        Console.WriteLine("Not a valid option.");
                    }
                    Console.WriteLine("Pres any key to continue");
                    Console.ReadKey(true);
                    
                    Console.Clear();

                }
                catch (OverflowException)
                {

                    Console.WriteLine("operation resulted in an overflow \n enetr a valid number to coninue ?");
                }
                catch (FormatException)
                {
                    Console.WriteLine("it´s a not a numner !");
                }

            }
        }// end of main

        private static double Multi(double firstNum, double secondNum)

        {
            return firstNum * secondNum;
           
        }

        private static double Divide(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
     
        }
        private static double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
        private static double Subtract(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
        static double AskUserForNumber()
        {
            Console.Write("Please enter number:");
            return Convert.ToDouble(Console.ReadLine());

        }

    }//class program
}//namespace
