using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNomad.Translitter
{
    public class CustomStringBuilder
    {
        private readonly char[] _array;
        private int _index;

        public CustomStringBuilder(int capacity)
        {
#if NET45 || NETSTANDARD1_3
            _array = ArrayPool<char>.Shared.Rent(capacity);
#else
            _array = new char[capacity];
#endif
            _index = 0;
        }

        public void Append(char c)
        {
            _array[_index++] = c;
        }

        public override string ToString()
        {
            return new string(_array, 0, _index);
        }

        public void Dispose()
        {
#if NET45 || NETSTANDARD1_3
            ArrayPool<Char>.Shared.Return(_array);
#endif
        }
    }
}
