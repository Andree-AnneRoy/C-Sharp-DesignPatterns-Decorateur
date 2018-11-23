using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class Program
    {
        static void Main(string[] args)
        {
            Livre livre = new Livre("Patrick Sénécal", "Alyss", 2000, 10);
            livre.Display();

            Video video = new Video("Christopher Nolan", "Inception", 150, 5);
            video.Display();

            Console.WriteLine("\nLe vidéo est prêt pour emprunt et sera emprunté :");

            Emprunt empruntVideo = new Emprunt(video);
            empruntVideo.ItemsEmpruntes("Emprunteur #1");
            empruntVideo.ItemsEmpruntes("Emprunteur #2");

            empruntVideo.Display();

            Console.ReadKey();
        }
    }
}
