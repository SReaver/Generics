using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {

        static void Main(string[] args)
        {
            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
            Game game = new Game();
            //game.StartGame();
            text = text.Replace(",", "").Replace(".", "").Replace("  ", "");

            string[] arr = text.Split(' ');
            Dictionary<string, int> jack = new Dictionary<string, int>();
            int count = 0;
            foreach (var item in arr.GroupBy(g => g))
            {
                jack.Add(item.Key, arr.Count(w => w == item.Key));
            }
            Console.WriteLine("\t"+"Слово\t"+"Количество\t");
            int c = 1;
            foreach (var item in jack)
            {
                Console.WriteLine($"{c++},\t {item.Key}, \t {item.Value} \t");
               
            }
        }
    }
}
