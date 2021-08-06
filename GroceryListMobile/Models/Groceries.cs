using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GroceryListMobile.Models
{
    public class Groceries : ObservableCollection<string>
    {
        public string Category { get; set; }

        public static List<Groceries> GroupedList { get; set; } = new List<Groceries>();
        public static Groceries Fruits { get; set; } = new Groceries("Fruit");
        public static Groceries Vegetables { get; set; } = new Groceries("Vegetables");

        public Groceries(string s)
        {
            Category = s;
        }
    }
}