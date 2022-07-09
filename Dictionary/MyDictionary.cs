using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T,Z>
    {
        T[] _array1;
        Z[] _array2;
        T[] _tempArray1;
        Z[] _tempArray2;

        public MyDictionary()
        {
            _array1 = new T[0];
            _array2 = new Z[0];
        }
        public void Add(T item, Z item2)
        {
            _tempArray1 = _array1;
            _tempArray2 = _array2;
            _array1 = new T[_array1.Length + 1];
            _array2 = new Z[_array2.Length + 1];

            for (int i = 0; i < _tempArray1.Length; i++)
            {
                _array1[i] = _tempArray1[i];
            }

            _array1[_array1.Length - 1] = item;

            for (int i = 0; i < _tempArray2.Length; i++)
            {
                _array2[i] = _tempArray2[i];
            }
            _array2[_array2.Length - 1] = item2;

        }

       

        public int Length
        {
            get { return _array1.Length; }
        }

        public T[] Items
        {
            get { return _array1; }
        }

        public Z[] Itemss
        {
            get { return _array2; }
        }


    }
}
