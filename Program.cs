using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            myFunction();
            conditionals("Hamza");
        }

        static void myFunction() {
            Console.WriteLine("Hello Every one?");

        }

        static void conditionals(string firstName) {

            if(firstName == "Hamza"){
                Console.WriteLine("Hi" + " " + firstName);
            }else {
                Console.WriteLine("Hello" + " " + "stranger");
            }


        }
    }
}
