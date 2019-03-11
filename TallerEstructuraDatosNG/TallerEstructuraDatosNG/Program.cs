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
       

        static void Main(string[] args)
        {
            ArrDataOpartor ArrO = new ArrDataOpartor(DataGenerator.PopulateArray(11,100,false), DataGenerator.PopulateArray(11, 100f, false), DataGenerator.PopulateArray(11));
            ListDataOperator LstO = new ListDataOperator(DataGenerator.PopulateList(11, 100, false), DataGenerator.PopulateList(11, 100f, false), DataGenerator.PopulateList(11));
            StackDataOperator StkO = new StackDataOperator(DataGenerator.PopulateStack(11, 100, false), DataGenerator.PopulateStack(11, 100f, false), DataGenerator.PopulateStack(11));
            QueueDataOperator QueO = new QueueDataOperator(DataGenerator.PopulateQueue(11, 100, false), DataGenerator.PopulateQueue(11, 100f, false), DataGenerator.PopulateQueue(11));

            //pruebas
            #region arrays 
            #region int Array
            //arreglo enteros 
            Console.WriteLine("se creo un arreglo de enteros con los datos :");
            Console.WriteLine(ArrO.ArrToString(ArrO.Ints));
            Console.WriteLine("\n");

            int[] intsMethodsOut;

            //perfect Shuffle
            Console.WriteLine("el arreglo se desordena perfectamente :");
            bool succes = false;
            ArrO.PerfectShuffle(1, out succes, out intsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(intsMethodsOut));
            Console.WriteLine("\n");

            //sort asending
            Console.WriteLine("el arreglo se ordena acxendente :");
            succes = false;
            ArrO.SortAscending( out succes, out intsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(intsMethodsOut));
            Console.WriteLine("\n");

            //shuffle
            Console.WriteLine("el arreglo se desordena :");
            succes = false;
            ArrO.Shuffle(out succes, out intsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(intsMethodsOut));
            Console.WriteLine("\n");

            //sort desending
            Console.WriteLine("el arreglo se ordena decendente :");
            succes = false;
            ArrO.SortDescending(out succes, out intsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(intsMethodsOut));
            Console.WriteLine("\n");

            //RemoveEven
            Console.WriteLine(" se le remueven impares :");
            succes = false;
            ArrO.RemoveEven( out succes, out intsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(intsMethodsOut));
            Console.WriteLine("\n");

            //Remove odds
            Console.WriteLine(" se le remueven pares :");
            succes = false;
            ArrO.RemoveOdds(out succes, out intsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(intsMethodsOut));
            Console.WriteLine("\n");

            Console.ReadLine();
            #endregion
            #region float Array
            //arreglo enteros 
            Console.WriteLine("se creo un arreglo de flotantes con los datos :");
            Console.WriteLine(ArrO.ArrToString(ArrO.Floats));
            Console.WriteLine("\n");

            float[] floatsMethodsOut;

            //perfect Shuffle
            Console.WriteLine("el arreglo se desordena perfectamente :");
            succes = false;
            ArrO.PerfectShuffle(1, out succes, out floatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(floatsMethodsOut));
            Console.WriteLine("\n");

            //sort asending
            Console.WriteLine("el arreglo se ordena ascendente :");
            succes = false;
            ArrO.SortAscending(out succes, out floatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(floatsMethodsOut));
            Console.WriteLine("\n");

            //shuffle
            Console.WriteLine("el arreglo se desordena :");
            succes = false;
            ArrO.Shuffle(out succes, out floatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(floatsMethodsOut));
            Console.WriteLine("\n");

            //sort desending
            Console.WriteLine("el arreglo se ordena decendente :");
            succes = false;
            ArrO.SortDescending(out succes, out floatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(floatsMethodsOut));
            Console.WriteLine("\n");

            //RemoveEven
            Console.WriteLine(" se le remueven impares :");
            succes = false;
            ArrO.RemoveEven(out succes, out floatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(floatsMethodsOut));
            Console.WriteLine("\n");

            //Remove odds
            Console.WriteLine(" se le remueven pares :");
            succes = false;
            ArrO.RemoveOdds(out succes, out floatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(floatsMethodsOut));
            Console.WriteLine("\n");

            Console.ReadLine();
            #endregion
            #region Itemslot Array
            //arreglo enteros 
            Console.WriteLine("se creo un arreglo de slots con los datos :");
            Console.WriteLine(ArrO.ArrToString(ArrO.Slots));
            Console.WriteLine("\n");

            Itemslot[] slotsMethodsOut;

            //perfect Shuffle
            Console.WriteLine("el arreglo se desordena perfectamente :");
            succes = false;
            ArrO.PerfectShuffle(1, out succes, out slotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(slotsMethodsOut));
            Console.WriteLine("\n");

            //sort asending
            Console.WriteLine("el arreglo se ordena ascendente :");
            succes = false;
            ArrO.SortAscending(out succes, out slotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(slotsMethodsOut));
            Console.WriteLine("\n");

            //shuffle
            Console.WriteLine("el arreglo se desordena :");
            succes = false;
            ArrO.Shuffle(out succes, out slotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(slotsMethodsOut));
            Console.WriteLine("\n");

            //sort desending
            Console.WriteLine("el arreglo se ordena decendente :");
            succes = false;
            ArrO.SortDescending(out succes, out slotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(slotsMethodsOut));
            Console.WriteLine("\n");

            //RemoveEven
            Console.WriteLine(" se le remueven impares :");
            succes = false;
            ArrO.RemoveEven(out succes, out slotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(slotsMethodsOut));
            Console.WriteLine("\n");

            //Remove odds
            Console.WriteLine(" se le remueven pares :");
            succes = false;
            ArrO.RemoveOdds(out succes, out slotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(ArrO.ArrToString(slotsMethodsOut));
            Console.WriteLine("\n");

            Console.ReadLine();
            #endregion
            #endregion

            #region Lists 
            #region int List
            //arreglo enteros 
            Console.WriteLine("se creo una lista de enteros con los datos :");
            Console.WriteLine(LstO.ListIntToString(LstO.Ints));
            Console.WriteLine("\n");

            List<int> lstIntsMethodsOut;

            //perfect Shuffle
            Console.WriteLine("la lista se desordena perfectamente :");
            succes = false;
            LstO.PerfectShuffle(1, out succes, out lstIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListIntToString(lstIntsMethodsOut));
            Console.WriteLine("\n");

            //sort asending
            Console.WriteLine("la lista se ordena acxendente :");
            succes = false;
            LstO.SortAscending(out succes, out lstIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListIntToString(lstIntsMethodsOut));
            Console.WriteLine("\n");

            //shuffle
            Console.WriteLine("la lista se desordena :");
            succes = false;
            LstO.Shuffle(out succes, out lstIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListIntToString(lstIntsMethodsOut));
            Console.WriteLine("\n");

            //sort desending
            Console.WriteLine("la lista se ordena decendente :");
            succes = false;
            LstO.SortDescending(out succes, out lstIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListIntToString(lstIntsMethodsOut));
            Console.WriteLine("\n");

            //RemoveEven
            Console.WriteLine(" se le remueven impares :");
            succes = false;
            LstO.RemoveEven(out succes, out lstIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListIntToString(lstIntsMethodsOut));
            Console.WriteLine("\n");

            //Remove odds
            Console.WriteLine(" se le remueven pares :");
            succes = false;
            LstO.RemoveOdds(out succes, out lstIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListIntToString(lstIntsMethodsOut));
            Console.WriteLine("\n");

            Console.ReadLine();
            #endregion
            #region float List
            //arreglo enteros 
            Console.WriteLine("se creo una lsita de flotantes con los datos :");
            Console.WriteLine(LstO.ListFloatToString(LstO.Floats));
            Console.WriteLine("\n");

            List<float> lstFloatsMethodsOut;

            //perfect Shuffle
            Console.WriteLine("la lista se desordena perfectamente :");
            succes = false;
            LstO.PerfectShuffle(1, out succes, out lstFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListFloatToString(lstFloatsMethodsOut));
            Console.WriteLine("\n");

            //sort asending
            Console.WriteLine("la lista se ordena ascendente :");
            succes = false;
            LstO.SortAscending(out succes, out lstFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListFloatToString(lstFloatsMethodsOut));
            Console.WriteLine("\n");

            //shuffle
            Console.WriteLine("la lista se desordena :");
            succes = false;
            LstO.Shuffle(out succes, out lstFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListFloatToString(lstFloatsMethodsOut));
            Console.WriteLine("\n");

            //sort desending
            Console.WriteLine("la lista se ordena decendente :");
            succes = false;
            LstO.SortDescending(out succes, out lstFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListFloatToString(lstFloatsMethodsOut));
            Console.WriteLine("\n");

            //RemoveEven
            Console.WriteLine(" se le remueven impares :");
            succes = false;
            LstO.RemoveEven(out succes, out lstFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListFloatToString(lstFloatsMethodsOut));
            Console.WriteLine("\n");

            //Remove odds
            Console.WriteLine(" se le remueven pares :");
            succes = false;
            LstO.RemoveOdds(out succes, out lstFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListFloatToString(lstFloatsMethodsOut));
            Console.WriteLine("\n");

            Console.ReadLine();
            #endregion
            #region Itemslot List
            //arreglo enteros 
            Console.WriteLine("se creo una lista de itemslots con los datos :");
            Console.WriteLine(LstO.ListSlotToString(LstO.Slots));
            Console.WriteLine("\n");

            List<Itemslot> lstSlotsMethodsOut;

            //perfect Shuffle
            Console.WriteLine("la lista se desordena perfectamente :");
            succes = false;
            LstO.PerfectShuffle(1, out succes, out lstSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListSlotToString(lstSlotsMethodsOut));
            Console.WriteLine("\n");

            //sort asending
            Console.WriteLine("la lista se ordena ascendente :");
            succes = false;
            LstO.SortAscending(out succes, out lstSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListSlotToString(lstSlotsMethodsOut));
            Console.WriteLine("\n");

            //shuffle
            Console.WriteLine("la lista se desordena :");
            succes = false;
            LstO.Shuffle(out succes, out lstSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListSlotToString(lstSlotsMethodsOut));
            Console.WriteLine("\n");

            //sort desending
            Console.WriteLine("la lista se ordena decendente :");
            succes = false;
            LstO.SortDescending(out succes, out lstSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListSlotToString(lstSlotsMethodsOut));
            Console.WriteLine("\n");

            //RemoveEven
            Console.WriteLine(" se le remueven impares :");
            succes = false;
            LstO.RemoveEven(out succes, out lstSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListSlotToString(lstSlotsMethodsOut));
            Console.WriteLine("\n");

            //Remove odds
            Console.WriteLine(" se le remueven pares :");
            succes = false;
            LstO.RemoveOdds(out succes, out lstSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(LstO.ListSlotToString(lstSlotsMethodsOut));
            Console.WriteLine("\n");

            Console.ReadLine();
            #endregion
            #endregion

            #region stacks
            #region Int stack
            //arreglo enteros 
            Console.WriteLine("se creo un stack de enteros con los datos :");
            Console.WriteLine(StkO.StackIntToString(StkO.Ints));
            Console.WriteLine("\n");

            Stack<int> stkIntsMethodsOut;

            //perfect Shuffle
            Console.WriteLine("el stack se desordena perfectamente :");
            succes = false;
            StkO.PerfectShuffle(1, out succes, out stkIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackIntToString(stkIntsMethodsOut));
            Console.WriteLine("\n");

            //sort asending
            Console.WriteLine("el stack se ordena acxendente :");
            succes = false;
            StkO.SortAscending(out succes, out stkIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackIntToString(stkIntsMethodsOut));
            Console.WriteLine("\n");

            //shuffle
            Console.WriteLine("el stack se desordena :");
            succes = false;
            StkO.Shuffle(out succes, out stkIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackIntToString(stkIntsMethodsOut));
            Console.WriteLine("\n");

            //sort desending
            Console.WriteLine("el stack se ordena decendente :");
            succes = false;
            StkO.SortDescending(out succes, out stkIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackIntToString(stkIntsMethodsOut));
            Console.WriteLine("\n");

            //RemoveEven
            Console.WriteLine(" se le remueven impares :");
            succes = false;
            StkO.RemoveEven(out succes, out stkIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackIntToString(stkIntsMethodsOut));
            Console.WriteLine("\n");

            //Remove odds
            Console.WriteLine(" se le remueven pares :");
            succes = false;
            StkO.RemoveOdds(out succes, out stkIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackIntToString(stkIntsMethodsOut));
            Console.WriteLine("\n");

            Console.ReadLine();

            #endregion
            #region Float stack
            //arreglo enteros 
            Console.WriteLine("se creo un stack de flotantes con los datos :");
            Console.WriteLine(StkO.StackFloatToString(StkO.Floats));
            Console.WriteLine("\n");

            Stack<float> stkFloatsMethodsOut;

            //perfect Shuffle
            Console.WriteLine("el stack se desordena perfectamente :");
            succes = false;
            StkO.PerfectShuffle(1, out succes, out stkFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackFloatToString(stkFloatsMethodsOut));
            Console.WriteLine("\n");

            //sort asending
            Console.WriteLine("el stack se ordena acxendente :");
            succes = false;
            StkO.SortAscending(out succes, out stkFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackFloatToString(stkFloatsMethodsOut));
            Console.WriteLine("\n");

            //shuffle
            Console.WriteLine("el stack se desordena :");
            succes = false;
            StkO.Shuffle(out succes, out stkFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackFloatToString(stkFloatsMethodsOut));
            Console.WriteLine("\n");

            //sort desending
            Console.WriteLine("el stack se ordena decendente :");
            succes = false;
            StkO.SortDescending(out succes, out stkFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackFloatToString(stkFloatsMethodsOut));
            Console.WriteLine("\n");

            //RemoveEven
            Console.WriteLine(" se le remueven impares :");
            succes = false;
            StkO.RemoveEven(out succes, out stkFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackFloatToString(stkFloatsMethodsOut));
            Console.WriteLine("\n");

            //Remove odds
            Console.WriteLine(" se le remueven pares :");
            succes = false;
            StkO.RemoveOdds(out succes, out stkFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackFloatToString(stkFloatsMethodsOut));
            Console.WriteLine("\n");

            Console.ReadLine();

            #endregion
            #region Itemslot stack
            //arreglo enteros 
            Console.WriteLine("se creo una lista de enteros con los datos :");
            Console.WriteLine(StkO.StackSlotToString(StkO.Slots));
            Console.WriteLine("\n");

            Stack<Itemslot> stkSlotsMethodsOut;

            //perfect Shuffle
            Console.WriteLine("la lista se desordena perfectamente :");
            succes = false;
            StkO.PerfectShuffle(1, out succes, out stkSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackSlotToString(stkSlotsMethodsOut));
            Console.WriteLine("\n");

            //sort asending
            Console.WriteLine("la lista se ordena acxendente :");
            succes = false;
            StkO.SortAscending(out succes, out stkSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackSlotToString(stkSlotsMethodsOut));
            Console.WriteLine("\n");

            //shuffle
            Console.WriteLine("la lista se desordena :");
            succes = false;
            StkO.Shuffle(out succes, out stkSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackSlotToString(stkSlotsMethodsOut));
            Console.WriteLine("\n");

            //sort desending
            Console.WriteLine("la lista se ordena decendente :");
            succes = false;
            StkO.SortDescending(out succes, out stkSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackSlotToString(stkSlotsMethodsOut));
            Console.WriteLine("\n");

            //RemoveEven
            Console.WriteLine(" se le remueven impares :");
            succes = false;
            StkO.RemoveEven(out succes, out stkSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackSlotToString(stkSlotsMethodsOut));
            Console.WriteLine("\n");

            //Remove odds
            Console.WriteLine(" se le remueven pares :");
            succes = false;
            StkO.RemoveOdds(out succes, out stkSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(StkO.StackSlotToString(stkSlotsMethodsOut));
            Console.WriteLine("\n");

            Console.ReadLine();

            #endregion

            #endregion

            #region Queue
            #region Int Queue
            //arreglo enteros 
            Console.WriteLine("se creo una cola de enteros con los datos :");
            Console.WriteLine(QueO.StackIntToString(QueO.Ints));
            Console.WriteLine("\n");

            Queue<int> QIntsMethodsOut;

            //perfect Shuffle
            Console.WriteLine("la cola se desordena perfectamente :");
            succes = false;
            QueO.PerfectShuffle(1, out succes, out QIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackIntToString(QIntsMethodsOut));
            Console.WriteLine("\n");

            //sort asending
            Console.WriteLine("la cola se ordena ascendente :");
            succes = false;
            QueO.SortAscending(out succes, out QIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackIntToString(QIntsMethodsOut));
            Console.WriteLine("\n");

            //shuffle
            Console.WriteLine("la cola se desordena :");
            succes = false;
            QueO.Shuffle(out succes, out QIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackIntToString(QIntsMethodsOut));
            Console.WriteLine("\n");

            //sort desending
            Console.WriteLine("la cola se ordena decendente :");
            succes = false;
            QueO.SortDescending(out succes, out QIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackIntToString(QIntsMethodsOut));
            Console.WriteLine("\n");

            //RemoveEven
            Console.WriteLine(" se le remueven impares :");
            succes = false;
            QueO.RemoveEven(out succes, out QIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackIntToString(QIntsMethodsOut));
            Console.WriteLine("\n");

            //Remove odds
            Console.WriteLine(" se le remueven pares :");
            succes = false;
            QueO.RemoveOdds(out succes, out QIntsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackIntToString(QIntsMethodsOut));
            Console.WriteLine("\n");

            Console.ReadLine();

            #endregion
            #region Float stack
            //arreglo enteros 
            Console.WriteLine("se creo una cola de flotantes con los datos : /n");
            Console.WriteLine(QueO.StackFloatToString(QueO.Floats));
            Console.WriteLine("\n");

            Queue<float> QFloatsMethodsOut;

            //perfect Shuffle
            Console.WriteLine("la cola se desordena perfectamente :");
            succes = false;
            QueO.PerfectShuffle(1, out succes, out QFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackFloatToString(QFloatsMethodsOut));
            Console.WriteLine("\n");

            //sort asending
            Console.WriteLine("la cola se ordena ascendente :");
            succes = false;
            QueO.SortAscending(out succes, out QFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackFloatToString(QFloatsMethodsOut));
            Console.WriteLine("\n");

            //shuffle
            Console.WriteLine("la cola se desordena :");
            succes = false;
            QueO.Shuffle(out succes, out QFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackFloatToString(QFloatsMethodsOut));
            Console.WriteLine("\n");

            //sort desending
            Console.WriteLine("la cola se ordena decendente :");
            succes = false;
            QueO.SortDescending(out succes, out QFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackFloatToString(QFloatsMethodsOut));
            Console.WriteLine("\n");

            //RemoveEven
            Console.WriteLine(" se le remueven impares :");
            succes = false;
            QueO.RemoveEven(out succes, out QFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackFloatToString(QFloatsMethodsOut));
            Console.WriteLine("\n");

            //Remove odds
            Console.WriteLine(" se le remueven pares :");
            succes = false;
            QueO.RemoveOdds(out succes, out QFloatsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackFloatToString(QFloatsMethodsOut));
            Console.WriteLine("\n");

            Console.ReadLine();

            #endregion
            #region Itemslot stack
            //arreglo enteros 
            Console.WriteLine("se creo una cola de Itemslots con los datos :");
            Console.WriteLine(QueO.StackSlotToString(QueO.Slots));
            Console.WriteLine("\n");

            Queue<Itemslot> QSlotsMethodsOut;

            //perfect Shuffle
            Console.WriteLine("la cola se desordena perfectamente :");
            succes = false;
            QueO.PerfectShuffle(1, out succes, out QSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackSlotToString(QSlotsMethodsOut));
            Console.WriteLine("\n");

            //sort asending
            Console.WriteLine("la cola se ordena ascendente :");
            succes = false;
            QueO.SortAscending(out succes, out QSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackSlotToString(QSlotsMethodsOut));
            Console.WriteLine("\n");

            //shuffle
            Console.WriteLine("la cola se desordena :");
            succes = false;
            QueO.Shuffle(out succes, out QSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackSlotToString(QSlotsMethodsOut));
            Console.WriteLine("\n");

            //sort desending
            Console.WriteLine("la cola se ordena decendente :");
            succes = false;
            QueO.SortDescending(out succes, out QSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackSlotToString(QSlotsMethodsOut));
            Console.WriteLine("\n");

            //RemoveEven
            Console.WriteLine(" se le remueven impares :");
            succes = false;
            QueO.RemoveEven(out succes, out QSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackSlotToString(QSlotsMethodsOut));
            Console.WriteLine("\n");

            //Remove odds
            Console.WriteLine(" se le remueven pares :");
            succes = false;
            QueO.RemoveOdds(out succes, out QSlotsMethodsOut);
            Console.WriteLine("se pudo completar la operacion ? " + succes);
            Console.WriteLine(QueO.StackSlotToString(QSlotsMethodsOut));
            Console.WriteLine("\n");

            Console.ReadLine();

            #endregion

            #endregion

            #region Dic
            #endregion


        }

    }
}
