using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Trek_Battle_2014
{
    class BattleEngineTest
    {


      static void Main(string[] args)
      {
         // Battle logic goes here
         // 1.  Create an array of 6 SpaceShips
         // 2.  Load this array with 6 ships:
         //     a. 3 StarShips (either 1 GalaxyClass and 2 DefiantClass OR 2 GalaxyClass and 1 DefiantClass)
         //     b. 3 KlingonShips (either 1 BattleCruiser and 2 BirdOfPrey OR 2 BattleCruiser and 1 BirdOfPrey)
         // 3.  Select 1 ship at random from the array to fire
         // 4.  Select 1 ship at random from the other side to be hit (that has not already been destroyed)
         // 5.  Continue step 4 until all ships from one side has been destroyed

         BattleSimulationEngine battle = new BattleSimulationEngine();

         battle.BattleEngine();
      }

       
    }
}
