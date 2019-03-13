using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEstructuraDatosNG.Clases
{
    class ListDataOperator : IDataOperator<List<int>>, IDataOperator<List<float>>, IDataOperator<List<Itemslot>>
    {

        List<int> ints;
        List<float> floats;
        List<Itemslot> slots;

        public List<int> Ints { get => ints; set => ints = value; }
        public List<float> Floats { get => floats; set => floats = value; }
        public List<Itemslot> Slots { get => slots; set => slots = value; }

        public ListDataOperator(List<int> ints, List<float> floats, List<Itemslot> slots)
        {
            this.ints = ints;
            this.floats = floats;
            this.slots = slots;
        }

        public string ListIntToString(List<int> ts)
        {
            string data = "";
            for (int i = 0; i < ts.Count; i++)
            {
                data += ts[i].ToString() + ", ";
            }
            return data;
        }
        public string ListFloatToString(List<float> ts)
        {
            string data = "";
            for (int i = 0; i < ts.Count; i++)
            {
                data += ts[i].ToString() + ", ";
            }
            return data;
        }
        public string ListSlotToString(List<Itemslot> ts)
        {
            string data = "";
            for (int i = 0; i < ts.Count; i++)
            {
                data += ts[i].ToString() + ", ";
            }
            return data;
        }

        #region int
        public void PerfectShuffle(int iterations, out bool success, out List<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {

                List<int> lst = new List<int>(ints);
                Random r = new Random();
                List<int> a1 = new List<int>();
                List<int> a2 = new List<int>();

                if (lst.Count % 2 == 0)
                {
                    for (int n = 0; n < iterations; n++)
                    {
                        for (int i = 0; i < lst.Count / 2; i++)
                        {
                            a1.Add(lst[i]);
                        }
                        for (int j = lst.Count / 2; j < lst.Count; j++)
                        {
                            a2.Add(lst[j]);
                        }
                        int size = lst.Count;
                        lst.Clear();
                        for (int i = 0; i < size; i += 2)
                        {
                            lst.Add(a1[i / 2]);
                            lst.Add(a2[i / 2]);
                        }
                    }
                }

                else if (lst.Count % 2 == 1)
                {
                    for (int n = 0; n < iterations; n++)
                    {
                        int temp = lst[lst.Count - 1];

                        for (int i = 0; i < lst.Count - 1 / 2; i++)
                        {
                            a1.Add(lst[i]);
                        }
                        for (int j = lst.Count - 1 / 2; j < lst.Count - 1; j++)
                        {
                            a2.Add(lst[j]);
                        }
                        int x = r.Next(0, lst.Count);
                        lst.Clear();
                        for (int i = 0; i < lst.Count; i += 2)
                        {
                            lst.Add(a1[i / 2]);
                            lst.Add(a2[i / 2]);
                            if (x % 2 == 0 && i == x || x % 2 == 1 && i - 1 == x)
                            {
                                lst.Add(temp);
                                i++;
                            }
                        }
                    }
                }
                success = true;
                t = lst;
                Console.WriteLine(ListIntToString(t));
            }
        }
        public void RemoveEven(out bool success, out List<int> t)
        {
            success = false;
            t = null;
            if (ints != null)
            {
                List<int> lst = new List<int>(ints);
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i] % 2 != 0)
                    {
                        lst[i] = 0;
                    }
                }
                success = true;
                t = lst;
                Console.WriteLine(ListIntToString(t));
            }

        }
        public void RemoveOdds(out bool success, out List<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                List<int> lst = new List<int>(ints);
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i] % 2 == 0)
                    {
                        lst[i] = 0;
                    }
                }
                success = true;
                t = lst;
                Console.WriteLine(ListIntToString(t));
            }
        }
        public void Shuffle(out bool success, out List<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                List<int> lst = new List<int>(ints);
                Random _random = new Random();
                for (int i = 0; i < lst.Count; i++)
                {
                    int r = i + _random.Next(lst.Count - i);
                    int temp = lst[r];
                    lst[r] = lst[i];
                    lst[i] = temp;
                }
                success = true;
                t = lst;
                Console.WriteLine(ListIntToString(t));
            }
        }
        public void SortAscending(out bool success, out List<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                List<int> arr = new List<int>(ints);
                int temp;

                for (int write = 0; write < arr.Count; write++)
                {
                    for (int sort = 0; sort < arr.Count - 1; sort++)
                    {
                        if (arr[sort] > arr[sort + 1])
                        {
                            temp = arr[sort + 1];
                            arr[sort + 1] = arr[sort];
                            arr[sort] = temp;
                        }
                    }
                }
                success = true;
                t = arr;
                Console.WriteLine(ListIntToString(t));
            }
        }
        public void SortDescending(out bool success, out List<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                List<int> arr = new List<int>(ints);
                int temp;

                for (int write = 0; write < arr.Count; write++)
                {
                    for (int sort = 0; sort < arr.Count - 1; sort++)
                    {
                        if (arr[sort] < arr[sort + 1])
                        {
                            temp = arr[sort + 1];
                            arr[sort + 1] = arr[sort];
                            arr[sort] = temp;
                        }
                    }
                }
                success = true;
                t = arr;
                Console.WriteLine(ListIntToString(t));
            }
        }
        #endregion

        #region float
        public void PerfectShuffle(int iterations, out bool success, out List<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {

                List<float> lst = new List<float>(floats);
                Random r = new Random();
                List<float> a1 = new List<float>();
                List<float> a2 = new List<float>();

                if (lst.Count % 2 == 0)
                {
                    for (int n = 0; n < iterations; n++)
                    {
                        for (int i = 0; i < lst.Count / 2; i++)
                        {
                            a1.Add(lst[i]);
                        }
                        for (int j = lst.Count / 2; j < lst.Count; j++)
                        {
                            a2.Add(lst[j]);
                        }
                        int size = lst.Count;
                        lst.Clear();
                        for (int i = 0; i < size; i += 2)
                        {
                            lst.Add(a1[i / 2]);
                            lst.Add(a2[i / 2]);
                        }
                    }
                }

                else if (lst.Count % 2 == 1)
                {
                    for (int n = 0; n < iterations; n++)
                    {
                        float temp = lst[lst.Count - 1];

                        for (int i = 0; i < lst.Count - 1 / 2; i++)
                        {
                            a1.Add(lst[i]);
                        }
                        for (int j = lst.Count - 1 / 2; j < lst.Count - 1; j++)
                        {
                            a2.Add(lst[j]);
                        }
                        int x = r.Next(0, lst.Count);
                        lst.Clear();
                        for (int i = 0; i < lst.Count; i += 2)
                        {
                            lst.Add(a1[i / 2]);
                            lst.Add(a2[i / 2]);
                            if (x % 2 == 0 && i == x || x % 2 == 1 && i - 1 == x)
                            {
                                lst.Add(temp);
                                i++;
                            }
                        }
                    }
                }
                success = true;
                t = lst;
                Console.WriteLine(ListFloatToString(t));
            }
        }
        public void RemoveEven(out bool success, out List<float> t)
        {
            success = false;
            t = null;
            if (floats != null)
            {
                List<float> lst = new List<float>(floats);
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i] % 2 != 0)
                    {
                        lst[i] = 0;
                    }
                }
                success = true;
                t = lst;
                Console.WriteLine(ListFloatToString(t));
            }

        }
        public void RemoveOdds(out bool success, out List<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                List<float> lst = new List<float>(floats);
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i] % 2 == 0)
                    {
                        lst[i] = 0;
                    }
                }
                success = true;
                t = lst;
                Console.WriteLine(ListFloatToString(t));
            }
        }
        public void Shuffle(out bool success, out List<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                List<float> lst = new List<float>(floats);
                Random _random = new Random();
                for (int i = 0; i < lst.Count; i++)
                {
                    int r = i + _random.Next(lst.Count - i);
                    float temp = lst[r];
                    lst[r] = lst[i];
                    lst[i] = temp;
                }
                success = true;
                t = lst;
                Console.WriteLine(ListFloatToString(t));
            }
        }
        public void SortAscending(out bool success, out List<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                List<float> arr = new List<float>(floats);
                float temp;

                for (int write = 0; write < arr.Count; write++)
                {
                    for (int sort = 0; sort < arr.Count - 1; sort++)
                    {
                        if (arr[sort] > arr[sort + 1])
                        {
                            temp = arr[sort + 1];
                            arr[sort + 1] = arr[sort];
                            arr[sort] = temp;
                        }
                    }
                }
                success = true;
                t = arr;
                Console.WriteLine(ListFloatToString(t));
            }
        }
        public void SortDescending(out bool success, out List<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                List<float> arr = new List<float>(floats);
                float temp;

                for (int write = 0; write < arr.Count; write++)
                {
                    for (int sort = 0; sort < arr.Count - 1; sort++)
                    {
                        if (arr[sort] < arr[sort + 1])
                        {
                            temp = arr[sort + 1];
                            arr[sort + 1] = arr[sort];
                            arr[sort] = temp;
                        }
                    }
                }
                success = true;
                t = arr;
                Console.WriteLine(ListFloatToString(t));
            }
        }
        #endregion

        #region ItemSlot
        public void PerfectShuffle(int iterations, out bool success, out List<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {

                List<Itemslot> lst = new List<Itemslot>(slots);
                Random r = new Random();
                List<Itemslot> a1 = new List<Itemslot>();
                List<Itemslot> a2 = new List<Itemslot>();

                if (lst.Count % 2 == 0)
                {
                    for (int n = 0; n < iterations; n++)
                    {
                        for (int i = 0; i < lst.Count / 2; i++)
                        {
                            a1.Add(lst[i]);
                        }
                        for (int j = lst.Count / 2; j < lst.Count; j++)
                        {
                            a2.Add(lst[j]);
                        }
                        int size = lst.Count;
                        lst.Clear();
                        for (int i = 0; i < size; i += 2)
                        {
                            lst.Add(a1[i / 2]);
                            lst.Add(a2[i / 2]);
                        }
                    }
                }

                else if (lst.Count % 2 == 1)
                {
                    for (int n = 0; n < iterations; n++)
                    {
                        Itemslot temp = lst[lst.Count - 1];

                        for (int i = 0; i < lst.Count - 1 / 2; i++)
                        {
                            a1.Add(lst[i]);
                        }
                        for (int j = lst.Count - 1 / 2; j < lst.Count - 1; j++)
                        {
                            a2.Add(lst[j]);
                        }
                        int x = r.Next(0, lst.Count);
                        lst.Clear();
                        for (int i = 0; i < lst.Count; i += 2)
                        {
                            lst.Add(a1[i / 2]);
                            lst.Add(a2[i / 2]);
                            if (x % 2 == 0 && i == x || x % 2 == 1 && i - 1 == x)
                            {
                                lst.Add(temp);
                                i++;
                            }
                        }
                    }
                }
                success = true;
                t = lst;
               Console.WriteLine(ListSlotToString(t));
            }
        }
        public void RemoveEven(out bool success, out List<Itemslot> t)
        {
            success = false;
            t = null;
            if (slots != null)
            {
                List<Itemslot> lst = new List<Itemslot>(slots);
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i] % 2 != 0)
                    {
                        lst[i].Clear();
                    }
                }
                success = true;
                t = lst;
                Console.WriteLine(ListSlotToString(t));
            }

        }
        public void RemoveOdds(out bool success, out List<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                List<Itemslot> lst = new List<Itemslot>(slots);
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i] % 2 == 0)
                    {
                        lst[i].Clear();
                    }
                }
                success = true;
                t = lst;
                Console.WriteLine(ListSlotToString(t));
            }
        }
        public void Shuffle(out bool success, out List<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                List<Itemslot> lst = new List<Itemslot>(slots);
                Random _random = new Random();
                for (int i = 0; i < lst.Count; i++)
                {
                    int r = i + _random.Next(lst.Count - i);
                    Itemslot temp = lst[r];
                    lst[r] = lst[i];
                    lst[i] = temp;
                }
                success = true;
                t = lst;
                Console.WriteLine(ListSlotToString(t));
            }
        }
        public void SortAscending(out bool success, out List<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                List<Itemslot> arr = new List<Itemslot>(slots);
                Itemslot temp;

                for (int write = 0; write < arr.Count; write++)
                {
                    for (int sort = 0; sort < arr.Count - 1; sort++)
                    {
                        if (arr[sort] > arr[sort + 1])
                        {
                            temp = arr[sort + 1];
                            arr[sort + 1] = arr[sort];
                            arr[sort] = temp;
                        }
                    }
                }
                success = true;
                t = arr;
                Console.WriteLine(ListSlotToString(t));
            }
        }
        public void SortDescending(out bool success, out List<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                List<Itemslot> arr = new List<Itemslot>(slots);
                Itemslot temp;

                for (int write = 0; write < arr.Count; write++)
                {
                    for (int sort = 0; sort < arr.Count - 1; sort++)
                    {
                        if (arr[sort] < arr[sort + 1])
                        {
                            temp = arr[sort + 1];
                            arr[sort + 1] = arr[sort];
                            arr[sort] = temp;
                        }
                    }
                }
                success = true;
                t = arr;
                Console.WriteLine(ListSlotToString(t));
            }
        }
        #endregion

    }
}
