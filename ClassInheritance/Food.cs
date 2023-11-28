using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_inheritance
{
	abstract class Food : Product                                           //еда
	{
		//public Food(string name, string manufacturer, int price, int count) : base(name, manufacturer, price, count)
		//{

		//}

		public abstract void Discount();

	}
}
