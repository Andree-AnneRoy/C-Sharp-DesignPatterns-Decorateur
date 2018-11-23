using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    abstract class Decorateur : ItemsBibliotheque
    {
        protected ItemsBibliotheque itemBiblio;

        public Decorateur(ItemsBibliotheque itemBiblio)
        {
            this.itemBiblio = itemBiblio;
        }

        public override void Display()
        {
            itemBiblio.Display();
        }
    }
}
