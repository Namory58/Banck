using ClinicAnimals.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAnimals.Model
{
    public abstract class Animal
    {
        public string nom { get; set; }
        public string race { get; set; }
        public int age { get; set; }
        protected bool IsHunger { get; set; }
        public int PvMax { get; private set; }
        public int PvAct { get; set; }
        protected Animal(string nom, string race, int age):this(nom,race,age,10)
        {
         
        }         
        protected Animal(string nom, string race, int age,int pointMax)
        {
            this.nom = nom;
            this.race = race;
            this.age = age;
            IsHunger = true;
            this.PvMax = pointMax;
            this.PvAct = 1;
        }
        public abstract string Speak();
        public void Heal(int value)
        {
            PvAct += value;

            if (PvMax < PvAct)
            {
                PvAct = PvMax;
            }
            if (PvAct < 0)
            {
                PvAct = 0;
            }
            
        }
        public void Eat(Food f)
        {
            switch (f)
            {
                case Food.meat:
                    Heal(4);
                    break;
                case Food.rice:
                    Heal(2);
                    break;
                case Food.carote:
                    Heal(1);
                    break;
            }
        }

    }
}
