using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //Constructor  ctor yaz tab tab
        public MyList()
        {
            items = new T[0];//0 elelmanlı bir dizi oluşturduk.
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];//dizinin elelman sayısını 1 arttırdık.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//Geçici arraydekileri eski diziye attık
            }
            items[items.Length - 1] = item;//sonuncu dizi elemanını item olarak tanımlıyoruz.
        }
    }
}
