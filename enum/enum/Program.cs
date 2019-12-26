
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  @enum
{

    enum AccType { Fiziki=1, huquqi }
    class Program
    {
        static void Main(string[] args)
        {









            List<Accountant> customer = new List<Accountant>() {
                         new Accountant(1,27,"Besir", AccType.Fiziki,new List<Transachistory>()
            {
              new Transachistory(1,10,100,"FORMULA 1")
        }),
                new Accountant(1,25,"Kamal", AccType.Fiziki,new List<Transachistory>()
            {
              new Transachistory(1,12,35,"Academy")
        }),
                new Accountant(1,25,"Nurlan", AccType.huquqi,new List<Transachistory>()
            {
              new Transachistory(1,12,35,"Academy")
        })
            };



            var ACCTHuquqi = customer.Where(w => w.actype == AccType.huquqi).Count();

            Console.WriteLine( $"Hüquqi şexslerin sayı {ACCTHuquqi} -dir");

            Console.WriteLine();

            var ACCTFiziki = customer.Where(w => w.actype == AccType.Fiziki).Count();

            Console.WriteLine($"Fiziki şexslerin sayı {ACCTFiziki} -dir");

            //customer.First().tranzaksiya.Add(new Transachistory(1, 12, 25, "Academy"));



        }
    }

    class Accountant
    {
        public Accountant(int i, int a, string n, AccType act, List<Transachistory> h)
        {
            Age = a;
            Name = n;
            Id = i;
            actype = act;
            tranzaksiya = h;
        }
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public AccType actype { get; set; }

        public List<Transachistory> tranzaksiya { get; set; } = new List<Transachistory>();


    }

    //class Category
    //{
    //    public Category(string n)
    //    {
    //        Name = n;
    //    }
    //    public string Name { get; set; }
    //}

    //class Product
    //{
    //    public Product(int i, string n, double p, Category c)
    //    {
    //        Id = i;
    //        Name = n;
    //        Price = p;
    //    }
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public double Price { get; set; }
    //    public Category Category { get; set; }
    //}

    class Transachistory
    {
        public Transachistory(int i, int date, int amount, string dst)
        {
            Id = i;
            Date = date;
            Amount = amount;
            Destination = dst;
        }
        public int Id { get; set; }
        public int Date { get; set; }
        public int Amount { get; set; }
        public string Destination { get; set; }
    }
}
