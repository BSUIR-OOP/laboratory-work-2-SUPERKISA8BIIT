using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    public class ListOfFigures: IList<Figure>
    {

        private readonly List<Figure> _collection;
        public int _count ;
        public ListOfFigures(params Figure[] shapes)
        {
            _collection = new List<Figure>(shapes);
        }

        public Figure this[int index] { get =>_collection[index]; set => _collection[index]=value; }

        public int Count => _collection.Count;

        public bool IsReadOnly => false;

        public void Add(Figure item)
        {
          _collection.Add(item);
        }

        public void Clear()
        {
            _collection.Clear();
        }

        public bool Contains(Figure item)
        {
            return _collection.Contains(item);
        }

        public void CopyTo(Figure[] array, int arrayIndex)
        {
            _collection.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Figure> GetEnumerator()
        {
            return _collection.GetEnumerator();
        }

        public int IndexOf(Figure item)
        {
            return _collection.IndexOf(item);
        }

        public void Insert(int index, Figure item)
        {
             _collection.Insert(index, item);
        }

        public bool Remove(Figure item)
        {
            return _collection.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _collection.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _collection.GetEnumerator();               
        }
    }
}
