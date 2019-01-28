using System;

namespace NameSorter
{
    public class Asset<T> : IComparable<string>
    {
        private readonly string Data;

        public Asset(string data)
        {
            Data = data;
        }

        public int CompareTo(string other)
        {
            return this.CompareTo(other);
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
