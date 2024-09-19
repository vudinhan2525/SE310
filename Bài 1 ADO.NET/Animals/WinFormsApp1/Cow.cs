using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Cow : Animal
    {
        public Cow(int numberOfCows) : base("Cow", numberOfCows) { }

        public override string MakeSound()
        {
            return "Moo";
        }

        public override int ProduceMilk()
        {
            Random random = new Random();
            int totalMilk = 0;
            for (int i = 0; i < NumberOfAnimals; i++)
            {
                totalMilk += random.Next(0,21);  // Bò cho sữa từ 0 - 20 lít
            }
            return totalMilk;
        }

        public override void GiveBirth()
        {

            UpdateNumberOfAnimals();
        }
    }
}
