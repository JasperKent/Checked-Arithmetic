using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaths
{
    internal static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> source)
            where T : IAdditionOperators<T, T, T>, new()
        {
            T sum = new();

            foreach (var item in source)
            {
                sum += item;
            }

            return sum;
        }
    }
}
