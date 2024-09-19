using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int NumberOfAnimals { get; set; }

        public Animal(string name, int numberOfAnimals)
        {
            Name = name;
            NumberOfAnimals = numberOfAnimals;
        }

        // Abstract method for making sound, each animal will implement this.
        public abstract string MakeSound();

        // Abstract method for milk production, to be implemented in child classes.
        public abstract int ProduceMilk();

        // Abstract method for giving birth, to be implemented in child classes.
        public abstract void GiveBirth();

        // Print the sound of all animals when they are hungry.
        public string HungrySound()
        {
            string sound = "";
            for (int i = 0; i < NumberOfAnimals; i++)
            {
                sound += (MakeSound());
                sound += " ";
            }
            return sound;
        }
        public void UpdateNumberOfAnimals()
        {
            Random random = new Random();

            NumberOfAnimals += random.Next(0, NumberOfAnimals + 1);
        }
    }
}
