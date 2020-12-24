using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Trek_Battle_2014
{
	class GalaxyClass : StarShip
	{
		private int pTorpedoes;
		private int damage;
		static Random random = new Random();

		public GalaxyClass(string registry, string name, int initShield) : base(registry, name, initShield)
		{
			
			pTorpedoes = 10;
		}

		public override int Fire()
		{

			//int damage = 0;
			int fire = random.Next(1, 2);
			if (fire == 2)
			{
				Console.WriteLine($"{base.Name} fired phasers");
				damage = 1;
			}
			if (fire == 1)
			{
				
				if (pTorpedoes == 0)
				{
					Console.WriteLine($"{base.Name} Cannot fire Photon Torpedoes must reload");
					damage = 0;
					pTorpedoes = 10;
				}
				else
				{
					pTorpedoes--;
					Console.WriteLine($"{base.Name} fired Photon Torpedoes");
					damage = 2;
				}				
			}
			//Console.WriteLine($"{damage}");
			return damage;
		}

		
	}
}
