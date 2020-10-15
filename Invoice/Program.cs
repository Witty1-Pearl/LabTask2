using System;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("P1", "Keyboard", 10, 12.00);
            double cost = invoice.getInvoiceAmount();
            Console.WriteLine("Part {0}, Desc {1}, Quantity {2}, Price Each {3:C}, Total Cost {4:C}", invoice.PartNumber, invoice.PartDescription, invoice.Quantity, invoice.Price, cost);
            Console.WriteLine();

            Invoice invoice2 = new Invoice("P2", "Mouse", 5, -5.50); // let this be the negative price
            double cost2 = invoice2.getInvoiceAmount();
            Console.WriteLine("Part {0}, Desc {1}, Quantity {2}, Price Each {3:C}, Total Cost {4:C}", invoice2.PartNumber, invoice2.PartDescription, invoice2.Quantity, invoice2.Price, cost2);
            Console.ReadLine();
        }
    }
}
