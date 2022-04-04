using System;
namespace DataStructureHM.Models
{
    public class Book:Product
    {
        public string AuthorName { get; set; }

        public int PageCount { get; set; }

        public override void Sell()
        {
            ProductCountIsZeroException(Count);
            Count--;
            TotalInCome++;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"ID : {ID}\n" +
                $"Name : {Name}\n" +
                $"Price : {Price}\n" +
                $"Count : {Count}\n" +
                $"Author Name : {AuthorName}\n" +
                $"Page Count : {PageCount}\n" +
                $"Total Income : {TotalInCome}");
        }

        public Book(string name , double price, string authorname, int pagecount)
        {
            Name = name;
            Price = price;
            AuthorName = authorname;
            PageCount = pagecount;
        }
    }
}
