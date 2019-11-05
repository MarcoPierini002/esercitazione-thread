using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace esercitazione_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread myThread = new Thread(() =>
            //{
            //    Console.WriteLine("MyThread è iniziato");
            //    Thread.Sleep(1000);
            //    Console.WriteLine("MyThread è terminato");
            //});

            ////esecuzione di mythread
            //myThread.Start();

            //Thread.Sleep(500);
            //Console.WriteLine("main thread");


            //Console.WriteLine();


            //string someVariabile = "matteo Tumiati";

            //var workerThread = new Thread((o) =>
            // {
            //     Console.WriteLine("saluti da :{0}", someVariabile);
            // });


            //Console.WriteLine();



            //var list = new List<Thread>();
            ////qui creiamo ed eseguiamo cinque worker thread 
            //for (int index = 0 ; index < 5 ; index++)
            //{
            //    var myThread = new Thread((currentIndex) =>
            //   {
            //       Console.WriteLine("thread {0} è iniziato", currentIndex);
            //       Thread.Sleep(500);
            //       Console.WriteLine("thread {0} è terminato", currentIndex);
            //   });
            //    myThread.Start(index);
            //    list.Add(myThread);
            //}
            ////attesa  del completamento di ognuno dei worker thread 
            //foreach(Thread thread in list)
            //{
            //    thread.Join();
            //}
            //Console.WriteLine("esecuzione di tutti i therad terminata");

            var workerThread = new Thread(() =>
            {
                Console.WriteLine("inizio di un thread molto lungo");
                Thread.Sleep(5000);
                Console.WriteLine("termine worker thread");
            });

            workerThread.Start();
            workerThread.Join(500);

            //se il worker thread è ancora in esecuzione lo si cancella
            if (workerThread.ThreadState !=ThreadState.Stopped)
            {
                workerThread.Abort();
            }
            Console.WriteLine("termine applicazione");

            var workerthread = new Thread(() =>
           {
               try
               {
                   Console.WriteLine("inizio di un thread molto lungo");
                   Thread.Sleep(5000);
                   Console.WriteLine("termine worker thread");
               }
               catch (ThreadAbortException ex)
               {
                    //qui va messo il codice dell'eccezione
                }
           });

            workerThread.IsBackground = false;
            workerThread.Priority = ThreadPriority.Lowest;

            Console.ReadLine();
        }
    }
}
