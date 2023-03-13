using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts
{
    public class HourlyEmployee : Employee
    {
        #region Properties

        public float Hours { get; set; }
        public decimal HourValue { get; set; }

        #endregion

        public override decimal GetValueToPay()
        {
            return HourValue * (decimal)Hours;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Hours..................{Hours}\n\t" +
                $"Value per Hour.........{HourValue:C2}\n\t" +
                $"Gete value to Pay......{GetValueToPay():C2}";
        }
    }
}
