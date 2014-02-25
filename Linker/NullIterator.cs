using System.Collections;

namespace Linker
{
    public class NullIterator : IEnumerator
    {
        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public object Current
        {
            get { return null; }
        }
    }
}