using System;
using System.Collections.Generic;
using animals.Models;

namespace animals.Services
{
    public class AnimalService
    {
        private List<Animal> animals;

        public AnimalService()
        {
            animals = new List<Animal>();

            InitAnimals();
        }

        private void InitAnimals()
        {
            Pig peppa = new Pig("Peppa");
            Cat garfield = new Cat("Gafield");
            Dog grivei = new Dog("Grivei");
            Horse trojan = new Horse("Trojan");

            animals.Add(peppa);
            animals.Add(garfield);
            animals.Add(grivei);
            animals.Add(trojan);
        }

        public void ShowAnimals()
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name} {animal.Name} makes {animal.MakeSound()}!");
            }
        }
    }
}