using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Category :IEntitiy
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        


    }
}
