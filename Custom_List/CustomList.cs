using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    public class CustomList<T>
    {
        private T[] items;
        private int count;
        private int capacity;
        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];

             
        }
        
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
       
 
        public void Add(T item)
        {
            if (count == capacity)
            {
                Expand();
            }
            items[count] = item;
            count++; 
        }
        public void Remove(T item)
        {
            for (int i = 0; i <= count; i++)
            {
                if (item.Equals(items[i]))
                {
                    items[i] = default(T);
                    Compress(i);
                    i = count + 1;
                }
            }
        }

        private void Expand()
        {
            T[] itemHolder = new T[capacity];
            itemHolder = items;
            capacity *= 2;
            items = new T[capacity];
            for (int i = 0; i<= count-1; i++)
            {
                items[i] = itemHolder[i];
            }
        }
        private void Compress(int position)
        {
            int a = 0;
            T[] itemHolder = new T[capacity];
            for(int i = 0; i <= count-1; i++)
            {
                if (i == position)
                {
                    itemHolder[i] = items[i + 1];
                    a++;
                }
                itemHolder[i] = items[a];
                a++;
            }
            for(int i = 0; i <= count; i++)
            {
                items[i] = itemHolder[i];
            }
            count--;
        }

        public override string ToString()
        {
            string listString=null;
            for(int i = 0; i <= count-1; i++)
            {
                T value = items[i];
                value.ToString();
                listString += value + " ";
            }
            return listString;
        }
        //public CustomList<T> zipper(T list)
        //{

        //}

    }
}
