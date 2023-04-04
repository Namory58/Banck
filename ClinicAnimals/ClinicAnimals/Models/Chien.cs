using ClinicAnimals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAnimals.Model
{
    public class Chien : Animal
    {
        public Chien(string nom, string race, int age) : base(nom, race, age)
        {

        }
        public override string Speak()
        {
            return "Wouf Wouf !!";
        }
        public string Eat()
        {
            if (IsHunger) 
            {
                
                return "j'ai mangé la viande";
            }
            else
            {
                return "je n'est pas manger";
            }
        }
       
        
    }
}
