using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation
{
	class GasData
	{
		public string Name { get; set; }
		public float Price { get; set; }
		public GasData(string name, float price)
		{
			Name = name;
			Price = price;
		}
		public override string ToString()
		{
			return Name;
		}
	}
	internal class GasStation 
	{
		public List<GasData> gas;
		public List<GasData> goods;
		public float GasSum { get; set; }
		public float GoodSum { get; set; }
		public float TotalSum { get { return GasSum + GoodSum; } }
		public GasStation()
		{
			gas = new List<GasData>
			{
				new GasData("A-92", 26.59f),
				new GasData("A-95", 27.89f),
				new GasData("A-95+", 28.99f)
			};
			goods = new List<GasData>
			{
				new GasData("Coca-Cola", 9.99f),
				new GasData("Hamburger", 12.59f),
				new GasData("Hot-Dog", 7.99f),
				new GasData("PotatoFree", 16.29f),
				//Add other goods
			};
		}

	}
}
