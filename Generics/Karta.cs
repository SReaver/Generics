using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public enum Mast { Черви, Буби, Крести, Пики }
    public enum Tip { Валет, Дама, Король, Туз, Шестёрка, Семёрка, Восьмёрка, Девятка, Десятка }
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
            for (int i = 0; i < 36; i++)
            {
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
            }
            return koloda;
        }
    }
}
