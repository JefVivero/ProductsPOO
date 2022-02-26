using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsPOO
{    
    public class Invoice : IPay
    {
        private ICollection<Product> _products;

        public Invoice()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal ValueToPay()
        {
            decimal Total=0;
            foreach (Product product in _products)
            {                
                Total += product.ValueToPay();                
            }            
            return Total;
        }

        public override string ToString()
        {
            string all = "";
            foreach (Product product in _products)
            {
                all += $"\n\t{product.ToString()}\n\t";
            }
            return $"\n\tFactura:\n\t{all} " +
                $"\n\tTOTAL: {ValueToPay():C2}" ;

        }
    }
}
