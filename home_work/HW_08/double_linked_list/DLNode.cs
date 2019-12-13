using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    class DLNode<T>
    {

        private T _value;
        public T Value
        {
            get { return _value; }
            set { _value = value; }
        }
        private DLNode<T> _ptr_next;

        public DLNode<T> Next
        {
            get { return _ptr_next; }
            set { _ptr_next = value; }
        }
        private DLNode<T> _ptr_prev;

        public DLNode<T> Prev
        {
            get { return _ptr_prev; }
            set { _ptr_prev = value; }
        }

        public DLNode(T value, DLNode<T> prev = null, DLNode<T> next = null)
        {
            _value = value;
            _ptr_prev = prev;
            _ptr_next = next;
        }
        public override bool Equals(object obj)
        {
            return this == obj as DLNode<T>;
        }

        public override int GetHashCode()
        {
            return (_ptr_next != null ? _ptr_next.GetHashCode() : 0.GetHashCode()) +
                (_ptr_prev != null ? _ptr_prev.GetHashCode() : 0.GetHashCode()) +
                (_value.GetHashCode());
        }

        public override string ToString()
        {
            return $"{Value}";
        }

        public static bool operator ==(DLNode<T> first, DLNode<T> second)
        {
            return first.Value as DLNode<T> == second.Value as DLNode<T>;
        }
        public static bool operator !=(DLNode<T> first, DLNode<T> second)
        {
            return !(first == second);
        }

    }
}
