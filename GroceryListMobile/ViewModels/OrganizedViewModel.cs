using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using GroceryListMobile.Models;

namespace GroceryListMobile.ViewModels
{
    class OrganizedViewModel
    {
        public ObservableCollection<Groceries> OGroupedList { get; set; }

        public OrganizedViewModel()
        {
            OGroupedList = new ObservableCollection<Groceries>();
            foreach (Groceries value in Groceries.GroupedList)
            {
                OGroupedList.Add(value);
            }
        }
    }
}
