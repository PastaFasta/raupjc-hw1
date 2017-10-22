using System;

namespace Zadatak1
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int _count = -1;

        public IntegerList()
        {
            _internalStorage = new int[4];
        }

        public IntegerList(int initialSize)
        {
            if(initialSize < 0)
            {
                initialSize= Math.Abs(initialSize);
            }
            _internalStorage = new int[initialSize];
        }
        
        public int Count
        {
            get
            {
                return _count+1;
            }
        }
        #region IIntegerList
        public void Add(int item)
        {
            _count++;
            if (_count >= _internalStorage.Length)
            {
                Array.Resize(ref _internalStorage, _internalStorage.Length * 2);
            }
            _internalStorage[_count] = item;
        }

        public void Clear()
        {
            _count = -1;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i <= _count; i++)
            {
                if (_internalStorage[i] == item)
                    return true;
            }
            return false;
        }

        public int GetElement(int index)
        {
            if(index <= _count)
            {
                return _internalStorage[index];
            }
            else
            {
                throw new System.IndexOutOfRangeException();
            }
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i <= _count; i++)
            {
                if (_internalStorage[i] == item)
                    return i;
            }
            return -1;
        }

        public bool Remove(int item)
        {
            for (int i = 0; i <= _count; i++)
            {
                if(_internalStorage[i] == item)
                {
                    return (RemoveAt(i));
                }
            }
            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index > _count)
            {
                throw new IndexOutOfRangeException();
            }
            _count--;
            for (int i = index; i <= _count; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            return true;
        }
        #endregion IIntegerList
    }
}