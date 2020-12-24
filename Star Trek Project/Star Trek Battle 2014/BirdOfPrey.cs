using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Trek_Battle_2014
{
    class BirdOfPrey : KlingonShip
    {
      private int pTorpedos;
      private int damage;
      Random random = new Random();

      public BirdOfPrey(string name, int initShields) : base(name,initShields)
      {
          pTorpedos = 3;
      }
      public override int Fire()
      {
         //int damage = 0;
         int fire = random.Next(1, 2);
         if (fire == 2)
         {
            Console.WriteLine($"{base.Name} fired Disrupter");
            damage = 1;
         }
         if (fire == 1)
         {
            if (pTorpedos == 0)
            {
               Console.WriteLine($"{base.Name} Reloads Photon torpedoes.");
               damage = 0;
               pTorpedos = 3;
            }
            else
            {
               Console.WriteLine($"{base.Name} fires Photon torpedoes");
               pTorpedos--;
               damage = 2;
            }
         }
         //Console.WriteLine($"{damage}");
         return damage;
      }

      public int Damage
      {
         get
         {
            return damage;
         }
      }
   }


}
