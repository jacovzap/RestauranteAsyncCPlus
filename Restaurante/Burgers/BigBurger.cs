using Restaurante.Ingredientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Burgers
{
    public class BigBurger : Burger
    {
        private Tomate _tomate { get; set; }
        private Pan _pan { get; set; }
        private Carne _carne { get; set; }
        private Salsa _salsa { get; set; }
        private Queso _queso { get; set; }
        private Papa _papa { get; set; }
        private Carne _segundaCarne { get; set; }
        private Tocino _tocino { get; set; }

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
        public Carne segundaCarne
        {
            get { return _segundaCarne; }
            set { _segundaCarne = value; }
        }
        public Tocino tocino
        {
            get { return _tocino; }
            set { _tocino = value; }
        }


        public override void mostrar()
        {
            Console.WriteLine("             ***HAMBURGUESA GRANDE***");
        }
    }
}
