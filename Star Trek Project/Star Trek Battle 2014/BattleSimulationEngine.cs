using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Trek_Battle_2014
{
	class BattleSimulationEngine
	{
		public void BattleEngine()
		{
         Random random = new Random();
         

         GalaxyClass uSSGalaxy = new GalaxyClass("NCC-70637", "USS Galaxy", 15);
         BattleCruiser bortas = new BattleCruiser("KES Bortas", 15);
         GalaxyClass saoPaulo = new GalaxyClass("NCC-75633", "USS Sao Paulo", 15);
         BirdOfPrey kangsBirdOfPrey = new BirdOfPrey("KES Bird Of Prey", 15);
         DefiantClass defiant = new DefiantClass("NCC-74913", "USS Defiant", 15);
         BirdOfPrey kitang = new BirdOfPrey("KES Ki'tang", 15);

         SpaceShip[] spaceShips =
         {
            uSSGalaxy,defiant, saoPaulo,
            bortas, kitang, kangsBirdOfPrey
         };

         List<string> starshipsDestroyed = new List<string>();
         List<string> klingonsDestroyed = new List<string>();


         do
         {
            int shipFired = random.Next(0, 6);
            int shipHit = random.Next(0, 6);

            if (spaceShips[shipFired] is StarShip && spaceShips[shipHit] is KlingonShip)
            {
               if (spaceShips[shipHit].ShieldStrength >= 0)
               {
                  spaceShips[shipHit].Hit(spaceShips[shipFired].Fire());
               }

            }
            if (spaceShips[shipFired] is KlingonShip && spaceShips[shipHit] is StarShip)
            {
               if (spaceShips[shipHit].ShieldStrength >= 0)
               {
                  spaceShips[shipHit].Hit(spaceShips[shipFired].Fire());
               }
            }

            if (spaceShips[shipHit].ShieldStrength < 0)
            {
               if (spaceShips[shipHit] is StarShip)
               {
                  if (!starshipsDestroyed.Contains(spaceShips[shipHit].Name))
                  {
                     starshipsDestroyed.Add(spaceShips[shipHit].Name);
                     Console.WriteLine($"{spaceShips[shipHit].Name} was destroyed");
                     Console.WriteLine();
                  }

                  if (starshipsDestroyed.Count == 3)
                  {
                     Console.WriteLine("Klingon Empire Victory!");
                     break;
                  }
               }
               if (spaceShips[shipHit] is KlingonShip)
               {
                  if (!klingonsDestroyed.Contains(spaceShips[shipHit].Name))
                  {
                     klingonsDestroyed.Add(spaceShips[shipHit].Name);
                     Console.WriteLine($"{spaceShips[shipHit].Name} was destroyed");
                     Console.WriteLine();
                  }
                  if (klingonsDestroyed.Count == 3)
                  {
                     Console.WriteLine("Star Fleet Victory!");
                     break;
                  }
               }               

            }
         } while (starshipsDestroyed.Count < 3 || klingonsDestroyed.Count < 3);

         Console.WriteLine();
         Console.WriteLine("Battle Damage Report: ");

         foreach (var item in spaceShips)
         {
            if (item.ShieldStrength > 0)
            {
               Console.WriteLine($"{item.Name} shield strength: {item.ShieldStrength}");
            }
            if (item.ShieldStrength < 0)
            {
               Console.WriteLine($"{item.Name} Destroyed!");
            }
         }
         Console.WriteLine();
         /*Console.WriteLine("Klingon Ships Destroyed:");
         foreach (var item in klingonsDestroyed)
         {
            Console.WriteLine(item);
         }
         Console.WriteLine();
         Console.WriteLine("Star Fleet Ships Destroyed:");
         foreach (var item in starshipsDestroyed)
         {
            Console.WriteLine(item);
         }*/
      }

      
	}
}
