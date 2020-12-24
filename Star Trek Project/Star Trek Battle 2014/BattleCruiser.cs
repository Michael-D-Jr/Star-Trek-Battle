using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Trek_Battle_2014
{
	class BattleCruiser : KlingonShip
	{
		private int pTorpedoes;
		private int damage;
		
		Random random = new Random();

		public BattleCruiser(string name, int initShield): base(name, initShield)
		{
			
			pTorpedoes = 10;
		}

		public override int Fire()
		{
			//int damage = 0;
			int fire = random.Next(1, 2);
			if (fire == 2)
			{
				damage = 1;
				Console.WriteLine($"{base.Name} fired disruptor");				
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
					damage = 2;
					Console.WriteLine($"{base.Name} fired Photon Torpedoes");					
				}
			}

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
