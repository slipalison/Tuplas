using System;
using System.Collections.Generic;

namespace Tuplas
{
    public static class EnumerableExtensions
    {
        public static (T min, T max) MinMax<T>(this IEnumerable<T> source) where T : IComparable<T>
        {
            using (var iterator = source.GetEnumerator())
            {
                if (!iterator.MoveNext())
                {
                    throw new InvalidOperationException("Cannot find min/max of an empty sequence.");
                }
      
                var result = (min: iterator.Current, max: iterator.Current);
                while (iterator.MoveNext())
                {
                    if (iterator.Current.CompareTo(result.min) < 0) result.min = iterator.Current;
                    if (iterator.Current.CompareTo(result.max) > 0) result.max = iterator.Current;
                }
                return result;
            }
        }
    }
}
