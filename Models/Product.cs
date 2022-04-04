using System;
namespace DataStructureHM.Models
{
    public abstract class Product:Exceptions
    {
        private int _id;

        public int ID { get; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }

        protected double TotalInCome { get; set; }

        public abstract void Sell();

        public abstract void ShowInfo();

        public Product()
        {
            _id++;
            ID = _id;
        }
    }
    
        
}
