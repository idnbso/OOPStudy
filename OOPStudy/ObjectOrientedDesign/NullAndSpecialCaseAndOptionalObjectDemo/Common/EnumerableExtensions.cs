using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Common
{
    static class EnumerableExtensions
    {
        public static void Do<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            foreach (T obj in sequence)
            {
                action(obj);
            }
        }
    }
}
