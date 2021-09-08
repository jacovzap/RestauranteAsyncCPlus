using Restaurante.Ingredientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Burgers
{
    public class SmallBurger : Burger
    {
        private Tomate _tomate {get;set;}
        private Pan _pan { get; set; }
        private Carne _carne { get; set; }
        private Salsa _salsa { get; set; }

        public Tomate tomate
        {
            get { return _tomate; }
            set { _tomate = value; }
        }
        public Carne carne
        {
            get { return _carne; }
            set { _carne = value; }
        }
        public Pan pan
        {
            get { return _pan; }
            set { _pan = value; }
        }
        public Salsa salsa
        {
            get { return _salsa; }
            set { _salsa = value; }
        }


        public override void mostrar()
        {
            Console.WriteLine("                ***HAMBURGUESA PEQUEÑA***");
        }
    }
}
