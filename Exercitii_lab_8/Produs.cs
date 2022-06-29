using System;

namespace Exercitii_laborator_8
{
    /// <summary>
    /// Modeleaza un produs
    /// </summary>
    class Produs
    {
        public int Pret { get; private set; }
        public string Model { get; private set; }
        public string Producator { get; private set; }


        /// <summary>
        /// Creeaza un produs
        /// </summary>
        /// <param name="Pret">Accepta un parametru de tip int</param>
        /// <param name="model">Accepta un parametru de tip string</param>
        /// <param name="producator">Accepta un parametru de tip string</param>
        public Produs(int Pret, string model, string producator)
        {
            this.Pret = Pret;
            this.Model = model;
            this.Producator = producator;
        }
    }
}
