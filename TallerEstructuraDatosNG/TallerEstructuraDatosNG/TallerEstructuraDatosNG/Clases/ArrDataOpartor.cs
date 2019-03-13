using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEstructuraDatosNG.Clases
{
    public class ArrDataOpartor : IDataOperator<int[]>, IDataOperator<float[]>, IDataOperator<Itemslot[]>
    {
        int[] ints;
        float[] floats;
        Itemslot[] slots;

        public int[] Ints { get => ints; set => ints = value; }
        public float[] Floats { get => floats; set => floats = value; }
        public Itemslot[] Slots { get => slots; set => slots = value; }
        
        public ArrDataOpartor(int[] ints, float[] floats, Itemslot[] slots)
        {
            this.ints = ints;
            this.floats = floats;
            this.slots = slots;
        }

        public string ArrToString<T>(T[] ts)
        {
            string data = "";
            for (int i = 0; i < ts.Length; i++)
            {
                data += ts[i].ToString() + ", ";
            }
            return data;
        }
        public string IntsToString(int[] ints)
        {
            string data = "";
            int[] toPrint = ints;

            for (int i = 0; i < toPrint.Length; i++)
            {
                data += toPrint[i].ToString() + ", ";
            }
            return data;
        }
        public string FloatsToString(float[] floats)
        {
            string data = "";
            float[] toPrint = floats;

            for (int i = 0; i < toPrint.Length; i++)
            {
                data += toPrint[i].ToString() + ", ";
            }
            return data;
        }
        public string slotsToString(Itemslot[] slots)
        {
            string data = "";
            Itemslot[] toPrint = slots;

            for (int i = 0; i < toPrint.Length; i++)
            {
                data += toPrint[i].ToString() + ", ";
            }
            return data;
        }


        #region int
        public void PerfectShuffle(int iterations, out bool success, out int[] t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                int[] arr = new int[ints.Length];
                Array.Copy(ints, arr, ints.Length);
                Random r = new Random();
                int[] a1 = new int[arr.Length / 2];
                int[] a2 = new int[arr.Length / 2];

                if (arr.Length % 2 == 0)
                {
                    for (int n = 0; n < iterations; n++)
                    {
                        for (int i = 0; i < arr.Length / 2; i++)
                        {
                            a1[i] = arr[i];
                        }
                        for (int j = arr.Length / 2; j < arr.Length; j++)
                        {
                            a2[j - arr.Length / 2] = arr[j];
                        }

                        for (int i = 0; i < arr.Length; i += 2)
                        {
                            arr[i] = a1[i / 2];
                            arr[i + 1] = a2[i / 2];
                        }
                    }
                }

                else if (arr.Length % 2 == 1)
                {
                    for (int n = 0; n < iterations; n++)
                    {
                        int temp = arr[arr.Length - 1];

                        for (int i = 0; i < (arr.Length - 1)/ 2 -1; i++)
                        {
                            a1[i] = arr[i];
                        }
                        for (int j = (arr.Length - 1 )/ 2; j < arr.Length - 1; j++)
                        {
                            a2[j- (arr.Length - 1)/2] = arr[j];
                        }
                        int x = r.Next(0, arr.Length);
                        for (int i = 0; i < arr.Length-1; i += 2)
                        {
                            arr[i] = a1[i / 2];
                            arr[i + 1] = a2[i / 2];
                            if (x % 2 == 0 && i == x || x % 2 == 1 && i - 1 == x)
                            {
                                arr[i + 2] = temp;
                                i++;
                            }
                        }
                    }
                }
                success = true;
                t = arr;
                Console.WriteLine(ArrToString(t));
            }

        }
        public void RemoveEven(out bool success, out int[] t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                int[] arr = new int[ints.Length];
                Array.Copy(ints, arr, ints.Length);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        arr[i] = 0;
                    }
                }
                success = true;
                t = arr;
                Console.WriteLine(ArrToString(t));
            }

        }
        public void RemoveOdds(out bool success, out int[] t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                int[] arr = new int[ints.Length];
                Array.Copy(ints, arr, ints.Length);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        arr[i] = 0;
                    }
                }
                success = true;
                t = arr;
                Console.WriteLine(ArrToString(t));
            }
        }
        public void Shuffle(out bool success, out int[] t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                int[] arr = new int[ints.Length];
                Array.Copy(ints, arr, ints.Length);
                Random _random = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    int r = i + _random.Next(arr.Length - i);
                    int temp = arr[r];
                    arr[r] = arr[i];
                    arr[i] = temp;
                }
                success = true;
                t = arr;
                Console.WriteLine(ArrToString(t));
            }
        }
        public void SortAscending(out bool success, out int[] t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                int[] arr = new int[ints.Length];
                Array.Copy(ints, arr, ints.Length);
                int temp;

                for (int write = 0; write < arr.Length; write++)
                {
                    for (int sort = 0; sort < arr.Length - 1; sort++)
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
                Console.WriteLine(ArrToString(t));

            }

        }
        public void SortDescending(out bool success, out int[] t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                int[] arr = new int[ints.Length];
                Array.Copy(ints, arr, ints.Length);
                int temp;

                for (int write = 0; write < arr.Length; write++)
                {
                    for (int sort = 0; sort < arr.Length - 1; sort++)
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
                Console.WriteLine(ArrToString(t));
            }
        } 
        #endregion

        #region float
        public void SortAscending(out bool success, out float[] t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                float[] arr = new float[floats.Length];
                Array.Copy(floats, arr, floats.Length);
                float temp;

                for (int write = 0; write < arr.Length; write++)
                {
                    for (int sort = 0; sort < arr.Length - 1; sort++)
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
                Console.WriteLine(ArrToString(t));
            }
        }
        public void SortDescending(out bool success, out float[] t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                float[] arr = new float[floats.Length];
                Array.Copy(floats, arr, floats.Length);
                float temp;

                for (int write = 0; write < arr.Length; write++)
                {
                    for (int sort = 0; sort < arr.Length - 1; sort++)
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
                Console.WriteLine(ArrToString(t));
            }
        }
        public void Shuffle(out bool success, out float[] t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                float[] arr = new float[floats.Length];
                Array.Copy(floats, arr, floats.Length);
                Random _random = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    int r = i + _random.Next(arr.Length - i);
                    float temp = arr[r];
                    arr[r] = arr[i];
                    arr[i] = temp;
                }
                success = true;
                t = arr;
                Console.WriteLine(ArrToString(t));
            }
        }
        public void RemoveOdds(out bool success, out float[] t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                float[] arr = new float[floats.Length];
                Array.Copy(floats, arr, floats.Length);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        arr[i] = 0;
                    }
                }
                success = true;
                t = arr;
                Console.WriteLine(ArrToString(t));
            }
        }
        public void RemoveEven(out bool success, out float[] t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                float[] arr = new float[floats.Length];
                Array.Copy(floats, arr, floats.Length);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        arr[i] = 0;
                    }
                }
                success = true;
                t = arr;
                Console.WriteLine(ArrToString(t));
            }
        }
        public void PerfectShuffle(int iterations, out bool success, out float[] t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                float[] arr = new float[floats.Length];
                Array.Copy(floats, arr, floats.Length);
                Random r = new Random();
                float[] a1 = new float[arr.Length / 2];
                float[] a2 = new float[arr.Length / 2];

                if (arr.Length % 2 == 0)
                {
                    for (int n = 0; n < iterations; n++)
                    {
                        for (int i = 0; i < arr.Length / 2; i++)
                        {
                            a1[i] = arr[i];
                        }
                        for (int j = arr.Length / 2; j < arr.Length; j++)
                        {
                            a2[j - arr.Length / 2] = arr[j];
                        }

                        for (int i = 0; i < arr.Length; i += 2)
                        {
                            arr[i] = a1[i / 2];
                            arr[i + 1] = a2[i / 2];
                        }
                    }
                }

                else if (arr.Length % 2 == 1)
                {
                    for (int n = 0; n < iterations; n++)
                    {
                        float temp = arr[arr.Length - 1];

                        for (int i = 0; i < (arr.Length - 1) / 2-1; i++)
                        {
                            a1[i] = arr[i];
                        }
                        for (int j = (arr.Length - 1) / 2; j < arr.Length - 1; j++)
                        {
                            a2[j- (arr.Length - 1) / 2] = arr[j];
                        }
                        int x = r.Next(0, arr.Length);
                        for (int i = 0; i < arr.Length-1; i += 2)
                        {
                            arr[i] = a1[i / 2];
                            arr[i + 1] = a2[i / 2];
                            if (x % 2 == 0 && i == x || x % 2 == 1 && i - 1 == x)
                            {
                                arr[i + 2] = temp;
                                i++;
                            }
                        }
                    }
                }
                success = true;
                t = arr;
                Console.WriteLine(ArrToString(t));
            }
        }



        #endregion

        #region itemSlot
        public void SortAscending(out bool success, out Itemslot[] t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Itemslot[] arr = new Itemslot[slots.Length];
                Array.Copy(slots, arr, slots.Length);
                Itemslot temp;

                for (int write = 0; write < arr.Length; write++)
                {
                    for (int sort = 0; sort < arr.Length - 1; sort++)
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
                Console.WriteLine(ArrToString(t));
            }
        }
        public void SortDescending(out bool success, out Itemslot[] t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Itemslot[] arr = new Itemslot[slots.Length];
                Array.Copy(slots, arr, slots.Length);
                Itemslot temp;

                for (int write = 0; write < arr.Length; write++)
                {
                    for (int sort = 0; sort < arr.Length - 1; sort++)
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
                Console.WriteLine(ArrToString(t));
            }
        }
        public void Shuffle(out bool success, out Itemslot[] t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Itemslot[] arr = new Itemslot[slots.Length];
                Array.Copy(slots, arr, slots.Length);
                Random _random = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    int r = i + _random.Next(arr.Length - i);
                    Itemslot temp = arr[r];
                    arr[r] = arr[i];
                    arr[i] = temp;
                }
                success = true;
                t = arr;
                Console.WriteLine(ArrToString(t));
            }
        }
        public void RemoveOdds(out bool success, out Itemslot[] t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Itemslot[] arr = new Itemslot[slots.Length];
                
                Array.Copy(slots, arr, slots.Length);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        arr[i].Clear();
                    }
                }
                success = true;
                t = arr;
                Console.WriteLine(ArrToString(t));
            }
        }
        public void RemoveEven(out bool success, out Itemslot[] t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Itemslot[] arr = new Itemslot[slots.Length];
                Array.Copy(slots, arr, slots.Length);


                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        arr[i].Clear();
                    }
                }
                success = true;
                t = arr;
                Console.WriteLine(ArrToString(t));
            }
        }
        public void PerfectShuffle(int iterations, out bool success, out Itemslot[] t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Itemslot[] arr = new Itemslot[slots.Length];
                Array.Copy(slots, arr, slots.Length);
                Random r = new Random();
                Itemslot[] a1 = new Itemslot[arr.Length / 2];
                Itemslot[] a2 = new Itemslot[arr.Length / 2];

                if (arr.Length % 2 == 0)
                {
                    for (int n = 0; n < iterations; n++)
                    {
                        for (int i = 0; i < arr.Length / 2; i++)
                        {
                            a1[i] = arr[i];
                        }
                        for (int j = arr.Length / 2; j < arr.Length; j++)
                        {
                            a2[j - arr.Length / 2] = arr[j];
                        }

                        for (int i = 0; i < arr.Length; i += 2)
                        {
                            arr[i] = a1[i / 2];
                            arr[i + 1] = a2[i / 2];
                        }
                    }
                }
                else if (arr.Length % 2 == 1)
                {
                    for (int n = 0; n < iterations; n++)
                    {
                        Itemslot temp = arr[arr.Length - 1];

                        for (int i = 0; i < (arr.Length - 1) / 2-1; i++)
                        {
                            a1[i] = arr[i];
                        }
                        for (int j = (arr.Length - 1) / 2; j < arr.Length - 1; j++)
                        {
                            a2[j- (arr.Length - 1) / 2] = arr[j];
                        }
                        int x = r.Next(0, arr.Length);
                        for (int i = 0; i < arr.Length-1; i += 2)
                        {
                            arr[i] = a1[i / 2];
                            arr[i + 1] = a2[i / 2];
                            if (x % 2 == 0 && i == x || x % 2 == 1 && i - 1 == x)
                            {
                                arr[i + 2] = temp;
                                i++;
                            }
                        }
                    }
                }

                success = true;
                t = arr;
                Console.WriteLine(ArrToString(t));
            }
        } 
        #endregion


    }
}
