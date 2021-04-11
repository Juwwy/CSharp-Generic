using System;
namespace IntergenicResearchLibraryTest
{
    public class GenericDefaulterList<T>
    {
        private const int DEFAULTSIZE = 100;
        private T[] record;

        private int numLen;
        private int head = 0;

        private int tail = 0;

        public GenericDefaulterList()
        {
            record = new T[DEFAULTSIZE];
        }

        public void Enqueue(T item)
        {
            if(numLen == record.Length)
            {
                throw new System.Exception("Record is full");
            }
            record[head] = item;
            head++;
            numLen++;
        }

        public T Dequeue()
        {
            if(numLen == 0)
            {
                throw new System.Exception("Record is empty");
            }
            T item = record[tail];
            tail++;
            numLen--;
            return item;
        }
    }
}