using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4_2
{
    public class NameObjectNameComparer : IComparer<NameObject>
    {
        private StringComparer _comparer = StringComparer.CurrentCulture;
        public NameObjectNameComparer(StringComparer? comparer = null) 
        { 
            if (comparer != null)
            {
                _comparer = comparer;
            }
        }
        public int Compare (NameObject x, NameObject y)
        {
            return _comparer.Compare(x?.Name, y?.Name);
        }
       
        public class NameObjectCollection<T> : IList<T> where T : NameObject 
        {
            private List<NameObject> _innerList = new List<NameObject> ();
            private NameObjectNameComparer _comparer = new NameObjectNameComparer();

            public int Count => throw new NotImplementedException();

            public bool IsReadOnly => throw new NotImplementedException();

            public T this[int index]
            {
                get => (T)_innerList[index];
                set => _innerList[index] = value;
            }

            public void SortByName(StringComparer? nameComparer = null) 
            {  
                _innerList.Sort(new NameObjectNameComparer(nameComparer));
            }

            public void Add(T item)
            {
                _innerList.Add(item);
            }

            public void OutputNamesToConsole()
            {
                var builder = new StringBuilder($"Names:{Environment.NewLine}");
                foreach ( var currenrObject in _innerList )
                { 
                    builder.Append( currenrObject.Name );
                    builder.Append(Environment.NewLine);
                }
                Console.WriteLine(builder);                    
            }

            public int IndexOf(T item)
            {
                throw new NotImplementedException();
            }

            public void Insert(int index, T item)
            {
                throw new NotImplementedException();
            }

            public void RemoveAt(int index)
            {
                throw new NotImplementedException();
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public bool Contains(T item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(T[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            public bool Remove(T item)
            {
                throw new NotImplementedException();
            }

            public IEnumerator<T> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    }
}
