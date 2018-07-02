using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumerLive
{
    class Program
    {


        static void Main(string[] args)
        {
            CBlockingQueue<int> cBlockingQueue = new CBlockingQueue<int>() { };

            Thread t1 = new Thread(_ => Producer.ProducerMaker(cBlockingQueue));
            Thread t2 = new Thread(_ => Producer.ProducerMaker(cBlockingQueue));
            Thread t3 = new Thread(_ => Producer.ProducerMaker(cBlockingQueue));
            Thread t4 = new Thread(_ => Consumer.ConsumerWriter(cBlockingQueue));
          //  Thread t5 = new Thread(_ => Consumer.ConsumerWriter(cBlockingQueue));

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
           // t5.Start();

            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
          //  t5.Join();
        }






    }
}


