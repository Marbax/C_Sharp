using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productHierarchy
{
    class SoldGoods : AFlowControl
    {
        AFlowControl _stock_pointer;
        public SoldGoods(AFlowControl stock_pointer, params AProduct[] array) : base(array)
        {
            _stock_pointer = stock_pointer;
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
                else if (!_stock_pointer.Contains(obj))
                {
                    throw new OutOfStock($"\n=================\nThis product doesn't exist ! \n{obj.ToString()}\n=========================\n");
                }
                base.Add(obj);
                _stock_pointer.Remove(obj);

            }
            catch (OutOfDate date_ex)
            {
                Console.WriteLine(date_ex.Message);
            }
            catch (DefectiveGoods defec_ex)
            {
                Console.WriteLine(defec_ex.Message);
            }
            catch (OutOfStock stock_ex)
            {
                Console.WriteLine(stock_ex.Message);
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
