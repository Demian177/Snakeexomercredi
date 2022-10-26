
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snakeexomercredi.CLASS;

namespace Snakeexomercredi;
     internal class Program
{

    static void Main(string[] args)
    {
        bool ending = false; 
      Map map = new Map();
        
        Joueur joueur = new Joueur();
        Food food = new Food(); // creer


        while (!ending) // afficher
        {
            map.initmap();
            joueur.clavier();
            food.initmap();
            joueur.initmap();
            joueur.deplacer();
        }
    }

       
}

