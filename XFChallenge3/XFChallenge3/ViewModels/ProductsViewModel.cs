using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XFChallenge3.Models;
using XFChallenge3.Views;

namespace XFChallenge3.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        public ProductsViewModel()
        {
            CreateProducts();

            ProductSelectedCommand = new Command<Product>(OnProductSelected);
        }

        public ObservableCollection<Product> Products { get; set; }

        public Command<Product> ProductSelectedCommand { get; set; }

        private void CreateProducts()
        {
            Products = new ObservableCollection<Product>
            {
                new Product {
                    Name = "Product Name",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.",
                    Images = new List<Models.Image> {
                        new Models.Image {
                            Source = "One.png",
                        },
                        new Models.Image {
                            Source = "Two.png",
                        },
                        new Models.Image {
                            Source = "Three.png",
                        },
                        new Models.Image {
                            Source = "Four.png",
                        },
                    },
                    SalePrice = "50€",
                    Sale = true,
                    Price = "100€" },
                new Product {
                    Name = "Product Name",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.",
                    Images = new List<Models.Image> {
                        new Models.Image {
                            Source = "Two.png",
                        },
                        new Models.Image {
                            Source = "One.png",
                        },
                        new Models.Image {
                            Source = "Three.png",
                        },
                        new Models.Image {
                            Source = "Four.png",
                        },
                    },
                    Price = "100€" },
                new Product {
                    Name = "Product Name",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.",
                    Images = new List<Models.Image> {
                        new Models.Image {
                            Source = "Three.png",
                        },
                        new Models.Image {
                            Source = "One.png",
                        },
                        new Models.Image {
                            Source = "Three.png",
                        },
                        new Models.Image {
                            Source = "Four.png",
                        },
                    },
                    Price = "100€" },
                new Product {
                    Name = "Product Name",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.",
                    Images = new List<Models.Image> {
                        new Models.Image {
                            Source = "Four.png",
                        },
                        new Models.Image {
                            Source = "One.png",
                        },
                        new Models.Image {
                            Source = "Three.png",
                        },
                        new Models.Image {
                            Source = "Four.png",
                        },
                    },
                    Price = "100€" },
                new Product {
                    Name = "Product Name",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.",
                    Images = new List<Models.Image> {
                        new Models.Image {
                            Source = "One.png",
                        },
                        new Models.Image {
                            Source = "Two.png",
                        },
                        new Models.Image {
                            Source = "Three.png",
                        },
                        new Models.Image {
                            Source = "Four.png",
                        },
                    },
                    SalePrice = "50€",
                     Sale = true,
                    Price = "100€" },
                new Product {
                    Name = "Product Name",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.",
                    Images = new List<Models.Image> {
                        new Models.Image {
                            Source = "Two.png",
                        },
                        new Models.Image {
                            Source = "One.png",
                        },
                        new Models.Image {
                            Source = "Three.png",
                        },
                        new Models.Image {
                            Source = "Four.png",
                        },
                    },
                    Price = "100€" },
                new Product {
                    Name = "Product Name",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.",
                    Images = new List<Models.Image> {
                        new Models.Image {
                            Source = "Three.png",
                        },
                        new Models.Image {
                            Source = "Two.png",
                        },
                        new Models.Image {
                            Source = "Three.png",
                        },
                        new Models.Image {
                            Source = "Four.png",
                        },
                    },
                    Price = "100€" },
                new Product {
                    Name = "Product Name",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.",
                    Images = new List<Models.Image> {
                        new Models.Image {
                            Source = "Four.png",
                        },
                        new Models.Image {
                            Source = "Two.png",
                        },
                        new Models.Image {
                            Source = "Three.png",
                        },
                        new Models.Image {
                            Source = "Four.png",
                        },
                    },
                     Sale = true,
                     SalePrice = "50€",
                    Price = "100€" },
                new Product {
                    Name = "Product Name",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.",
                    Images = new List<Models.Image> {
                        new Models.Image {
                            Source = "One.png",
                        },
                        new Models.Image {
                            Source = "Two.png",
                        },
                        new Models.Image {
                            Source = "Three.png",
                        },
                        new Models.Image {
                            Source = "Four.png",
                        },
                    },
                    Price = "100€" },
                new Product {
                    Name = "Product Name",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.",
                    Images = new List<Models.Image> {
                        new Models.Image {
                            Source = "Two.png",
                        },
                        new Models.Image {
                            Source = "One.png",
                        },
                        new Models.Image {
                            Source = "Three.png",
                        },
                        new Models.Image {
                            Source = "Four.png",
                        },
                    },
                     Sale = true,
                    SalePrice = "50€",
                    Price = "100€" },
                new Product {
                    Name = "Product Name",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.",
                    Images = new List<Models.Image> {
                        new Models.Image {
                            Source = "Three.png",
                        },
                        new Models.Image {
                            Source = "Two.png",
                        },
                        new Models.Image {
                            Source = "Three.png",
                        },
                        new Models.Image {
                            Source = "Four.png",
                        },
                    },
                    Price = "100€" },
                new Product {
                    Name = "Product Name",
                    Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.",
                    Images = new List<Models.Image> {
                        new Models.Image {
                            Source = "Four.png",
                        },
                        new Models.Image {
                            Source = "Two.png",
                        },
                        new Models.Image {
                            Source = "Three.png",
                        },
                        new Models.Image {
                            Source = "Four.png",
                        },
                    },
                    Price = "100€" }
                };
        }


        private async void OnProductSelected(Product product)
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new ProductDetailPage(product));
            //await App.Current.MainPage.Navigation.PushModalAsync(new TestPage());
        }
    }
}