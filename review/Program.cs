using System;

namespace ConsoleApp2
{
    interface DiscountPolicy
    {
        double ApplyDiscount(double amt,int qty);
    }

    class PercentDisc:DiscountPolicy
    {
        public double Percent{get;set; }
        public double ApplyDiscount(double amt,int qty)
        {
            return amt -(amt *Percent/100);
        }
    }

    class FlatDisc :DiscountPolicy
    {
        public double Amount{get;set;}

        public double ApplyDiscount(double amt,int qty)
        {
            return amt -Amount;
        }
    }

    class BulkTierDisc : DiscountPolicy
    {
        public int MinQty {get;set;}
        public double Percent { get;set; }

        public double ApplyDiscount(double amt,int qty)
        {
            if (qty >= MinQty)
                return amt - (amt *Percent /100);

            return amt;
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public double Price {get;set;}
        public string Cat{ get; set; }
    }

    class StockItem
    {
        public Product Prod {get;set;}
        public int Qty {get;set;}
    }

    class Branch
    {
        public int Id {get;set;}
        public string Name {get; set;}
        public StockItem[] Stock {get;set; }
    }

    class Store
    {
        public int StoreId {get;set; }
        public string Name {get;set;}
        public Branch[] Branches {get;set;}
    }

    class Supplier
    {
        public int Id {get; set;}
        public string Name {get;set;}
    }

    class PurchaseOrder
    {
        public int Id { get; set;}
        public Supplier Sup { get;set; }
        public Branch Branch { get; set; }
        public Product Prod { get;set;}
        public int Qty { get;set; }
    }

    class Customer
    {
        public int Id {get;set;}
        public string Name {get;set;}
    }

    class SalesOrder
    {
        public int Id { get;set;}
        public Customer Cust {get;set; }
        public Product[] Prods {get;set; }
        public int[] Qty { get; set; }
        public DiscountPolicy Disc {get; set; }

        public double GetTotal()
        {
            double amt = 0;
            int totalQty = 0;
            for (int i = 0; i <Prods.Length; i++)
            {
                amt += Prods[i].Price *Qty[i];
                totalQty += Qty[i];
            }
            return Disc.ApplyDiscount(amt,totalQty);
        }
    }

    class Invoice
    {
        public int Id { get; set; }
        public double Total { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Product p1 = new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 50000,
                Cat = "Tech"
            };
            Customer c1 = new Customer
            {
                Id=1,
                Name ="PK"
            };
            BulkTierDisc d1=new BulkTierDisc
            {
                MinQty= 5,
                Percent = 20
            };
            SalesOrder ord =new SalesOrder
            {
                Id =101,
                Cust = c1,
                Prods = new Product[] {p1},
                Qty = new int[] {5 },
                Disc = d1
            };
            Invoice inv = new Invoice
            {
                Id = 501,
                Total = ord.GetTotal()
            };

            Console.WriteLine("Customer:" + c1.Name);
            Console.WriteLine("Total: " + inv.Total);
        }
    }
}