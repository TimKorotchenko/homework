using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    /*
    добавления элемента в словарь, 
    удаления элемента, 
    получения элемента по ключу, 
    получение списка всех ключей.
    */
    class Program
    {
        class MyClass
        {
            public string FName { get; set; }
            public string LName { get; set; }
            public int ID { get; set; }
        }

        static void Main(string[] args)
        {
            // обычный словарь
            var dictionary = new Dictionary<int, string>();

            dictionary.Add(33, "32f23divovv");
            dictionary.Add(13, "3e33");
            dictionary.Add(99, "kppp");

            dictionary.Remove(13);

            var e = dictionary.TryGetValue(33, out var value);

            var keys1 = dictionary.Keys;


            // мой v1
            //var applicationDictionary = new ApplicationDictionary<string, string>();

            //applicationDictionary.Add(33, "32f23divovv");
            //applicationDictionary.Add(13, "3e33");
            //applicationDictionary.Add(99, "kppp");

            //applicationDictionary.Remove(13);

            //var e2 = applicationDictionary.TryGetValue(33, out var value1);

            //var keys2 = applicationDictionary.Keys();

            // v2
            var applicationDictionary = new ApplicationDictionary<string, MyClass>();

            applicationDictionary.Add("32f23divovv", new MyClass { FName = "D", ID = 3, LName = "ff" });
            applicationDictionary.Add("7brmr0gbc", new MyClass { FName = "zzz", ID = 1, LName = "dcsdc" });
            applicationDictionary.Add("89898", new MyClass { FName = "icfiviv", ID = 999, LName = "fff" });

            applicationDictionary.Remove("89898");

            var e2 = applicationDictionary.TryGetValue("7brmr0gbc", out var value1);

            var keys2 = applicationDictionary.Keys();
        }

        public class ApplicationDictionary<TKey, TValue>
        {
            private class Entry
            {
                public TKey key;
                public TValue value;
                public int hashCode;
            }

            private List<Entry> entries = new List<Entry>();

            public void Add(TKey key, TValue value)
            {
                var hashCode = key.GetHashCode();

                var entry = new Entry
                {
                    key = key,
                    value = value,
                    hashCode = hashCode
                };

                entries.Add(entry);
            }

            public void Remove(TKey key)
            {
                var hashCode = key.GetHashCode();

                foreach (var entry in entries)
                {
                    if (entry.hashCode == hashCode)
                    {
                        entries.Remove(entry);
                        break;
                    }
                }
            }

            public bool TryGetValue(TKey key, out TValue value)
            {
                var hashCode = key.GetHashCode();

                foreach (var entry in entries)
                {
                    if (entry.hashCode == hashCode)
                    {
                        value = entry.value;
                        return true;
                    }
                }

                value = default(TValue);
                return false;
            }

            public TKey[] Keys()
            {
                var keys = entries.Select(x => x.key).ToArray();
                return keys;
            }
        }
    }
}
