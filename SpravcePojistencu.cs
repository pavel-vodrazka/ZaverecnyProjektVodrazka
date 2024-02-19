using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektVodrazka
{
    /// <summary>
    /// Třída pro správce pojištěnců.
    /// Pracuje s databází pojištěnců.
    /// </summary>
    internal class SpravcePojistencu
    {
        /// <summary>
        /// Databáze pojištěnců, s níž správce pracuje.
        /// </summary>
        private DatabazePojistencu databaze;

        /// <summary>
        /// Bezparametrický konstruktor.
        /// Inicializuje prázdnou databázi pojištěnců.
        /// </summary>
        public SpravcePojistencu()
        {
            databaze = new();
        }

        /// <summary>
        /// Vyžádá od uživatele nacionále nového pojištěnce a přidá ho do databáze.
        /// </summary>
        internal void PridejPojistence()
        {
            string jmeno, prijmeni, telefonniCislo;
            int vek;

            Console.WriteLine();
            jmeno = ZiskejRetezec("Zadejte jméno pojištěného:");
            prijmeni = ZiskejRetezec("Zadejte příjmení:");
            telefonniCislo = ZiskejRetezec("Zadejte telefonní číslo:");
            vek = ZiskejInt("Zadejte věk:");
            databaze.Pridej(new Pojistenec(jmeno, prijmeni, vek, telefonniCislo));
            Console.WriteLine();
            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");
            Console.ReadKey();
        }

        /// <summary>
        /// Vypíše do konzole všechny pojištěnce v databázi.
        /// </summary>
        internal void VypisVsechnyPojistence()
        {
            VypisSeznamPojistencu(databaze);
        }

        internal void VypisSeznamPojistencu(DatabazePojistencu celaNeboJenVyhledanych)
        {
            if (celaNeboJenVyhledanych.PocetPojistenců > 0)
            {
                Console.WriteLine();
                Console.WriteLine(celaNeboJenVyhledanych.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Pokračujte libovolnou klávesou...");
            Console.ReadKey();
        }

        /// <summary>
        /// Vyžádá od uživatele jméno a příjmení a vyhledá v databázi a vypíše do konzole (všechny) pojištěnce tohoto jména a příjmení.
        /// </summary>
        internal void VyhledejPojistence()
        {
            string jmeno, prijmeni;

            Console.WriteLine();
            jmeno = ZiskejRetezec("Zadejte jméno pojištěného:", true);
            prijmeni = ZiskejRetezec("Zadejte příjmení:", true);
            DatabazePojistencu vyhledani = new DatabazePojistencu(databaze.Vyhledej(jmeno, prijmeni));
            VypisSeznamPojistencu(vyhledani);
        }

        /// <summary>
        /// Instruuje uživatele, jakou informaci má zadat a následně od něj získá textový řetězec.
        /// Validuje vstup a při zadání prázdného řetězce nebo řetězce obsahujícího pouze bílé znaky opakuje jeho vyžádání.
        /// </summary>
        /// <param name="instrukce">Instrukce uživateli.</param>
        /// <param name="muzeBytPrazdny">Zda zadaný řetězec po otrimování může být prázdný.</param>
        /// <returns>Textový řetězec zadaný uživatelem do konzole po otrimování.</returns>
        static string ZiskejRetezec(string instrukce, bool muzeBytPrazdny = false)
        {
            string trimovanyVstup;
            do
            {
                Console.WriteLine(instrukce);
                trimovanyVstup = Console.ReadLine()?.Trim() ?? string.Empty;
            } while (trimovanyVstup == string.Empty && !muzeBytPrazdny);
            return trimovanyVstup;
        }

        /// <summary>
        /// Instruuje uživatele, jakou informaci má zadat a následně od něj získá celé int.
        /// Validuje vstup a pokud ho nelze parsovat na int opakuje jeho vyžádání.
        /// </summary>
        /// <param name="instrukce">Instrukce uživateli.</param>
        /// <returns>Int parsovaný z textového řetězce zadaného uživatelem do konzole po otrimování.</returns>
        static int ZiskejInt(string instrukce)
        {
            string trimovanyVstup;
            int parsovanyInt;
            do
            {
                Console.WriteLine(instrukce);
                trimovanyVstup = Console.ReadLine()?.Trim() ?? string.Empty;
            } while (!int.TryParse(trimovanyVstup, out parsovanyInt));
            return parsovanyInt;
        }
    }
}
