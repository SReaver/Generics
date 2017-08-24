using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class KV
    {
        public Karta k;
        public Player p;
    }
    public class Game
    {
        string gameName { get; set; }
        List<Player> Players;
        List<Karta> Lk;
        public void StartGame()
        {
            Players = new List<Player>() { new Player() { gamerName = "player1" }, new Player() { gamerName = "player2" } };
            int flag = 0;
            kolodaCreator koloda = new kolodaCreator();
            Lk = koloda.createKoloda();
            #region
            foreach (var item in Lk)
            {
                Players[flag].cards.Enqueue(item);
                if (flag == Players.Count - 1)
                {
                    flag = 0;
                }
                else
                {
                    flag++;
                }

            }
            #endregion

            Player win = new Player();
            while (Players.Any(w => w.cards.Count <= 36))
            {
                Dictionary<int, KV> di = new Dictionary<int, KV>();
                int kvcount = 1;
                foreach (var item in Players)
                {
                    di.Add(kvcount, new KV() { k = item.cards.First(), p = item });
                    kvcount++;
                    //Console.WriteLine(item.gamerName+"("+item.cards.Count+")"+ item.cards.First().mast.ToString()+
                    //    " "+item.cards.First().tip.ToString());
                    item.cards.Dequeue();
                    
                }
               
                var dii=di.OrderByDescending(o => (int)o.Value.k.tip);

                var winner = dii.First();
                foreach (var diplayer in di)
                {
                    winner.Value.p.cards.Enqueue(diplayer.Value.k);
                }
                if (Players.Any(w=>w.cards.Count==36))
                {
                    Console.WriteLine("Конец");
                    break;
                }
                //Console.WriteLine($"Победил {winner.Value.p.gamerName}");

                //Console.WriteLine("-------------------");
                

            }
            win = Players.FirstOrDefault(w => w.cards.Count == 36);
            Console.WriteLine("Победил "+win.gamerName);

        }




    }
}
