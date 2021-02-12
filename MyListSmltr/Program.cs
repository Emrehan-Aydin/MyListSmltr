using System;

namespace MyListSmltr
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> MyDictionary = new MyList<int, string>();
            MyDictionary.Add(1, "Emrehan");
            MyDictionary.Add(2, "Burak");
            MyDictionary.Add(3, "Emre");
            MyDictionary.Add(4, "Onur");
            MyDictionary.Add(5, "Halil");
            MyDictionary.Add(6, "Engin");
        }
    }
}
