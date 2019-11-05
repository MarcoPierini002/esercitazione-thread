using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EsercizioTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //costruzione di un semplice task 
            var simpleTask = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("ciao da simpleTask");
            });

            //costruzione di un task con parametro in input
            var parameterTask = Task.Factory.StartNew(name)=>
                
        }
    }
}
