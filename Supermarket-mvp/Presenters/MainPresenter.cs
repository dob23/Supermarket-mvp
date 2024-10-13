using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp._Repositories;
namespace Supermarket_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView _mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            _mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this._mainView.ShowPayModeView += ShowPayModeView;
            this._mainView.ShowProductView += ShowProductsView;
            this._mainView.ShowCustomerView += ShowCustomersView;
            this._mainView.ShowCategorieView += ShowCategoryView;
        }

        private void ShowPayModeView(object sender, EventArgs e) {
            IPayModeView view = PayModeView.GetInstance((MainView)_mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }
        private void ShowProductsView(object sender, EventArgs e)
        { 
            IProductsView view = ProductsView.GetInstance((MainView)_mainView);
            IProductsRepository repository = new ProductRepository(sqlConnectionString);
            new ProductsPresenter(view, repository);
        }
        private void ShowCustomersView(object sender, EventArgs e)
        {
            ICustomerView view = CustomerView.GetInstance((MainView)_mainView);
            ICustomerRepository repository = new CustomersRepository(sqlConnectionString);
            new CustomerPresenter(view, repository);
        }
        private void ShowCategoryView(object sender, EventArgs e)
        {
            ICategoryView view = CategoryView.GetInstance((MainView)_mainView);
            ICategoryRepository repository = new CategoryRepository(sqlConnectionString);
            new CategoryPresenter(view, repository);
        }
    }
}
