using System;
using System.Collections.Generic;
using System.Text;

namespace MyListSmltr
{
    class MyList<U,V>
    {
        U[] Key;
        V[] Value;
        
        public MyList()
        {
            Key = new U[0];
            Value = new V[0];
        }
        
        public void Add(U key,V value)
        {
            Console.WriteLine("\n{0} Numaralı Kullanıcı Eklendi!", key);
            
            U[] TmpKey = Key;
            V[] TmpValue = Value;
            
            Key = new U[Key.Length+1];
            Value = new V[Value.Length+1];
            
            for (int i = 0; i < TmpKey.Length; i++)
            {
                Key[i] = TmpKey[i];           
                Value[i] = TmpValue[i];           
            }
            
            Key[Key.Length-1] = key;
            Value[Value.Length-1] = value;
            ShowList(); 
        }
        
        public void ShowList()
        {
            for (int i = 0; i < Key.Length; i++)
            {
                Console.WriteLine("{0} {1}", Key[i],Value[i]);
            }
        }
    }
}
