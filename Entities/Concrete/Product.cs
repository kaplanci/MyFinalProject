using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Product:IEntitiy
    {
        public int ProductID  { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock  { get; set; }
        public decimal UnitPrice { get; set; }
        
    }
}
