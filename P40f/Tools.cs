using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40f
{
    internal class Tools
    {
        public static int CapturaNumPulsado(string mensaje, int min, int max)
        {
            int opcion = 0;
            Console.Write("\n\t\t\t\t\t{0} [{1}...{2}]: ", mensaje, min, max);

            opcion = Console.ReadKey().KeyChar - '0';

            while (opcion < min || opcion > max)
            {
                Console.WriteLine("\n\n\t\t\t\t\tERROR");
                Console.Write("\n\t\t\t\t\tIntroduce una opción: ");
                opcion = Console.ReadKey().KeyChar - '0';
            }
            return opcion;
        }

		public static string CuadraTexto(string texto, int numChar)
		{

			if (texto.Length > numChar)
				texto = texto.Substring(0, numChar);
			else
			{
				for (int i = texto.Length; i < numChar; i++)
				{
					texto = texto + " ";
					//texto = " "+texto;
				}

				/*
				int aux = numChar - texto.Length;
				if (aux % 2 != 0)
					aux += 1;            
					for (int i = 0; i <= aux/2; i++)
						texto = " " + texto + " ";
				*/


			}

			return texto;
		}

	}
}
