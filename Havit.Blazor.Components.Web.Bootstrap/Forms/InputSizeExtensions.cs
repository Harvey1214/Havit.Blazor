﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havit.Blazor.Components.Web.Bootstrap.Internal;

namespace Havit.Blazor.Components.Web.Bootstrap.Forms
{
	public static class InputSizeExtensions
	{
		/// <summary>
		/// Returns CSS class to render input (form-control) with desired size.
		/// </summary>
		public static string AsFormControlCssClass(this InputSize inputSize)
		{
			return inputSize switch
			{
				InputSize.Regular => null,
				InputSize.Small => "form-control-sm",
				InputSize.Large => "form-control-lg",
				_ => throw new InvalidOperationException($"Unknown {nameof(InputSize)} value {inputSize}.")
			};
		}

		/// <summary>
		/// Returns CSS class to render select (form-select) with desired size.
		/// </summary>
		public static string AsFormSelectCssClass(this InputSize inputSize)
		{
			return inputSize switch
			{
				InputSize.Regular => null,
				InputSize.Small => "form-select-sm",
				InputSize.Large => "form-select-lg",
				_ => throw new InvalidOperationException($"Unknown {nameof(InputSize)} value {inputSize}.")
			};
		}
	}
}
