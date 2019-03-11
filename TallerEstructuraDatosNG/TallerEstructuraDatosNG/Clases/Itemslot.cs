using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEstructuraDatosNG.Clases
{
    public struct Itemslot: IComparable
    {
        public Itemslot(Item item, int count) : this()
        {
            Item = item;
            Count = count;
        }

        public Item Item { get; set; }
        public int Count { get; set; }


        public void Clear()
        {
            Item = null;
            Count = 0;
        }

        public static bool operator >(Itemslot a, Itemslot b) => a.Count > b.Count;
        public static bool operator <(Itemslot a, Itemslot b) => a.Count < b.Count;
        public static int operator % (Itemslot a, int b) => a.Count % b;

        public override string ToString()
        {
            if (Item != null)
                return "(" + Count + ") " + Item.name;
            else
                return " - ";
        }

        public int CompareTo(object obj)
        {
            if(obj is Itemslot)
            {
                Itemslot pItem = (Itemslot)obj;

                if (Count > pItem.Count)
                    return 1;
                if (Count < pItem.Count)
                    return -1;
                else
                    return 0;

            }
            return 0;
        }
    }
}
