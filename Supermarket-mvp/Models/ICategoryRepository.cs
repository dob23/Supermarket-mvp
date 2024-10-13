using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
namespace Supermarket_mvp.Models
{
    internal interface ICategoryRepository
    {
        void CategoryAdd(CategoryModel categoryModel);
        void CategoryEdit(CategoryModel categoryModel);
        void CategoryDelete(int id);
        IEnumerable<CategoryModel> GetAll();
        IEnumerable<CategoryModel> GetByValue(string value);
    }
}
