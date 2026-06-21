// See https://aka.ms/new-console-template for more information
using Solid.LSP;
using Solid.OCP.Performing_OCP;
using Solid.Task7;
using Solid.Task7.Discount;
using Solid.Task7.MessageSender;


Console.WriteLine("Hello, World!");

// OCP 
var service = new SalaryService();
decimal fulltimeSalary = service.CalculateSalary(new FullTypeEmployee(), 1000);
decimal partTimeSalary = service.CalculateSalary(new PartTimeEmployee(), 1000);


//LSP
 static void MakeBirdFly(Bird bird)
{
    bird.Fly();
}


//Task 7 : Online shop
Product laptop = new Product("Laptop", 50000000, new PercentDiscount(10));
Product mouse = new Product("Mouse", 700000, new FixedAmountDiscount(50000));

List<Product> products = new List<Product>
        {
            laptop,
            mouse
        };

IMessageSender messageSender = new EmailSender();

OrderService orderService = new OrderService(messageSender);

Invoice invoice = orderService.Buy("ali.shabani6528@gmail.com", products);

Console.WriteLine($"Total price: {invoice.TotalPrice}");