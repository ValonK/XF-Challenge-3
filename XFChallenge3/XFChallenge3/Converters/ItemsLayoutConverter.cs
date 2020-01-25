using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XFChallenge3.Converters
{
    public class ItemsLayoutConverter : IValueConverter
    {
        //HeightRequest="{OnPlatform iOS=300, Android=250}"
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(!(value is ItemsLayout itemsLayout))
            {
                return null;
            }

            if(itemsLayout is GridItemsLayout)
            {
                if (Device.RuntimePlatform == Device.Android)
                {
                    return 250;
                }
                else
                {
                    return 300;
                }
            }

            if(itemsLayout is LinearItemsLayout)
            {
                if (Device.RuntimePlatform == Device.Android)
                {
                    return 450;
                }
                else
                {
                    return 500;
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
