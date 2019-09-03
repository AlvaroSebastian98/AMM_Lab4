using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ejercicio02
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}
