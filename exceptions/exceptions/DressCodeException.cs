using System;

namespace Exceptions
{
    class DressCodeException:ApplicationException
    {
        string message = "You are not wearing an Elf costume and u are underage.";
        public DressCodeException()//constructor
        {
            Console.WriteLine(message);
        }
    }
}
