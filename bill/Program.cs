using System;
using System.Collections.Generic;

public class Product
{
    private string Id;
    private string pname;
    private int qty;
    private double price;
    private double totalPrice;

    public Product(string Id, string pname, int qty, double price, double totalPrice)
    {
        this.Id = Id;
        this.pname = pname;
        this.qty = qty;
        this.price = price;
        this.totalPrice = totalPrice;
    }

    public string GetId()
    {
        return Id;
    }

    public string GetPname()
    {
        return pname;
    }

    public int GetQty()
    {
        return qty;
    }

    public double GetPrice()
    {
        return price;
    }

    public double GetTotalPrice()
    {
        return totalPrice;
    }

    public static void DisplayFormat()
    {
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("\nProduct ID \t \tName \t\tQuantity\t\tRate  \t\t\t\tTotal Price\n");
        Console.WriteLine("-----------------------------------------------------------------------------");
    }

    public void Display()
    {
        Console.WriteLine($"{Id}\t\t{pname}\t\t{qty}\t\t{price}\t\t{totalPrice}");
    }
}

public class ShoppingBill
{
    public static void Main(string[] args)
    {
        string id = null;
        string productName = null;
        int quantity = 0;
        double price = 0.0;
        double totalPrice = 0.0;
        double overAllPrice = 0.0;
        double subtotal = 0.0, discount = 0.0;
        char choice = '\0';

        Console.WriteLine("\t\t\t\t-------------------Invoice-------------------");
        Console.WriteLine("\t\t\t\t\t  Metro Mart Grocery Shop");
        Console.WriteLine("\t\t\t\t\t3/98 Pyay Road, Taw Win Center");
        Console.WriteLine("\t\t\t\t\t      Opposite Sein GayHar");
        Console.WriteLine("GSTIN 03WQRTPP89W2e\t\t\t\t\t\t\tContact:(+959) 9972733499");

        DateTime date = DateTime.Now;
        string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        Console.WriteLine($"Date: {date.ToString("dd/MM/yyyy HH:mm:ss")} {days[(int)date.DayOfWeek - 1]}\t\t\t\t\t\t (+959) 1920399992");

        Console.Write("Enter Customer Name: ");
        string customername = Console.ReadLine();

        List<Product> products = new List<Product>();
        do
        {
            Console.WriteLine("Enter the product details");
            Console.Write("Product ID: ");
            id = Console.ReadLine();
            
            Console.Write("Product Name: ");
            productName = Console.ReadLine();
            
            Console.Write("Quantity: ");
            quantity = int.Parse(Console.ReadLine());
            
            Console.Write("Price(per unit): ");
            price = double.Parse(Console.ReadLine());

            totalPrice = price * quantity;

            overAllPrice += totalPrice;
            
            products.Add(new Product(id, productName, quantity, price, totalPrice));
            
            Console.Write("Want to add more items? (y or n): ");

            choice = char.Parse(Console.ReadLine());

        } while (choice == 'y' || choice == 'Y');

        Product.DisplayFormat();
        foreach (Product p in products)
        {
            p.Display();
        }
        
        Console.WriteLine($"\n\t\t\t\t\t\t\t\t\tTotal Amount($) {overAllPrice}");

        discount = overAllPrice * 2 / 100;
        Console.WriteLine($"\n\t\t\t\t\t\t\t\t\t Discount($.){discount}");

        subtotal = overAllPrice - discount;
        Console.WriteLine($"\n\t\t\t\t\t\t\t\t\t Subtotal{subtotal}");
        
        Console.WriteLine($"\n\t\t\t\t\t\t\t\t\t Invoice TOtal (subtotal)");
        Console.WriteLine("\t\t\t\t----------------Thank You For Shopping!!----------------");
        Console.WriteLine("\t\t\t\t                Visit Again");
    }
    
}
