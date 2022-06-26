using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator8___Exercitiu_1
{
    class CasaDeMarcat : Magazin
    {
        public void AfiseazaVanzarile()
        {
            Magazin vanzari = new Magazin();
            vanzari.Vanzari();
        }

        public void AfiseazaCosturi()
        {
            Magazin costuri = new Magazin();
            costuri.CostProduse();
        }
    }
}
