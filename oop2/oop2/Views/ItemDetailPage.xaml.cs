﻿using oop2.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace oop2.Views
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