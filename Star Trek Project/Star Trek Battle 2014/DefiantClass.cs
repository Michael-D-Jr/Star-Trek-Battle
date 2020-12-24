using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Trek_Battle_2014
{
	class DefiantClass : StarShip
	{
		private int pTorpedoes;
		private int qTorpedoes;
		private int damage;
		
		Random random = new Random();

		public DefiantClass(string registry, string name, int initShield):base(registry,name,initShield)
		{
			pTorpedoes = 1;
			qTorpedoes = 1;
			
		}

		public override int Fire()
		{
			//int damage = 0;
			int fire = random.Next(1, 3);
			if (fire == 1)
			{
				Console.WriteLine($"{base.Name} fired phasers");
				damage = 1;
			}
			if (fire == 2)
			{
				if (pTorpedoes == 0)
				{
					Console.WriteLine($"{base.Name} reloads Photon torpedoes");
					damage = 0;
					pTorpedoes = 1;
				}
				else
				{
					pTorpedoes--;
					Console.WriteLine($"{base.Name} fired Photon torpedoes");
					damage = 2;
				}				
			}
			if (fire == 3)
			{
				if (qTorpedoes == 0)
				{
					Console.WriteLine($"{base.Name} reloads quantum torpedoes");
					damage = 0;
					qTorpedoes = 1;
				}
				else
				{
					qTorpedoes--;
					Console.WriteLine($"{base.Name} fires Quantum torpedoes");
					damage = 4;
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
