using System;
namespace Taller2
{
	public class StringFinder
	{
		public StringFinder()
		{
			Console.Write("Escriba la cadena general: ");
			char[] cadenaOrigien = (Console.ReadLine()).ToCharArray();
			Console.Write("Escriba la cadena a buscar: ");
			char[] cadenaBusqueda = (Console.ReadLine()).ToCharArray();

			int n = cadenaOrigien.Length,
				m = cadenaBusqueda.Length;

			int pMatch = -1;
			for (int i = 0; i <= (n-m); i++)
			{
				bool match = true;
				for (int j = 0; j < m; j++)
				{
					if (cadenaOrigien[i+j] != cadenaBusqueda[j])
					{
						match = false;
						break;
					}
				}

				if (match)
				{
					pMatch = i+1;
					break;
				}
			}
			if (pMatch != -1){
				Console.WriteLine("Palabra encontrada en la posición " + pMatch);
			}
			else {
				Console.WriteLine("Palabra no encontrada");
			}
		}
	}
}

