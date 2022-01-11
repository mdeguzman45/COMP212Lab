namespace Marc_DeGuzman_Exercise01
{
    public class Invoice
    {
        public int PartNumber { get; }
        public string PartDescription { get; }
        public int Quantity { get; }
        public decimal Price { get; }

        public Invoice(int partNumber, string partDescription, int quantity, decimal price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {
            return $"{PartNumber, -10} {PartDescription, -15} {Quantity, 10} {Price, 15:C}";
        }
    }
}
