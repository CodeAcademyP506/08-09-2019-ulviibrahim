using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceTask_14._09
{
    enum Category { ickiler = 1, meyveler }

    //    Kateqoriyalar üzrə satışların toplam dəyəri(Məs: İçkilər-10m, Meyvələr 25m)
    //Ən çox pul xərcləyən müştərini tapın
    //OrderHistories-də bütün satılan malların sayını 1 vahid artırın
    //Person obyektini elə dəyişin ki(interface) onun içərisindəki əlavə edəcəyiniz PrintData metodu universal olsun



    class Program
    {
        static void Main(string[] args)
        {


            List<Person> customer = new List<Person>() {
                new Person(1,25,"Nurlan"),
                new Person(2,20,"Ramin"),
                new Person(3,29,"Kamal"),
                new Person(4,30,"Emin"),
                new Person(5,15,"Seymur"),
            };

            List<Product> products = new List<Product>()
            {
                new Product(1,"Coca-cola",2, Category.ickiler),
                new Product(2,"Fanta",2, Category.ickiler),
                new Product(3,"Sprite",3, Category.ickiler),
                new Product(4,"Alma",3, Category.meyveler),
                new Product(5,"Heyva",2, Category.meyveler),
                new Product(6,"Nar",5, Category.meyveler)
            };

            //var cate = products.Where(w => w.Category == Category.ickiler).FirstOrDefault();
            //Console.WriteLine(cate.Name);

            List<OrderHistory> orderHistories = new List<OrderHistory>()
            {
                new OrderHistory(1,1,3,4),
                new OrderHistory(2,2,6,5),
                new OrderHistory(3,2,1,3),
                new OrderHistory(4,3,5,3),
                new OrderHistory(5,4,2,6),
                new OrderHistory(6,5,4,1),
                new OrderHistory(7,5,1,8)
            };


            var sum = 0d;
            foreach (var order in orderHistories)
            {
                var myprodId = products.Where(w=>w.Id==order.ProductId);
                foreach (var item in myprodId)
                {
                    if (item.Category==Category.ickiler)
                    {
                        var flinetotal = order.Count * item.Price;
                        sum += flinetotal;
                    }

                  
                }

                

                
            }
            var summeyve = 0d;
            foreach (var order in orderHistories)
            {
                var myprodId = products.Where(w => w.Id == order.ProductId);
                foreach (var item in myprodId)
                {
                    if (item.Category == Category.meyveler)
                    {
                        var flinetotal = order.Count * item.Price;
                        summeyve += flinetotal;
                    }


                }




            }
            Console.WriteLine($"Satilmis ickilerin toplam qiymeti: {sum}");
            Console.WriteLine($"Satilmis meyvelerin toplam qiymeti: {summeyve}");


            //var mainicki = products.Where(w => w.Category == Category.ickiler);

            //var ickiPrice = 0d;
            //foreach (var item in mainicki)
            //{
            //    var satis = orderHistories.Where(w => w.ProductId == item.Id);



            //    Console.WriteLine(satis);
            //}

            //var findAlma = products.Where(alma => alma.Category == Category.ickiler).First();

            //var almaCusts = orderHistories.Where(w => w.ProductId == findAlma.Id).Select(s => s.ProductId); 


            //var rsult = products.Where(w => almaCusts.Contains(w.Id));
            //var icki = 0d;
            //foreach (var item in rsult)
            //{
            //    Console.WriteLine(item.Name);
            //    icki += item.Price;
            //}

            //Console.WriteLine(icki);

            ////var mysatis = products.Where(w => w.Category == Category.ickiler).Select(s => s.Price);

            ////foreach (var item in mysatis)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //foreach (var item in orderHistories)
            //{
            //    var ListPro = products.Where(w => w.Id == item.ProductId);

            //    var categorypro = ListPro.Where(w => w.Category == Category.ickiler).FirstOrDefault();
            //    Console.WriteLine(categorypro.Name);
            //}




        }

    }


    class Person
    {
        public Person(int i, int a, string n)
        {
            Age = a;
            Name = n;
            Id = i;
        }
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public int Test { get; set; }
    }



    class Product
    {
        public Product(int i, string n, double p, Category c)
        {
            Id = i;
            Name = n;
            Price = p;
            Category = c;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
    }

    class OrderHistory
    {
        public OrderHistory(int i, int cid, int pid, int cnt)
        {
            Id = i;
            CustomerId = cid;
            ProductId = pid;
            Count = cnt;
        }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
    }


}