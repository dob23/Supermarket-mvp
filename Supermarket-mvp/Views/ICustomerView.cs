using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface ICustomerView
    {
        string Customer_Id { get; set; }
        string First_Name { get; set; }
        string Last_Name { get; set; }
        string Document_Number { get; set; }
        string Address { get; set; }
        string Birthday { get; set; }
        string Phone_Number { get; set; }
        string Email { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetCustomerListBildingSource(BindingSource CustomerList);
        void Show();
    }
}
