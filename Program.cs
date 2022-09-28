internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Learn your squares and cubes!");
		bool active = true;
		while (active)
		{
			bool valid = true;
			while (valid)
			{
				Console.WriteLine("Please enter an integer :)");
				int input = int.Parse(Console.ReadLine());

				if (input >= 1 && input <= 1290)
				{
					valid = false;
					Console.WriteLine("Number \t Squared \t Cubed");
					Console.WriteLine("=======\t =======\t =======");
					for (int i = 1; i <= input; i++)
					{
						int squared = i * i;
						int cubed = i * i * i;
						Console.WriteLine(i +"\t "+squared+"\t\t"+cubed);
					}
				}
				else if (input > 1290)
				{
					Console.WriteLine("This number is too high to store cubed! Please input something a bit smaller");
					valid = true;
				}
				else
				{
					Console.WriteLine("This is not a valid integer or a negative number. Try again.");
				}
			}

			Console.WriteLine();
			bool repeat = true;

			while (repeat)
			{
				Console.WriteLine("Continue? Y/N");
				string input = Console.ReadLine().ToLower();
				if (input == "y")
				{
					active = true;
					repeat = false;
				}
				else if (input == "n")
				{
					active = false;
					repeat = false;
				}
				else
				{
					Console.WriteLine("Please use Y or N :)");
					repeat = true;
				}
			}
		}
	}
}