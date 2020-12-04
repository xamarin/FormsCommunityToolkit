﻿using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.CommunityToolkit.UI.Views
{
	/// <inheritdoc/>
	public abstract class Popup<T> : BasePopup
	{
		TaskCompletionSource<T> taskCompletionSource;
		View view;

		/// <summary>
		/// Initalizes a default implementation of <see cref="Popup{T}"/>.
		/// </summary>
		protected Popup() =>
			taskCompletionSource = new TaskCompletionSource<T>();

		/// <inheritdoc />
		public override View View
		{
			get => view;
			set
			{
				if (view == value)
					return;

				view = value;
			}
		}

		/// <summary>
		/// Resets the Popup.
		/// </summary>
		public void Reset() =>
			taskCompletionSource = new TaskCompletionSource<T>();

		/// <summary>
		/// Dismiss the current popup.
		/// </summary>
		/// <param name="result">
		/// The result to return.
		/// </param>
		public void Dismiss(T result)
		{
			taskCompletionSource.TrySetResult(result);
			OnDismissed(result);
		}

		/// <summary>
		/// Gets the final result of the dismissed popup.
		/// </summary>
		public Task<T> Result => taskCompletionSource.Task;

		/// <inheritdoc/>
		public override void LightDismiss() =>
			taskCompletionSource.TrySetResult(GetLightDismissResult());

		/// <summary>
		/// Gets the light dismiss default result.
		/// </summary>
		/// <returns>
		/// The light dismiss value of <see cref="T"/>.
		/// </returns>
		/// <remarks>
		/// When a user dismisses the Popup via the light dismiss, this
		/// method will return a default value.
		/// </remarks>
		protected virtual T GetLightDismissResult() => default(T);
	}
}
