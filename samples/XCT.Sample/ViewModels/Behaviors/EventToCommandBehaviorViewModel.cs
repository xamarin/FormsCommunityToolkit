﻿using System.Windows.Input;
using Xamarin.CommunityToolkit.Helpers;

namespace Xamarin.CommunityToolkit.Sample.ViewModels.Behaviors
{
	public class EventToCommandBehaviorViewModel : BaseViewModel
	{
		int clickCount;

		public EventToCommandBehaviorViewModel() =>
			IncrementCommand = CommandHelper.Create(() => ClickCount++);

		public int ClickCount
		{
			get => clickCount;
			set => SetProperty(ref clickCount, value);
		}

		public ICommand IncrementCommand { get; }
	}
}