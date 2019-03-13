using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEstructuraDatosNG.Clases
{
    class DataGenerator
    {
        static ItemDB itemDB = new ItemDB();

        public static int[] PopulateArray(int size, int maxNumber, bool randomData = false)
        {
            int[] ts = new int[size];
                if (randomData)
                {
                    Random random = new Random();
                    for (int i = 0; i < ts.Length; i++)
                    {
                        ts[i] = random.Next(0, maxNumber);
                    }
                }
                else
                {
                    for (int i = 0; i < ts.Length; i++)
                    {
                        ts[i] = i + 1;
                    }
                }
            return ts;
        }
        public static float[] PopulateArray(int size, float maxNumber, bool randomData = false)
        {
            float[] ts = new float[size];

                if (randomData)
                {
                    
                    for (int i = 0; i < ts.Length; i++)
                    {
                        float toAdd = GenRandFloat(0, maxNumber);
                        ts[i] = toAdd;
                    }
                }
                else
                {
                    for (int i = 0; i < ts.Length; i++)
                    {
                        ts[i] = i + 1 + (float)i / ts.Length;
                    }
                }

            return ts;

        }
        public static Itemslot[] PopulateArray(int size)
        {
            Itemslot[] ts = new Itemslot[size];
            Random random = new Random();
                for (int i = 0; i < ts.Length; i++)
                {
                    Item item = itemDB.Items[i % itemDB.Items.Count];
                    ts[i] = new Itemslot(item, random.Next(0, 100));
                }
            return ts;

        }


        public static List<int> PopulateList(int size, int maxNumber, bool randomData = false)
        {
            List<int> ts = new List<int>();

                if (randomData)
                {
                    Random random = new Random();
                    for (int i = 0; i < size; i++)
                    {
                        ts.Add(random.Next(0, maxNumber));
                    }
                }
                else
                {
                    for (int i = 0; i < size; i++)
                    {
                        ts.Add(i + 1);
                    }
                }
            return ts;
        }
        public static List<float> PopulateList(int size, float maxNumber, bool randomData = false)
        {
            List<float> ts = new List<float>();

            if (randomData)
            {
                Random random = new Random();
                for (int i = 0; i < size; i++)
                {
                    float toAdd = GenRandFloat(0, maxNumber);
                    ts.Add(toAdd);
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    ts.Add(i + 1 +(float) i / size);
                }
            }

            return ts;

        }
        public static List<Itemslot> PopulateList(int size)
        {
            List<Itemslot> ts = new List<Itemslot>();
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                ts.Add(new Itemslot(itemDB.Items[i % itemDB.Items.Count], random.Next(0, 100)));
            }

            return ts;
        }

        public static Queue<int> PopulateQueue(int size, int maxNumber, bool randomData = false)
        {
            Queue<int> ts = new Queue<int>();
            if (randomData)
            {
                Random random = new Random();
                for (int i = 0; i < size; i++)
                {
                    ts.Enqueue(random.Next(0, maxNumber));
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    ts.Enqueue(i + 1);
                }
            }
            return ts;
        }
        public static Queue<float> PopulateQueue(int size, float maxNumber, bool randomData = false)
        {
            Queue<float> ts = new Queue<float>();
            if (randomData)
            {
                Random random = new Random();
                for (int i = 0; i < size; i++)
                {
                    ts.Enqueue(GenRandFloat(0, maxNumber));
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    ts.Enqueue(i + 1 + (float)i / size);
                }
            }
            return ts;
        }
        public static Queue<Itemslot> PopulateQueue(int size)
        {
            Queue<Itemslot> ts = new Queue<Itemslot>();
            Random random = new Random();


            for (int i = 0; i < size; i++)
            {
                ts.Enqueue(new Itemslot(itemDB.Items[i % itemDB.Items.Count], random.Next(0, 100)));
            }

            return ts;

        }

        public static Stack<int> PopulateStack(int size, int maxNumber, bool randomData = false)
        {
            Stack<int> ts = new Stack<int>();

            if (randomData)
            {
                Random random = new Random();
                for (int i = 0; i < size; i++)
                {
                    ts.Push(random.Next(0, maxNumber));
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    ts.Push(i + 1);
                }
            }

            return ts;
        }
        public static Stack<float> PopulateStack(int size, float maxNumber, bool randomData = false)
        {
            Stack<float> ts = new Stack<float>();

            if (randomData)
            {
                Random random = new Random();
                for (int i = 0; i < size; i++)
                {
                    ts.Push(GenRandFloat(0, maxNumber));
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    ts.Push(i + 1 + (float)i / size);
                }
            }

            return ts;
        }
        public static Stack<Itemslot> PopulateStack(int size)
        {
            Stack<Itemslot> ts = new Stack<Itemslot>();
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                ts.Push(new Itemslot(itemDB.Items[i % itemDB.Items.Count], random.Next(0, 100)));
            }

            return ts;
        }

        public static Dictionary<string, int> PopulateDict(int size, int maxNumber, bool randomData = false)
        {
            Dictionary<string, int> ts = new Dictionary<string, int>();
            if (randomData)
            {
                Random random = new Random();
                for (int i = 0; i < size; i++)
                {
                    ts.Add(i.ToString(),random.Next(0, maxNumber));
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    ts.Add(i.ToString(), i+1);
                }
            }
            return ts;
        }
        public static Dictionary<string, float> PopulateDict(int size, float maxNumber, bool randomData = false)
        {
            Dictionary<string, float> ts = new Dictionary<string, float>();
            if (randomData)
            {
                Random random = new Random();
                for (int i = 0; i < size; i++)
                {
                    ts.Add(i.ToString(), GenRandFloat(0, maxNumber));
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    ts.Add(i.ToString(), i + 1);
                }
            }
            return ts;
        }
        public static Dictionary<string, Itemslot> PopulateDict(int size)
        {
            Dictionary<string, Itemslot> ts = new Dictionary<string, Itemslot>();

            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                Item item = itemDB.Items[i % itemDB.Items.Count];
                ts.Add(i.ToString(), new Itemslot(item, random.Next(0, 100)));
            }

            return ts;
        }


        public static float GenRandFloat(float min, float max )
        {
            Random random = new Random();
            int floatBaseN = random.Next((int)min, (int)max);
            float f = floatBaseN + (float)random.NextDouble();
            return f;
        }

    }




}
