using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumerLive
{
    public class Consumer
    {
        private int _solution;

        public int ConsumerSolute(int[] inputArgs)
        {
            _solution = inputArgs.Sum();
            return _solution;
        }

        public static void ConsumerWriter(CBlockingQueue<int> cBlockingQueue)
        {
            int i = 1;
           while (true)
            {
                
                string[] stream = new string[1];
                stream[0] = cBlockingQueue.Dequeue().Sum().ToString();
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Thread.Sleep(5);
                Console.WriteLine($"Обработано: {i}");
                i++;
               // File.AppendAllText("text.txt", stream[0]);
            }
        }
    }
}
