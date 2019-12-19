using System;
using System.Collections;
using System.Collections.Generic;

namespace ListConsoleApp
{
    class SequenceIterator : IEnumerator<int>
    {
        private readonly int max;
        private int current;
        public SequenceIterator(int max)
        {
            this.max = max;

        }
        public int Current
        {
            get
            {
                if (this.current <= 0)
                    throw new InvalidOperationException();
                return this.current;
            }
        }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if (this.current >= this.max)
                return false;

            this.current++;
            return true;
        }

        public void Reset()
        {
            this.current = 0;
        }
    }
}
