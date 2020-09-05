using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WnGCalculator.Models
{
    public class DnDObject
    {
        public int id { get; set; }
        public Engine Type { get; set;}
    }
    public class Engine
    {
        public int id {get;}

        public int ParentTag { get; set; }
        public string Name { get; set; }

        public string SysName { get; set; }

        public string ImageName { get; set; }

    }
}
