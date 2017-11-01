using System;

namespace AssociativeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            AssociativeArray test = new AssociativeArray(3);
            test.Add("pigeon", "pie");
            test.Add("pie", "pie");
            Console.Read();
        }
    }

    class AssociativeArray
    {
        public class Kvp
        {
            public string Key { get; set; }
            public string Value { get; set; }

            public Kvp(string key, string value)
            {
                Key = key;
                Value = value;
            }
        }

        public Kvp[] AArray { get; set; }
        public int CurrentCap { get; set; }

        public AssociativeArray(int size)
        {
            AArray = new Kvp[size];
        }

        public void Add(string key, string value)
        {
            int keyHash = key.GetHashCode();
            if(keyHash < 0)
            {
                keyHash = keyHash * -1;
            }
            int location = keyHash % AArray.Length;
            if (AArray[location] == null)
            {
                AArray[location] = new Kvp(key, value);
                CurrentCap++;
            }
            else
            {
                while (AArray[location] != null)
                {
                    if (AArray[location].Key == key)
                    {
                        return;
                    }
                    location++;
                    if (location >= AArray.Length)
                    {
                        Reallocate();
                        Add(key, value);
                    }
                }
            }
            if (CurrentCap > AArray.Length / 2)
            {
                Reallocate();
            }
        }

        public void Reallocate()
        {
            AssociativeArray temp = new AssociativeArray(AArray.Length * 2);
            for (int i = 0; i < AArray.Length; i++)
            {
                if (AArray[i] != null)
                {
                    temp.Add(AArray[i].Key, AArray[i].Value);
                }
            }
            AArray = temp.AArray;
        }
    }

}
