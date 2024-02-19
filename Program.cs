namespace ZaverecnyProjektVodrazka
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            SpravcePojistencu spravce = new();

            char volba;

            do
            {
                Console.Clear();
                VypisHlavicku();
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (volba)
                {
                    case '1':
                        spravce.PridejPojistence();
                        break;
                    case '2':
                        spravce.VypisVsechnyPojistence();
                        break;
                    case '3':
                        spravce.VyhledejPojistence();
                        break;
                }
            } while (volba != '4');
        }

        /// <summary>
        /// Vypíše hlavičku hlavičku obrazovky a nápovědu k možným akcím.
        /// </summary>
        static void VypisHlavicku()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Vyberte si akci:");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Konec");
        }
    }
}
