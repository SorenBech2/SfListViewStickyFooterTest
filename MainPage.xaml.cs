using SfListViewStickyFooterTest.Models;

namespace SfListViewStickyFooterTest
{
    public partial class MainPage : ContentPage
    {
        MainViewModel _viewModel;
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = _viewModel = viewModel;
        }

        private void AddButton_Clicked(object sender, EventArgs e)
        {
            _viewModel.TestList.Add(new ItemModel { Id = Guid.NewGuid().ToString(), Name = $"Item {_viewModel.TestList.Count + 1}" });
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            _viewModel.TestList.RemoveAt(_viewModel.TestList.Count - 1);
        }
    }
}
