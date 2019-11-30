using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productHierarchy
{

    [Serializable]
    public class OutOfDate : ApplicationException
    {
        public OutOfDate() { }
        public OutOfDate(string message) : base(message) { }
        public OutOfDate(string message, Exception inner) : base(message, inner) { }
        protected OutOfDate(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
