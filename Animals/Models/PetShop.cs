﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class PetShop
    {
        public List<Cat> cats = new List<Cat>();
        public List<Dog> dogs = new List<Dog>();
        public List<Bird> birds = new List<Bird>();
        public List<Fish> fishes = new List<Fish>();

        public PetShop()
        {
            Cat cat1 = new Cat("Tom", "Male", 1, 20, 10, 1);
            Cat cat2 = new Cat("Cat2", "Female", 2, 30, 20, 10);
            Dog dog1 = new Dog("Dog1", "Male", 1, 20, 10, 1);
            Dog dog2 = new Dog("Dog2", "Female", 2, 30, 20, 10);
            Bird bird1 = new Bird("Bird1", "Male", 1, 20, 10, 1);
            Bird bird2 = new Bird("Bird2", "Female", 2, 30, 20, 10);
            Fish fish1 = new Fish("Fish1", "Male", 1, 20, 10, 1);
            Fish fish2 = new Fish("Fish2", "Female", 2, 30, 20, 10);

            cats.Add(cat1);
            cats.Add(cat2);
            dogs.Add(dog1);
            dogs.Add(dog2);
            birds.Add(bird1);
            birds.Add(bird2);
            fishes.Add(fish1);
            fishes.Add(fish2);

        }

     

        public void RemoveByNickNameCats(string nickName)
        {
            foreach (var item in cats)
            {
                if (item.Name == nickName) cats.Remove(item);
            }
        }

        public void RemoveByNickNameDogs(string nickName)
        {
            foreach (var item in dogs)
            {
                if (item.Name == nickName) dogs.Remove(item);
            }
        }

        public void RemoveByNickNameBirds(string nickName)
        {
            foreach (var item in birds)
            {
                if (item.Name == nickName) birds.Remove(item);
            }
        }

        public void RemoveByNickNameFishes(string nickName)
        {
            foreach (var item in fishes)
            {
                if (item.Name == nickName) fishes.Remove(item);
            }
        }

        public Cat ReturnByNickNameCat(string nickName)
        {
            foreach (var item in cats)
            {
                if (item.Name == nickName) return item;
            }
            return new Cat("", "", 0, 0, 0, 0);
        }

        public Dog ReturnByNickNameDog(string nickName)
        {
            foreach (var item in dogs)
            {
                if (item.Name == nickName) return item;
            }
            return new Dog("", "", 0, 0, 0, 0);
        }

        public Bird ReturnByNickNameBird(string nickName)
        {
            foreach (var item in birds)
            {
                if (item.Name == nickName) return item;
            }
            return new Bird("", "", 0, 0, 0, 0);
        }

        public Fish ReturnByNickNameFish(string nickName)
        {
            foreach (var item in fishes)
            {
                if (item.Name == nickName) return item;
            }
            return new Fish("", "", 0, 0, 0, 0);
        }

        public void show()
        {
            Console.WriteLine("Cats\n");
            foreach (var item in cats)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Dogs\n");
            foreach (var item in dogs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Birds\n");
            foreach (var item in birds)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Fishes\n");
            foreach (var item in fishes)
            {
                Console.WriteLine(item);
            }
        }

   

        public override string ToString()
        {
            string retString = "PetShop\n\n";

            retString += "\nCats\n\n";
            foreach (var item in cats)
            {
                retString += item.Name + "\n";
            }

            retString += "\nDogs\n\n";
            foreach (var item in dogs)
            {
                retString += item.Name + "\n";
            }

            retString += "\nBirds\n\n"; ;
            foreach (var item in birds)
            {
                retString += item.Name + "\n";
            }

            retString += "\nFishes\n\n";
            foreach (var item in fishes)
            {
                retString += item.Name + "\n";
            }

            return retString;
        }

    }
}
