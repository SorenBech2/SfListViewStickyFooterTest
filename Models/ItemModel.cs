using CommunityToolkit.Mvvm.ComponentModel;

namespace SfListViewStickyFooterTest.Models
{
    public partial class ItemModel : ObservableObject
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;
    }
}
