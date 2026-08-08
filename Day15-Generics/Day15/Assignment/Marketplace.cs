using System;

namespace Day15
{
    class Product
    {
        public int Id {get;set;}
        public string Name {get;set; }
        public double Price {get;set; }

        public Product(int id,string name, double price)
        {
            Id=id;
            Name=name;
            Price=price;
        }

        public void Show()
        {
            Console.WriteLine(Id +" "+ Name +" " + Price);
        }
    }

    class Book:Product
    {
        public string Author {get;set;}

        public Book(int id,string name, double price, string author)
            : base(id, name,price)
        {
            Author =author;
        }
    }

    class Clothing:Product
    {
        public string Size {get; set; }

        public Clothing(int id, string name, double price, string size)
            : base(id, name,price)
        {
            Size =size;
        }
    }

    class ProductHelper
    {
        public static void ApplyDiscount<T>(T prod, double per)
            where T :Product
        {
            prod.Price = prod.Price - (prod.Price * per / 100);
        }
    }
}