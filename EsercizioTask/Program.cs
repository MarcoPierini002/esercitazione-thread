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
            var parameterTask = Task.Factory.StartNew((name) =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("ciao da parameterTask,{0}", name);
            }, "Matteo Tumiati");

            //costruzione di un task che ritorna un risultato

            var resulutTask = Task.Factory.StartNew((inputValue) =>
            PerformSomeLongCalculation(inputValue), 5000D);
            resulutTask.Start();
                
                

                
        }

        private static void PerformSomeLongCalculation(object inputValue)
        {
            throw new NotImplementedException();
        }
    }
}
