using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Supermarket_mvp.Models
{
    internal class CategoryModel
    {
        [DisplayName("Pay Mode Id")]
        public int Id { get; set; }

        [DisplayName("Categorie Name")]
        [Required(ErrorMessage = "Category Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Category Name must be between 3 and 50 Charaters")]
        public string Name { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "Pay Mode Description is required")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Category Description must be between 3 and 80 Charaters")]
        public string Description { get; set; }
    }
}
