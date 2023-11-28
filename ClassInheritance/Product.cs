using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_inheritance
{
	abstract class Product							//продукты баз.класс
	{
		protected string name;
		protected string manufacturer;						//производитель
		protected double price;
		protected int count;
				
		public virtual void Print() 
		{
			Console.WriteLine($"Наименование: {name}\nПроизводитель: {manufacturer}\nЦена: {price} руб.\nКоличество: {count}");
		}

		//public string GetName() { return name; } 
		//public string GetManufacturer()	{ return manufacturer; 	}
		//public double GetPrice() { return price; }
		public int GetCount() { return count; }

		//public void SetName(string name) { this.name = name; }
		//public void SetManufacturer(string manufacturer) { this.manufacturer = manufacturer; }
		//public void SetPrice(double price) { _ = price > 0 ? this.price = price : this.price = 0; }
		public void SetCount(int count)	{ _ = count > 0 ? this.count = count : this.count = 0; }
		public void AddCount(int count)	{ _ = count > 0 ? this.count += count : this.count = 0; }
		public void DellCount(int count)	
		{
			if(count>0)
			{
				this.count -= count;
			}
			if(this.count<0)
			{
				this.count = 0;
			}
		}
		
		
		public double SumPrice()
		{
			return _ = price * count;
		}
	}
}
