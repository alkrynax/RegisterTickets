using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterTickets
{
    public class TicketsService
    {
        private const decimal KebabPrice = 5m;
        public int Quantity { get; private set; }

        public static void StartApplication()
        {
            Console.WriteLine("Hello, World!");

        }

        public TicketsService(int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentException("La quantité ne peut pas être négative.");
            }
            Quantity = quantity;
        }

        public decimal CalculateTotalPrice()
        {
            return Quantity * KebabPrice;
        }
    }
}