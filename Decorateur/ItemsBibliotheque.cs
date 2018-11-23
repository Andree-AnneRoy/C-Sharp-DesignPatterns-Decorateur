using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    abstract class ItemsBibliotheque
    {
        private int nbCopies;

        public int nombreCopies
        {
            get
            {
                return nbCopies;
            }

            set
            {
                nbCopies = value;
            }
        }

        public abstract void Display();
    }
}
