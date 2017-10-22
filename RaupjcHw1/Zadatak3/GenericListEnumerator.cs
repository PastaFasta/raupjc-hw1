using System.Collections;
using System.Collections.Generic;

namespace Zadatak3
{
    public class GenericListEnumerator<T> : IEnumerator<T>
    {

        public GenericListEnumerator(GenericList<T> genericList)
        {
            
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public T Current { get; }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }

}