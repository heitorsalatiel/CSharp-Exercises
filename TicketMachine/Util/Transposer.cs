using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachine.Util
{
    public static class Transposer
    {
        public static IEnumerable<IEnumerable<T>> ToTwoDimensionalCollection<T>(this IEnumerable<T> collection,int columnsNumber)
        {
            List<T> row = new List<T>(columnsNumber);
            foreach (T item in collection)
            {
                row.Add(item);
                if (row.Count == columnsNumber)
                {
                    yield return row;
                    row = new List<T>(columnsNumber);
                }
            }
            if (row.Count > 0)
                yield return row;
        }
    }
}
