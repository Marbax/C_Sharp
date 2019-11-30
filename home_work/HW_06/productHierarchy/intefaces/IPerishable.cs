using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productHierarchy
{
    interface IPerishable
    {
        bool OutOfDate { get; set; }
        DateTime EndDate { get; set; }

        bool IsOutOfDate();

    }
}
