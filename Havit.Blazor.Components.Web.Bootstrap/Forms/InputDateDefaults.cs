﻿using Havit.Blazor.Components.Web.Bootstrap.Internal;
using Microsoft.AspNetCore.Components;

namespace Havit.Blazor.Components.Web.Bootstrap
{
	/// <summary>
	/// Default values for <see cref="HxInputDate{TValue}"/> and derived components.
	/// </summary>
	public class InputDateDefaults : IInputDefaultsWithSize
	{
		/// <summary>
		/// Input size.
		/// </summary>
		public InputSize InputSize { get; set; } = InputSize.Regular;

		/// <summary>
		/// Optional icon to display within the input.
		/// </summary>
		[Parameter] public IconBase CalendarIcon { get; set; }
	}
}