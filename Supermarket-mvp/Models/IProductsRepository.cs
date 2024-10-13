using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IProductsRepository
    {
        void ProductAdd(ProductsModel productsModel);
        void ProductEdit(ProductsModel productsModel);
        void ProductDelete(int id);
        IEnumerable<ProductsModel> GetAll();
        IEnumerable<ProductsModel> GetByValue(string value);
    }
}
