using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakeexomercredi.CLASS
{
    public class Joueur:Map
    {
        ConsoleKeyInfo clav = new ConsoleKeyInfo();
        char key = 'z';
        string direction = "haut";
        List<position> Snake;
        public int x;
        public int y;
        public Joueur()
        {
            x = largeur/2;
            y = longueur/2;
            List<position> Snake = new List<position>(); // donnez une nouvelle liste
            Snake.Add(new position(x, y)); // add nouvelle position dans la liste vide elle recupere la tete du serpent 
        }
        public override void initmap()
        {
            foreach (position position in Snake)
            {
                Console.SetCursorPosition(position.x, position.y); // recuperer le joueur et l'afficher
                Console.WriteLine("O"); // choisir forme du perso
            }
        }
        public void clavier()
        {
            if (Console.KeyAvailable)
            {
                clav = Console.ReadKey(true);
                key = clav.KeyChar;
            }
        }
        private void directions()
        {
            if (key=='z' && direction != "bas")//haut
            {
                direction = "haut";
            }
            else if (key == 'q' && direction != "droite")
            {
                direction = "gauche";
            }
            else if (key == 'd' && direction != "gauche")
            {
                direction = "droite";
            }
            else if (key == 's' && direction != "haut")
            {
                direction = "bas";
            }
        }
    }
}
