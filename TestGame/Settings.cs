using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{


// A class we´ll be using quite alot. The Constructor is called when we call this class
    internal class Settings
    {
        public static int Width { get; set; }

        public static int Height { get; set;  }

        public static string directions;

        public Settings() 
        {
            Width = 16;
            Height = 16;
            directions = "left";

        
        
        
        }




    }
}
