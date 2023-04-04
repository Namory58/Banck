using ClinicAnimals.Model;
using ClinicAnimals.Models;

namespace TestClinic
{
  
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }
        Chat cat = new Chat("titi", "boxer", 14);
        Chien Dog = new Chien("Milou", "Berger", 12);
        Clinic r = new Clinic();
        [Test]
        public void chat()
        {
            cat.race = "Berger_allemand";
            Assert.That(cat.nom,Is.EqualTo("titi"));
            Assert.That(cat.race, Is.EqualTo("Berger_allemand"));
            Assert.That(cat.age, Is.EqualTo(14));
            Assert.That(cat.Speak, Is.EqualTo("Miou Miou"));
            
        }
        [Test]
        public void chien()
        {
            Dog.nom = "tata"; 
            Assert.That(Dog.nom, Is.EqualTo("tata"));
            Assert.That(Dog.race, Is.EqualTo("Berger"));
            Assert.That(Dog.age, Is.EqualTo(12));

        }
        [Test]
        public void chienEat()
        {
            Assert.That(Dog.Eat,Is.EqualTo("je n'est pas manger"));
        }
        [Test]
        public void Chienspeak()
        {
            Assert.That(Dog.Brak, Is.EqualTo("ouf ouf"));
        }
        [Test]
        public void clinic()
        {
            Chien medor  = new Chien("milou", "berger_allemand", 12);
            Chien dog = new Chien("milou", "berger_allemand", 12);
            r.Add(medor);
            r.Add(dog);
            r.FeedAnimal(Food.meat);
            var expected = new List<Animal>();
            expected.Add(medor);
            expected.Add(dog);
            CollectionAssert.AreEqual(expected, r.animals);
            Assert.That(dog.PvAct, Is.EqualTo(2));

        }
    }
}