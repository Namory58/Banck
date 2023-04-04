using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAnimals.Model
{
    public class Chat :Animal
    {
        public Chat(string nom, string race, int age) : base(nom, race, age)
        {
        }
        public Chat(string nom, string race, int age,int pointMax) : base(nom, race, age,pointMax)
        {
        }
       public override string Speak()
        {
            return "Miaou  Miaou";
        }
    }
   
}
