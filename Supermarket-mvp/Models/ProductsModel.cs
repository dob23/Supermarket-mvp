using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProductsModel
    {
        [DisplayName("Product Id")]
        public int Product_Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Product Name must be between 3 and 80 Charaters")]
        public string Name { get; set; }

        [DisplayName("Product Price")]
        [Required(ErrorMessage = "Product Price is required")]
        public decimal Price { get; set; }

        [DisplayName("Product Stock")]
        [Required(ErrorMessage = "Product Stock is required")]
        public int Stock { get; set; }

        [DisplayName("Product Category_Id")]
        [Required(ErrorMessage = "Product Categorie_Id is required")]
        public int Category_Id { get; set; }


    }
}
