using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.ViewEngineLibrary
{
    abstract class Controller
    {
        public void Render(string viewName, IDictionary<string, object> context)
        {
            var engine = CreateViewEngine();
            var html = engine.Render(viewName, context);

            Console.WriteLine(html);
        }

        protected abstract IViewEngine CreateViewEngine();
    }
}
