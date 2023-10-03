using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEI
{
    public class Farm
    {
        public List<IAnimal> Animals { get; set; }
        public List<IPlant> Plants { get; set; }
        public decimal Money { get; set; }
        public int FarmSize { get; set; }

        public Farm(decimal initialMoney, int initialFarmSize)
        {
            Animals = new List<IAnimal>();
            Plants = new List<IPlant>();
            Money = initialMoney;
            FarmSize = initialFarmSize;
        }

        public void BuySpace()
        {
            int newSpaceCost = FarmSize * 10;
            if(Money >= newSpaceCost)
            {
                Money -= newSpaceCost;
                FarmSize++;
                Console.WriteLine($"YOU HAVE BOUGHT A NEW SPACE. FARM SIZE: {FarmSize}");
            }
            else
            {
                Console.WriteLine($"YOU DON'T HAVE MONEY TO BUY A NEW SPACE");
            }
        }

        public void BuySeeds(IPlant plant, int quantity)
        {
            decimal totalCost = plant.SeedValue * quantity;
            if(Money >= totalCost)
            {
                Money -= totalCost;
                for (int i = 0; i < quantity; i++) 
                {
                    Plants.Add(Activator.CreateInstance(plant.GetType()) as IPlant);
                }
                    Console.WriteLine($"YOU HAVE PURCHASED {quantity} SEEDS OF {plant.Name}.");
            }
            else
            {
                    Console.WriteLine("YOU DON'T HAVE ENOUGHT MONEY TO BUY THESE SEEDS");
            }
        }
        
         public void BuyAnimals(IAnimal animal, int quantity)
        {
            decimal totalCost = animal.AnimalPrice * quantity;
            if (Money >= totalCost)
            {
                Money -= totalCost;
                for (int i = 0; i < quantity; i++)
                 {
                Animals.Add(Activator.CreateInstance(animal.GetType()) as IAnimal);
                     }
                Console.WriteLine($"YOU HAVE BOUGHT {quantity} {animal.Name}(S).");
            }
            else
            {
                Console.WriteLine("YOU DON'T HAVE ENOUGHT MONEY TO BUY THESE ANIMALS.");
            }
         }
        public void PassTurn()
        {
            foreach (var plant in Plants)
            {
                plant.Harvest();
            }

            foreach (var animal in Animals)
            {
                animal.Produce();
            }
        }
    }
    
}

