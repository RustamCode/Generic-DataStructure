using System;
namespace DataStructureHM.Models
{
    public class Exceptions
    {
        public void CapasityLimitException(int capasity , int count)
        {
            if (count==capasity)
            {
                throw new Exception("Capasity is full");
            }
        }

        public void NotFoundException(int? notfound)
        {
            if (notfound==null)
            {
                throw new Exception("Not found");
            }
        }

        public void ProductCountIsZeroException(int productzero)
        {
            if (productzero==0)
            {
                throw new Exception("Product isn't found");
            }
        }
    }
}
