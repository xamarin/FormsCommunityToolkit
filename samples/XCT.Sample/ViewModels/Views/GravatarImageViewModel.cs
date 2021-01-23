﻿using System;
using System.Linq;
using Xamarin.CommunityToolkit.UI.Views;

namespace Xamarin.CommunityToolkit.Sample.ViewModels.Views
{
	public class GravatarImageViewModel : BaseViewModel
	{
		bool enableCache;
		string email = "dsiegel@avantipoint.com";
		int size = 50;
		DefaultGravatar defaultGravatar = DefaultGravatar.MysteryPerson;

		public DefaultGravatar[] Defaults { get; } = Enum.GetValues(typeof(DefaultGravatar)).Cast<DefaultGravatar>().ToArray();

		public bool EnableCache
		{
			get => enableCache;
			set => SetProperty(ref enableCache, value);
		}

		public string Email
		{
			get => email;
			set => SetProperty(ref email, value);
		}

		public int Size
		{
			get => size;
			set => SetProperty(ref size, value);
		}

		public DefaultGravatar DefaultGravatar
		{
			get => defaultGravatar;
			set => SetProperty(ref defaultGravatar, value);
		}
	}
}