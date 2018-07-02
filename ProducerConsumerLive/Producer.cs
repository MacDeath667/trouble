using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumerLive
{
    class Producer
    {
        public int[] inputNumbers = new int[2];

        public static void ProducerMaker(CBlockingQueue<int> cBlockingQueue)
        {
            for (int i = 1; ; i++)
            {
                cBlockingQueue.Enqueue(RandArr());
                if (i.Equals(10))
                    return;
            }
        }

        public Producer(int a, int b)
        {
            inputNumbers[0] = a;
            inputNumbers[1] = b;
        }

        public static int[] RandArr()
        {
            int[] randArr = new int[2];
            randArr[0] = DateTime.Now.Millisecond + DateTime.Now.Second;
            Thread.Sleep(60);
            randArr[1] = DateTime.Now.Millisecond + DateTime.Now.Second;
            return randArr;
        }
    }
}
