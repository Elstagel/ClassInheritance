using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
		
		public List<Product> newProducts = new List<Product>
		{
			new Cheese("Российский Сыр", "Деревня", 522.50, 0),
			new Cheese("Адыгейский Сыр", "Деревня", 570, 0),
			new Cheese("Голандский Сыр", "Деревня", 620, 0),
			new Cheese("Гауда Сыр", "Деревня", 750, 0),
			new Cheese("Дор-блю Сыр", "Деревня", 420, 0),
			new Cheese("Маццарела Сыр", "Деревня", 360, 0),

			new Bread("Квас хлеб", "Деревня", 40, 0),
			new Bread("Чаббата хлеб", "Деревня", 50, 0),
			new Bread("Бородинский хлеб", "Деревня", 57, 0),
			new Bread("Деревенский хлеб", "Деревня", 78, 0),

			new Sausages("Сосиски вкусняшки", "Два друга", 245.80, 0),
			new Sausages("Сосиски с сыром", "Два друга", 267.70, 0),
			new Sausages("Сосиски кровянка", "Два друга", 287.60, 0),
			new Sausages("Сосиски чипупу", "Два друга", 333.50, 0),
			new Sausages("Сосиски от бабули", "Два друга", 350.80, 0),

			new Soap("Мыло хозяйственое", "Donic", 89, 0),
			new Soap("Мыло парфюмированое", "Donic", 78, 0),
			new Soap("Мыло с ананасом", "Donic", 56, 0),
			new Soap("Мыло с кокосом", "Donic", 76, 0),
			new Soap("Мыло интимное", "Donic", 34, 0),

			new Powder("Порошок Автомат", "Чистый Дом", 525.62, 0),
			new Powder("Порошок Ручной", "Чистый Дом", 452.72, 0),
			new Powder("Порошок Альпийская свежисть", "Чистый Дом", 524.42, 0),
			new Powder("Порошок для всей семьи", "Чистый Дом", 234.22, 0),
			new Powder("Порошок автомат-автомат", "Чистый Дом", 56.52, 0),
			new Powder("Порошок №1", "Чистый Дом", 155.82, 0),

			new GarbageBag("Мусорный пакет 60л.", "Чистый Дом", 123.75, 0),
			new GarbageBag("Мусорный пакет 30л.", "Чистый Дом", 245.75, 0),
			new GarbageBag("Мусорный пакет 90л.", "Чистый Дом", 344.20, 0),
			new GarbageBag("Мусорный пакет 120л.", "Чистый Дом", 543.90, 0),
			new GarbageBag("Мусорный пакет 20л.", "Чистый Дом", 345.80, 0),
			new GarbageBag("Мусорный пакет 35.5л.", "Чистый Дом", 643.85, 0),
		};


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

		public void Menu()
		{
			ConsoleKey key;
			do
			{
				PrintMenu();
				Console.WriteLine();


				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case (ConsoleKey)'1':
						Console.Clear();
						do
						{
							PrintMenuFood();
							key = Console.ReadKey(true).Key;
							switch (key)
							{
								case (ConsoleKey)'1':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите преобрести:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										chease.AddCount(count);
										if (count > 0) { PrintAdd(); Thread.Sleep(300); }
									}
									Console.Clear();

									break;
								case (ConsoleKey)'2':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите преобрести:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										bread.AddCount(count);
										if (count > 0) { PrintAdd(); Thread.Sleep(300); }
									}
									Console.Clear();
									break;
								case (ConsoleKey)'3':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите преобрести:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										sausages.AddCount(count);
										if (count > 0) { PrintAdd(); Thread.Sleep(300); }

									}
									Console.Clear();
									break;
								case (ConsoleKey)'4':
									Console.Clear();

									break;
								default:
									Console.Clear();
									Console.ForegroundColor = ConsoleColor.Red;
									Console.WriteLine($"Введен не правильный код");
									Console.ForegroundColor = ConsoleColor.White;
									Console.WriteLine($"Для продолжение нажмите любую клавишу");
									Console.ReadKey(true);
									Console.Clear();
									break;
							}
						} while (key != (ConsoleKey)'4');
						break;
					case (ConsoleKey)'2':
						Console.Clear();
						do
						{
							PrintMenuFoodDel();
							key = Console.ReadKey(true).Key;
							switch (key)
							{
								case (ConsoleKey)'1':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите удалить:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										chease.DellCount(count);
										PrintDell(); Thread.Sleep(300);
									}
									Console.Clear();
									break;
								case (ConsoleKey)'2':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите удалить:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										bread.DellCount(count);
										PrintDell(); Thread.Sleep(300);

									}
									Console.Clear();

									break;
								case (ConsoleKey)'3':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите удалить:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										sausages.DellCount(count);
										PrintDell(); Thread.Sleep(300);

									}
									Console.Clear();

									break;
								case (ConsoleKey)'4':
									Console.Clear();

									break;
								default:
									Console.Clear();
									Console.ForegroundColor = ConsoleColor.Red;
									Console.WriteLine($"Введен не правильный код");
									Console.ForegroundColor = ConsoleColor.White;
									Console.WriteLine($"Для продолжение нажмите любую клавишу");
									Console.ReadKey(true);
									Console.Clear();
									break;
							}
						} while (key != (ConsoleKey)'4');
						break;
					case (ConsoleKey)'3':
						Console.Clear();
						do
						{
							PrintMenuHouseholdChemicals();
							key = Console.ReadKey(true).Key;
							switch (key)
							{
								case (ConsoleKey)'1':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите преобрести:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										soap.AddCount(count);
										if (count > 0) { PrintAdd(); Thread.Sleep(300); }
									}
									Console.Clear();
									break;
								case (ConsoleKey)'2':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите преобрести:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										powder.AddCount(count);
										if (count > 0) { PrintAdd(); Thread.Sleep(300); }
									}
									Console.Clear();
									break;
								case (ConsoleKey)'3':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите преобрести:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										garbageBag.AddCount(count);
										if (count > 0) { PrintAdd(); Thread.Sleep(300); }
									}
									Console.Clear();
									break;
								case (ConsoleKey)'4':
									Console.Clear();

									break;
								default:
									Console.Clear();
									Console.ForegroundColor = ConsoleColor.Red;
									Console.WriteLine($"Введен не правильный код");
									Console.ForegroundColor = ConsoleColor.White;
									Console.WriteLine($"Для продолжение нажмите любую клавишу");
									Console.ReadKey(true);
									Console.Clear();
									break;
							}
						} while (key != (ConsoleKey)'4');
						break;
					case (ConsoleKey)'4':
						Console.Clear();
						do
						{
							PrintMenuHouseholdChemicalsDel();
							key = Console.ReadKey(true).Key;
							switch (key)
							{
								case (ConsoleKey)'1':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите удалить:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										soap.DellCount(count);
										PrintDell(); Thread.Sleep(300);
									}
									Console.Clear();
									break;
								case (ConsoleKey)'2':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите удалить:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										powder.DellCount(count);
										PrintDell(); Thread.Sleep(300);
									}
									Console.Clear();
									break;
								case (ConsoleKey)'3':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите удалить:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										garbageBag.DellCount(count);
										PrintDell(); Thread.Sleep(300);
									}
									Console.Clear();
									break;
								case (ConsoleKey)'4':
									Console.Clear();
									break;
								default:
									Console.Clear();
									Console.ForegroundColor = ConsoleColor.Red;
									Console.WriteLine($"Введен не правильный код");
									Console.ForegroundColor = ConsoleColor.White;
									Console.WriteLine($"Для продолжение нажмите любую клавишу");
									Console.ReadKey(true);
									Console.Clear();
									break;
							}
						} while (key != (ConsoleKey)'4');
						break;
					case (ConsoleKey)'5':
						Console.Clear();
						foreach (var item in newProducts)
						{
							item.Print();
							Console.WriteLine();
						}
						Console.ReadKey(true);
						Console.Clear();

						break;
					case (ConsoleKey)'0':
						Console.Clear();
						PrintList();
						Console.ReadKey(true);
						Console.Clear();

						break;
					case ConsoleKey.Escape:
						Console.Clear();
						Console.WriteLine($"Заходите еще!!!");
						break;
					default:
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine($"Введен не правильный код");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine($"Для продолжение нажмите любую клавишу");
						Console.ReadKey(true);
						Console.Clear();
						break;
				}

			} while (key != ConsoleKey.Escape);

		}


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
			Console.WriteLine($"5-Посмотреть новые товары.");
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
