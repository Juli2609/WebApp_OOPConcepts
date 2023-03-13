using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts
{
    public class CommissionEmployee : Employee
    {
        #region Properties
        public decimal CommissionPercentage { get; set; }
        public decimal Sales { get; set; }
        #endregion

        public override decimal GetValueToPay()
        {
            return Sales * ((decimal) (CommissionPercentage / 100));
        }
        public override string ToString() 
        {
            return $"{base.ToString()}\n\t" +
                $"Commision Percentge..{CommissionPercentage / 100:P2}\n\t" +
                $"Sales................{Sales:C2}\n\t" +
                $"Get Valeu To Pay.....{GetValueToPay():C2}"; //Se usa el C2 es el tipo dinero para imprimir en consola
        }

        //metodo que calcule el porcentaje: pediente
    }
}
