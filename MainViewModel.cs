using CommunityToolkit.Mvvm.ComponentModel;
using SfListViewStickyFooterTest.Models;
using System.Collections.ObjectModel;

namespace SfListViewStickyFooterTest
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<ItemModel> testList = new() { 
            new() { Id = "1", Name = "Item 1" }, 
            new() { Id = "2", Name = "Item 2" }, 
            new() { Id = "3", Name = "Item 3" } 
        };
        public MainViewModel()
        {
            
        }


    }
}
