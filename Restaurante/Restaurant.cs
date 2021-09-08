using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Restaurant
    {
        private Empleado empleado = new Empleado();
        private Chef chef= new Chef();
     

       public async Task start()
        {
            while(true)
            {
                 mostrarOpciones();

            }
        }


        public async Task tomarPedido()
        {
            Burger burger = new Burger();
            Drink drink = new Drink();
            int burgerOption = empleado.showBurgers();
            int drinkOption = empleado.showdrinks();

            switch (burgerOption)
            {
                case 1:
                    var smallBurgerTask = chef.prepareSmallBurger();
                    burger = await smallBurgerTask;
                    Console.WriteLine("Hamburguesa Pequeña lista...");
                    break;
                case 2:
                    var MediumBurgerTask = chef.prepareMediumBurger();
                    burger = await MediumBurgerTask;
                    Console.WriteLine("Hamburguesa Mediana lista...");
                    break;
                case 3:
                    var BigBurgerTask = chef.prepareBigBurger();
                    burger = await BigBurgerTask;
                    Console.WriteLine("Hamburguesa Grande lista...");
                    break;
                default:
                    break;
            }

            

            switch (drinkOption)
            {
                case 1:
                    var smallDrinkTask = chef.serveSmallDrink();
                    drink = await smallDrinkTask;
                    Console.WriteLine("Bebida Pequeña lista...");
                    break;
                case 2:
                    var mediumDrinkTask = chef.serveMediumDrink();
                    drink = await mediumDrinkTask;
                    Console.WriteLine("Bebida Mediana lista...");
                    break;
                case 3:
                    var bigDrinkTask = chef.serveBigDrink();
                    drink = await bigDrinkTask;
                    Console.WriteLine("Bebida Grande lista...");
                    break;
                default:
                    break;
            }


            Combo combo =  chef.armarCombo(burger,drink);
            Console.WriteLine("EL COMBO ESTA LISTO");
            combo.mostrar();



        }


        public void mostrarOpciones()
        {
                Console.Clear();
                Console.WriteLine("--------------------BIENVENIDO AL RESTAURANT----------------------");
                Console.WriteLine("1. Ver menu");
                Console.WriteLine("2. Pedir que limpien la mesa");
                Console.WriteLine("3. Tomar Pedido\n");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        empleado.showMenu();
                        break;
                    case 2:
                        empleado.limpiarMesa();
                        break;
                    case 3:
                         tomarPedido();
                        break;
                    default:
                        break;
                }
        }
    }
}
