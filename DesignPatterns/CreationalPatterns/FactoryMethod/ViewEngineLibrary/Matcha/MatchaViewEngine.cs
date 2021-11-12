using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.ViewEngineLibrary.Matcha
{
    class MatchaViewEngine : IViewEngine
    {
        public string Render(string viewName, IDictionary<string, object> context)
        {
            return "View rendered by Matcha";
        }
    }
}
