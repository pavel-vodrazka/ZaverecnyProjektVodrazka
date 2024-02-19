using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektVodrazka
{
    /// <summary>
    /// Třída pro databázi pojištěnců.
    /// S databází pracuje správce pojištěnců.
    /// Databáze je implementována jako List&lt;Pojistenec&gt;.
    /// </summary>
    internal class DatabazePojistencu
    {
        /// <summary>
        /// Datový objekt držící za běhu aplikace zadané pojištěnce.
        /// Zde implementován jako List&lt;Pojistenec&gt;, unikátnost by bylo možno zajistit např. použitím HashSetu (pokud by pojištěnec byl implementován jako Record nebo měl implementováno hodnotové hešování).
        /// </summary>
        private List<Pojistenec> pojistenci;

        /// <summary>
        /// Počet pojištěnců v databázi.
        /// </summary>
        public int PocetPojistenců
        {
            get => pojistenci.Count;
        }

        /// <summary>
        /// Bezparametrický konstruktor databáze.
        /// Inicializuje datový objekt, v němž budou instance pojištenců drženy.
        /// </summary>
        public DatabazePojistencu()
        {
            pojistenci = [];
        }

        /// <summary>
        /// Parametrický konstruktor databáze pojištěnců.
        /// Datový objekt, v němž budou instance pojištěnců drženy, je inicializován z Listu předaného v parametru.
        /// </summary>
        /// <param name="pojistenci"></param>
        public DatabazePojistencu(List<Pojistenec> pojistenci)
        {
            this.pojistenci = pojistenci;
        }

        /// <summary>
        /// Textová reprezentace seznamu pojištěnců.
        /// </summary>
        /// <returns>Řetězec, kde jsou vypsáni pojištěnci; výpis každého je na novém řádku.</returns>
        public override string ToString()
        {
            return string.Join('\n', pojistenci);
        }

        /// <summary>
        /// Přidá nového pojištěnce do databáze.
        /// </summary>
        /// <param name="pojistenec">Nový pojištěnec.</param>
        public void Pridej(Pojistenec pojistenec)
        {
            pojistenci.Add(pojistenec);
        }

        /// <summary>
        /// Vyhledá pojištěnce se zadaným jménem a příjmením.
        /// Pokud je jméno nebo příjmení zadáno jako prázdný řetězec, není k němu přihlédnuto.
        /// </summary>
        /// <param name="jmeno">Zadané jméno.</param>
        /// <param name="prijmeni">Zadané příjmení.</param>
        /// <returns>List&lt;Pojistenec&gt;.</returns>
        public List<Pojistenec> Vyhledej(string jmeno, string prijmeni)
        {
            return pojistenci.Where(x => (x.Jmeno == jmeno || jmeno == string.Empty) && (x.Prijmeni == prijmeni || prijmeni == string.Empty)).ToList();
        }
    }
}
