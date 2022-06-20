using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)

        {
            // string myName = "Hughes";
            // Console.WriteLine( myName.Length);


            // Console.WriteLine(myName.ToUpper());
            //  Console.WriteLine(myName.ToLower());


            //   Console.WriteLine(myName.Contains("u"));

            //  Console.WriteLine(myName.IndexOf("u"));

            // Console.WriteLine(myName.Substring(2,2));
      


            // Console.ReadLine();



            // NUMBERS

            // int myAge=25;
            // double myAccountBal = 10.00;

            // Console.WriteLine(3+5);
            //  Console.WriteLine(30/5);
            //   Console.WriteLine(3-5);
            //    Console.WriteLine(3*5);

            //  Console.WriteLine(3+5.4);
            //       Console.WriteLine(5/2.0);


         // myAge++;

         // myAge--;
            // Console.WriteLine(Math.Abs(10));
            //    Console.WriteLine(Math.Pow(10,2));
            //    Console.WriteLine(Math.Sqrt(144));
            // Console.WriteLine(Math.Max(2,7));
            // Console.WriteLine(Math.Min(2,7));


            // Console.WriteLine(Math.Round(2.57));

            // GET INPUT FROM USER

            // Console.WriteLine("Hello");
            //  Console.Write("What is your name : ");
            //    string userName = Console.ReadLine();
            //    Console.WriteLine("Hi " + userName );

            //    Console.Write("Where are you from : ");
            //    string place = Console.ReadLine();
            //    Console.WriteLine("Hi " + userName + " from "+ place + " nice to meet you!");
            // Console.ReadLine();



            Console.WriteLine("SIMPLE CALCULATOR");
              Console.WriteLine("GET THE SUM OF TWO NUMBERS");
                Console.Write("What is your first number: ");
                //integers
                //   int firstNum= Convert.ToInt32(Console.ReadLine());
                //   Console.Write("What is your second number: ");
                //   int secondNum= Convert.ToInt32(Console.ReadLine());;

                // //   Convert.ToInt32("40");


//doubles
                  double firstNum= Convert.ToDouble(Console.ReadLine());
                  Console.Write("What is your second number: ");
                  double secondNum= Convert.ToDouble(Console.ReadLine());;

                  Console.Write("The total is: " + (firstNum + secondNum));
              



        }
    }
}
