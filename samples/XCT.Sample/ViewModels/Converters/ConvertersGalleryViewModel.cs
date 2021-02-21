﻿using System.Collections.Generic;
using Xamarin.CommunityToolkit.Converters;
using Xamarin.CommunityToolkit.Sample.Models;
using Xamarin.CommunityToolkit.Sample.Pages.Converters;
using Xamarin.Forms;

namespace Xamarin.CommunityToolkit.Sample.ViewModels.Converters
{
	public class ConvertersGalleryViewModel : BaseGalleryViewModel
	{
		protected override IEnumerable<SectionModel> CreateItems() => new[]
		{
			new SectionModel(
				typeof(BoolToObjectConverterPage),
				nameof(BoolToObjectConverter),
				"The BoolToObjectConverter is a converter that allows users to convert a bool value binding to a specific object."),
			new SectionModel(
				typeof(EqualConverterPage),
				nameof(EqualConverter),
				"The EqualConverter is a converter that allows users to convert any value binding to a bool depending on whether or not it is equal to a different value. "),

			new SectionModel(
				typeof(DoubleToIntConverterPage),
				nameof(DoubleToIntConverter),
				"The DoubleToIntConverter is a converter that allows users to convert an incoming double value to an int."),

			new SectionModel(
				typeof(IndexToArrayItemConverterPage),
				nameof(IndexToArrayItemConverter),
				"The IndexToArrayItemConverter is a converter that allows users to convert a int value binding to an item in an array."),
			new SectionModel(
				typeof(IntToBoolConverterPage),
				nameof(IntToBoolConverter),
				"The IntToBoolConverter is a converter that allows users to convert an incoming int value to a bool."),

			new SectionModel(
				typeof(ItemTappedEventArgsPage),
				nameof(ItemTappedEventArgsConverter),
				"A converter that allows you to extract the value from ItemTappedEventArgs that can be used in combination with EventToCommandBehavior"),

			new SectionModel(
				typeof(ItemSelectedEventArgsPage),
				nameof(ItemSelectedEventArgsConverter),
				"A converter that allows you to extract the value from ItemSelectedEventArgs that can be used in combination with EventToCommandBehavior"),

			new SectionModel(
				typeof(ByteArrayToImageSourcePage),
				nameof(ByteArrayToImageSourceConverter),
				Color.FromHex("#498205"),
				"A converter that allows you to convert byte array to an object of a type ImageSource"),

			new SectionModel(
				typeof(MultiConverterPage),
				nameof(MultiConverter),
				"This sample demonstrates how to use Multibinding Converter"),

			new SectionModel(
				typeof(DateTimeOffsetConverterPage),
				nameof(DateTimeOffsetConverter),
				"A converter that allows to convert from a DateTimeOffset type to a DateTime type"),

			new SectionModel(
				typeof(VariableMultiValueConverterPage),
				nameof(VariableMultiValueConverter),
				"A converter that allows you to combine multiple boolean bindings into a single binding."),

			new SectionModel(
				typeof(ListIsNullOrEmptyPage),
				nameof(ListIsNullOrEmptyConverter),
				"A converter that allows you to check if collection is null or empty"),
		};
	}
}