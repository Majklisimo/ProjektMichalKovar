using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Menu
    {
        private Manager manager;

        // Konstruktor třídy Menu, který inicializuje instanci Manager
        public Menu()
        {
            manager = new Manager();
        }

        // Metoda pro zobrazení hlavní nabídky
        public void HlavniMenu()
        {
            bool konec = false;

            while (!konec)
            {
                Console.Clear();
                Console.WriteLine("======== Evidence Pojištěných ========");
                Console.WriteLine("1. Přidat nového pojištěnce");
                Console.WriteLine("2. Vypsat všechny pojištěnce");
                Console.WriteLine("3. Vyhledat pojištěnce");
                Console.WriteLine("4. Konec");
                Console.WriteLine("====================================");
                Console.Write("Vyberte možnost (1-4): ");

                string volba = Console.ReadLine();

                switch (volba)
                {
                    case "1":
                        PridejNovehoPojistence();
                        break;
                    case "2":
                        VypisPojistence();
                        break;
                    case "3":
                        NajdiPojistence();
                        break;
                    case "4":
                        konec = true;
                        Console.WriteLine("Děkujeme za použití aplikace.");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, zkuste to znovu.");
                        break;
                }

                if (!konec)
                {
                    Console.WriteLine("\nStiskněte libovolnou klávesu pro pokračování...");
                    Console.ReadKey();
                }
            }
        }

        // Metoda pro přidání nového pojištěnce
        private void PridejNovehoPojistence()
        {
            Console.Write("Zadejte jméno: ");
            string jmeno = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(jmeno))
            {
                Console.WriteLine("Jméno nesmí být prázdné.");
                return;
            }

            Console.Write("Zadejte příjmení: ");
            string prijmeni = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(prijmeni))
            {
                Console.WriteLine("Příjmení nesmí být prázdné.");
                return;
            }

            Console.Write("Zadejte věk: ");
            string vekVstup = Console.ReadLine();
            int vek;

            if (!int.TryParse(vekVstup, out vek) || vek < 0)
            {
                Console.WriteLine("Věk musí být nezáporné číslo.");
                return;
            }

            Console.Write("Zadejte telefon: ");
            string telefon = Console.ReadLine();

            manager.PridejPojistence(jmeno, prijmeni, vek, telefon);
        }

        // Metoda pro vypsání všech pojištěnců
        private void VypisPojistence()
        {
            manager.VypisPojistence();
        }

        // Metoda pro vyhledání pojištěnce
        private void NajdiPojistence()
        {
            Console.Write("Zadejte jméno pojištěnce: ");
            string jmeno = Console.ReadLine();

            Console.Write("Zadejte příjmení pojištěnce: ");
            string prijmeni = Console.ReadLine();

            manager.NajdiPojistence(jmeno, prijmeni);
        }
    }
}
