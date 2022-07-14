using System.Collections;

namespace YieldInCsharp.OurCompilerSyntacticSugers
{
    internal class RundomNumberClass : IEnumerable<int>, IEnumerator<int>
    {
        private readonly Random _random;
        private readonly int _count;
        private int _counter;
        private int _current;
        private int _state;

        public RundomNumberClass(int count)
        {
            _count = count;
            _random = new Random(Guid.NewGuid().GetHashCode());
        }

        public IEnumerator<int> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // this call will call non explicit specific member
            return GetEnumerator();
        }

        // This is how compiler implement it
        //public bool MoveNext()
        //{
        //    switch (_state)
        //    {
        //        case 0:
        //            {
        //                _counter = 0;
        //                goto case 1;
        //            }
        //        case 1:
        //            {
        //                _state = 1;
        //                if (_counter >= _count)
        //                    return false;

        //                _current = _random.Next();
        //                _state = 2;
        //                return true;
        //            }
        //        case 2:
        //            {
        //                _counter++;
        //                goto case 1;
        //            }
        //        default: return true;
        //    }
        //}

        public bool MoveNext()
        {
            if (_counter >= _count)
                return false;

            if (_counter == 0)
            {
                _current = _random.Next();
                _counter++;
                return true;
            }

            _current = _random.Next();
            _counter++;

            return true;
        }

        public int Current => _current;

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose() { }

        object IEnumerator.Current => this.Current;
    }
}