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








                Double firstNum;
                Double secondNum;
                string operation;
                Double answer;


                Console.WriteLine("Hello , your are welcome to basic calculator!");

                Console.WriteLine(" operation like  x, / , +, -");

                Console.Write("Please enter first number:");

                firstNum = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine(" Enter your operation (x , / , + , - ) ");
                operation = Console.ReadLine();

                Console.Write("Plaese enter second number : ");

               secondNum = Convert.ToInt32(Console.ReadLine());



                //Console.WriteLine(" Pres any key to continue");
                // Console.ReadKey();
                // Console.WriteLine("Thanks");
                // Console.Clear();

                //Console.WriteLine("Pess any key to continue. ");
                // Console.ReadKey(true);

                // Console.Clear();


                if (operation == "x")

                {
                   answer = firstNum * secondNum;

                    Console.WriteLine($" {firstNum} {operation} {secondNum}  =  {answer} ");
                   // Console.ReadLine();
                }

                else if (operation == "/")

                {
                    answer = firstNum / secondNum;

                    Console.WriteLine($" {firstNum} {operation} {secondNum}  =  {answer} ");

                }

                else if (operation == "+")


                {
                    answer = firstNum + secondNum;

                    Console.WriteLine($" {firstNum} {operation} {secondNum}  =  {answer} ");

                }
                else if (operation == "-")

                {
                    answer = firstNum - secondNum;
                    Console.WriteLine($" {firstNum} {operation} {secondNum}  =  {answer} ");


                    {

                        
                        Console.WriteLine(" Pres any key to continue");
                        Console.ReadKey();
                        // Console.WriteLine("Thanks");
                        Console.Clear();

                    }

                }
               
               
                
                










            }
        }
            





    }






}
