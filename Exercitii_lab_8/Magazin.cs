using System;
using System.Collections.Generic;

namespace Exercitii_laborator_8
{
    /// <summary>
    /// Modeleaza un magazin
    /// </summary>
    class Magazin
    {
        private string parola = string.Empty;
        public List<Produs> Produse { get; private set; }
        private readonly CasaDeMarcat casaDeMarcat = new CasaDeMarcat();


        /// <summary>
        /// Creeaza un magazin si o parola
        /// </summary>
        /// <param name="Parola">Accepta un parametru de tip string</param>
        public Magazin(string parola)
        {
            this.Produse = new List<Produs>();
            this.parola = parola;
        }


        /// <summary>
        /// Adauga un produs
        /// </summary>
        /// <param name="produs">Accepta un parametru de tip produs</param>
        public void AdaugaProdus(Produs produs)
        {
            if (produs is Telefon)
            {
                Telefon telefon = produs as Telefon;

                this.Produse.Add(telefon);
                telefon.SetareParola(parola);
                return;
            }
            this.Produse.Add(produs);
        }


        /// <summary>
        /// Schimba parola
        /// </summary>
        /// <param name="nouaParola">Accepta un parametru de tip string</param>
        public void SchimbaParola(string nouaParola)
        {
            foreach (Produs produs in Produse)
            {
                if (produs is Telefon)
                {
                    Telefon telefon = produs as Telefon;

                    telefon.SchimbareParola(parola, nouaParola);
                }
            }
            this.parola = nouaParola;
        }


        /// <summary>
        /// Vinde un produs
        /// </summary>
        /// <param name="model">Accepta un parametru de tip string</param>
        /// <param name="producator">Accepta un parametru de tip string</param>
        public void VindeProdus(string model, string producator)
        {
            Produs dinStoc;

            if (Produse.Count == 0)
            {
                Console.WriteLine("Magazinul este gol");
                return;
            }

            foreach (Produs produs in Produse)
            {
                if (string.Equals(producator, produs.producator) && string.Equals(model, produs.model))
                {
                    dinStoc = produs;
                    casaDeMarcat.Incaseaza(dinStoc.Pret);

                    if (produs is Telefon)
                    {
                        Telefon telefon = produs as Telefon;
                        telefon.SchimbareParola(this.parola, string.Empty);
                    }

                    Produse.Remove(dinStoc);

                    Console.WriteLine($"\"S-a vandut produsul {model}  {producator}\"");
                    return;
                }
            }
            Console.WriteLine($"\"Produsul {model}  {producator} nu este pe stoc\"");
        }


        /// <summary>
        /// Ce se intampla daca avem client
        /// </summary>
        /// <param name="esteClientInMagazin">Accepta un parametru de tip bool</param>
        public void ClientInMagazin(bool esteClientInMagazin)
        {
            if (Produse.Count == 0 && esteClientInMagazin)
            {
                Console.WriteLine("Magazinul este gol. Reveniti in alta zi.");
                return;
            }

            foreach (Produs produs in Produse)
            {
                if (produs is Bec)
                {
                    Bec bec = produs as Bec;
                    
                    if (esteClientInMagazin)
                        bec.Aprinde();
                    else
                        bec.Stinge();
                }

                if (produs is Televizor)
                {
                    Televizor televizor = produs as Televizor;

                    if (esteClientInMagazin)
                        televizor.Deschide();
                    else
                        televizor.Opreste();
                }

                if (produs is Telefon)
                {
                    Telefon telefon = produs as Telefon;

                    if (esteClientInMagazin)
                        telefon.Deblocheaza(this.parola);
                    else
                        telefon.Blocheaza();
                }
            }
        }


        /// <summary>
        /// Returneaza incasarile
        /// </summary>
        /// <returns>Returneaza un int</returns>
        public int TotalVanzari()
        {
            return casaDeMarcat.Incasari;
        }
    }
}
