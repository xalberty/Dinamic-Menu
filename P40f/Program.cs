using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vMenu1 = { "ACCIONES", "Abrir", "Cerrar", "Cargar", "Descargar" };
            string[] vMenu2 = { "ACCIONES de la Puerta", "Abrir", "Cerrar", "Montar", "Desmontar", "Subir", "Bajar" };
            string[] vMenu3 = { "Indice", "Cap 1", "Cap 2", "Cap 3", "Capítulo final del libro" };


            Menu menu1 = new Menu(vMenu1);
            Menu menu2 = new Menu(vMenu2);
            Menu menu3 = new Menu(vMenu3);


            int option1 = menu1.showMenu();
            int option2 = menu2.showMenu();
            int option3 = menu3.showMenu();




            Console.Write("\n\n\n\t\t\t\t\tPress enter to skip ");
            Console.ReadLine();

        }
    }
}
