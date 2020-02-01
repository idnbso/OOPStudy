using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Demo(string[] args)
        {
            var modifyPrice = new ModifyPrice();
            var product = new Product("Phone", 500);

            Execute(modifyPrice, new ProductCommand(product, PriceAction.Increase, 100));
           
            Execute(modifyPrice, new ProductCommand(product, PriceAction.Increase, 50));

            Execute(modifyPrice, new ProductCommand(product, PriceAction.Decrease, 2500));

            Console.WriteLine(product);
            Console.WriteLine();

            modifyPrice.UndoActions();
            Console.WriteLine(product);
        }

        private static void Execute(ModifyPrice modifyPrice, ICommand productCommand)
        {
            modifyPrice.SetCommand(productCommand);
            modifyPrice.Invoke();
        }
    }
}
