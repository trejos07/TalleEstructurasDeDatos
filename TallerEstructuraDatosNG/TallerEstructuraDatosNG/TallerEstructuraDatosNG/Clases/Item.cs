using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEstructuraDatosNG.Clases
{
    public class Item
    {

        public string name;
        public int id;
        public string descripcion;

        public Item(string name, int id, string descripcion)
        {
            this.name = name;
            this.id = id;
            this.descripcion = descripcion;
        }

        //public int CompareTo(object obj)
        //{
        //    if (obj is Item)
        //    {
        //        Item pItem = obj as Item;

        //        if (id > pItem.id)
        //            return 1;
        //        if (id < pItem.id)
        //            return -1;
        //        else
        //            return 0;
        //    }
        //    else
        //        return 0;
        //}


    }
}
