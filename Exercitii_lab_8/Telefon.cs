using System;

namespace Exercitii_lab_8
{
    /// <summary>
    /// Modeleaza un telefon
    /// </summary>
    class Telefon : Produs
    {
        private string Parola { get; set; }


        /// <summary>
        /// Creeaza un telefon
        /// </summary>
        /// <param name="Pret">Accepta un parametru de tip int</param>
        /// <param name="model">Accepta un parametru de tip string</param>
        /// <param name="producator">Accepta un parametru de tip string</param>
        public Telefon(int Pret, string model, string producator) : base(Pret, model, producator)
        {
        }


        /// <summary>
        /// Blocheaza si afiseaza un mesaj
        /// </summary>
        public void Blocheaza()
        {
            Console.WriteLine("Telefonul este blocat");
        }


        /// <summary>
        /// Deblocheaza si fiseaza un mesaj
        /// </summary>
        /// <param name="parola">Accepta un parametru de tip string</param>
        public void Deblocheaza(string parolaActuala)
        {
            if ((string.Equals(this.Parola, parolaActuala)) || this.Parola == string.Empty)
            {
                Console.WriteLine("Telefonul este deblocat");
                return;
            }
            Console.WriteLine("Parola gresita");
        }


        /// <summary>
        /// Seteaza o parola
        /// </summary>
        /// <param name="parola">Accepta un parametru de tip string</param>
        public void SetareParola(string parola)
        {
            this.Parola = parola;
        }


        /// <summary>
        /// Schimba parola
        /// </summary>
        /// <param name="parolaActuala">Accepta un parametru de tip string</param>
        /// <param name="nouaParola">Accepta un parametru de tip string</param>
        public void SchimbareParola(string parolaActuala, string nouaParola)
        {
            if (string.Equals(this.Parola, parolaActuala))
            {
                this.Parola = nouaParola;
                Console.WriteLine("Parola schimbata");
                return;
            }
            Console.WriteLine("Nu se potrivesc");
        }
    }
}
