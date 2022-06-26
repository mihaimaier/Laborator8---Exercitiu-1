using System;

namespace Laborator8___Exercitiu_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Laborator 8 - Exercitiu 1

            // Scrieți un program care va modela un magazin de electronice. Magazinul de electronice va avea afișate 
            // televizoare, telefoane, becuri inteligente precum si sisteme audio. Când clientul va intra in magazin, 
            // becurile se vor aprinde, televizoarele vor porni pe un program cu muzică iar telefoanele își vor debloca
            // automat ecranul. Clientul va putea cumpăra produse de la casă iar aceasta va calcula automat veniturile.
            // La plecarea clientului, becurile se vor stinge, televizoarele se vor opri iar telefoanele isi vor bloca
            // ecranul.

            // Becul
            //    • Fiecare bec va costa 25 ron
            //    • Va avea o metodă care va aprinde becul și va confirma acest lucru în consolă.
            //    • Va avea o metodă care va stinge becul și va confirma acest lucru în consolă.

            // Televizorul
            //    • Fiecare televizor va costa 1000 de ron.
            //    • Va avea un model și producător
            //    • Va avea o metodă care va porni televizorul pe un program cu muzica și va confirma acest lucru
            //      în consolă, menționând modelul și producătorul.
            //    • Va avea o metodă care va opri televizorul și va confirma acest lucru în consolă.

            // Telefonul
            //    • Fiecare telefon va costa câte 1700 ron
            //    • Va avea un model și un producător
            //    • Va avea o metodă ”deblochează” care va debloca telefonul și va confirma acest lucru în consolă
            //    • Va avea o metodă ”blochează” care va bloca telefonul

            //   Casa de marcat
            //    • Va persista valoarea curentă a vânzărilor și va încasa prețul produselor cumpărate

            //  Magazinul
            //    • Va conține lista produselor
            //    • Va permite adăugarea de produse
            //    • Va avea o metodă care va returna valoarea curentă a vânzărilor
            //    • Va expune o modalitate pentru cumpărarea televizoarelor, a becurilor și a telefoanelor
            //    o La cumpărarea unui produs
            //    ▪ Se va verifica dacă produsul este pe stoc
            //    ▪ Produsul va fi retras din stoc
            //   ▪ Prețul va fi încasat

            Magazin client1 = new Magazin();
            client1.AdaugaProduse(new Becul(25, "X500", "Samsung"));
            client1.AdaugaProduse(new Becul(25, "X500", "Samsung"));
            client1.AdaugaProduse(new Televizor(1000, ProgramMuzica.Dance, "100", "LG"));
            client1.AdaugaProduse(new Telefon(1700, "12", "Apple"));
            client1.IntrareClient();
            client1.AfiseazaVanzari();
            client1.AfiseazaCosturi();
            client1.IesireClient();
        }
    }
}
