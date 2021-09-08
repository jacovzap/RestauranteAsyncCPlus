using Restaurante.Ingredientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Burgers
{
    public class MediumBurger : Burger
    {
        private Tomate _tomate { get; set; }
        private Pan _pan { get; set; }
        private Carne _carne { get; set; }
        private Salsa _salsa { get; set; }
        private Queso _queso { get; set; }
        private Papa _papa { get; set; }

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
        public Queso queso
        {
            get { return _queso; }
            set { _queso = value; }
        }
        public Papa papa
        {
            get { return _papa; }
            set { _papa = value; }
        }


        public override void mostrar()
        {
            Console.WriteLine("              ***HAMBURGUESA MEDIANA***");
        }
    }
}
