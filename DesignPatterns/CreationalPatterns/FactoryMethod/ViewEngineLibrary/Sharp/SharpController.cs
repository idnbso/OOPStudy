using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.ViewEngineLibrary.Sharp
{
    class SharpController : Controller
    {
        protected override IViewEngine CreateViewEngine()
        {
            return new SharpViewEngine();
        }
    }
}
