using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_inheritance
{
	class ShoppingListcs
	{

		public Cheese chease = new Cheese("Российский Сыр", "Деревня", 522.50, 0);
		public Bread bread = new Bread("Бородинский хлеб", "Деревня", 340, 0);
		public Sausages sausages = new Sausages("Сосиски вкусняшки", "Два друга", 245.70, 0);

		public Soap soap = new Soap("Мыло хозяйственое", "Donic", 522.50, 0);
		public Powder powder = new Powder("Порошок Автомат", "Чистый Дом", 155.82, 0);
		public GarbageBag garbageBag = new GarbageBag("Мусорный пакет 60л.", "Чистый Дом", 245.70, 0);


		//public List<Product> products = new List<Product>
		//{
		//	new Cheese("Российский Сыр", "Деревня", 522.50, 0),
		//	new Bread("Бородинский хлеб", "Деревня", 340, 0),
		//	new Sausages("Сосиски вкусняшки", "Два друга", 245.70, 0),

		//	new Soap("Мыло хозяйственое", "Donic", 522.50, 0),
		//	new Powder("Порошок Автомат", "Чистый Дом", 155.82, 0),
		//	new GarbageBag("Мусорный пакет 60л.", "Чистый Дом", 245.70, 0)
		//};


		public void PrintList()
		{
			if (chease.GetCount()>0)chease.Print(); Console.WriteLine();
			if (bread.GetCount()>0) bread.Print(); Console.WriteLine();
			if (sausages.GetCount()>0) sausages.Print(); Console.WriteLine();
			if (soap.GetCount()>0) soap.Print(); Console.WriteLine();
			if (powder.GetCount()>0) powder.Print(); Console.WriteLine();
			if (garbageBag.GetCount()>0) garbageBag.Print(); Console.WriteLine();
			PrintSum();

		}
		//public void SetChease(int count)
		//{
		//	chease.SetCount(count);
		//}
		//public void SetBread(int count)
		//{
		//	bread.SetCount(count);
		//}
		//public void SetSausage(int count)
		//{
		//	sausages.SetCount(count);
		//}
		//public void SetSoap(int count)
		//{
		//	soap.SetCount(count);
		//}
		//public void SetGarbageBag(int count)
		//{
		//	garbageBag.SetCount(count);
		//}
		//public void SetPowder(int count)
		//{
		//	powder.SetCount(count);
		//}


		public void PrintSum()
		{
			Console.ForegroundColor= ConsoleColor.Green;
			Console.Write($"Сумма ваших покупок: ");
			Console.ForegroundColor= ConsoleColor.White;
			Console.WriteLine(chease.SumPrice()+bread.SumPrice()+sausages.SumPrice()+soap.SumPrice()+powder.SumPrice()+garbageBag.SumPrice()+" руб.");
			
		}
		public void PrintMenu()
		{
			Console.WriteLine($"Это Ваш планшет.");
			Console.WriteLine($"Тут вы можете покупать продукты из нашего списка.");
			Console.WriteLine($"Планшет старый придеться клацать по кнопочкам.....");
			Console.WriteLine($"1-Добавить продукты.");
			Console.WriteLine($"2-Удалить продукты.");
			Console.WriteLine($"3-Выбор хозяйсттвеных товаров.");
			Console.WriteLine($"4-Удалить хозяйсттвеные товары.");
			Console.WriteLine($"0-Вывести список покупок.");
			Console.WriteLine($"Esc-Выход.");
		}


		public void PrintMenuFood()
		{
			Console.WriteLine($"1-Добавить сыр.");
			Console.WriteLine($"2-Добавть хлеб.");
			Console.WriteLine($"3-Добавить сосиски.");
			Console.WriteLine($"4-Для возвращения в меню.");
		}
		public void PrintMenuFoodDel()
		{
			Console.WriteLine($"1-Удалить сыр.");
			Console.WriteLine($"2-Удалить хлеб.");
			Console.WriteLine($"3-Удалить сосиски.");
			Console.WriteLine($"4-Для возвращения в меню.");
		}

		public void PrintMenuHouseholdChemicals()
		{
			Console.WriteLine($"1-Добавить мыло.");
			Console.WriteLine($"2-Добавть порошок.");
			Console.WriteLine($"3-Добавить мусорный пакет.");
			Console.WriteLine($"4-Для возвращения в меню.");

		}
		public void PrintMenuHouseholdChemicalsDel()
		{
			Console.WriteLine($"1-Удалить мыло.");
			Console.WriteLine($"2-Удалить порошок.");
			Console.WriteLine($"3-Удалить мусорный пакет.");
			Console.WriteLine($"4-Для возвращения в меню.");

		}

		public void PrintDell()
		{
			Console.ForegroundColor= ConsoleColor.DarkRed;
			Console.WriteLine("Товар удален!!");
			Console.ForegroundColor= ConsoleColor.White;
		}
		public void PrintAdd()
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine("Товар добавлен!!");
			Console.ForegroundColor = ConsoleColor.White;
		}


	}
}
