using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakeexomercredi.CLASS
{
    public class Food : Map
    {
    
        public position _position = new position(0, 0);
        Random random = new Random();

        public  Food()
        {
            _position.x = random.Next(1, largeur);
            _position.y = random.Next(1, longueur);  
        }
        public override void initmap()
        {
            Console.SetCursorPosition(_position.x, _position.y);
            Console.Write('*');
        }

        public position locateFood()
        {
            return _position;
        }

        public void newFoodLocation()
        {
            _position.x = random.Next(1, largeur);
            _position.y = random.Next(1, longueur);
        }
    }

}

