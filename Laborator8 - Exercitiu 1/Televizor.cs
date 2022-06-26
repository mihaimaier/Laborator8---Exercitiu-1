using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator8___Exercitiu_1
{
    class Televizor : Magazin
    {
        private int cost;
        private string model;
        private string producator;
        public Televizor(int cost, ProgramMuzica programMuzica,string model, string producator)
        {
            this.cost = cost;
            this.model = model;
            this.producator = producator;
        }

        public void Aprinde()
        {
            Console.WriteLine($"Televizorul a fost pornit pe programul: {ProgramMuzica.Dance}. Modelul si Producatorul Televizorului este: X1000 si LG");
            SistemAudio sistemAudio = new SistemAudio();
            sistemAudio.Porneste();
        }
        public void Inchide()
        {
            Console.WriteLine("Televizorul a fost oprit!");
            SistemAudio sistemAudio = new SistemAudio();
            sistemAudio.Opreste();

        }
        public int CostTelevizor()
        {
            return this.cost;
        }
    }

    enum ProgramMuzica
    {
        Dance, Rock, Pop, Rap, Soul, Classical, Dubstep, DNB
    }
}
