﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Player
    {
        public string gamerName { get; set; }
        public Queue<Karta> cards = new Queue<Karta>();

        public void printCards()
        {
            foreach (var item in cards)
            {
                Console.WriteLine(item.tip + " "+item.mast);
            }
        }
    }
}
