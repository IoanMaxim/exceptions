using System;
//EXCEPTIONS:
//
namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int a = 100;
            //    int b = a / 0;
            //    Console.WriteLine(a);
            //}
            //catch (DivideByZeroException exception)//exception este un nume de variabila;
            //{
            //    Console.WriteLine("Ups, something is wrong.");
            //    Console.WriteLine(exception.Message);
            //    Console.WriteLine(exception.StackTrace);
            //    Console.WriteLine(exception.Source);
            //}

            try
            {
                Person ionut = new Person(35);
                Person ionut1 = new Person(-1);
                Person ionut2 = new Person(2);
                Person ionut3 = new Person(81);
            }
            catch (ArgumentException e)
            {
                //Console.WriteLine(e);//This will show all the error;
                Console.WriteLine(e.Message + e.GetType());
                //throw;
            }
            catch (DressCodeException ex)
            {
                Console.WriteLine(ex.Message + ex.GetType());
            }















            Console.ReadLine();
        }
    }
}
