using System.Data;
using static Exercise_4.Program;

namespace Exercise_4
{
   
    internal static class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            var kil = GetArray<int>(list);
            foreach (var item in kil)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(list[3]);
            Console.ReadLine();
        }
        public static T[] GetArray<T>(this MyList<T> list)
        {

            T[] values = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                values[i] = list[i];
            }
            return values;
        }
        public class MyList<T>
        {
            private T[] _arrayValue = Array.Empty<T>();

            public T this[int index]
            {
                get
                {
                    return _arrayValue[index];
                }
                set
                {
                    _arrayValue[index] = value;
                }
            }
            public void Add(T value)
            {
                var arrayTemp = new T[_arrayValue.Length + 1];
                for (int i = 0; i < _arrayValue.Length; i++)
                {
                    arrayTemp[i] = _arrayValue[i];
                }
                arrayTemp[_arrayValue.Length] = value;
                _arrayValue = arrayTemp;
            }

          

            public int Count { get { return _arrayValue.Length; } }

        }
    }
}