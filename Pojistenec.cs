using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektVodrazka
{
    /// <summary>
    /// Třída pro pojištěnce.
    /// Je evidováno jméno, příjmení, věk a telefonní číslo.
    /// Evidovat věk není nejlepší řešení, lepší by bylo evidovat datum narození a věk z něj počítat, ale držíme se zadání.
    /// </summary>
    internal class Pojistenec
    {
        /// <summary>
        /// Jméno pojištěnce.
        /// </summary>
        public string Jmeno { get; private set; }
        /// <summary>
        /// Příjmení pojištěnce.
        /// </summary>
        public string Prijmeni { get; private set; }
        /// <summary>
        /// Věk pojištěnce v celých rocích.
        /// </summary>
        public int Vek { get; private set; }
        /// <summary>
        /// Telefonní číslo pojištěnce.
        /// </summary>
        public string TelefonniCislo { get; private set; }

        /// <summary>
        /// Parametrický konstruktor instance pojištěnce.
        /// </summary>
        /// <param name="jmeno">Jméno.</param>
        /// <param name="prijmeni">Příjmení.</param>
        /// <param name="vek">Věk v celých rocích.</param>
        /// <param name="telefonniCislo">Telefonní číslo.</param>
        public Pojistenec(string jmeno, string prijmeni, int vek, string telefonniCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }

        /// <summary>
        /// Textová reprezentace pojištěnce.
        /// </summary>
        /// <returns>Řetězec obsahující jméno, příjmení, věk a telefonní číslo oddělené tabulátory.</returns>
        public override string ToString()
        {
            return $"{Jmeno}\t{Prijmeni}\t{Vek}\t{TelefonniCislo}";
        }
    }
}
