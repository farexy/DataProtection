using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSecurity
{
    public class Alphabet
    {
        private readonly string _alphabet;

        public Alphabet(string alphabet)
        {
            _alphabet = alphabet;
        }

        public int this[char i]
        {
            get
            {
                int res = _alphabet.IndexOf(i);
                if (res == -1)
                {
                    throw new IndexOutOfRangeException();
                }
                return res;
            }
        }

        public char this[int i]
        {
            get
            {
                return _alphabet[i];
            }
        }

        public int Length
        {
            get
            {
                return _alphabet.Length;
            }
        }
    }
}
