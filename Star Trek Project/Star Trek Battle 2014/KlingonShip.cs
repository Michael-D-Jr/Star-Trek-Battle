using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Trek_Battle_2014
{
   abstract class KlingonShip : SpaceShip
    {

       public KlingonShip(string name, int initShield) : base(name, initShield)
       {
            
       }

      //public abstract override void Hit(int hitstrength);
      public abstract override int Fire();

      public override string ToString()
      {
         return string.Format("{0} Current Shield Strength: {1}", Name, ShieldStrength);
      }
   }
}
