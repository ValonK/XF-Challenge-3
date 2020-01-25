using System;
using System.Windows.Input;
using Xamarin.Forms;
using XFChallenge3.Models;

namespace XFChallenge3.ViewModels
{
    public class ProductDetailViewModel : BaseViewModel
    {
        public ProductDetailViewModel(Product product)
        {
            Product = product;
            Initialize();
        }

        public Product Product { get; set; }

        public ICommand BackCommand => new Command(OnBack);

        private void Initialize()
        {
            OnPropertyChanged(nameof(Product.Images));
        }

        private async void OnBack()
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
