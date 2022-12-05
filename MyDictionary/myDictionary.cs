using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class myDictionary<key, value>
    {
        key[] k;
        value[] v;

        public myDictionary()
        {
            k = new key[0];
            v = new value[0];
        }
        public void Add(key key, value value)
        {
            key[] ktemparray = k;
            k = new key[k.Length + 1];
            value[] vtemparray = v;
            v = new value[v.Length + 1];
            for (int i = 0; i < ktemparray.Length; i++)
            {
                k[i] = ktemparray[i];
                v[i] = vtemparray[i];
            }
            v[v.Length - 1] = value;
            k[k.Length - 1] = key;
        }
        public int Length
        {
            get { return v.Length; }

        }
    }

}
