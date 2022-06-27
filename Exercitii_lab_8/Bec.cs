using System;

namespace Exercitii_laborator_8
{
    /// <summary>
    /// Modeleaza un bec
    /// </summary>
    class Bec : Produs
    {
        /// <summary>
        /// Creeaza un bec
        /// </summary>
        /// <param name="Pret">Accepta un parametru de tip int</param>
        /// <param name="model">Accepta un parametru de tip string</param>
        /// <param name="producator">Accepta un parametru de tip string</param>
        public Bec(int Pret, string model, string producator) : base(Pret, model, producator)
        {

        }


        /// <summary>
        /// Afiseaza un mesaj de confirmare
        /// </summary>
        public void Aprinde()
        {
            Console.WriteLine("Becul este aprins");
        }


        /// <summary>
        /// Afiseaza un mesaj de confirmare
        /// </summary>
        public void Stinge()
        {
            Console.WriteLine("Becul este stins");
        }
    }
}
