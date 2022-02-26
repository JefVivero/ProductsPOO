using System.Collections.Generic;

namespace ProductsPOO
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }        
        public override decimal ValueToPay()
        {
            decimal Total = 0;
            foreach (Product product in Products)
            {                
                Total += product.ValueToPay();
            }
            return Total;            
        }

        public override string ToString()
        {
            string all="";
            
            foreach (Product product in Products)
            {
                all += $"{product.Description},";                             
            }
            decimal TotalPay= ValueToPay();

            TotalPay = TotalPay - (TotalPay * (decimal)Discount);

            return $"{base.ToString()} " +
                $"\n\tDiscount:{Discount:P2}" +
                $"\n\tProducts:{all}" +
                $"\n\tTotal to Pay: {TotalPay:C2}";

        }


    }
}
