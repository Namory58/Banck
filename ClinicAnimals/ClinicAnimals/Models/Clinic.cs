using ClinicAnimals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAnimals.Models
{
   public class Clinic
    {
        public int Taille;
        public List<Animal> animals;
        public List<Animal> salles;
        public Clinic() : this(10)
        {
        }
        public Clinic(int taille)
        {
            this.Taille = taille;
            animals = new List<Animal>();
            salles = new List<Animal>();
        }
        public void Add(Animal a )
        {
            if ((animals.Count() == Taille)) {
                salles.Add(a);
            }
            animals.Add(a);
        }
        public void FeedAnimal(Food f) {

            List<Animal> liste = new List<Animal>();
            foreach (Animal animal in animals)
            {
                animal.Eat(f);
                if ((animal.PvAct == animal.PvMax)||(animal.PvAct==0))
                {
                    liste.Add(animal);
                }
            }
            /*retirer*/  this.animals = this.animals.Except(liste).ToList();
            /*
             *  Ajouter un animal de la prémière liste d'attende (salle) jusqu'a
             *  ce que la taille de la clinique soit atteinte
             * 
             */
            while(animals.Count< Taille ||salles.Count==0)
            {
                Animal premier = salles.First();
                animals.Add(premier);
                salles.Remove(premier);
            }

        }

    }

}
