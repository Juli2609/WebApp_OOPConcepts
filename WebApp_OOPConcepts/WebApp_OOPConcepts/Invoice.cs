using System;
using System.Collections.Generic;
using System.Text;
using WebApp_OOPConcepts.Interface;

namespace WebApp_OOPConcepts
{
    public class Invoice : IPay
    {
        #region Properties

        public int Id { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }

        #endregion

        #region Methods

        public decimal GetValueToPay()
        {
            return (decimal)Quantity * Price;
        }

        public override string ToString()
        {
            return $"ID: {Id} - Description: {Description}\n\t" +
                $"Quantity......{Quantity}\n\t" +
                $"Price.........{Price:C2}\n\t" +
                $"Total Invoice.{GetValueToPay():C2}";
        }

        #endregion
    }
}
