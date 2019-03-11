using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEstructuraDatosNG.Clases
{
    class StackDataOperator : IDataOperator<Stack<int>>, IDataOperator<Stack<float>>, IDataOperator<Stack<Itemslot>>
    {
        Stack<int> ints;
        Stack<float> floats;
        Stack<Itemslot> slots;

        public StackDataOperator(Stack<int> ints, Stack<float> floats, Stack<Itemslot> slots)
        {
            this.ints = ints;
            this.floats = floats;
            this.slots = slots;
        }

        public Stack<int> Ints { get => ints; }
        public Stack<float> Floats { get => floats;  }
        public Stack<Itemslot> Slots { get => slots;  }

        public string StackIntToString(Stack<int> ts)
        {
            string data = "";
            Stack<int> toprint = new Stack<int>(ts);

            while (toprint.Count>0)
            {
                data += toprint.Pop().ToString() + ", ";
            }
            return data;
        }
        public string StackFloatToString(Stack<float> ts)
        {
            string data = "";
            Stack<float> toprint = new Stack<float>(ts);

            while (toprint.Count > 0)
            {
                data += toprint.Pop().ToString() + ", ";
            }
            return data;
        }
        public string StackSlotToString(Stack<Itemslot> ts)
        {
            string data = "";
            Stack<Itemslot> toprint = new Stack<Itemslot>(ts);
            while (toprint.Count > 0)
            {
                data += toprint.Pop().ToString() + ", ";
            }
            return data;
        }

        #region Int
        public void PerfectShuffle(int iterations, out bool success, out Stack<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                Stack<int> ts = new Stack<int>(ints);
                Stack<int> t1 = new Stack<int>();
                Stack<int> t2 = new Stack<int>();

                for (int i = 0; i < iterations; i++)
                {
                    if (ts.Count % 2 == 0)
                    {
                        while (ts.Count > 0)
                        {
                            t1.Push(ts.Pop());
                            t2.Push(ts.Pop());
                        }
                        while (t1.Count > 0 || t2.Count > 0)
                        {
                            if (t1.Count > 0)
                                ts.Push(t1.Pop());
                            if (t2.Count > 0)
                                ts.Push(t2.Pop());
                        }
                    }
                    else if (ts.Count%2 == 1)
                    {
                        int tem = ts.Pop();
                        while (ts.Count > 0)
                        {
                            t1.Push(ts.Pop());
                            t2.Push(ts.Pop());
                        }
                        ts.Push(tem);
                        while (t1.Count > 0 || t2.Count > 0)
                        {
                            if (t1.Count > 0)
                                ts.Push(t1.Pop());
                            if (t2.Count > 0)
                                ts.Push(t2.Pop());
                        }
                    }
                }
                Stack<int> final = new Stack<int>();
                while(ts.Count>0)
                {
                    final.Push(ts.Pop());
                }

                success = true;
                t =  final;
            }

        }
        public void RemoveEven(out bool success, out Stack<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                Stack<int> ts = new Stack<int>(ints);
                Stack<int> newTs = new Stack<int>();
                while (ts.Count > 0)
                {
                    if (ts.Peek() % 2 != 0)
                    {
                        ts.Pop();
                    }
                    else
                        newTs.Push(ts.Pop());
                    
                }
                while (newTs.Count != 0)
                {
                    ts.Push(newTs.Pop());
                }
                success = true;
                t = ts;
            }
        }
        public void RemoveOdds(out bool success, out Stack<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                Stack<int> ts = new Stack<int>(ints);
                Stack<int> newTs = new Stack<int>();
                while(ts.Count >0)
                {
                    if (ts.Peek() % 2 == 0)
                    {
                        ts.Pop();
                    }
                    else
                        newTs.Push(ts.Pop());

                }

                while (newTs.Count != 0)
                {
                    ts.Push(newTs.Pop());
                }
                success = true;
                t = ts;
            }
        }
        public void Shuffle(out bool success, out Stack<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                Stack<int> ts = new Stack<int> (ints);
                Random rnd = new Random();
                success = true;
                t = new Stack<int>(ts.OrderBy(x => rnd.Next()));

            }
        }
        public void SortAscending(out bool success, out Stack<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                Stack<int> inputs = new Stack<int>(ints);
                Stack<int> ss = new Stack<int>();
                while (inputs.Count > 0 )
                {
                    int temp = inputs.Pop();
                    while(ss.Count>0 && ss.Peek()>temp)
                    {
                        inputs.Push(ss.Pop());
                    }
                    ss.Push(temp);
                }

                success = true;
                t = ss;
            }
        }
        public void SortDescending(out bool success, out Stack<int> t)
        {
            success = false;
            t = null;

            if (ints != null)
            {
                Stack<int> inputs = new Stack<int>(ints);
                Stack<int> ss = new Stack<int>();
                while (inputs.Count > 0)
                {
                    int temp = inputs.Pop();
                    while (ss.Count > 0 && ss.Peek() < temp)
                    {
                        inputs.Push(ss.Pop());
                    }
                    ss.Push(temp);
                }

                success = true;
                t = ss;
            }
        }
        #endregion

        #region Float
        public void PerfectShuffle(int iterations, out bool success, out Stack<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                Stack<float> ts = new Stack<float>(floats);
                Stack<float> t1 = new Stack<float>();
                Stack<float> t2 = new Stack<float>();

                for (int i = 0; i < iterations; i++)
                {
                    if (ts.Count % 2 == 0)
                    {
                        while (ts.Count > 0)
                        {
                            t1.Push(ts.Pop());
                            t2.Push(ts.Pop());
                        }
                        while (t1.Count > 0 || t2.Count > 0)
                        {
                            if (t1.Count > 0)
                                ts.Push(t1.Pop());
                            if (t2.Count > 0)
                                ts.Push(t2.Pop());
                        }
                    }
                    else if (ts.Count% 2 == 1)
                    {
                        float tem = ts.Pop();
                        while (ts.Count > 0)
                        {
                            t1.Push(ts.Pop());
                            t2.Push(ts.Pop());
                        }
                        ts.Push(tem);
                        while (t1.Count > 0 || t2.Count > 0)
                        {
                            if (t1.Count > 0)
                                ts.Push(t1.Pop());
                            if (t2.Count > 0)
                                ts.Push(t2.Pop());
                        }
                    }
                }
                Stack<float> final = new Stack<float>();
                while (ts.Count > 0)
                {
                    final.Push(ts.Pop());
                }

                success = true;
                t = ts;
            }

        }
        public void RemoveEven(out bool success, out Stack<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                Stack<float> ts = new Stack<float>(floats);
                Stack<float> newTs = new Stack<float>();
                while (ts.Count>0)
                {
                    if (ts.Peek() % 2 != 0)
                    {
                        ts.Pop();
                    }
                    else
                        newTs.Push(ts.Pop());
                }
                while (newTs.Count != 0)
                {
                    ts.Push(newTs.Pop());
                }
                success = true;
                t = ts;
            }
        }
        public void RemoveOdds(out bool success, out Stack<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                Stack<float> ts = new Stack<float>(floats);
                Stack<float> newTs = new Stack<float>();
                while (ts.Count > 0)
                {
                    if (ts.Peek() % 2 == 0)
                    {
                        ts.Pop();
                    }
                    else
                        newTs.Push(ts.Pop());
                    
                }
                while (newTs.Count != 0)
                {
                    ts.Push(newTs.Pop());
                }
                success = true;
                t = ts;
            }
        }
        public void Shuffle(out bool success, out Stack<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                Stack<float> ts = floats;
                Random rnd = new Random();
                success = true;
                t = new Stack<float>(ts.OrderBy(x => rnd.Next()));

            }
        }
        public void SortAscending(out bool success, out Stack<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                Stack<float> inputs = new Stack<float>(floats);
                Stack<float> ss = new Stack<float>();
                while (inputs.Count > 0)
                {
                    float temp = inputs.Pop();
                    while (ss.Count > 0 && ss.Peek() > temp)
                    {
                        inputs.Push(ss.Pop());
                    }
                    ss.Push(temp);
                }

                success = true;
                t = ss;
            }
        }
        public void SortDescending(out bool success, out Stack<float> t)
        {
            success = false;
            t = null;

            if (floats != null)
            {
                Stack<float> inputs = new Stack<float>(floats);
                Stack<float> ss = new Stack<float>();
                while (inputs.Count > 0)
                {
                    float temp = inputs.Pop();
                    while (ss.Count > 0 && ss.Peek() < temp)
                    {
                        inputs.Push(ss.Pop());
                    }
                    ss.Push(temp);
                }

                success = true;
                t = ss;
            }
        }
        #endregion

        #region Itemslot
        public void PerfectShuffle(int iterations, out bool success, out Stack<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Stack<Itemslot> ts = new Stack<Itemslot>(slots);
                Stack<Itemslot> t1 = new Stack<Itemslot>();
                Stack<Itemslot> t2 = new Stack<Itemslot>();

                for (int i = 0; i < iterations; i++)
                {
                    if (ts.Count % 2 == 0)
                    {
                        while (ts.Count > 0)
                        {
                            t1.Push(ts.Pop());
                            t2.Push(ts.Pop());
                        }
                        while (t1.Count > 0 || t2.Count > 0)
                        {
                            if (t1.Count > 0)
                                ts.Push(t1.Pop());
                            if (t2.Count > 0)
                                ts.Push(t2.Pop());
                        }
                    }
                    else if (ts.Count% 2 == 1)
                    {
                        Itemslot tem = ts.Pop();
                        while (ts.Count > 0)
                        {
                            t1.Push(ts.Pop());
                            t2.Push(ts.Pop());
                        }
                        ts.Push(tem);
                        while (t1.Count > 0 || t2.Count > 0)
                        {
                            if (t1.Count > 0)
                                ts.Push(t1.Pop());
                            if (t2.Count > 0)
                                ts.Push(t2.Pop());
                        }
                    }
                }
                Stack<Itemslot> final = new Stack<Itemslot>();
                while (ts.Count > 0)
                {
                    final.Push(ts.Pop());
                }
                success = true;
                t = ts;
            }

        }
        public void RemoveEven(out bool success, out Stack<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Stack<Itemslot> ts = new Stack<Itemslot>(slots);
                Stack<Itemslot> newTs = new Stack<Itemslot>();
                while(ts.Count >0)
                {
                    if (ts.Peek() % 2 != 0)
                    {
                        ts.Pop();
                    }
                    else
                        newTs.Push(ts.Pop());
                }
                while (newTs.Count != 0)
                {
                    ts.Push(newTs.Pop());
                }
                success = true;
                t = ts;
            }
        }
        public void RemoveOdds(out bool success, out Stack<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Stack<Itemslot> ts = new Stack<Itemslot>(slots);
                Stack<Itemslot> newTs = new Stack<Itemslot>();
                while (ts.Count > 0)
                {
                    if (ts.Peek() % 2 == 0)
                    {
                        ts.Pop();
                    }
                    else
                        newTs.Push(ts.Pop());
                }
                while (newTs.Count != 0)
                {
                    ts.Push(newTs.Pop());
                }
                success = true;
                t = ts;
            }
        }
        public void Shuffle(out bool success, out Stack<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Stack<Itemslot> ts = new Stack < Itemslot > (slots);
                Random rnd = new Random();
                success = true;
                t = new Stack<Itemslot>(ts.OrderBy(x => rnd.Next()));

            }
        }
        public void SortAscending(out bool success, out Stack<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Stack<Itemslot> inputs = new Stack<Itemslot>(slots);
                Stack<Itemslot> ss = new Stack<Itemslot>();
                while (inputs.Count > 0)
                {
                    Itemslot temp = inputs.Pop();
                    while (ss.Count > 0 && ss.Peek() > temp)
                    {
                        inputs.Push(ss.Pop());
                    }
                    ss.Push(temp);
                }

                success = true;
                t = ss;
            }
        }
        public void SortDescending(out bool success, out Stack<Itemslot> t)
        {
            success = false;
            t = null;

            if (slots != null)
            {
                Stack<Itemslot> inputs = new Stack<Itemslot>(slots);
                Stack<Itemslot> ss = new Stack<Itemslot>();
                while (inputs.Count > 0)
                {
                    Itemslot temp = inputs.Pop();
                    while (ss.Count > 0 && ss.Peek() < temp)
                    {
                        inputs.Push(ss.Pop());
                    }
                    ss.Push(temp);
                }

                success = true;
                t = ss;
            }
        }
        #endregion



    }
}
