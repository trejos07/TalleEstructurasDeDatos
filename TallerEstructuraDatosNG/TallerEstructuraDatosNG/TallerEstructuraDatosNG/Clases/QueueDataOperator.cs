using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEstructuraDatosNG.Clases
{
    public class QueueDataOperator: IDataOperator<Queue<int>>, IDataOperator<Queue<float>>, IDataOperator<Queue<Itemslot>>
    {
        Queue<int> ints;
        Queue<float> floats;
        Queue<Itemslot> slots;

        public QueueDataOperator(Queue<int> ints, Queue<float> floats, Queue<Itemslot> slots)
        {
            this.ints = ints;
            this.floats = floats;
            this.slots = slots;
        }

        public Queue<int> Ints { get => ints; set => ints = value; }
        public Queue<float> Floats { get => floats; set => floats = value; }
        public Queue<Itemslot> Slots { get => slots; set => slots = value; }

        public string QIntToString(Queue<int> ts)
        {
            string data = "";
            Queue<int> toprint = new Queue<int>(ts);

            while (toprint.Count > 0)
            {
                data += toprint.Dequeue().ToString() + ", ";
            }
            return data;
        }
        public string QFloatToString(Queue<float> ts)
        {
            string data = "";
            Queue<float> toprint = new Queue<float>(ts);

            while (toprint.Count > 0)
            {
                data += toprint.Dequeue().ToString() + ", ";
            }
            return data;
        }
        public string QSlotToString(Queue<Itemslot> ts)
        {
            string data = "";
            Queue<Itemslot> toprint = new Queue<Itemslot>(ts);
            while (toprint.Count > 0)
            {
                data += toprint.Dequeue().ToString() + ", ";
            }
            return data;
        }


        #region int
        public void SortAscending(out bool success, out Queue<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                Queue<int> ts = new Queue<int>(ints);

                success = false;
                t = new Queue<int>(ts.OrderBy(x => x));
                Console.WriteLine(QIntToString(t));
            }
        }
        public void SortDescending(out bool success, out Queue<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                Queue<int> ts = new Queue<int>(ints);

                success = false;
                t = new Queue<int>(ts.OrderByDescending(x => x));
                Console.WriteLine(QIntToString(t));
            }
        }
        public void Shuffle(out bool success, out Queue<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                Queue<int> ts = new Queue<int>(ints);
                Random rnd = new Random();
                success = false;
                t = new Queue<int>(ts.OrderBy(x => rnd.Next()));
                Console.WriteLine(QIntToString(t));

            }
        }
        public void RemoveOdds(out bool success, out Queue<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                Queue<int> ts = new Queue<int>(ints);
                Queue<int> newTs = new Queue<int>();
                while(ts.Count>0)
                {
                    if (ts.Peek() % 2 == 0)
                    {
                        ts.Dequeue();
                    }
                    else
                        newTs.Enqueue(ts.Dequeue());
                }
                while (newTs.Count > 0)
                {
                    ts.Enqueue(newTs.Dequeue());
                }
                success = true;
                t = ts;
                Console.WriteLine(QIntToString(t));
            }
        }
        public void RemoveEven(out bool success, out Queue<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                Queue<int> ts = new Queue<int>(ints);
                Queue<int> newTs = new Queue<int>();
                while (ts.Count > 0)
                {
                    if (ts.Peek() % 2 != 0)
                    {
                        ts.Dequeue();
                    }
                    else
                        newTs.Enqueue(ts.Dequeue());
                }
                while (newTs.Count > 0)
                {
                    ts.Enqueue(newTs.Dequeue());
                }
                success = true;
                t = ts;
                Console.WriteLine(QIntToString(t));
            }
        }
        public void PerfectShuffle(int iterations, out bool success, out Queue<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                Queue<int> ts = new Queue<int>(ints);
                Queue<int> t1 = new Queue<int>();
                Queue<int> t2 = new Queue<int>();

                for (int i = 0; i < iterations; i++)
                {
                    if (ts.Count % 2 == 0)
                    {
                        int half = ts.Count / 2;
                        while (ts.Count > half)
                        {
                            t1.Enqueue(ts.Dequeue());
                            
                        }
                        while (ts.Count > 0)
                        {
                            t2.Enqueue(ts.Dequeue());

                        }
                        
                        while (t1.Count > 0 || t2.Count > 0)
                        {
                            if (t1.Count > 0)
                                ts.Enqueue(t1.Dequeue());
                            if (t2.Count > 0)
                                ts.Enqueue(t2.Dequeue());
                        }
                    }
                    else if (ts.Count%2 == 1)
                    {
                        int tem = ts.Dequeue();
                        int half = ts.Count / 2;
                        while (ts.Count > half)
                        {
                            t1.Enqueue(ts.Dequeue());

                        }
                        while (ts.Count > 0)
                        {
                            t2.Enqueue(ts.Dequeue());

                        }
                        ts.Enqueue(tem);
                        while (t1.Count > 0 || t2.Count > 0)
                        {
                            if (t1.Count > 0)
                                ts.Enqueue(t1.Dequeue());
                            if (t2.Count > 0)
                                ts.Enqueue(t2.Dequeue());
                        }
                    }
                }
                success = true;
                t = ts;
                Console.WriteLine(QIntToString(t));
            }


        }
        #endregion

        #region float
        public void SortAscending(out bool success, out Queue<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                Queue<float> ts = new Queue<float>(floats);

                success = false;
                t = new Queue<float>(ts.OrderBy(x => x));
                Console.WriteLine(QFloatToString(t));
            }
        }
        public void SortDescending(out bool success, out Queue<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                Queue<float> ts = new Queue<float>(floats);

                success = false;
                t = new Queue<float>(ts.OrderByDescending(x => x));
                Console.WriteLine(QFloatToString(t));
            }
        }
        public void Shuffle(out bool success, out Queue<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                Queue<float> ts = new Queue<float>(floats);
                Random rnd = new Random();
                success = false;
                t = new Queue<float>(ts.OrderBy(x => rnd.Next()));
                Console.WriteLine(QFloatToString(t));

            }
        }
        public void RemoveOdds(out bool success, out Queue<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                Queue<float> ts = new Queue<float>(floats);
                Queue<float> newTs = new Queue<float>();
                while (ts.Count > 0)
                {
                    if (ts.Peek() % 2 == 0)
                    {
                        ts.Dequeue();
                    }
                    else
                        newTs.Enqueue(ts.Dequeue());
                }
                while (newTs.Count > 0)
                {
                    ts.Enqueue(newTs.Dequeue());
                }
                success = true;
                t = ts;
                Console.WriteLine(QFloatToString(t));
            }
        }
        public void RemoveEven(out bool success, out Queue<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                Queue<float> ts = new Queue<float>(floats);
                Queue<float> newTs = new Queue<float>();
                while (ts.Count > 0)
                {
                    if (ts.Peek() % 2 != 0)
                    {
                        ts.Dequeue();
                    }
                    else
                        newTs.Enqueue(ts.Dequeue());
                }
                while (newTs.Count > 0)
                {
                    ts.Enqueue(newTs.Dequeue());
                }
                success = true;
                t = ts;
                Console.WriteLine(QFloatToString(t));
            }
        }
        public void PerfectShuffle(int iterations, out bool success, out Queue<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                Queue<float> ts = new Queue<float>(floats);
                Queue<float> t1 = new Queue<float>();
                Queue<float> t2 = new Queue<float>();

                for (int i = 0; i < iterations; i++)
                {
                    if (ts.Count % 2 == 0)
                    {
                        int half = ts.Count / 2;
                        while (ts.Count > half)
                        {
                            t1.Enqueue(ts.Dequeue());

                        }
                        while (ts.Count > 0)
                        {
                            t2.Enqueue(ts.Dequeue());

                        }
                        while (t1.Count > 0 || t2.Count > 0)
                        {
                            if (t1.Count > 0)
                                ts.Enqueue(t1.Dequeue());
                            if (t2.Count > 0)
                                ts.Enqueue(t2.Dequeue());
                        }
                    }
                    else if (ts.Count % 2 == 1)
                    {
                        float tem = ts.Dequeue();
                        int half = ts.Count / 2;
                        while (ts.Count > half)
                        {
                            t1.Enqueue(ts.Dequeue());

                        }
                        while (ts.Count > 0)
                        {
                            t2.Enqueue(ts.Dequeue());

                        }
                        ts.Enqueue(tem);
                        while (t1.Count > 0 || t2.Count > 0)
                        {
                            if (t1.Count > 0)
                                ts.Enqueue(t1.Dequeue());
                            if (t2.Count > 0)
                                ts.Enqueue(t2.Dequeue());
                        }
                    }
                }
                success = true;
                t = ts;
                Console.WriteLine(QFloatToString(t));
            }


        }
        #endregion

        #region Itemslot
        public void SortAscending(out bool success, out Queue<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Queue<Itemslot> ts = new Queue<Itemslot>(slots);

                success = false;
                t = new Queue<Itemslot>(ts.OrderBy(x => x));
                Console.WriteLine(QSlotToString(t));
            }
        }
        public void SortDescending(out bool success, out Queue<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Queue<Itemslot> ts = new Queue<Itemslot>(slots);

                success = false;
                t = new Queue<Itemslot>(ts.OrderByDescending(x => x));
                Console.WriteLine(QSlotToString(t));
            }
        }
        public void Shuffle(out bool success, out Queue<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Queue<Itemslot> ts = new Queue<Itemslot>(slots);
                Random rnd = new Random();
                success = false;
                t = new Queue<Itemslot>(ts.OrderBy(x => rnd.Next()));
                Console.WriteLine(QSlotToString(t));

            }
        }
        public void RemoveOdds(out bool success, out Queue<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Queue<Itemslot> ts = new Queue<Itemslot>(slots);
                Queue<Itemslot> newTs = new Queue<Itemslot>();
                while (ts.Count > 0)
                {
                    if (ts.Peek() % 2 == 0)
                    {
                        ts.Dequeue();
                    }
                    else
                        newTs.Enqueue(ts.Dequeue());
                }
                while (newTs.Count > 0)
                {
                    ts.Enqueue(newTs.Dequeue());
                }
                success = true;
                t = ts;
                Console.WriteLine(QSlotToString(t));
            }
        }
        public void RemoveEven(out bool success, out Queue<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Queue<Itemslot> ts = new Queue<Itemslot>(slots);
                Queue<Itemslot> newTs = new Queue<Itemslot>();
                while (ts.Count > 0)
                {
                    if (ts.Peek() % 2 != 0)
                    {
                        ts.Dequeue();
                    }
                    else
                        newTs.Enqueue(ts.Dequeue());
                }
                while (newTs.Count > 0)
                {
                    ts.Enqueue(newTs.Dequeue());
                }
                success = true;
                t = ts;
                Console.WriteLine(QSlotToString(t));
            }
        }
        public void PerfectShuffle(int iterations, out bool success, out Queue<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Queue<Itemslot> ts = new Queue<Itemslot>(slots);
                Queue<Itemslot> t1 = new Queue<Itemslot>();
                Queue<Itemslot> t2 = new Queue<Itemslot>();

                for (int i = 0; i < iterations; i++)
                {
                    if (ts.Count % 2 == 0)
                    {
                        int half = ts.Count / 2;
                        while (ts.Count > half)
                        {
                            t1.Enqueue(ts.Dequeue());

                        }
                        while (ts.Count > 0)
                        {
                            t2.Enqueue(ts.Dequeue());

                        }
                        while (t1.Count > 0 || t2.Count > 0)
                        {
                            if (t1.Count > 0)
                                ts.Enqueue(t1.Dequeue());
                            if (t2.Count > 0)
                                ts.Enqueue(t2.Dequeue());
                        }
                    }
                    else if (ts.Count % 2 == 1)
                    {
                        Itemslot tem = ts.Dequeue();
                        int half = ts.Count / 2;
                        while (ts.Count > half)
                        {
                            t1.Enqueue(ts.Dequeue());

                        }
                        while (ts.Count > 0)
                        {
                            t2.Enqueue(ts.Dequeue());

                        }
                        ts.Enqueue(tem);
                        while (t1.Count > 0 || t2.Count > 0)
                        {
                            if (t1.Count > 0)
                                ts.Enqueue(t1.Dequeue());
                            if (t2.Count > 0)
                                ts.Enqueue(t2
                                    .Dequeue());
                        }
                    }
                }
                success = true;
                t = ts;
                Console.WriteLine(QSlotToString(t));    
            }


        }
        #endregion
    }
}
