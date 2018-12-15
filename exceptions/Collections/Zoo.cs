using System.Collections.Generic;

namespace Collections
{
    class Zoo
    {
        public List<Animal> Animal { get; set; }
        public Zoo()//constructor fara parametri
        {
            Animal = new List<Animal>();
            InitialZoo();
        }

        private void InitialZoo()
        {
            Animal.Add(new Animal("Elephant", Gender.Female));
            Animal.Add(new Animal("Tiger", Gender.Male));
            Animal.Add(new Animal("Zebra", Gender.Male));
            Animal.Add(new Animal("Fox", Gender.Female));
        }
    }
}
