using System;

namespace CA_MethodCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // variables
            //
            double number1 = 0, number2 = 0;
            double answer = 0;

            string userResponse;
            string operation;
            string operationSymbol = "";

            bool quitting = false;
            bool validResponse;

            //
            // display opening screen
            //
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\tThe Simple Calculator");
            Console.WriteLine("\t\tLaughing Leaf Productions");
            Console.WriteLine();

            //
            // pause for user
            //
            Console.WriteLine("\t\tPress any key to continue.");
            Console.ReadKey();

            //
            // application loop
            //
            while (!quitting)
            {
                //
                // get and validate the first number from the user
                //
                validResponse = false;
                while (!validResponse)
                {
                    //
                    // display header
                    //
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("\t\tThe Simple Calculator");
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.Write("\tEnter the first number:");
                    userResponse = Console.ReadLine();

                    if (!double.TryParse(userResponse, out number1))
                    {
                        Console.WriteLine("\tYou must enter a number. (2.4, 9, etc.)");

                        //
                        // pause for user
                        //
                        Console.WriteLine("\t\tPress any key to continue.");
                        Console.ReadKey();
                    }
                    else
                    {
                        validResponse = true;
                    }
                }
                
                //
                // get and validate the second number from the user
                //
                validResponse = false;
                while (!validResponse)
                {
                    //
                    // display header
                    //
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("\t\tThe Simple Calculator");
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.Write("\tEnter the second number:");
                    userResponse = Console.ReadLine();

                    if (!double.TryParse(userResponse, out number2))
                    {
                        Console.WriteLine("\tYou must enter a number. (2.4, 9, etc.)");

                        //
                        // pause for user
                        //
                        Console.WriteLine("\t\tPress any key to continue.");
                        Console.ReadKey();
                    }
                    else
                    {
                        validResponse = true;
                    }
                }

                //
                // get and validate the operation from the user
                //
                validResponse = false;
                while (!validResponse)
                {
                    //
                    // display header
                    //
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("\t\tThe Simple Calculator");
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.Write("\tEnter the operation ( ADD SUBTRACT MULTIPLY DIVIDE ):");
                    operation = Console.ReadLine().ToUpper();

                    //
                    // validate the user response and process their choice
                    //
                    switch (operation)
                    {
                        case "ADD":
                            answer = number1 + number2;
                            operationSymbol = "+";
                            validResponse = true;
                            break;

                        case "SUBTRACT":
                            answer = number1 - number2;
                            operationSymbol = "+";
                            validResponse = true;
                            break;

                        case "MULTIPLY":
                            answer = number1 * number2;
                            operationSymbol = "+";
                            validResponse = true;
                            break;

                        case "DIVIDE":
                            answer = number1 / number2;
                            operationSymbol = "+";
                            validResponse = true;
                            break;

                        default:
                            Console.WriteLine("\tYou must enter a valid operation.");

                            //
                            // pause for user
                            //
                            Console.WriteLine("\t\tPress any key to continue.");
                            Console.ReadKey();
                            break;
                    }
                }

                //
                // display the answer
                //
                // display header
                //
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\t\tThe Simple Calculator");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"\tAnswer: {number1} {operationSymbol} {number2} = {answer}");
                Console.WriteLine();

                //
                // pause for user
                //
                Console.WriteLine("\t\tPress any key to continue.");
                Console.ReadKey();

                //
                // ask the user to continue or exit, validate the response
                //
                validResponse = false;
                while (!validResponse)
                {
                    //
                    // display header
                    //
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("\t\tThe Simple Calculator");
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.Write("\tWould you like to perform another calculation ( YES or NO ):");
                    userResponse = Console.ReadLine().ToUpper();

                    //
                    // validate the user response and process their choice
                    //
                    if (!(userResponse == "NO" || userResponse == "YES"))
                    {
                        Console.WriteLine("\tYou must enter either 'YES' or 'NO'.");

                        //
                        // pause for user
                        //
                        Console.WriteLine("\t\tPress any key to continue.");
                        Console.ReadKey();
                    }
                    else
                    {
                        if (userResponse == "NO")
                        {
                            quitting = true;
                        }

                        validResponse = true;
                    }
                }
            }
        }
    }
}