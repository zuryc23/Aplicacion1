using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            string archivo = "App1MZ.txt";
            char op = 'n';
            int opcion = 0;

            StreamReader arl;
            StreamWriter arE;

            while (op != 's')
            {
                Console.WriteLine("1.- Nombre\n2.- Salir");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("ingrese el nombre del archivo: ");
                    arE = File.AppendText(Console.ReadLine() + ".txt");
                    arE.Close();
                }

                else if (opcion == 2)
                {
                    Console.Write("Desea Salir[s/n]");
                    op = char.Parse(Console.ReadLine());
                }
            }
        }
    }
}

