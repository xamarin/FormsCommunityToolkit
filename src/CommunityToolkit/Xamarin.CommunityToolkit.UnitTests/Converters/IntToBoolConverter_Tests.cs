﻿using System;
using System.Globalization;
using Xamarin.CommunityToolkit.Converters;
using Xunit;

namespace Xamarin.CommunityToolkit.UnitTests.Converters
{
	public class IntToBoolConverter_Tests
	{
		[Theory]
		[InlineData(1, true)]
		[InlineData(0, false)]
		public void IndexToArrayConverter(int value, bool expectedResult)
		{
			var intToBoolConverter = new IntToBoolConverter();

			var result = intToBoolConverter.Convert(value, typeof(IntToBoolConverter_Tests), null, CultureInfo.CurrentCulture);

			Assert.Equal(result, expectedResult);
		}

		[Theory]
		[InlineData(true, 1)]
		[InlineData(false, 0)]
		public void IndexToArrayConverterBack(bool value, int expectedResult)
		{
			var intToBoolConverter = new IntToBoolConverter();

			var result = intToBoolConverter.ConvertBack(value, typeof(IntToBoolConverter_Tests), null, CultureInfo.CurrentCulture);

			Assert.Equal(result, expectedResult);
		}

		[Theory]
		[InlineData(2.5)]
		[InlineData("")]
		[InlineData(null)]
		public void InValidConverterValuesThrowArgumenException(object value)
		{
			var intToBoolConverter = new IntToBoolConverter();
			Assert.Throws<ArgumentException>(() => intToBoolConverter.Convert(value, typeof(IndexToArrayItemConverter), null, CultureInfo.CurrentCulture));
		}

		[Theory]
		[InlineData(2.5)]
		[InlineData("")]
		[InlineData(null)]
		public void InValidConverterBackValuesThrowArgumenException(object value)
		{
			var intToBoolConverter = new IntToBoolConverter();
			Assert.Throws<ArgumentException>(() => intToBoolConverter.ConvertBack(value, typeof(IndexToArrayItemConverter), null, CultureInfo.CurrentCulture));
		}
	}
}