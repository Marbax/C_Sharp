using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productHierarchy
{

    [Serializable]
    public class DefectiveGoods : ApplicationException
    {
        public DefectiveGoods() { }
        public DefectiveGoods(string message) : base(message) { }
        public DefectiveGoods(string message, Exception inner) : base(message, inner) { }
        protected DefectiveGoods(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
