namespace ProductsPOO
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {            
            return  (Price*(decimal)Tax) + Price;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tValue to Pay:{$"{ValueToPay():C2}",18}";
        }
    }
}
