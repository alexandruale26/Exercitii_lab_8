using System;

namespace Exercitii_lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Scrieți un program care va modela un magazin de electronice. Magazinul de electronice va avea afișate 
              televizoare, telefoane, becuri inteligente precum si sisteme audio. Când clientul va intra in magazin, 
              becurile se vor aprinde, televizoarele vor porni pe un program cu muzică iar telefoanele își vor debloca 
              automat ecranul. Clientul va putea cumpăra produse de la casă iar aceasta va calcula automat veniturile. 
              La plecarea clientului, becurile se vor stinge, televizoarele se vor opri iar telefoanele isi vor bloca ecranul.

                  Becul
                    • Fiecare bec va costa 25 ron
                    • Va avea o metodă care va aprinde becul și va confirma acest lucru în consolă.
                    • Va avea o metodă care va stinge becul și va confirma acest lucru în consolă.

                  Televizorul
                    • Fiecare televizor va costa 1000 de ron.
                    • Va avea un model și producător
                    • Va avea o metodă care va porni televizorul pe un program cu muzica și va confirma acest lucru în consolă, menționând modelul și producătorul.
                    • Va avea o metodă care va opri televizorul și va confirma acest lucru în consolă.

                  Telefonul
                    • Fiecare telefon va costa câte 1700 ron
                    • Va avea un model și un producător
                    • Va avea o metodă ”deblochează” care va debloca telefonul și va confirma acest lucru în consolă
                    • Va avea o metodă ”blochează” care va bloca telefonul

                  Casa de marcat
                    • Va persista valoarea curentă a vânzărilor și va încasa prețul produselor cumpărate

                  Magazinul
                    • Va conține lista produselor
                    • Va permite adăugarea de produse
                    • Va avea o metodă care va returna valoarea curentă a vânzărilor
                    • Va expune o modalitate pentru cumpărarea televizoarelor, a becurilor și a telefoanelor
                        o La cumpărarea unui produs
                        ▪ Se va verifica dacă produsul este pe stoc
                        ▪ Produsul va fi retras din stoc
                        ▪ Prețul va fi încasat
            */


            bool esteClient = true;
            Magazin notAltex = new Magazin("bubu");


            notAltex.AdaugaProdus(new Bec(25, "P10", "Philips"));
            notAltex.AdaugaProdus(new Televizor(1000, "X2000", "Panasonic"));
            notAltex.AdaugaProdus(new Televizor(1000, "L1000", "LG"));
            notAltex.AdaugaProdus(new Bec(25, "L20", "Lohuis"));
            notAltex.AdaugaProdus(new Telefon(1700, "Xperia 1", "Sony"));
            notAltex.AdaugaProdus(new Bec(25, "P10", "Philips"));
            notAltex.AdaugaProdus(new Telefon(1700, "Xperia 1", "Sony"));
            notAltex.AdaugaProdus(new Telefon(12000, "Iphone 17 Pro Max Giga Ultra 10inch", "Apple"));
            notAltex.AdaugaProdus(new Bec(25, "P10", "Philips"));


            Console.WriteLine("Avem in stoc -----");
            AfisareStoc(notAltex);


            Console.WriteLine();
            notAltex.SchimbaParola("mimi");


            Console.WriteLine("\nClientul a intrat -----");
            notAltex.ClientInMagazin(esteClient);



            Console.WriteLine();
            notAltex.VindeProdus("P10", "Philips");
            notAltex.VindeProdus("L50", "Lohuis");
            notAltex.VindeProdus("S2500", "Samsung");
            notAltex.VindeProdus("Xperia 1", "Sony");
            notAltex.VindeProdus("L1000", "LG");


            Console.WriteLine("\nMai avem pe stoc -----");
            AfisareStoc(notAltex);

            Console.WriteLine($"\nTotal vanzari: {notAltex.TotalVanzari()} lei");


            Console.WriteLine("\nClientul a plecat-----");
            notAltex.ClientInMagazin(!esteClient);
        }


        static void AfisareStoc(Magazin magazin)
        {
            foreach (Produs produs in magazin.Produse)
            {
                Console.WriteLine($"{produs.model}  {produs.producator}");
            }
        }

    }
}
