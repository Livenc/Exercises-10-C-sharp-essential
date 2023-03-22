using System.ComponentModel;
using System.Diagnostics;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("1", "2");
          
            Console.WriteLine(myDictionary["2"]);
            Console.ReadKey();

        }
        public class MyDictionary<TKey, TValue>
        {
            private List<MyStructList<TKey, TValue>> _items = new List<MyStructList<TKey, TValue>>();

            public void Add(TKey key, TValue value)
            {
                _items.Add(new MyStructList<TKey, TValue>(key, value));
            }

            public TValue this[TKey key]
            {
                get
                {
                    foreach (MyStructList<TKey, TValue> pair in _items)
                    {
                        if (pair.Key.Equals(key))
                        {
                            return pair.Value;
                        }
                    }
                    throw new KeyNotFoundException();
                }
            }

            public int Count
            {
                get { return _items.Count; }
            }
        }
        public readonly struct MyStructList<TKey, TValue>
        {
            
            private readonly TKey key;
            
            private readonly TValue value; 

            public MyStructList(TKey key, TValue value)
            {
                this.key = key;
                this.value = value;
            }

            public TKey Key { get { return key; } }

            public TValue Value { get { return value; } }

        }

    }
}