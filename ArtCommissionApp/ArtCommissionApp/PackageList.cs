using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ArtCommissionApp
{
    public class Package
    {
        public int PackId { get; set; }
        public string Name { get; set; }
        public PackageInfo PackageInfo { get; set; }
        
    }

    public class PackageInfo
    {
        public int InfoId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Duration { get; set; }
        public int PackId { get; set; }
        public Package Package { get; set; }
    }
}
