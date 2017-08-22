using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Game
    {
        string gameName { get; set; }
        List<Player> Players;
        List<Karta> Lk;
        public void StartGame()
        {
            Players = new List<Player>() { new Player() { gamerName = "player1" }, new Player() { gamerName = "player2" } };
            int flag =0;
            kolodaCreator koloda = new kolodaCreator();
            Lk=koloda.createKoloda();
            foreach (var item in Lk)
            {
                Players[flag].cards.Add(item);
                if (flag==Players.Count-1)
                {
                    flag=0;
                }
                else
                {
                    flag++;
                }
                
            }
        }




    }
}
