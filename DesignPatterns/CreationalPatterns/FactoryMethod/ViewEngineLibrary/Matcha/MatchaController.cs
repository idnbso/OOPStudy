using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.ViewEngineLibrary.Matcha
{
    class MatchaController : Controller
    {
        protected override IViewEngine CreateViewEngine()
        {
            return new MatchaViewEngine();
        }
    }
}
