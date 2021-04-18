﻿using System;
using System.Globalization;
using Xamarin.CommunityToolkit.Extensions.Internals;
using Xamarin.Forms;

namespace Xamarin.CommunityToolkit.Converters
{
	/// <summary>
	/// A converter that returns the enumerable sequence of enum as the result.
	/// </summary>
	public class EnumToListConverter : ValueConverterExtension, IValueConverter
	{
		/// <summary>
		/// Returns a string array that contains the substrings in this string that are delimited by <see cref="Separators"/>.
		/// </summary>
		/// <param name="value">The string to split.</param>
		/// <param name="targetType">The type of the binding target property. This is not implemented.</param>
		/// <param name="parameter">The string or strings that delimits the substrings in this string. This overrides the value in <see cref="Separator"/> and <see cref="Separators"/>.</param>
		/// <param name="culture">The culture to use in the converter. This is not implemented.</param>
		/// <returns>An array whose elements contain the substrings in this string that are delimited by <see cref="Separator"/> or, if set, <see cref="Separators"/> or, if set, <paramref name="parameter"/>.</returns>
		public object? Convert(object? value, Type? targetType, object? parameter, CultureInfo? culture)
		{
			if (value is Type type)
				return Enum.GetValues(type);

			return new string[] { };
		}

		/// <summary>
		/// This method is not implemented and will throw a <see cref="NotImplementedException"/>.
		/// </summary>
		/// <param name="value">N/A</param>
		/// <param name="targetType">N/A</param>
		/// <param name="parameter">N/A</param>
		/// <param name="culture">N/A</param>
		/// <returns>N/A</returns>
		public object? ConvertBack(object? value, Type? targetType, object? parameter, CultureInfo? culture)
			=> throw new NotImplementedException();
	}
}