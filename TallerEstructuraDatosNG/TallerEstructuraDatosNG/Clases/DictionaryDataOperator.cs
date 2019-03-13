using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TallerEstructuraDatosNG.Clases
{
    public class DictionaryDataOperator: IDataOperator<Dictionary<string, int>>, IDataOperator<Dictionary<string, float>>, IDataOperator<Dictionary<string, Itemslot>>
    {
        Dictionary<string, int> ints;
        Dictionary<string, float> floats;
        Dictionary<string, Itemslot> slots;

        public DictionaryDataOperator(Dictionary<string, int> ints, Dictionary<string, float> floats, Dictionary<string, Itemslot> slots)
        {
            this.ints = ints;
            this.floats = floats;
            this.slots = slots;

        }

        public Dictionary<string, int> Ints { get => ints; set => ints = value; }
        public Dictionary<string, float> Floats { get => floats; set => floats = value; }
        public Dictionary<string, Itemslot> Slots { get => slots; set => slots = value; }


        public string ListIntToString(List<int> ts)
        {
            string data = "";
            for (int i = 0; i < ts.Count; i++)
            {
                data += ts[i].ToString() + ", ";
            }
            Console.WriteLine(data);
            return data;
        }
        public string ListFloatToString(List<float> ts)
        {
            string data = "";
            for (int i = 0; i < ts.Count; i++)
            {
                data += ts[i].ToString() + ", ";
            }
            Console.WriteLine(data);
            return data;
        }
        public string ListSlotToString(List<Itemslot> ts)
        {
            string data = "";
            for (int i = 0; i < ts.Count; i++)
            {
                data += ts[i].ToString() + ", ";
            }
            Console.WriteLine(data);
            return data;
        }

        #region ints
        public void PerfectShuffle(int iterations, out bool success, out Dictionary<string, int> t)
        {
            Console.WriteLine("// No Implemnetado \\");
            success = false;
            t = null;
        }
        public void RemoveEven(out bool success, out Dictionary<string, int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                Random rnd = new Random();
                success = true;
                ListIntToString(new List<int>(ints.Where(x => x.Value % 2 != 0).Select(x => x.Value)));
            }
        }
        public void RemoveOdds(out bool success, out Dictionary<string, int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                Random rnd = new Random();
                success = true;
                ListIntToString(new List<int>(ints.Where(x => x.Value % 2 == 0).Select(x => x.Value)));
            }
        }
        public void Shuffle(out bool success, out Dictionary<string, int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                Random rnd = new Random();
                success = true;
                ListIntToString(new List<int>(ints.OrderBy(kp => rnd.Next()).Select(x => x.Value)));
            }
        }
        public void SortAscending(out bool success, out Dictionary<string, int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                success = true;
                ListIntToString(new List<int>(ints.OrderBy(kp => kp.Value).Select(x => x.Value)));
            }
        }
        public void SortDescending(out bool success, out Dictionary<string, int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                success = true;
                ListIntToString(new List<int>(ints.OrderByDescending(kp => kp.Value).Select(x => x.Value)));

            }
        }
#endregion

        #region floats
        public void PerfectShuffle(int iterations, out bool success, out Dictionary<string, float> t)
        {
            Console.WriteLine("// No Implemnetado \\");
            success = false;
            t = null;
        }
        public void RemoveEven(out bool success, out Dictionary<string, float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                Random rnd = new Random();
                success = true;
                ListFloatToString(new List<float>(floats.Where(x => x.Value % 2 != 0).Select(x => x.Value)));
            }
        }
        public void RemoveOdds(out bool success, out Dictionary<string, float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                Random rnd = new Random();
                success = true;
                ListFloatToString(new List<float>(floats.Where(x => x.Value % 2 == 0).Select(x => x.Value)));
            }
        }
        public void Shuffle(out bool success, out Dictionary<string, float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                Random rnd = new Random();
                success = true;
                ListFloatToString(new List<float>(floats.OrderBy(kp => rnd.Next()).Select(x => x.Value)));
            }
        }
        public void SortAscending(out bool success, out Dictionary<string, float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                success = true;
                ListFloatToString( new List<float>(floats.OrderBy(kp => kp.Value).Select(x => x.Value)));
            }
        }
        public void SortDescending(out bool success, out Dictionary<string, float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                success = true;
                ListFloatToString(new List<float>(floats.OrderByDescending(kp => kp.Value).Select(x => x.Value)));
            }
        }
        #endregion

        #region slots
        public void PerfectShuffle(int iterations, out bool success, out Dictionary<string, Itemslot> t)
        {
            Console.WriteLine(" // No Implemnetado \\ ");
            success = false;
            t = null;
        }
        public void RemoveEven(out bool success, out Dictionary<string, Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Random rnd = new Random();
                success = true;
                ListSlotToString(new List<Itemslot>(slots.Where(x => x.Value % 2 != 0).Select(x => x.Value)));
            }
        }
        public void RemoveOdds(out bool success, out Dictionary<string, Itemslot> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                Random rnd = new Random();
                success = true;
                ListSlotToString(new List<Itemslot>(slots.Where(x => x.Value % 2 == 0).Select(x => x.Value)));
            }
        }
        public void Shuffle(out bool success, out Dictionary<string, Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Random rnd = new Random();
                success = true;
                ListSlotToString( new List<Itemslot>(slots.OrderBy(kp => rnd.Next()).Select(x => x.Value)));
            }
        }
        public void SortAscending(out bool success, out Dictionary<string, Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                success = true;
                ListSlotToString( new List<Itemslot>(slots.OrderBy(kp => kp.Value).Select(x => x.Value)));
            }
        }
        public void SortDescending(out bool success, out Dictionary<string, Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                success = true;
                ListSlotToString( new List<Itemslot>(slots.OrderByDescending(kp => kp.Value).Select(x => x.Value)));
            }
        }
        #endregion

        
        public void PrintOriginal(Type type)
        {
            if (type == typeof(Dictionary<string, int>))
            {
                Console.WriteLine("La lista de valores contenida en el Diccionario Original es :");
                ListIntToString(new List<int>(ints.Select(x => x.Value)));
            }
            if (type == typeof(Dictionary<string, float>))
            {
                Console.WriteLine("La lista de valores contenida en el Diccionario Original es :");
                ListFloatToString(new List<float>(floats.Select(x => x.Value)));
            }
            if (type == typeof(Dictionary<string, Itemslot>))
            {
                    Console.WriteLine("La lista de valores contenida en el Diccionario Original es :");
                    ListSlotToString(new List<Itemslot>(slots.Select(x => x.Value)));
            }
        }
    }
}
