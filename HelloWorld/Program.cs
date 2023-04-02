using System;

namespace HelloWorld
{
    public class Animal
    {
        private int age { get; set; }
        private string type { get; set; }
        private string name { get; set; }

        public string Move(int distance)
        {
            return name + " has moved " + distance + "m";
        }

        //we are declaring a virtual method that can be overridden in the subclasses (method overriding) 
        public virtual void MakeSound()
        {
            Console.WriteLine("something");
        }
        
        
        public Animal(int age, string type, string name = null)
        {
            this.age = age;
            this.type = type;
            this.name = name;
        }

        public class Dog : Animal {

            // we are overriding the method in the parent class
            public override void MakeSound()
            {
                Console.WriteLine("woof");
            }

            // creating a derived class *notice how we use base() to instansiate it
            public Dog(int age, string type, string name = null) : base(age, type, name)
            {

            }
        }
    

        static void Main()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("=====");
            Animal pet1 = new Animal(6, "house cat", "Hosh");
            Animal pet2 = new Animal(2, "puppy", "Bruce");
            // creating a new Dog instance, see how it is within Animal ex. Animal.Dog
            Animal.Dog myDog = new Animal.Dog(2, "golden retriever", "Doge");
            Console.WriteLine("=====");
            Console.WriteLine(myDog.Move(2));
            Console.WriteLine("=====");
            // overridden method
            myDog.MakeSound();
            Console.WriteLine("=======");

            //Basic Linq (built in query type language for C#)
            Console.WriteLine("words that are longer that 3 chars: ");
            var listOfString = new List<string>() { "a", "bccc", "caaa", "d" };
            var findSpecific = listOfString.Where(s => s.Length > 1);
            foreach (string wrd in findSpecific)
            {
                Console.WriteLine(wrd);
            }

            Console.WriteLine("=======");
            Console.WriteLine("Even numbers");
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var evenNumbers = from n in numbers
                              where n % 2 == 0
                              select n;
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }


        }
    }
}



// key takeaways from object orientation
/*
 Inheritance - we can access functions and properties of the base class 


 Abstraction - declare class as abstract, shows incomplete class members that need to be implimented
               for example we can create a general public abstract makeSound method, this will need to be implimented
               in the derived (dog) class using the override. We do not need to specify the details of the method, which is the advantage.
               Take note, abstract class cannot be instansiated. 

Polymorphism - method overriding & method overloading. Overriding = we can call a method on a subclass that overrides a same method in the parent class,
               even though they have the same name. Method overloading is same name, but different parameters, could potentially be different types. In
               summary, they make it so that the code can handle different types of data and objects without writing separate methods

               *This works quite well with interfaces*
               

*/