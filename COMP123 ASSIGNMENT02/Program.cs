using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_ASSIGNMENT02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create 4 objects
            Pet cici = new Pet("Cici", "cute cat", 4);
            Pet pipi = new Pet("Pipi", "adorable cat", 3);
            Pet evelyn = new Pet("Evelyn", "chubby pig", 25);
            Pet tommy = new Pet("Tommy", "fluffy dog", 6);
           
            //create list and store 4 objects
            List<Pet> pets = new List<Pet>();
            pets.Add(cici);
            pets.Add(pipi);
            pets.Add(evelyn);
            pets.Add(tommy);

            //using setowner and train method to change pet's status
            evelyn.SetOwner("Lucas");
            pipi.SetOwner("Eve");
            evelyn.Train();
            tommy.Train();

            //displaying all pet in pets list
            foreach (var pet in pets)
            {
                Console.WriteLine(pet);
            }
            Console.WriteLine();

            //prompt the user for owners name
            Console.Write("Enter the owner's name and see the pets under his name: ");
            string owner = Console.ReadLine();

            //checking each pet if the prompt matches pet.Owner

            for (int i = 0; i < pets.Count(); i++)
            {
                if (owner != pets[i].Owner)
                {
                    if (i == pets.Count() - 1)
                    {
                        Console.WriteLine("There is no pet under this person name");
                    }
                }
                else
                {
                    Console.WriteLine(pets[i].Name + " belongs to " + owner);
                }
            }
          

            Console.ReadLine();
        }
    }
    class Pet
    {
        public string Name { get; }
        public int Age { get; }
        public string Description { get; }
        public string Owner { get; private set;}
        public bool IsHouseTrained { get; private set;}

        public Pet(string name, string description, int age = 1)
        {
            Name = name;
            Description = description;
            Age = age;
        }

        public override string ToString()
        {
            if (Owner == null)
            {
                Owner = "no owner";
            }
            if (IsHouseTrained)
            {
                return $"{Name} is a {Description} and {Age} years old, owner is {Owner} and {Name} is trained";
            }
            else 
            { 
                return $"{Name} is a {Description} and {Age} years old, owner is {Owner} and {Name} is not trained";
            }
            
        }

        public void Train()
        { 
            IsHouseTrained = true;
        }

        public void SetOwner(string newOwner)
        { 
            Owner = newOwner;
        }
    }
}
