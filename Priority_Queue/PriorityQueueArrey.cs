using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Queue
{
    public class PriorityQueueArrey
    {
        Model[] array;
        int rear = -1;

        public PriorityQueueArrey(int length)
        {
            array = new Model[length];
        }

        public bool IsFull()
        {
            if (rear >= array.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEmpty()
        {
            if (rear == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Enqueue(string value, int priortiy)
        {
            if (IsFull())
            {
                Console.WriteLine("Full ...");
            }
            else
            {
                var NewNode = new Model(value, priortiy);
                rear++;
                array[rear] = NewNode;
            }
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty ...");
            }
            else
            {
                int PopedItemindex = 0;
                for (int i = 0; i < rear; i++)
                {
                    if (array[i].Priortiy >= array[i + 1].Priortiy)
                    {
                        PopedItemindex = i + 1;
                    }
                }
                var minimumItem = "Poped item : " + array[PopedItemindex].Value
                + " " + array[PopedItemindex].Priortiy;
                Console.WriteLine(minimumItem);

                for (int i = PopedItemindex; i < rear - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                rear--;
            }
        }

        public void PrintElement() 
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty ...");
            }
            else
            {
                for (int i = 0; i < rear; i++)
                {
                    var x = "Items:\n" + array[i].Value + " " + array[i].Priortiy;
                    Console.WriteLine(x);
                }
            }
        }
    }




    public class Model
    {
        public string Value { get; private set; }
        public int Priortiy { get; set; }
        public Model(string value, int priortiy)
        {
            Value = value;
            Priortiy = priortiy;
        }
    }
}
