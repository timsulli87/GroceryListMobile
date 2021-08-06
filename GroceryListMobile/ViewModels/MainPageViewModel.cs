using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GroceryListMobile.Models;
using GroceryListMobile.Services;
using GroceryListMobile.Views;
using MvvmHelpers;
using MvvmHelpers.Commands;
using Xamarin.Forms;
using Command = MvvmHelpers.Commands.Command;

namespace GroceryListMobile.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _input;
        public string Input
        {
            get { return _input; }
            set
            {
                if (value != _input)
                {
                    _input = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Input"));
                }
            }
        }
        public List<string> UnorganizedList { get; set; }
        public ObservableCollection<string> UnorganizedCollection { get; set; }
        public ObservableCollection<string> OrganizedCollection { get; set; }
        public Command AddItemCommand { get; }
        public Command SortItemsCommand { get; }

        public MainPageViewModel()
        {
            UnorganizedList = new List<string>();
            UnorganizedCollection = new ObservableCollection<string>();
            OrganizedCollection = new ObservableCollection<string>();

            AddItemCommand = new Command(AddItem);
            SortItemsCommand = new Command(SortItems);
        }

        void AddItem()
        {
            if (Input == "")
            {
                return;
            }
            else
            {
                UnorganizedList.Add(Input);
                UnorganizedCollection.Add(Input);
                Input = "";
            }
        }

        private void SortItems()
        {
            OrganizeIt o = new OrganizeIt();
            o.OrganizeItems(UnorganizedList);
        }
    }
}
