using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        T[] _tempArray;
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                items[i] = _tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
