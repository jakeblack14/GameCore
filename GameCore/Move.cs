﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{

   
    public class Move
    {
       public int row;
       public char col;
       public COORD Begin = new COORD();
       public COORD End = new COORD();

        public void convertMove(COORD coord)
        {
            coord.X = 8 - row;
            coord.Y = col - 65;
        }

        public void getBeginMove()
        {
            Console.Write("\n");
            Console.Write("What COORD do you want to move?");
            Console.Write("\n");
            col = Console.ReadKey().KeyChar;
            row = (int)Console.ReadKey().KeyChar - 48;
            Console.Write("\n");
            convertMove(Begin);

        }

        public void getEndMove()
        {
            Console.Write("Where do you want to move");
            Console.Write("?\n");
            col = Console.ReadKey().KeyChar;
            row = (int)Console.ReadKey().KeyChar - 48;
            convertMove(End);
            Console.Write("\n");
        }
    }



  
}
