using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a dialect: Australian, Southern, Northern, Pirate.");
                var dialect = Console.ReadLine(); // What happens if you run the app without this line?
                
                switch (dialect.ToLower())


                {
                    case "australian":
                        Console.WriteLine("G'day!");
                        break;
                    case "southern":
                        Console.WriteLine("Howdy Y'all!!");
                        break;
                    case "northern":
                        Console.WriteLine("Hey yous");
                        break;
                    case "pirate":
                        Console.WriteLine("Arg?");
                        break;
                    default:
                        Console.WriteLine("Howdy Y'all!!");
                        break;
                }
            }
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Welcome to the animal section, {name}. What's your favorite color?");
            string colorChoice = Console.ReadLine();

            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 5);

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Dog", "Cat" };
            var randomAnimal = animals[randomNumber];
            Console.WriteLine($"{colorChoice} is an excellent choice. Would you like to have a {colorChoice} {randomAnimal}?");
            Console.ReadLine();

            foreach (var animal in animals)
            {
                var counter = 0;
                foreach (var currentCharacter in animal)
                {
                    if (currentCharacter == 'a' || currentCharacter == 'e' || currentCharacter == 'i' || currentCharacter == 'o' || currentCharacter == 'u' || currentCharacter == 'y')
                    {
                        counter++;
                    }
                }
                if (counter >= 2)
                {
                    Console.WriteLine(animal);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("too few syllables");
                    Console.ReadLine();
                }
            }

        }
    }
}
