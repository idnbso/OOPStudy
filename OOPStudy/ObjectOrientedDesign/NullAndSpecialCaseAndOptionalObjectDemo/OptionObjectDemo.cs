using OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo
{
    class OptionObjectDemo
    {
        static void Demo()
        {
            Option<string> name = Option<string>.Some("something");

            /// Pattern Matching Demo
            //name
            //    .When(s => s.Length > 3).Do(s => Console.WriteLine($"{s} long"))
            //    .WhenSome().Do(s => Console.WriteLine($"{s} short"))
            //    .WhenNone().Do(() => Console.WriteLine("missing"))
            //    .Execute();

            //string label =
            //    name
            //        .When(s => s.Length > 3).MapTo(s => s.Substring(0, 3))
            //        .WhenSome().MapTo(s => s)
            //        .WhenNone().MapTo("<empty>")
            //        .Map();


            Console.ReadLine();
        }
    }
}
