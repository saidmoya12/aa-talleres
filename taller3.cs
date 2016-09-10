using System;

namespace BusquedaBinaria
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.Write("Ingrese el rango inferior: ");
			int initial = int.Parse(Console.ReadLine());

			Console.Write("Ingrese el rango superior: ");
			int final = int.Parse(Console.ReadLine());

			int[] numbers = new int[(final-initial)+1];

			for (int index = 0, num = initial; num <= final; num++, index++)
			{
				numbers[index] = num;
			}

			int res = MainClass.binaryFinder(numbers);


			if (res != -1)
				Console.WriteLine("Su número es "+res);
			else
				Console.WriteLine("Número no encontrado");
			
			Console.ReadLine();
		}

		/// <summary>
		/// overload
		/// </summary>
		/// <returns>The finder.</returns>
		/// <param name="array">Array.</param>
		private static int binaryFinder(int[] numbers)
		{
			int first = 0, last = numbers.Length - 1;

			return binaryFinder(numbers, first, last);
		}

		private static int binaryFinder(int[] numbers, int first, int last)
		{
			int mid = 0;

			if (last < first)
				return -1;
			else
				mid = (first + last) / 2;


			Console.WriteLine(numbers[mid]+" Es el numero?");
			Console.Write("1 Correcto, 2 Es mayor, 3 Es menor: ");

			int cond = int.Parse(Console.ReadLine());

			int number = -1;
			switch (cond)
			{
				case 1:
					number = numbers[mid];
					//mid = index;
					break;
				case 2:
					number = binaryFinder(numbers, first, mid - 1);
					break;
				case 3:
					number = binaryFinder(numbers, mid + 1, last);
					break;
			}

			return number;

		}
	}
}
