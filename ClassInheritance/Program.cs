using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace class_inheritance
{
	internal class Program
	{
		static void Main(string[] args)
		{

			ShoppingListcs shoppingListcs= new ShoppingListcs();


			ConsoleKey key;
			do
			{
				shoppingListcs.PrintMenu();
				Console.WriteLine();


				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case (ConsoleKey)'1':
						Console.Clear();
						do
						{
							shoppingListcs.PrintMenuFood();
							key = Console.ReadKey(true).Key;
							switch (key)
							{
								case (ConsoleKey)'1':
									{
										Console.ForegroundColor= ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите преобрести:");
										Console.ForegroundColor= ConsoleColor.White;
										int count= Convert.ToInt32(Console.ReadLine());
										shoppingListcs.chease.AddCount(count);
										if (count > 0) { shoppingListcs.PrintAdd(); Thread.Sleep(300); }
									}
									Console.Clear();

									break;
								case (ConsoleKey)'2':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите преобрести:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										shoppingListcs.bread.AddCount(count);
										if (count > 0) { shoppingListcs.PrintAdd(); Thread.Sleep(300); }
									}
									Console.Clear();
									break;
								case (ConsoleKey)'3':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите преобрести:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										shoppingListcs.sausages.AddCount(count);
										if (count > 0) { shoppingListcs.PrintAdd(); Thread.Sleep(300); }

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
						} while (key!=(ConsoleKey)'4');
						break;
					case (ConsoleKey)'2':
						Console.Clear();
						do
						{
							shoppingListcs.PrintMenuFoodDel();
							key = Console.ReadKey(true).Key;
							switch (key)
							{
								case (ConsoleKey)'1':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите удалить:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										shoppingListcs.chease.DellCount(count);
										shoppingListcs.PrintDell(); Thread.Sleep(300);
									}
									Console.Clear();
									break;
								case (ConsoleKey)'2':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите удалить:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										shoppingListcs.bread.DellCount(count);
										shoppingListcs.PrintDell(); Thread.Sleep(300);

									}
									Console.Clear();

									break;
								case (ConsoleKey)'3':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите удалить:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										shoppingListcs.sausages.DellCount(count);
										shoppingListcs.PrintDell(); Thread.Sleep(300);

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
							shoppingListcs.PrintMenuHouseholdChemicals();
							key = Console.ReadKey(true).Key;
							switch (key)
							{
								case (ConsoleKey)'1':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите преобрести:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										shoppingListcs.soap.AddCount(count);
										if (count > 0) { shoppingListcs.PrintAdd(); Thread.Sleep(300); }
									}
									Console.Clear();
									break;
								case (ConsoleKey)'2':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите преобрести:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										shoppingListcs.powder.AddCount(count);
										if (count > 0) { shoppingListcs.PrintAdd(); Thread.Sleep(300); }
									}
									Console.Clear();
									break;
								case (ConsoleKey)'3':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите преобрести:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										shoppingListcs.garbageBag.AddCount(count);
										if (count > 0) { shoppingListcs.PrintAdd(); Thread.Sleep(300); }
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
							shoppingListcs.PrintMenuHouseholdChemicalsDel();
							key = Console.ReadKey(true).Key;
							switch (key)
							{
								case (ConsoleKey)'1':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите удалить:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										shoppingListcs.soap.DellCount(count);
										shoppingListcs.PrintDell(); Thread.Sleep(300);
									}
									Console.Clear();
									break;
								case (ConsoleKey)'2':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите удалить:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										shoppingListcs.powder.DellCount(count);
										shoppingListcs.PrintDell(); Thread.Sleep(300);
									}
									Console.Clear();
									break;
								case (ConsoleKey)'3':
									{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Введите количества в штуках,которое хотите удалить:");
										Console.ForegroundColor = ConsoleColor.White;
										int count = Convert.ToInt32(Console.ReadLine());
										shoppingListcs.garbageBag.DellCount(count);
										shoppingListcs.PrintDell(); Thread.Sleep(300);
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
					case (ConsoleKey)'0':
						Console.Clear();
						shoppingListcs.PrintList();
						Console.ReadKey(true);
						Console.Clear();

						break;
					case ConsoleKey.Escape:
						Console.Clear();
						Console.WriteLine($"Приходите еще!!!");
						break;
					default:
						Console.Clear();
						Console.ForegroundColor= ConsoleColor.Red;
						Console.WriteLine($"Введен не правильный код");
						Console.ForegroundColor= ConsoleColor.White;
						Console.WriteLine($"Для продолжение нажмите любую клавишу");
						Console.ReadKey(true);
						Console.Clear();
						break;
				}

			} while (key != ConsoleKey.Escape);

		}
	}
}
