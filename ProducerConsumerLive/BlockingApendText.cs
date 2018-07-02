//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ProducerConsumerLive
//{
//    class BlockingApendText
//    {
//        private readonly Queue<T[]> _queue = new Queue<T[]>();
//        private readonly Int32 _maxItems = 5;
//        public int count;



//        public void Enqueue(T[] value)
//        {
//            lock (_queue)
//            {
//                while (_queue.Count >= _maxItems)
//                    Monitor.Wait(_queue);

//                Monitor.PulseAll(_queue);
//                _queue.Enqueue(value);
//                count = _queue.Count;
//            }
//        }

//        public T[] Dequeue()
//        {
//            lock (_queue)
//            {
//                while (_queue.Count == 0)
//                    Monitor.Wait(_queue);

//                Monitor.PulseAll(_queue);
//                count = _queue.Count;
//                return _queue.Dequeue();

//            }
//        }

//        public void Clear()
//        {
//            lock (_queue)
//            {
//                _queue.Clear();
//                Console.WriteLine($"{nameof(CBlockingQueue<T>)}.{nameof(Clear)}: queue cleared.");
//                Monitor.PulseAll(_queue);
//                count = _queue.Count;
//            }
//        }
//    }
//}
