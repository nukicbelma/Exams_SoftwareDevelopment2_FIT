﻿using eProdaja.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace eProdaja.Mobile.Views
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