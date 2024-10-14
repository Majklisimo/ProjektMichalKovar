﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Pojistenci
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }
        public string Telefon { get; set; }

        public Pojistenci(string jmeno, string prijmeni, int vek, string telefon)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Telefon = telefon;
        }

        public override string ToString()
        {
            return $"{Jmeno}\t{Prijmeni}\t\t{Vek}\t{Telefon}";
        }
    }
}
