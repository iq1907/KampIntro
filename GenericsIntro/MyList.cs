using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            tempArray.CopyTo(items, 0);

            //for (int i = 0; i < tempArray.Length; i++)
            //{
            //    items[i] = tempArray[i];
            //}
            
            items[items.Length - 1] = item;
        }

        public int MyProperty { get; set; }
        public int Length { get { return items.Length; } }
        public T[] Items { get { return items; } }
    }
}
