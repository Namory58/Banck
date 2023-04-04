using ClinicAnimals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAnimals.Models
{
    public class Lapin:Animal
    {
        public Lapin(string nom, string race, int age) : base(nom, race, age)
        {
        }
        public Lapin(string nom, string race, int age, int pointMax) : base(nom, race, age, pointMax)
        {
        }
        public override string Speak()
        {
            return "Tap Tap!";
        }
        public new void Eat(Food f)
        {
            if (Food.carote == f)
            {
                PvAct +=1;
            }
        }
    }
}
