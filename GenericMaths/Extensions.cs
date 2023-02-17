using System.Collections.Generic;
using System.Numerics;

namespace GenericMaths
{
    internal static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> source)
            where T : IMyAdditionOperators<T, T, T>, new()
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
