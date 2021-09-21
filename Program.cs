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
            lovefunc(2, 2);
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
          public static bool lovefunc(int flower1, int flower2) { 
         if (flower1 % 2 == 0 && flower2 % 2 == 0 || flower1 % 2 != 0 && flower2 % 2 != 0) {

                return false;
        }  

        else 

        {
                return true;

        }
    }
    }
}


