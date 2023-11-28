using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_inheritance
{
	abstract class HouseholdChemicals : Product                             //бытовая химия
	{
		//public HouseholdChemicals(string name, string manufacturer, int price, int count) : base(name, manufacturer, price, count)
		//{
		//}

		public abstract void Discount();

	}
}
