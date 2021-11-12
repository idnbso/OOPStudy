using System.Collections.Generic;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.ViewEngineLibrary
{
    interface IViewEngine
    {
        string Render(string viewName, IDictionary<string, object> context);
    }
}