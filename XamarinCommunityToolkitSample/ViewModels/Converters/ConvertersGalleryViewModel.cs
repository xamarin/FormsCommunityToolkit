﻿using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Sample.Models;
using Xamarin.CommunityToolkit.Sample.Pages.Converters;
using Xamarin.CommunityToolkit.Sample.Resx;

namespace Xamarin.CommunityToolkit.Sample.ViewModels.Converters
{
    public class ConvertersGalleryViewModel : BaseViewModel
    {
        public IEnumerable<SectionModel> Items { get; } = new List<SectionModel> {
            new SectionModel(
                typeof(ItemTappedEventArgsPage),
                "ItemTappedEventArgs",
                Color.FromHex("#498205"),
                AppResources.ItemTappedEventArgsShortDescription
            ),

            new SectionModel(
                typeof(ItemSelectedEventArgsPage),
                "ItemSelectedEventArgs",
                Color.FromHex("#498205"),
                AppResources.ItemTappedSelectedEventArgsShortDescription
            ),

            new SectionModel(
                typeof(ByteArrayToImageSourcePage),
                "ByteArrayToImageSource",
                Color.FromHex("#498205"),
                AppResources.ByteArrayToImageSourceShortDescription
            )
        };
    }
}
