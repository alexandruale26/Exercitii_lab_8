using System;
namespace Exercitii_laborator_8
{
    /// <summary>
    /// Modeleaza o casa de marcat
    /// </summary>
    class CasaDeMarcat
    {
        public int Incasari { get; private set; }


        /// <summary>
        /// Creeaza o casa de marcat
        /// </summary>
        public CasaDeMarcat()
        {
            this.Incasari = 0;
        }


        /// <summary>
        /// Calculeaza vanzarea unui produs
        /// </summary>
        /// <param name="Pret">Accepta un parametru de tip int</param>
        public void Incaseaza(int Pret)
        {
            Incasari += Pret;
        }
    }
}
