using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GroceryListMobile.Models;

namespace GroceryListMobile.Services
{
    class OrganizeIt
    {
        public void OrganizeItems(List<string> groceries)
        {
            foreach (string value in groceries)
            {
                if (Keywords.fruitKeys.Any(value.Contains))
                {
                    Groceries.Fruits.Add(value);
                }
                else if (Keywords.vegetableKeys.Any(value.Contains))
                {
                    Groceries.Vegetables.Add(value);
                }
            }

            if (Groceries.Fruits.Any())
            {
                Groceries.GroupedList.Add(Groceries.Fruits);
            }
            if (Groceries.Vegetables.Any())
            {
                Groceries.GroupedList.Add(Groceries.Vegetables);
            }
        }
    }
}
