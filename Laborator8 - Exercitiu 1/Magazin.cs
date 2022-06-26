using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator8___Exercitiu_1
{
    class Magazin
    {
        private List<Magazin> produse = new List<Magazin>();

        public void AdaugaProduse(Magazin produse)
        {
            this.produse.Add(produse);
        }

        public void CostProduse()
        {

            foreach (Magazin produse in produse)
            {
                if (produse is Becul)
                {
                    Becul becul = produse as Becul;
                    Console.WriteLine($"Costul becului este: {becul.CostBecuri()} Ron");

                }
                if (produse is Televizor)
                {
                    Televizor televizor = produse as Televizor;
                    televizor.CostTelevizor();
                    Console.WriteLine($"Costul Televizorului este: {televizor.CostTelevizor()} Ron");
                }
                if (produse is Telefon)
                {
                    Telefon telefon = produse as Telefon;
                    telefon.CostTelefon();
                    Console.WriteLine($"Costul Telefonului este: {telefon.CostTelefon()} Ron");
                }
            }
        }

        public void Vanzari()
        {

            foreach (Magazin produse in produse)
            {
                if (produse is Becul)
                {
                    Becul becuri = produse as Becul;
                    AdaugaProduse(becuri);
                }
                if (produse is Televizor)
                {
                    Televizor televizore = produse as Televizor;
                    AdaugaProduse(televizore);
                }
                if (produse is Telefon)
                {
                    Telefon telefoane = produse as Telefon;
                    AdaugaProduse(telefoane);
                }

            }
        }

        public void IntrareClient()
        {
            Console.WriteLine("Bine ati venit in magazin! Ding Dong!");
            foreach (Magazin produse in produse)
            {
                if (produse is Becul)
                {
                    Becul beculete = produse as Becul;
                    beculete.AprindeBecul();
                }
                if (produse is Televizor)
                {
                    Televizor televizor = produse as Televizor;
                    televizor.Aprinde();
                }
                if (produse is Telefon)
                {
                    Telefon telefon = produse as Telefon;
                    telefon.Deblocheaza();
                }
            }
        }

        public void IesireClient()
        {
            Console.WriteLine("Multumim ca ati cumparat cu noi...La revedere! Ding Dong!");
            foreach (Magazin produse in produse)
            {
                if (produse is Becul)
                {
                    Becul becuri = produse as Becul;
                    becuri.InchideBecul();
                }
                if (produse is Televizor)
                {
                    Televizor televizore = produse as Televizor;
                    televizore.Inchide();
                }
                if (produse is Telefon)
                {
                    Telefon telefoane = produse as Telefon;
                    telefoane.Blocheaza();
                }
            }
        }
    }
}

