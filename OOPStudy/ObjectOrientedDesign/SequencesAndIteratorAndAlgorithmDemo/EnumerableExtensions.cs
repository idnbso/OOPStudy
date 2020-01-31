using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPStudy.SequencesDemo
{
    public static class EnumerableExtensions
    {
        public static T WithMinimum<T, TKey>(this IEnumerable<T> sequence, Func<T, TKey> predicate)
                where T : class
                where TKey : IComparable<TKey> =>
                    sequence
                        .Select(obj => Tuple.Create(obj, predicate(obj)))
                        .Aggregate((Tuple<T, TKey>)null, (min, cur) => min == null || cur.Item2.CompareTo(min.Item2) < 0 ? cur : min)
                        .Item1;
    }
}
