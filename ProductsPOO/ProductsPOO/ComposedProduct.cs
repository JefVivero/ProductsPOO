using System.Collections.Generic;

namespace ProductsPOO
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }
        public override decimal ValueToPay()
        {
            return Price + (Price * (decimal)Tax);
        }

        public override string ToString()
        {
            string all="";
            decimal TotalPay = 0;
            foreach (Product product in Products)
            {
                all += $"{product.Description},";
                TotalPay += product.ValueToPay();                
            }

            TotalPay = TotalPay - (TotalPay * (decimal)Discount);

            return $"{base.ToString()} " +
                $"\n\tDiscount:{Discount:P2}" +
                $"\n\tProducts:{all}" +
                $"\n\tTotal to Pay: {TotalPay:C2}";

        }


    }
}
