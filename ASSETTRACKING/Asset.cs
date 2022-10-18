using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSETTRACKING
{
    public class Asset
    {
        public int id { get; set; }
        public string name { get; set; }
        List<Item> Items { get; set; }
    }

}


