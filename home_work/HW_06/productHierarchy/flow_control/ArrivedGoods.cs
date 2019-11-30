using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productHierarchy
{
    class ArrivedGoods : AFlowControl
    {
        public ArrivedGoods(params AProduct[] array) : base(array)
        {
        }

        public override void Add(AProduct obj)
        {
            try
            {
                if (obj is IPerishable perishable_obj && perishable_obj.IsOutOfDate())
                {
                    throw new OutOfDate($"Product out of date ! End date is {perishable_obj.EndDate}");
                }
                else if (obj is IBreakable breackable_obj && breackable_obj.Breacked)
                {
                    throw new DefectiveGoods($"Product is defective ! Breacked = {breackable_obj.Breacked}");
                }
                base.Add(obj);

            }
            catch (OutOfDate date_ex)
            {
                Console.WriteLine(date_ex.Message);
            }
            catch (DefectiveGoods defec_ex)
            {
                Console.WriteLine(defec_ex.Message);
            }
        }

        public override void AddRange(params AProduct[] obj_array)
        {
            foreach (var item in obj_array)
            {
                this.Add(item);
            }
        }
    }
}
