using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace water_problem
{
	class Program
	{
		static void Main(string[] args)
		{
			int L = 0,  N = 0;
			Console.WriteLine("Введите длину:");
			Console.Write(">>");
			L = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Введите кол-во капель:");
			Console.Write(">>");
			Water_drop[] water_drop_mas = new Water_drop[Convert.ToInt32(Console.ReadLine())];
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Blue;
			for (int i = 0; i < water_drop_mas.Length; i++)
			{
				water_drop_mas[i] = new Water_drop();

				Console.WriteLine("Введите позицию " + (i + 1) + " капли:");
				Console.Write(">>");
				water_drop_mas[i].Position = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Введите скорость " + (i + 1) + " капли:");
				Console.Write(">>");
				water_drop_mas[i].Speed = Convert.ToInt32(Console.ReadLine());

				Console.Clear();
			}

			for(int t = 0; t < L; t++)
			{
				//изменение позиции каждой капли
				for (int i = 0; i < water_drop_mas.Length; i++)
				{
					water_drop_mas[i].Position = water_drop_mas[i].Position + water_drop_mas[i].Speed;
				}

				//проверка на соединение капель
				for (int i = 0; i < water_drop_mas.Length; i++)
				{
					if (i != 4)
					{
						for (int j = (i + 1); j < water_drop_mas.Length; j++)
						{
							if (water_drop_mas[i].Position == water_drop_mas[j].Position)
							{
								water_drop_mas[i].Speed = water_drop_mas[i].Speed + water_drop_mas[j].Speed;
								water_drop_mas[j].Position = 0;
								water_drop_mas[j].Speed = 0;
							}
						}
					}
					else;
				}

				//проверка на достижения конца
				for (int i = 0; i < water_drop_mas.Length; i++)
				{
					if (water_drop_mas[i].Position >= L)
					{
						N++;
						water_drop_mas[i].Position = 0;
						water_drop_mas[i].Speed = 0;
					}
						
				}
			}

			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Ответ: " + N);
			Console.ReadLine();
		}
	}
}
