using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productHierarchy
{

    [Serializable]
    public class OutOfStock : ApplicationException
    {
        public OutOfStock() { }
        public OutOfStock(string message) : base(message) { }
        public OutOfStock(string message, Exception inner) : base(message, inner) { }
        protected OutOfStock(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
