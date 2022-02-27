using ScannerAPP.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ScannerAPP.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}