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
    public partial class tunniplaan : ContentPage
    {
        BoxView box;
        Label lbl;
        Frame frm, frm2;
        public tunniplaan()

        {
            Grid grid = new Grid();
            for (int i = 0; i < 3; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }
            for (int i = 0; i < 4; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }
            {
                lbl = new Label { BackgroundColor = Color.LimeGreen, Text = "русский и литература", FontSize = 10 };
                grid.Children.Add(lbl, 0, 0);
                lbl = new Label { BackgroundColor = Color.LimeGreen, Text = "русский и литература", FontSize = 10 };
                grid.Children.Add(lbl, 0, 1);
                lbl = new Label { BackgroundColor = Color.LimeGreen, Text = "русский и литература", FontSize = 10 };
                grid.Children.Add(lbl, 0, 2);
                lbl = new Label { BackgroundColor = Color.LimeGreen, Text = "русский и литература", FontSize = 10 };
                grid.Children.Add(lbl, 0, 3);
                lbl = new Label { BackgroundColor = Color.LimeGreen, Text = "русский и литература", FontSize = 10 };
                grid.Children.Add(lbl, 0, 4);
                lbl = new Label { BackgroundColor = Color.LimeGreen, Text = "русский и литература", FontSize = 10 };
                grid.Children.Add(lbl, 0, 5);
                lbl = new Label { BackgroundColor = Color.LimeGreen, Text = "русский и литература", FontSize = 10 };
                grid.Children.Add(lbl, 0, 6);
                lbl = new Label { BackgroundColor = Color.LimeGreen, Text = "русский и литература", FontSize = 10 };
                frm = new Frame { BorderColor = BackgroundColor = Color.LightGreen };
                grid.Children.Add(frm, 1, 2);
                frm2 = new Frame
                {
                    BackgroundColor = Color.White,
                    BorderColor = Color.White,
                    CornerRadius = 50,
                    Opacity = 0.5
                };
                grid.Children.Add(frm2, 3, 3);
                Grid.SetRowSpan(frm2, 2);
                Content = grid;
            }
        }
    }
}
