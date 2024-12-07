﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivress
{
    public class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NombrePages { get; set; }

        public Livre(string titre, string auteur, int nbrPages)
        {
            Titre = titre;
            Auteur = auteur;
            NombrePages = nbrPages;
        }

        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Titre: {Titre}, Auteur: {Auteur}, Nombre de pages: {NombrePages}");
        }
    }
}
