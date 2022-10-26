using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakeexomercredi.CLASS
{
    public class Map

    {
        public Map()
        {
        }
        public int longueur = 50;


        public int largeur = 50;

        public virtual void initmap()
        {

            for (int i = 0; i < largeur; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("#");
            }
            for (int i = 0; i < largeur; i++)
            {
                Console.SetCursorPosition(i, largeur);
                Console.Write("#");
            }
            for (int i = 0; i < longueur; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("#");
            }
            for (int i = 0; i < longueur; i++)
            {
                Console.SetCursorPosition(longueur, i);
                Console.Write("#");
            }
            Console.Write("\n");
            Console.Write("\n");
        }
    }
}
