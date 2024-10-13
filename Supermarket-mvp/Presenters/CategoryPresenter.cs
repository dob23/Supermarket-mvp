using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Presenters
{
    internal class CategoryPresenter
    {
        private ICategoryView view;
        private ICategoryRepository repository;
        private BindingSource categorieBindingSource;
        private IEnumerable<CategoryModel> categorieList;

        public CategoryPresenter(ICategoryView view, ICategoryRepository repository)
        {
            this.categorieBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategory;
            this.view.AddNewEvent += AddNewCategory;
            this.view.EditEvent += LoadSelectCategorieToEdit;
            this.view.DeleteEvent += DeleteSelectedCategory;
            this.view.SaveEvent += SaveCategory;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoryListBildingSource(categorieBindingSource);

            LoadAllCategoryList();

            this.view.Show();

        }

        private void LoadAllCategoryList()
        {
            categorieList = repository.GetAll();
            categorieBindingSource.DataSource = categorieList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategory(object? sender, EventArgs e)
        {
            var categorie = new CategoryModel();
            categorie.Id = Convert.ToInt32(view.Category_Id);
            categorie.Name = view.Name;
            categorie.Description = view.Description;

            try
            {
                new Common.ModelDataValidation().Validate(categorie);
                if (view.IsEdit)
                {
                    repository.CategoryEdit(categorie);
                    view.Message = "PayMode Edit Successfuly";
                }
                else
                {
                    repository.CategoryAdd(categorie);
                    view.Message = "PayMode added Successfuly";
                }
                view.IsSuccessful = true;
                LoadAllCategoryList();
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
            view.Category_Id = "0";
            view.Name = "";
            view.Description = "";
        }

        private void DeleteSelectedCategory(object? sender, EventArgs e)
        {
            try
            {
                var Categorie = (CategoryModel)categorieBindingSource.Current;
                repository.CategoryDelete(Categorie.Id);
                view.IsSuccessful = true;
                view.Message = "Categorie deleted Successfuly";
                LoadAllCategoryList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete Categorie";
            }
        }

        private void LoadSelectCategorieToEdit(object? sender, EventArgs e)
        {
            var categorie = (CategoryModel)categorieBindingSource.Current;

            view.Category_Id = categorie.Id.ToString();
            view.Name = categorie.Name;
            view.Description = categorie.Description;

            view.IsEdit = true;
        }

        private void AddNewCategory(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategory(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categorieList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categorieList = repository.GetAll();
            }
            categorieBindingSource.DataSource = categorieList;
        }
    }
}
