using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEstructuraDatosNG.Clases
{
    public interface IDataOperator<T>
    {
        void SortAscending(out bool success, out T t);
        void SortDescending(out bool success, out T t);
        void Shuffle(out bool success, out T t);
        void RemoveOdds(out bool success, out T t);
        void RemoveEven(out bool success, out T t);
        void PerfectShuffle(int iterations, out bool success, out T t);

        

    }
}
