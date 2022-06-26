using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator8___Exercitiu_1
{
    class Telefon : Magazin
    {
        private int cost;
        private string model;
        private string producator;
        public Telefon(int cost, string model, string producator)
        {
            this.cost = cost;
            this.model = model;
            this.producator = producator;
        }
        public void Deblocheaza()
        {
            Console.WriteLine("Telefonul a fost deblocat");
        }
        public void Blocheaza()
        {
            Console.WriteLine("Telefonul a fost blocat!");
        }
        public int CostTelefon()
        {
            return this.cost;
        }
    }
}
