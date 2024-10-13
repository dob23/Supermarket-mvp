using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class ProductsPresenter
    {
        private IProductsView view;
        private IProductsRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductsModel> productList;

        public ProductsPresenter(IProductsView view, IProductsRepository repository)
        {
            this.productBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductsListBildingSource(productBindingSource);

            LoadAllProductList();

            this.view.Show();

        }

        private void LoadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            var product = new ProductsModel();
            product.Product_Id = Convert.ToInt32(view.ProductsId);
            product.Name = view.Name;
            int price;
            if (int.TryParse(view.Price, out price))
            {
                product.Price = price;
            }
            else
            {
                MessageBox.Show(" campo  numerico.");
            }
            int stock;
            if (int.TryParse(view.Stock, out stock))
            {
                product.Stock = stock;
            }
            else
            {
                MessageBox.Show(" campo  numerico.");
            }
            int categorie_id;
            if (int.TryParse(view.ProdCategory_Id, out categorie_id))
            {
                product.Category_Id = categorie_id;
            }
            else
            {
                MessageBox.Show("campo numerico.");
            }

            try
            {
                new Common.ModelDataValidation().Validate(product);
                if (view.IsEdit)
                {
                    repository.ProductEdit(product);
                    view.Message = "Product Edit Successfuly";
                }
                else
                {
                    repository.ProductAdd(product);
                    view.Message = "Product added Successfuly";
                }
                view.IsSuccessful = true;
                LoadAllProductList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }

        }

        private void CleanViewFields()
        {
            view.ProductsId = "0";
            view.Name = "";
            view.Price = "";
            view.Stock = "";
            view.ProdCategory_Id = "";
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            try
            {
                var products = (ProductsModel)productBindingSource.Current;
                repository.ProductDelete(products.Product_Id);
                view.IsSuccessful = true;
                view.Message = "Product deleted Successfuly";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete Product";
            }
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            var product = (ProductsModel)productBindingSource.Current;

            view.ProductsId = product.Product_Id.ToString();
            view.Name = product.Name;
            view.Price = product.Price.ToString();
            view.Stock = product.Stock.ToString();
            view.ProdCategory_Id = product.Category_Id.ToString();


            view.IsEdit = true;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }
            productBindingSource.DataSource = productList;
        }
    }
}

