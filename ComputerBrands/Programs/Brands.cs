using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBrands
{
     public class Brands
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string BrandFoundationYear { get; set; }
        public string BrandLocalCountry { get; set; }

        public Brands(int id,string brandName, string brandFoundationYear, string brandLocalCountry)
        {
            Id = id;
            BrandName = brandName;
            BrandFoundationYear = brandFoundationYear;
            BrandLocalCountry = brandLocalCountry;
        }

        internal static void DisplayBrands(string v, DataGridView brandList)
        {
            throw new NotImplementedException();
        }
    }
}
