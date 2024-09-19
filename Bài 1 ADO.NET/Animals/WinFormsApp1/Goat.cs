using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Goat : Animal
    {
        public Goat(int numberOfGoats) : base("Goat", numberOfGoats) { }

        public override string MakeSound()
        {
            return "Bleat";
        }

        public override int ProduceMilk()
        {
            Random random = new Random();
            int totalMilk = 0;
            for (int i = 0; i < NumberOfAnimals; i++)
            {
                totalMilk += random.Next(0,11);  // Dê cho sữa từ 0 - 10 lít
            }
            return totalMilk;
        }

        public override void GiveBirth()
        {
            UpdateNumberOfAnimals();
        }
    }
}
