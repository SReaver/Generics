using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public enum Mast { Черви, Буби, Крести, Пики }
    public enum Tip { Шестёрка=6, Семёрка=7, Восьмёрка=8, Девятка=9, Десятка=10, Валет=11, Дама=12, Король=13, Туз=21  }
    public class Karta
    {
        public Mast mast { get; set; }
        public Tip tip { get; set; }



    }

    public class kolodaCreator
    {
        public List<Karta> createKoloda()
        {
            List<Karta> koloda = new List<Karta>();
            foreach (Mast mast in Enum.GetValues(typeof(Mast)))
            {
                foreach (Tip tipitem in Enum.GetValues(typeof(Tip)))
                {
                    Karta karta = new Karta();
                    karta.mast = mast;
                    karta.tip = tipitem;
                    koloda.Add(karta);
                }
            }
            Random rnd = new Random();
            return koloda.OrderBy(w => rnd.Next()).ToList();
            
        }
    }
}
