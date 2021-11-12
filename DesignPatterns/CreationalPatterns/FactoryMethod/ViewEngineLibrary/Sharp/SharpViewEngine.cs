using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.ViewEngineLibrary.Sharp
{
    class SharpViewEngine : IViewEngine
    {
        public string Render(string viewName, IDictionary<string, object> context)
        {
            return "View rendered by Sharp";
        }
    }
}
