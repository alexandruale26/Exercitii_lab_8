using System;

namespace Exercitii_lab_8
{
    /// <summary>
    /// Modeleaza un televizor
    /// </summary>
    class Televizor : Produs
    {
        /// <summary>
        /// Creeaza un televizor
        /// </summary>
        /// <param name="Pret">Accepta un parametru de tip int</param>
        /// <param name="model">Accepta un parametru de tip string</param>
        /// <param name="producator">Accepta un parametru de tip string</param>
        public Televizor(int Pret, string model, string producator) : base(Pret, model, producator)
        {
        }


        /// <summary>
        /// Afiseaza un mesaj de confirmare
        /// </summary>
        public void Deschide()
        {
            Console.WriteLine("Televizorul este pornit");
        }


        /// <summary>
        /// Afiseaza un mesaj de confirmare
        /// </summary>
        public void Opreste()
        {
            Console.WriteLine("Televizorul este oprit");
        }
    }
}
