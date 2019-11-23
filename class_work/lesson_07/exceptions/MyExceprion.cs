using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    [Serializable]
    public class MyException : Exception
    {
        public DateTime TimeException { get; private set; }

        public MyException()
            : this("Мое исключение") { TimeException = DateTime.Now; }

        public MyException(string message)
            : base(message) { }

        public MyException(string message, Exception inner)
        : base(message, inner) { }

        protected MyException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
        : base(info, context) { }
    }


}
