namespace ProductsPOO
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal ValueToPay()
        {           
            return (Price * (decimal)Quantity) + ((Price * (decimal)Quantity)*(decimal)Tax);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tMeasurement: {Measurement:N2}" +
                $"\n\tQuantity: {Quantity:N2}" +
                $"\n\tValue to pay:{ValueToPay():C2}";
        }
    }
}
