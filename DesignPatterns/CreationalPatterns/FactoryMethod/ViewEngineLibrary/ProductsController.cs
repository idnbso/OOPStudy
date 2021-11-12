using DesignPatterns.CreationalPatterns.FactoryMethod.ViewEngineLibrary.Matcha;
using DesignPatterns.CreationalPatterns.FactoryMethod.ViewEngineLibrary.Sharp;
using System;
using System.Collections.Generic;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.ViewEngineLibrary
{
    sealed class ProductsController : SharpController
    {
        public void GetListProducts()
        {
            Console.WriteLine("Get products from a database.");

            var context = new Dictionary<string, object>();

            Render(viewName: "products.html", context);
        }
    }
}
