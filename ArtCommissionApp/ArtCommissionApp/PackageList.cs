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
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PackageInfo> PackageInfo { get; set; } = new List<PackageInfo>();
    }

    public class PackageInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Duration { get; set; }
    }
}
