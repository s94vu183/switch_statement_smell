using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Animal {
        public Animal(string name)
        {
            Name = name;
        }
        virtual public string AnimalType { get; private set; }
        public string Name { get; private set; }
        virtual public string talk { get; private set; }
    }

    class Dog : Animal {
        public Dog(string name):base(name)
        {

        }
        public override string AnimalType
        {
            get
            {
                return "dog";
            }
        }
        public override string talk
        {
            get
            {
                return "汪汪";
            }
        }
    }

    class Cat : Animal
    {
        public Cat(string name):base(name)
        {

        }
        public override string AnimalType
        {
            get
            {
                return "cat";
            }
        }
        public override string talk
        {
            get
            {
                return "喵喵";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Dog("dog1"),
                new Dog("dog2"),
                new Cat("cat1")
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name + animal.talk);
            }
        }
    }


}
