
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFChallenge3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
		#region Fields

		private GridItemsLayout _gridItemsLayout =
			new GridItemsLayout(2, ItemsLayoutOrientation.Vertical);

		private LinearItemsLayout _linearItemsLayout =
			new LinearItemsLayout(ItemsLayoutOrientation.Vertical);

		private readonly uint _length = 100;
		private readonly double _scaleFrom = 0.50;
		private readonly double _scaleTo = 1;
		private readonly Easing _easingIn = Easing.CubicIn;
		private readonly Easing _easingOut = Easing.CubicIn;

		#endregion

		public ProductsPage()
        {
            InitializeComponent();


			_gridItemsLayout.VerticalItemSpacing = 10;
			_gridItemsLayout.HorizontalItemSpacing = 10;
			_linearItemsLayout.ItemSpacing = 10;
		}
		
		private async void TapGestureRecognizerGrid_Tapped(object sender, System.EventArgs e)
		{
			CollectionViewProducts.ItemsLayout = _gridItemsLayout;



			await LayoutSwitchLabelGrid.ScaleTo(_scaleFrom, _length, _easingIn);
			await LayoutSwitchLabelGrid.ScaleTo(_scaleTo, _length, _easingOut);
		}

		private async void TapGestureRecognizerLinear_Tapped(object sender, System.EventArgs e)
		{
			CollectionViewProducts.ItemsLayout = _linearItemsLayout;

			await LayoutSwitchLabelList.ScaleTo(_scaleFrom, _length, _easingOut);
			await LayoutSwitchLabelList.ScaleTo(_scaleTo, _length, _easingIn);
		}
	}
}