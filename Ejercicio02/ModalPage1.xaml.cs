using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ejercicio02
{
    public partial class ModalPage1 : ContentPage
    {
        public ModalPage1()
        {
            InitializeComponent();

            btnClosePopup.Clicked += async (sender, e) =>
            {
                await Navigation.PopModalAsync();
            };

        }
    }
}
