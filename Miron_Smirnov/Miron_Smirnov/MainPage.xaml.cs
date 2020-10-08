using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Miron_Smirnov
{
    public partial class MainPage : ContentPage
    {
        Label Russkii;
        public MainPage()

        {
            Grid grid = new Grid();
            for (int i = 0; i < 10; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }
            for (int i = 0; i < 5; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }
            {
                BackgroundColor = Color.LightBlue;
            }
            //Понедельник Русский язык. 
            Russkii = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGreen, Text = "Русский и литература", FontSize = 10 };
            grid.Children.Add(Russkii, 2, 1);
            Grid.SetColumnSpan(Russkii, 2);
            var tap = new TapGestureRecognizer();
            tap.Tapped += (s, e) =>
            {
                Russkii = (Label)s;
                MoreInfo();
            };

            Russkii.GestureRecognizers.Add(tap);
            Content = grid;

        }
        public async void MoreInfo()
        {
            await DisplayAlert("Подробная информация", "Кабинет B221, Людмила Михайловна", "Закрыть");
        }

    }
}
