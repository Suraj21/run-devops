using Shopping.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Client.Data
{
    public class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
            new Product()
            {
                Name = "Iphone X",
                Description = "kjsadfklsdjf klsdjflksjlfksjdlkfjsdlkfj",
                ImageFile = "product1.png",
                Price = 950.00M,
                Category = "Smart-Phone"
            },
            new Product()
            {
                Name = "Iphone X",
                Description = "kjsadfklsdjf klsdjflksjlfksjdlkfjsdlkfj",
                ImageFile = "product1.png",
                Price = 950.00M,
                Category = "Smart-Phone"
            },
            new Product()
            {
                Name = "Iphone X",
                Description = "kjsadfklsdjf klsdjflksjlfksjdlkfjsdlkfj",
                ImageFile = "product1.png",
                Price = 950.00M,
                Category = "Smart-Phone"
            },
            new Product()
            {
                Name = "Iphone X",
                Description = "kjsadfklsdjf klsdjflksjlfksjdlkfjsdlkfj",
                ImageFile = "product1.png",
                Price = 950.00M,
                Category = "Smart-Phone"
            },
            new Product()
            {
                Name = "Iphone X",
                Description = "kjsadfklsdjf klsdjflksjlfksjdlkfjsdlkfj",
                ImageFile = "product1.png",
                Price = 950.00M,
                Category = "Smart-Phone"
            }
        };
    }
}