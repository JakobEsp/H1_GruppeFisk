using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Fisketank
{
    class Main
    {
        string[] type = { "Saltwater Fish", "Freshwater Fish", "Carnivore", "Herbivore" };

        List<Fish> saltHerbs = new();
        List<Fish> saltCarns = new();
        List<Fish> freshHerbs = new();
        List<Fish> freshCarns = new();

        public void Menu()
        {
            Console.BackgroundColor= ConsoleColor.DarkBlue;
            while(true)
            {
                Console.WriteLine("[1] Add Fish  [2] Remove Fish  [3] Show Aquariums");
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        AddFish();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        RemoveFish();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        ShowAquariums();
                        break;
                }
            }
        }
        public void AddFish()
        { 
            Fish newfish = new Fish();
            Console.Write("Enter the fish name: ");
            while (true)
            {
                string s = Console.ReadLine();
                if (s.Trim() != "")
                {
                    newfish.name = s;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("WrongInput try again");
                }
            }
            Console.Write("Enter the fish lenght: ");
            while(true)
            {
                string s = Console.ReadLine().Trim();
                double num;
                if (double.TryParse(s, out num))
                {
                    newfish.lenght = num;
                    break;
                }
                else
                {
                    Console.WriteLine("wrong input only type numbers");
                }
            }
            Console.Write("Enter the fish species: ");
            while (true)
            {
                string s = Console.ReadLine();
                if (s.Trim() != "")
                {
                    newfish.species = s;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("WrongInput try again");
                }
            }
            Console.Write("Enter the fish age: ");
            while (true)
            {
                string s = Console.ReadLine().Trim();
                double num;
                if (double.TryParse(s, out num))
                {
                    newfish.age = num;
                    break;
                }
                else
                {
                    Console.WriteLine("wrong input only type numbers");
                }
            }
            Console.Write("Enter the fish weight: ");
            while (true)
            {
                string s = Console.ReadLine().Trim();
                double num;
                if (double.TryParse(s, out num))
                {
                    newfish.weight = num;
                    break;
                }
                else
                {
                    Console.WriteLine("wrong input only type numbers");
                }
            }
            Console.WriteLine("Is it a saltwater fish? Press 1 for yes: ");
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.D1)
            {
                newfish.types.Add(type[0]);
            }
            else
            {
                newfish.types.Add(type[1]);
            }
            Console.WriteLine("Is it a Carnivore fish? Press 2 for yes: ");
            key = Console.ReadKey().Key;
            if (key == ConsoleKey.D2)
            {
                newfish.types.Add(type[2]);
            }
            else
            {
                newfish.types.Add(type[3]);
            }

            if (newfish.types.Contains(type[0]))
            {
                if (newfish.types.Contains(type[2]))
                {
                    saltCarns.Add(newfish);
                }
                else
                {
                    saltHerbs.Add(newfish);
                }
            }
            else
            {
                if (newfish.types.Contains(type[2]))
                {
                    freshCarns.Add(newfish);
                }
                else
                {
                    freshHerbs.Add(newfish);
                }
            }
            Console.Write("The fish has been added, press any key to move on.");
            Console.ReadKey();
            Console.Clear();
        }
        public void RemoveFish()
        {
            Console.Write("What tank do you want to remove a fish from?\n [1] Saltfish Herbivores\n  [2] Saltfish Carnivores\n  [3] Freshwater Herbivores\n [4] Freshwater Carnivores");

            bool removed = false;
            ConsoleKey key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    foreach(var fish in saltHerbs)
                    {
                        Console.Write($"All Fish in Saltfish Herbivores: \nId: {freshCarns.IndexOf(fish)}\nName: {fish.name}\n Age: {fish.age}\n Species: {fish.species}");
                        Console.WriteLine("What fish would you like to remove? (id)");
                        int id = int.Parse(Console.ReadLine());
                        saltHerbs.RemoveAt(id);
                        removed = true;
                    }
                    break;
                case ConsoleKey.D2:
                    foreach (var fish in saltCarns)
                    {
                        Console.Write($"All Fish in Saltfish Carnivores: \nId: {saltCarns.IndexOf(fish)}\nName: {fish.name}\n Age: {fish.age}\n Species: {fish.species}");
                        Console.WriteLine("What fish would you like to remove? (id)");
                        int id = int.Parse(Console.ReadLine());
                        saltCarns.RemoveAt(id);
                        removed = true;
                    }
                    break;
                case ConsoleKey.D3:
                    foreach (var fish in freshHerbs)
                    {
                        Console.Write($"All Fish in Freshwater Herbivores: \nId: {freshHerbs.IndexOf(fish)}\nName: {fish.name}\n Age: {fish.age}\n Species: {fish.species}");
                        Console.WriteLine("What fish would you like to remove? (id)");
                        int id = int.Parse(Console.ReadLine());
                        freshHerbs.RemoveAt(id);
                        removed = true;
                    }
                    break;
                case ConsoleKey.D4:
                    foreach (var fish in freshCarns)
                    {
                        Console.Write($"All Fish in Freshwater Carnivores: \n Id: {saltHerbs.IndexOf(fish)}\n Name: {fish.name}\n Age: {fish.age}\n Species: {fish.species}");
                        Console.WriteLine("What fish would you like to remove? (id)");
                        int id = int.Parse(Console.ReadLine());
                        freshCarns.RemoveAt(id);
                        removed = true;
                    }
                    break;
            }
            if (removed)
            {
                Console.WriteLine("Fish Removed from tank!\n Press anything to return to menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void ShowAquariums()
        {
            Console.WriteLine("\nSaltfish Herbivores:\n");
            foreach(Fish fish in saltHerbs) 
            {
                Console.Write($"Name: {fish.name} Age: {fish.age} Species:  {fish.species} Lenght: {fish.lenght} weight: {fish.weight}");
            }
            Console.WriteLine("\nSaltfish Carnivores:\n");
            foreach(Fish fish in saltCarns) 
            {
                Console.Write($"Name: {fish.name} Age: {fish.age} Species:  {fish.species} Lenght: {fish.lenght} weight: {fish.weight}");
            }
            Console.WriteLine("\nFreshwater Herbivores:\n");
            foreach(Fish fish in freshHerbs) 
            {
                Console.Write($"Name: {fish.name} Age: {fish.age} Species:  {fish.species} Lenght: {fish.lenght} weight: {fish.weight}");
            }
            Console.WriteLine("\nFreshwater Carnivores:\n");
            foreach(Fish fish in freshCarns) 
            {
                Console.Write($"Name: {fish.name} Age: {fish.age} Species:  {fish.species} Lenght: {fish.lenght} weight: {fish.weight}");
            }
            Console.WriteLine("Press Anything to return");
            Console.ReadKey();
            Console.Clear();
        }
    }

//          /`·.¸
//     /¸...¸`:·
// ¸.·´  ¸   `·.¸.·´)
//: © ):´;      ¸  {
// `·.¸ `·  ¸.·´\`·¸)
//     `\\´´\¸.·´
}
