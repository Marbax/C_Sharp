using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productHierarchy
{
    abstract class AFlowControl : IEnumerable, ICloneable
    {
        List<AProduct> _array;
        public int Count => _array.Count;
        public AProduct this[int index] { get => _array[index]; set => _array[index] = value; }

        public virtual void Add(AProduct obj) => _array.Add(obj);
        public virtual void AddRange(params AProduct[] obj_array) => _array.AddRange(obj_array.ToList<AProduct>());
        public virtual void RemoveAt(int index) => _array.RemoveAt(index);
        public virtual bool Remove(AProduct obj) => _array.Remove(obj);

        public virtual bool Contains(AProduct obj)
        {
            return _array.Contains(obj);
        }
        public AFlowControl(params AProduct[] array)
        {
            _array = array.ToList<AProduct>();
        }

        public virtual IEnumerator GetEnumerator() { return _array.GetEnumerator(); }


        private List<AProduct> ElementsClone()
        {
            List<AProduct> tmp_arr = new List<AProduct>();
            for (int i = 0; i < _array.Count; i++)
            {
                tmp_arr.Add((AProduct)_array[i].Clone());
            }
            return tmp_arr;

        }
        public object Clone()
        {
            AFlowControl tmp_flow = (AFlowControl)this.MemberwiseClone();
            tmp_flow._array = ElementsClone();
            return tmp_flow;
        }
    }
}
