using System;
using System.Collections;
using System.Collections.Generic;

namespace MyHashTable
{
    class MyHashTable
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,3,2};

            Hashtable map = new Hashtable();

            foreach(int a in arr)
            {
                if(map.ContainsKey(a) == false)
                {
                    map.Add(a, 1);
                }
                else
                {
                    int count = map.Count;
                    count++;
                    map.Add(a,count);
                }
            }
        }
    }
}
