using Restaurante.Burgers;
using Restaurante.Drinks;
using Restaurante.Ingredientes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Chef
    {
        private bool isAvailable { get; set; } = true;

        public bool IsAvaiable
        {
            set { isAvailable = value; }
            get { return isAvailable; }
        }



        public async Task<Carne> freirCarne()
        {
           await Task.Run(() =>
           {
               Console.WriteLine("Friendo la carne...");
               Thread.Sleep(4000);    
           });
           return new Carne();
        }

        public async Task<Papa> freirPapas()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Friendo las papas...");
                Thread.Sleep(3000);
            });
            return new Papa();
        }

        public async Task<Tocino> freirTocino()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Friendo el tocino...");
                Thread.Sleep(3000);
            });
            return new Tocino();
        }

        public Tomate colocarTomate()
        {
            return new Tomate();
        }

        public Salsa colocarSalsa()
        {
            return new Salsa();
        }

      
        public async Task<Queso> derretirQueso()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Derritiendo el queso...");
                Thread.Sleep(2000);
            });
            return new Queso();
        }

        public Pan colocarPan()
        {
            return new Pan();
        }

        public async Task<SmallBurger> prepareSmallBurger()
        {
            

            var carnetask = freirCarne();
            var carne = await carnetask;
            Console.WriteLine("La carne esta lista");

            var pan = colocarPan();
            Console.WriteLine("El pan esta listo");

            var tomate = colocarTomate();
            Console.WriteLine("El tomate esta listo");

            var salsa = colocarSalsa();
            Console.WriteLine("La salsa esta lista");

            var burger = new SmallBurger() { carne = carne, pan = pan, salsa = salsa, tomate = tomate };
            return burger;
        }

        public async Task<MediumBurger> prepareMediumBurger()
        {
            

            var carnetask = freirCarne();
            var quesotask = derretirQueso();
            var papastask = freirPapas();


            var carne = await carnetask;
            Console.WriteLine("La carne esta lista");

            var pan = colocarPan();
            Console.WriteLine("El pan esta listo");

            var queso = await quesotask;
            Console.WriteLine("El queso esta listo");

            var tomate = colocarTomate();
            Console.WriteLine("El tomate esta listo");

            var papas = await papastask;
            Console.WriteLine("Las papas estan listas");

            var salsa = colocarSalsa();
            Console.WriteLine("La salsa esta lista");

            var burger = new MediumBurger { pan = pan, carne = carne, queso = queso, papa = papas, tomate = tomate, salsa = salsa };
            return burger;
        }

        public async Task<BigBurger> prepareBigBurger()
        {
            

            var carnetask = freirCarne();
            var segundacarnetask = freirCarne();
            var quesotask = derretirQueso();
            var papastask = freirPapas();
            var tocinotask = freirTocino();

            var carne = await carnetask;
            Console.WriteLine("La carne esta lista");

            var pan = colocarPan();
            Console.WriteLine("El pan esta listo");

            var queso = await quesotask;
            Console.WriteLine("El queso esta listo");

            var segundacarne = await segundacarnetask;
            Console.WriteLine("La segunda carne esta lista");

            var tomate = colocarTomate();
            Console.WriteLine("El tomate esta listo");

            var tocino = await tocinotask;
            Console.WriteLine("El tocino esta listo");

            var papas = await papastask;
            Console.WriteLine("Las papas estan listas");

            var salsa = colocarSalsa();
            Console.WriteLine("La salsa esta lista");

            var burger = new BigBurger { pan = pan, carne = carne, queso = queso, papa = papas, tomate = tomate, salsa = salsa, segundaCarne = segundacarne, tocino = tocino};
            return burger;
        }


        public async Task servirBebida(int tiempo)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Sirviendo la bebida....");
                Thread.Sleep(tiempo);
            });
        }

        public async Task<SmallDrink> serveSmallDrink()
        {
            await servirBebida(200);
            return new SmallDrink();
        }
        public async Task<MediumDrink> serveMediumDrink()
        {
            await servirBebida(700);
            return new MediumDrink();
        }
        public async Task<BigDrink> serveBigDrink()
        {
            await servirBebida(1300);
            return new BigDrink();
        }

        public Combo armarCombo(Burger burger, Drink drink)
        {
            Combo combo = new Combo { Burgerr = burger, Drinkk = drink };
            return combo;
        }
    }
}
