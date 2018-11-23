using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class Video : ItemsBibliotheque
    {
        private string directeur;
        private string titre;
        private int duree;

        public Video(string directeur, string titre, int duree, int nombreCopies)
        {
            this.directeur = directeur;
            this.titre = titre;
            this.duree = duree;
            this.nombreCopies = nombreCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\n****** Vidéo ****** ");
            Console.WriteLine(" Directeur: {0}", directeur);
            Console.WriteLine(" Titre: {0}", titre);
            Console.WriteLine(" Durée: {0}", duree);
            Console.WriteLine(" # Copies: {0}", nombreCopies);
        }
    }
}
