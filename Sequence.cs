using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListConsoleApp
{
    class Sequence : IEnumerable<int>
    {
        private readonly int max;

        public Sequence(int max)
        {
            this.max = max;
        }
        public IEnumerator<int> GetEnumerator()
        {
            return new SequenceIterator(this.max);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
