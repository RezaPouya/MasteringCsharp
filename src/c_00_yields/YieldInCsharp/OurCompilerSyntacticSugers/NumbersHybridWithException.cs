using System.Collections;

namespace YieldInCsharp.OurCompilerSyntacticSugers
{
    internal class NumbersHybridWithException : IEnumerable<int>, IEnumerator<int>
    {
        private int _current;
        private int _state;

        public IEnumerator<int> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool MoveNext()
        {
            switch (_state)
            {
                default: return false;
                case 0:
                    {
                        Console.WriteLine("Begin");
                        Console.WriteLine("yielding 1");
                        _current = 1;
                        _state = 1;
                        return true;
                    }
                case 1:
                    {
                        Console.WriteLine("yielding 4");
                        throw new Exception("kaboom");
                        _current = 4;
                        _state = 2;
                        return true;
                    }
                case 2:
                    {
                        Console.WriteLine("yielding 2");
                        _current = 2;
                        _state = 3;
                        return true;
                    }
                case 3:
                    {
                        Console.WriteLine("End !!! ");
                        return false;
                    }
            }
        }

        public int Current => _current;

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        { }

        object IEnumerator.Current => this.Current;
    }
}