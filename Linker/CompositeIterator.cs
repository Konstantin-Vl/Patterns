using System.Collections;

namespace Linker
{
    public class CompositeIterator : IEnumerator
    {
        private readonly Stack _stack = new Stack();
   
        public CompositeIterator(IEnumerator enumerator)
        {
            _stack.Push(enumerator);
        }

        public bool MoveNext()
        {
            if (_stack.Count == 0)
                return false;

            var enumerator = (IEnumerator)_stack.Peek();
            if (enumerator.MoveNext()) return true;
            _stack.Pop();

            return MoveNext();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public object Current
        {
            get
            {
                if (!MoveNext()) return null;
                
                var enumerator = (IEnumerator) _stack.Peek();
                var component = (MenuComponent) enumerator.Current;
                if(component is Menu)
                    _stack.Push(component.GetEnumerator());
                return component;
            }
        }
    }
}
