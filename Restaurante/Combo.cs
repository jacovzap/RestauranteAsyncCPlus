using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante
{
    public class Combo
    {
        private Drink drink { get; set; }
        private Burger burger { get; set; }

        public Drink Drinkk
        {
            get { return drink; }
            set { drink = value; }
        }

        public Burger Burgerr
        {
            get { return burger; }
            set { burger = value; }
        }


        public void mostrar()
        {
            Console.WriteLine("-------------------COMBO LISTO-------------------");
            burger.mostrar();
            drink.mostrar();
        }
    }
}
