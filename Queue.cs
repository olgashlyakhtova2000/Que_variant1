using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Очередь_вариант_1
{
    public class Queue: IEnumerable
    {
        public Node front;
        public Node rear;
        public int count { get; private set; }
        public Queue()
        {

        }
        public void Enqeue(int x)
        {
            var t = new Node(x);
            if (rear == null)
            {
                front = rear = t;
            }
            rear.next = t;
            rear = t;
            count++;
        }
        public void Deqeue()
        {
            if (front == null)
                return;
            var t = front;
            front = front.next;
            if (front == null)
                rear = null;
            count--;
        }
        public IEnumerator GetEnumerator()
        {
            Node curr = front;
            for (int i = 1; curr != null; i++)
            {
                string s = Convert.ToString(i);
                s += ". ";
                s += Convert.ToString(curr.key);
                yield return s;
                curr = curr.next;

            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public int this[int i]
        {
            get
            {
                return front.key;
            }
            set
            {
                front.key = value;
            }

        }
    }
}
