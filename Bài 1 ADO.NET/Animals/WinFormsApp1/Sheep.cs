using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Sheep : Animal
    {
        public Sheep(int numberOfSheep) : base("Sheep", numberOfSheep) { }

        public override string MakeSound()
        {
            return "Baa";
        }

        public override int ProduceMilk()
        {
            Random random = new Random();
            int totalMilk = 0;
            for (int i = 0; i < NumberOfAnimals; i++)
            {
                totalMilk += random.Next(0, 5);  // Cừu cho sữa từ 0 - 5 lít
            }
            return totalMilk;
        }

        public override void GiveBirth()
        {
            UpdateNumberOfAnimals();
        }
    }
}
