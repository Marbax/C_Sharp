using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productHierarchy.flow_control
{
    class DecommisionedGoods : AFlowControl
    {
        public DecommisionedGoods(params AProduct[] array) : base(array)
        {
        }
    }
}
