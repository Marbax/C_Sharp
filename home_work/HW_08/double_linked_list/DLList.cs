using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    /*
    Создать обобщенный класс двунаправленного списка(List).
        Для класса List реализовать следующие методы:
            ▪ добавление элемента в конец списка;
            ▪ добавление элемента в указанную позицию;
            ▪ добавление диапазона элементов в указанную позицию;
            ▪ удаление элемента с начала списка;
            ▪ удаление элемента из указанной позиции;
            ▪ удаление диапазона элементов из указанной позиции;
            ▪ вывод на экран содержимого списка;
    */

    class DLList<T> : IEnumerable<T>
    {
        DLNode<T> _head;
        DLNode<T> _tail;
        int _count;

        public DLList() { }

        public T this[int index]
        {
            get
            {
                return GetNode(index).Value;
            }
            set
            {
                GetNode(index).Value = value;
            }
        }

        public int Count => _count;

        private DLNode<T> GetNode(int index)
        {
            if (index == 0)
                return _head;
            if (index == Count)
                return _tail;

            if (index > Count / 2)
            {
                var current = _tail;
                for (int i = Count; i > Count / 2 - 1; i--)
                {
                    if (i == index + 1)
                    {
                        return current;
                    }
                    current = current.Prev;
                }
                throw new IndexOutOfRangeException();
            }
            else
            {
                var current = _head;
                for (int i = 0; i < _count / 2 + 1; i++)
                {
                    if (i == index)
                    {
                        return current;
                    }
                    current = current.Next;
                }
                throw new IndexOutOfRangeException();
            }
        }

        public void Add(T item)
        {
            if (_count == 0)
            {
                _head = _tail = new DLNode<T>(item);
                _count++;
            }
            else
            {
                DLNode<T> newnode = new DLNode<T>(item, _tail);
                _tail.Next = newnode;
                _tail = newnode;
                _count++;
            }
        }

        public void AddFront(T item)
        {
            if (_count == 0)
            {
                _head = _tail = new DLNode<T>(item);
                _count++;
            }
            else
            {
                var newnode = new DLNode<T>(item, null, _head);
                _head.Prev = newnode;
                _head = newnode;
                _count++;
            }
        }

        public void Clear()
        {
            _head.Prev = _head.Next = _tail.Prev = _tail.Next = _tail = _head = null;
            _count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return this[i];
            }
        }

        public void Insert(int index, T item)
        {
            if (index == 0)
            {
                AddFront(item);
            }
            else if (index > 0 && index < _count)
            {
                var current = GetNode(index);
                DLNode<T> new_node = new DLNode<T>(item, current.Prev, current);
                current.Prev.Next = new_node;
                current.Prev = new_node;
                _count++;
            }
            else if (index == _count)
            {
                Add(item);
            }
        }

        public void InsertRange(int index, params T[] range)
        {//little bit lazy
            for (int i = 0, j = index; i < range.Length; i++, j++)
            {
                Insert(j, range[i]);
            }
        }

        public void RemoveFront()
        {
            if (_count > 1)
            {
                _head = _head.Next;
                _head.Prev = null;
                _count--;
            }
            else
            {
                _head = _tail = null;
                _count = 0;
            }

        }
        public void RemoveBack()
        {
            if (_count > 1)
            {
                _tail = _tail.Prev;
                _tail.Next = null;
                _count--;
            }
            else
            {
                _head = _tail = null;
                _count = 0;
            }
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                RemoveFront();
            }
            else if (index == Count - 1)
            {
                RemoveBack();
            }
            else
            {
                var needed_node = GetNode(index);
                needed_node.Prev.Next = needed_node.Next;
                needed_node.Next.Prev = needed_node.Prev;
                _count--;
            }
        }

        public void RemoveAtRange(int index, int count)
        {//little bit lazy
            if (index + count > this._count)
                throw new IndexOutOfRangeException();

            for (int i = index, j = 0; j < count; j++)
                RemoveAt(i);
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return this.Select(x => x.ToString()).Aggregate((x, y) => x + " " + y);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}
