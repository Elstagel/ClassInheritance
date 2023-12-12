using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_inheritance
{
	class Cheese : Food,IData                  //сыр
	{

		public Cheese(string name, string manufacturer, double price, int count)
		{
			this.name= name;
			this.manufacturer= manufacturer;
			this.price= price;
			this.count= count;
		}


		public override void Print()
		{

			base.Print();
			Date();
			Discount();

		}

		public override void Discount()
		{
			Console.WriteLine($"Скидка на товар отсутствует.");
		}

		public void Date()
		{
			DateTime date = DateTime.Now;

			Console.WriteLine($"Дата производства: {date.ToShortDateString()} - {date.AddMonths(6).ToShortDateString()}");
		}

	}
}
