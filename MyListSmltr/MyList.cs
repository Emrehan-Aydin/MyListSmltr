using System;
using System.Collections.Generic;
using System.Text;

namespace MyListSmltr
{
    class MyList<T,U>
    {
        List<MyList<T,U>> MyDictionary;
        public MyList()
        {
            MyDictionary = new List<MyList<T, U>>();
        }
        public T Key { get; set; }
        public U Item { get; set; }
        public void Add(T key,U item)
        {
            MyDictionary.Add(new MyList<T, U> { Key = key, Item = item });
            ShowList();
            Console.WriteLine("{0} Numaralı Kullanıcı Eklendi. \n",key);
        }
        public void ShowList()
        {
            foreach (var item in MyDictionary)
            {
                Console.WriteLine("{0} {1}",item.Key,item.Item);
            }
        }
    }
}
