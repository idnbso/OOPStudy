using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Common
{
    class Option<T> : IEnumerable<T>
    {
        private IEnumerable<T> Content { get; }

        private Option(IEnumerable<T> content)
        {
            this.Content = content;
        }

        public static Option<T> Some(T value) => new Option<T>(new T[] { value });

        public static Option<T> None() => new Option<T>(new T[0]);

        public IEnumerator<T> GetEnumerator() => this.Content.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
