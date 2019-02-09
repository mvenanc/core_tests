using System;
using exercicio_enum.Entities;
using exercicio_enum.Entities.Enums;

namespace exercicio_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order{
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment                
            };


            Console.WriteLine(order);
        }
    }
}
