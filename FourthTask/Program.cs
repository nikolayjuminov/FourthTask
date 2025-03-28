internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Введите натуральное число");
		bool isParsed = int.TryParse(Console.ReadLine(), out int userEntered);
		if (isParsed == false)
		{
			Console.WriteLine("Введено некорректное значение, задача завершена...");
		}
		else
		{
			if (userEntered < 0)
			{
				Console.WriteLine("Введенное число отрицательное");
			}
			else
			{
				Program.BodyTask(userEntered);
			}
		}
	}
	private static void BodyTask(int userEntered)
	{
		if (userEntered % 2 != 0)
		{
			Console.WriteLine("\"YES\"");
		}
		else
		{
			if (userEntered >= 2 && userEntered <= 5)
			{
				Console.WriteLine("\"NO\"");
			}
			else
			{
				if (userEntered >= 6 && userEntered <= 20)
				{
					Console.WriteLine("\"YES\"");
				}
				else
				{
					if (userEntered > 20)
					{
						Console.WriteLine("\"NO\"");
					}
					else
					{
						Console.WriteLine("YES");
					}
				}
			}
		}
	}
}