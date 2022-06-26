using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator8___Exercitiu_1
{
    class Becul : Magazin
    {
        private int cost;
        private string model;
        private string producator;
        public Becul(int cost, string model, string producator)
        {
            this.cost = cost;
            this.model = model;
            this.producator = producator;
        }
        public void AprindeBecul()
        {
            Console.WriteLine("Becul a fost aprins!");
        }
        public void InchideBecul()
        {
            Console.WriteLine("Becul a fost inchis!");
        }
        public int CostBecuri()
        {
            return this.cost;
        }
    }
}