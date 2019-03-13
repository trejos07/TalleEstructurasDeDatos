using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEstructuraDatosNG.Clases;

namespace TallerEstructuraDatosNG
{
    class Program
    {

        public delegate void TestAction<T>( out bool b, out T t);
        public delegate void TestPShuffle<T>(int i , out bool b, out T t);


        static void Main(string[] args)
        {
            ArrDataOpartor ArrO = new ArrDataOpartor(DataGenerator.PopulateArray(10, 100, true), DataGenerator.PopulateArray(10, 100f, true), DataGenerator.PopulateArray(10));
            ListDataOperator LstO = new ListDataOperator(DataGenerator.PopulateList(10, 100, true), DataGenerator.PopulateList(10, 100f, true), DataGenerator.PopulateList(10));
            StackDataOperator StkO = new StackDataOperator(DataGenerator.PopulateStack(10, 100, true), DataGenerator.PopulateStack(10, 100f, true), DataGenerator.PopulateStack(10));
            QueueDataOperator QueO = new QueueDataOperator(DataGenerator.PopulateQueue(10, 100, true), DataGenerator.PopulateQueue(10, 100f, true), DataGenerator.PopulateQueue(10));
            DictionaryDataOperator DicO = new DictionaryDataOperator(DataGenerator.PopulateDict(10, 100, true), DataGenerator.PopulateDict(10, 100f, true), DataGenerator.PopulateDict(10));

            #region Array
            Console.WriteLine("\n" + "------------------- Array Data Operator Test --------------------" + "\n");

            Console.WriteLine("------------------- Int Test --------------------" + "\n");
            TestDataOperator<int[]>(ArrO);
            Console.WriteLine("------------------- Float Test --------------------" + "\n");
            TestDataOperator<float[]>(ArrO);
            Console.WriteLine("------------------- Slot Test --------------------" + "\n");
            TestDataOperator<Itemslot[]>(ArrO);
            #endregion

            #region List
            Console.WriteLine("\n" + "------------------- List Data Operator Test --------------------" + "\n");

            Console.WriteLine("------------------- Int Test --------------------" + "\n");
            TestDataOperator<List<int>>(LstO);
            Console.WriteLine("------------------- Float Test --------------------" + "\n");
            TestDataOperator<List<float>>(LstO);
            Console.WriteLine("------------------- Slot Test --------------------" + "\n");
            TestDataOperator<List<Itemslot>>(LstO);
            #endregion

            #region Stack
            Console.WriteLine("\n" + "------------------- Stack Data Operator Test --------------------" + "\n");

            Console.WriteLine("------------------- Int Test --------------------" + "\n");
            TestDataOperator<Stack<int>>(StkO);
            Console.WriteLine("------------------- Float Test --------------------" + "\n");
            TestDataOperator<Stack<float>>(StkO);
            Console.WriteLine("------------------- Slot Test --------------------" + "\n");
            TestDataOperator<Stack<Itemslot>>(StkO);
            #endregion

            #region Queue
            Console.WriteLine("\n" + "------------------- Queue Data Operator Test --------------------" + "\n");

            Console.WriteLine("------------------- Int Test --------------------" + "\n");
            TestDataOperator<Queue<int>>(QueO);
            Console.WriteLine("------------------- Float Test --------------------" + "\n");
            TestDataOperator<Queue<float>>(QueO);
            Console.WriteLine("------------------- Slot Test --------------------" + "\n");
            TestDataOperator<Queue<Itemslot>>(QueO);
            #endregion

            #region Dic
            Console.WriteLine("\n" + "------------------- Queue Data Operator Test --------------------" + "\n");

            Console.WriteLine("------------------- Int Test --------------------" + "\n");
            TestDataOperator<Dictionary<string,int>>(DicO);
            Console.WriteLine("------------------- Float Test --------------------" + "\n");
            TestDataOperator<Dictionary<string, float>>(DicO);
            Console.WriteLine("------------------- Slot Test --------------------" + "\n");
            TestDataOperator<Dictionary<string, Itemslot>>(DicO);
            #endregion

        }

        public static void TestDataOperator<T>(IDataOperator<T> dataOperator)
        {
            Test<T>("SortAscending", dataOperator.SortAscending);
            Test<T>("SortDescending", dataOperator.SortDescending);
            Test<T>("Shuffle", dataOperator.Shuffle);
            TestPerfecShuffle<T>(1,"PerfectShuffle", dataOperator.PerfectShuffle);
            Test<T>("RemoveEven", dataOperator.RemoveEven);
            Test<T>("RemoveOdds", dataOperator.RemoveOdds);

        }
        public static void Test<T> (string methodName, TestAction<T> method)
        {
            Console.WriteLine(" se ejecuta el metodo "+ methodName +" en la estructura : "+ typeof(T).Name);
            bool succes = false;
            T methodsOut;
            method.Invoke(out succes, out methodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
           
            Console.WriteLine("\n");

            Console.ReadLine(); 
        }
        public static void TestPerfecShuffle<T>(int iterations, string methodName, TestPShuffle<T> method)
        {
            Console.WriteLine(" se ejecuta el metodo "+ methodName +" en la estructura :"+ typeof(T).Name);
            bool succes = false;
            T methodsOut;
            method.Invoke(iterations , out succes, out methodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
           
            Console.WriteLine("\n");

            Console.ReadLine(); 
        }


    }
}
