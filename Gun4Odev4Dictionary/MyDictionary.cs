using System;
using System.Collections.Generic;
using System.Text;

namespace Gun4Odev4Dictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        TKey[] tempKeys;
        TValue[] tempValues;
        public void Add(TKey key, TValue value)
        {
            tempKeys = keys;
            tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
           
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public int Count
        {
            get { return keys.Length; }
        }
       
    }
}
