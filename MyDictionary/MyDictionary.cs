using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {

        TKey[] key;
        TValue[] value;

        public MyDictionary()
        {
            key = new TKey[0];
            value = new TValue[0];

        }
        public void Add(TKey item1, TValue item2)
        {

            TKey[] temparraykey = key;
            TValue[] temparrayvalues = value;

            key = new TKey[key.Length + 1];
            value = new TValue[value.Length + 1];
            for (int i = 0; i < temparraykey.Length; i++)
            {
                key[i] = temparraykey[i];
                value[i] = temparrayvalues[i];
            }
            key[key.Length - 1] = item1;
            value[value.Length - 1] = item2;

            Console.WriteLine(item1 + " numaralı  " + item2 + " adlı kullanıcı sistemde aktifleştirildi");
        }

          public int Count //dizi uzunluğunu görürüm
        {
            get { return key.Length; }

            
        }
        public TKey[] Keys//key leri görürüm
        {
            get { return key; }
            
        }
        public TValue[] Values//valuesleri görürüm
        {
            get { return value; }

        }

    }
}

