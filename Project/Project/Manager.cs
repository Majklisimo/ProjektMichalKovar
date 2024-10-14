using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Manager
    {
        private List<Pojistenci> pojistenciList;
        public Manager()
        {
            pojistenciList = new List<Pojistenci>();
        }
        
        public void PridejPojistence(string jmeno, string prijmeni, int vek, string telefon)
        {
            Pojistenci novyPojistenec = new Pojistenci(jmeno, prijmeni, vek, telefon);
            pojistenciList.Add(novyPojistenec);
            Console.WriteLine("Pojištěnec byl úspěšně přidán.");
        }

        public void VypisPojistence()
        {
            if (pojistenciList.Count == 0)
            {
                Console.WriteLine("Žádní pojištěnci nejsou evidováni.");
                return;
            }

            Console.WriteLine("Jméno\tPříjmení\tVěk\tTelefon");
            Console.WriteLine("---------------------------------------------");

            foreach (var pojistenec in pojistenciList)
            {
                Console.WriteLine(pojistenec);
            }
        }
        public void NajdiPojistence(string jmeno, string prijmeni)
        {
            bool nalezen = false;

            foreach (var pojistenec in pojistenciList)
            {
                if (pojistenec.Jmeno.ToLower() == jmeno.ToLower() && pojistenec.Prijmeni.ToLower() == prijmeni.ToLower())
                {
                    Console.WriteLine("Jméno\tPříjmení\tVěk\tTelefon");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine(pojistenec);
                    nalezen = true;
                }
            }

            if (!nalezen)
            {
                Console.WriteLine("Pojištěnec nebyl nalezen.");
            }
        }

    }
}
