using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class Livre : ItemsBibliotheque
    {
        private string auteur;
        private string titre;
        private int anneePublication;

        public Livre(string auteur, string titre, int anneePublication, int nbCopies)
        {
            this.auteur = auteur;
            this.titre = titre;
            this.anneePublication = anneePublication;
            this.nombreCopies = nombreCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\n****** Livre ****** ");
            Console.WriteLine(" Auteur: {0}", auteur);
            Console.WriteLine(" Titre: {0}", titre);
            Console.WriteLine(" Année de publication: {0}", anneePublication);
            Console.WriteLine(" # Copies: {0}", nombreCopies);
        }
    }
}
