using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEI
{
    public class ProyectController
    {
        public Farm MyFarm { get; private set; }

        public ProyectController(decimal initialMoney, int initialFarmSize)
        {
            MyFarm = new Farm(initialMoney, initialFarmSize);
        }

        public void StartProyect()
        {
            Console.WriteLine("¡WELCOME TO THE SIMULATED FARM!");

            while (true) 
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Buy Seeds");
                Console.WriteLine("2. Buy Animals");
                Console.WriteLine("3. Buy Space");
                Console.WriteLine("4. Pass Turn");
                Console.WriteLine("5. View Farm Status");
                Console.WriteLine("6. Sell Products");
                Console.WriteLine("7. Exit");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        BuySeeds();
                        break;
                    case 2:
                        BuyAnimals();
                        break;
                    case 3:
                        MyFarm.BuySpace();
                        break;
                    case 4:
                        MyFarm.PassTurn();
                        break;
                    case 5:
                        ViewFarmStatus();
                        break;
                    case 6:
                        SellProducts();
                        break;
                    case 7:
                        Console.WriteLine("¡SEE YOU LATER!");
                        return;
                    default:
                        Console.WriteLine("INVALID OPTION. ENTER A NUMBER FROM 1 TO 7.");
                        break;
                }
            }
        }

        public void BuySeeds()
        {
            Console.WriteLine("CHOOSE THE TYPE OF PLANT YOU WANT YO BUY SEEDS:");
            Console.WriteLine("1. POTATO");
            Console.WriteLine("2. APPLE");

            int option = int.Parse(Console.ReadLine());

            IPlant selectedPlant = null;

            switch (option)
            {
                case 1:
                    selectedPlant = new PotatoPlant();
                    break;
                case 2:
                    selectedPlant = new ApplePlant();
                    break;
                default:
                    Console.WriteLine("INVALID OPTION.");
                    return;
            }

            Console.WriteLine($"INDICATE THE QUANTITY OF {selectedPlant.Name} SEEDS YOU WISH TO PURCHASE:");
            int quantity = int.Parse(Console.ReadLine());

            MyFarm.BuySeeds(selectedPlant, quantity);
        }

        public void BuyAnimals()
        {
            Console.WriteLine("CHOOSE THE TYPE OF ANIMAL YOU WANT YO BUY:");
            Console.WriteLine("1. CHICKEN");
            Console.WriteLine("2. COW");

            int option = int.Parse(Console.ReadLine());

            IAnimal selectedAnimal = null;

            switch (option)
            {
                case 1:
                    selectedAnimal = new Chicken();
                    break;
                case 2:
                    selectedAnimal = new Cow();
                    break;
                default:
                    Console.WriteLine("INVALID OPTION.");
                    return;
            }

            Console.WriteLine($"INDICATE THE QUANTITY OF {selectedAnimal.Name} ANIMALS YOU WISH TO PURCHASE:");
            int quantity = int.Parse(Console.ReadLine());

            MyFarm.BuyAnimals(selectedAnimal, quantity);
        }

        public void ViewFarmStatus()
        {
            Console.WriteLine("FARM STATUS:");
            Console.WriteLine($"AVAILABLE MONEY: {MyFarm.Money} SOLES");
            Console.WriteLine($"FARM SIZE: {MyFarm.FarmSize}");
            Console.WriteLine($"PLANTS OF THE FARM:");
            Console.WriteLine($"FARM ANIMALS:");
            foreach (var plant in MyFarm.Plants)
            {
                Console.WriteLine($"- {plant.Name}: REMAINING LIFE TIME: {plant.LifeTime} DAYS");
            }
            Console.WriteLine($"Animales en la granja:");
            foreach (var animal in MyFarm.Animals)
            {
                Console.WriteLine($"- {animal.Name}: REMAINING LIFE TIME: {animal.LifeTime} DAYS");
            }
        }

        public void SellProducts()
        {
            Console.WriteLine("CHOOSE WHAT PRODUCTS YOU WANT TO SELL:");
            Console.WriteLine("1. PLANT PRODUCTS");
            Console.WriteLine("2. ANIMAL PRODUCTS");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    SellPlantProducts();
                    break;
                case 2:
                    SellAnimalProducts();
                    break;
                default:
                    Console.WriteLine("INVALID OPTION.");
                    return;
            }
        }

        public void SellPlantProducts()
        {
            decimal totalEarnings = 0.0M;
            foreach (var plant in MyFarm.Plants)
            {
                totalEarnings += plant.Yield * plant.ProductValue;
            }

            MyFarm.Money += totalEarnings;

            Console.WriteLine($"YOU HAVE EARNED {totalEarnings} SOLES BY SELLING PLANT PRODUCTS.");
        }

        public void SellAnimalProducts()
        {
            decimal totalEarnings = 0.0M;
            foreach (var animal in MyFarm.Animals)
            {
                totalEarnings += animal.Productivity * animal.ProductPrice;
            }

            MyFarm.Money += totalEarnings;

            Console.WriteLine($"YOU HAVE EARNED {totalEarnings} SOLES BY SELLING ANIMAL PRODUCTS.");
        }
    }
}
