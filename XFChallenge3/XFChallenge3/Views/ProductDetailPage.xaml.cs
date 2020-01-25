
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFChallenge3.Models;
using XFChallenge3.ViewModels;

namespace XFChallenge3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetailPage : ContentPage
    {
        private bool scrollViewReachedEnd;

        public ProductDetailPage(Product product)
        {
            InitializeComponent();
            BindingContext = new ProductDetailViewModel(product);
        }
        
        private void DescriptionLabel_GestureRecognizer(object sender, System.EventArgs e)
        {

        }

        private async void UpFrameTapGestureRecognizer_OnTapped(object sender, System.EventArgs e)
        {
            await xScrollView.ScrollToAsync(xScrollView, ScrollToPosition.Start, true);
        }

        private async void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            scrollViewReachedEnd = false;

            await CarouselContainer.TranslateTo(0, e.ScrollY / 2, 50);

            var calc = e.ScrollY / OpacityGrid.Height;
            OpacityGrid.Opacity = calc;

            double maxY = xScrollView.ContentSize.Height - xScrollView.Height;
            int buffer = 20;

            if (e.ScrollY >= maxY - buffer && !scrollViewReachedEnd)
            {
                await UpFrame.ScaleTo(1);
                scrollViewReachedEnd = true;
            }

            if (e.ScrollY <= 100)
            {
                await UpFrame.ScaleTo(0);
            }
        }
    }
}