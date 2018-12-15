using System;

namespace Exceptions
{
    class Person
    {
        private int age;//field;
        public int Age//proprietate(o prop. te ajuta la validare);
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("can't be negative", "Age");
                }
                if (value == 2 || value > 80)
                {
                    throw new DressCodeException();//propria exceptie;
                }
                this.age = value;
            }
        }

        public Person(int age)//metoda;
        {
            this.Age = age;
        }


    }
}
