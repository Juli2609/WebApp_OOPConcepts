using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        #region Properties

        public decimal Base { get; set; }

        #endregion

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Base....................{Base:C2}\n\t" +
                $"Total......{GetValueToPay():C2}";
        }
    }
}
