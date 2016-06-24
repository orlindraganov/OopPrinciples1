namespace Animals
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Interfaces;
    using Models;

    class StartUp
    {
        static void Main()
        {
            ISound Dingo = new Dog("Dingo", 12, Sex.male);
            Animal Tom = new Tomcat("Tom", 5, Sex.male);
            Frog Frogger = new Frog("Pesho", 33, Sex.female);
            Kitten Pisana = new Kitten("Pisana", 2, Sex.female);

            Dingo.MakeSound();
            Tom.MakeSound();
            Frogger.MakeSound();
            Pisana.MakeSound();

            var animals = new List<Animal>();

            //Note - ISound has to be casted to Animal. Nice, a?
            animals.Add((Dog)Dingo);
            animals.Add(Tom);
            animals.Add(Frogger);
            animals.Add(Pisana);

            animals.Add(new Dog("Grigor", 5, Sex.male));
            animals.Add(new Dog("Stara Planina", 7, Sex.female));
            animals.Add(new Dog("Goebbles", 14, Sex.male));
            animals.Add(new Dog("Blondi", 4, Sex.female));

            animals.Add(new Cat("Lazy", 12, Sex.female));
            animals.Add(new Cat("Lord Donner von Wirtschaftsgesee", 3, Sex.male));
            animals.Add(new Tomcat("Generator", 4, Sex.male));
            animals.Add(new Kitten("Generatorka", 2, Sex.female));

            animals.Add(new Frog("Na Harry Potter 4D Jabata", 1, Sex.female));
            animals.Add(new Frog("Brünnilde", 12, Sex.female));
            animals.Add(new Frog("Fafner", 11, Sex.male));
            animals.Add(new Frog("Fasolt", 11, Sex.male));


            //using Linq
            var dogs = from animal in animals
                       where animal is Dog
                       select animal;

            //using Lambda
            var cats = animals.Where(c => c is Cat);

            var frogs = animals.Where(f => f is Frog);

            Console.WriteLine(Animal.CalculateAverageAge(dogs));
            Console.WriteLine(Animal.CalculateAverageAge(cats));
            Console.WriteLine(Animal.CalculateAverageAge(frogs));

        }
    }
}
