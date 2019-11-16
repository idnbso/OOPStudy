using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.SpecialCaseDemo
{
    class VoidWarranty : IWarranty
    {
        [ThreadStatic]
        private static VoidWarranty _value;

        private VoidWarranty() { }

        public static VoidWarranty Value
        {
            get
            {
                if (_value == null)
                {
                    _value = new VoidWarranty();
                }
                return _value;
            }
        }

        public void Claim(DateTime date, Action onValidClaim) { }

        private bool IsValidOn(DateTime date) => false;
    }
}
