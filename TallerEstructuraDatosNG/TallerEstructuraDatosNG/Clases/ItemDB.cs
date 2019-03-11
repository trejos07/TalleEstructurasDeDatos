using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEstructuraDatosNG.Clases
{
    public class ItemDB
    {
        public List<Item> Items = new List<Item>();

        public ItemDB()
        {
            Items.Add(new Item("Madera", 1, "obtenida de los arboles"));
            Items.Add(new Item("Hierro", 2, "fuerte pero muy pesado"));
            Items.Add(new Item("Bronce", 3, "solo sirve para estatuas"));
            Items.Add(new Item("Plata", 4, "brillante, hay mejores"));
            Items.Add(new Item("Oro", 6, "lo que todos quieren"));
            Items.Add(new Item("Diamante", 7, "escasos, abundan en las profundidades"));
            Items.Add(new Item("Esmeralda", 8, "poderosas piedras misticas"));

        }



    }
}
