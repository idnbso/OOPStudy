using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.ViewEngineLibrary
{
    public class Client
    {
        public static void Run()
        {
            var productsController = new ProductsController();
            productsController.GetListProducts();
        }
    }
}
