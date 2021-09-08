using Restaurante.Burgers;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Empleado
    {
        private bool isAvailable { get; set; } = true;

        public bool IsAvaiable
        {
            set { isAvailable = value; }
            get { return isAvailable; }
        }

        

        public void limpiarMesa()
        {
            Console.Clear();
            Console.WriteLine("El empleado esta limpiando la mesa...");
            Task.Delay(5000).Wait();
        }

        public int showBurgers()
        {
            Console.Clear();
            Console.WriteLine("---------------------------- BURGER MENU ----------------------------");
            Console.WriteLine("1. Hamburguesa pequeña. ");
            Console.WriteLine("2. Hamburguesa mediana. ");
            Console.WriteLine("3. Hamburguesa grande. ");
            Console.WriteLine(" Seleccione una opcion....");
            int opc = Convert.ToInt32(Console.ReadLine());
            return opc;
        }

        public int showdrinks()
        {
            Console.Clear();
            Console.WriteLine("---------------------------- DRINK MENU ----------------------------");
            Console.WriteLine("1. Bebida pequeña. ");
            Console.WriteLine("2. Bebida mediana. ");
            Console.WriteLine("3. Bebida grande. ");
            Console.WriteLine(" Seleccione una opcion....");
            int opc = Convert.ToInt32(Console.ReadLine());
            return opc;
        }


        public void showMenu()
        {
            Console.Clear();
            Console.WriteLine("---------------------------- BURGER MENU ----------------------------");
            Console.WriteLine("*** Hamburguesa pequeña. 3.00$");
            Console.WriteLine("*** Hamburguesa mediana. 7.00$");
            Console.WriteLine("*** Hamburguesa grande. 10.00$");
            Console.WriteLine("---------------------------- DRINK MENU -----------------------------");
            Console.WriteLine("=== Bebida pequeña. 0.50c");
            Console.WriteLine("=== Bebida mediana. 0.75c");
            Console.WriteLine("=== Bebida grande. 1.00$");
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }

  
}
