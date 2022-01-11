using System;
using System.Linq;

namespace Marc_DeGuzman_Exercise01
{
    public class PartsTest
    {
        static void Main(string[] args)
        {
            // initialize all invoice
            var invoices = new[]
            {
                new Invoice(87, "Electric Sander", 7, 57.98M),
                new Invoice(24, "Power Saw", 18, 99.99M),
                new Invoice(7, "Sledge Hammer", 11, 21.50M),
                new Invoice(77, "Hammer", 76, 11.99M),
                new Invoice(39, "Lawn Mower", 3, 79.50M),
                new Invoice(68, "Screw Driver", 106, 6.99M),
                new Invoice(56, "Jig Saw", 21, 11.00M)
            };

            // display all invoice
            Console.WriteLine("Original Collection:");
            foreach (var invoice in invoices)
            {
                Console.WriteLine(invoice);
            }

            var descriptionAndTotal = from invoice in invoices
                                      let invoiceTotal = (invoice.Quantity * invoice.Price)
                                      orderby invoiceTotal ascending 
                                      select new { invoice.PartDescription, invoiceTotal };

            // display description and total
            Console.WriteLine("\nPart Description and invoice total:");
            foreach (var invoiceTotal in descriptionAndTotal)
            {
                Console.WriteLine(invoiceTotal);
            }

            // lets order the list quantity in descending order
            var orderQuantityDescending = from invoice in invoices
                                  orderby invoice.Quantity descending
                                  select invoice;

            var highestQuantity = orderQuantityDescending.First();

            Console.WriteLine($"\nThe Part with highest quantity is {highestQuantity.PartDescription} with count {highestQuantity.Quantity}");

            // compute the average price of the parts
            var partPrices = from invoice in invoices
                             select invoice.Price;
            Console.WriteLine($"\nThe average price of the parts is {partPrices.Average().ToString("N2")}");
        }
    }
}
