using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class Emprunt : Decorateur
    {
        protected List<string> emprunteurs = new List<string>();

        public Emprunt(ItemsBibliotheque itemsBiblio) : base(itemsBiblio)
        {
        }

        public void ItemsEmpruntes(string nom)
        {
            emprunteurs.Add(nom);
            itemBiblio.nombreCopies--;
        }

        public void ItemsRetournes(string nom)
        {
            emprunteurs.Remove(nom);
            itemBiblio.nombreCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string emprunteurs in emprunteurs)
            {
                Console.WriteLine(" Emprunteur: " + emprunteurs);
            }
        }
    }
}
